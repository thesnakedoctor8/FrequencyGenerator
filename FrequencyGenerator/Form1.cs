using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using Excel = Microsoft.Office.Interop.Excel;
using System.Runtime.InteropServices;
using System.Threading;
using System.Diagnostics;
using System.IO; 

namespace FrequencyGenerator
{
    public partial class Form1 : Form
    {
        // Global Variables
        private static double frequency;
        private static double pkpkVoltage;
        private static double rmsVoltage;
        private static double dBm;
        private static double waveform;        // Sin = 0 Square = 1
        private static string readLine;

        Excel.Application xlApp;
        Excel.Workbook xlWorkBook;
        Excel.Worksheet xlWorkSheet;
        Excel.Range range;

        public Form1()
        {
            InitializeComponent();
            freqStartComboBox.SelectedIndex = 0;
            freqEndComboBox.SelectedIndex = 0;
        }

        private void connectButton_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Connect pressed");

            if (SetComPort())
            {
                usbLabel.Text = "USB: Connected";
                usbLabel.ForeColor = System.Drawing.Color.LimeGreen;

                //Disables the connection button
                connectButton.Enabled = false;
                //Enables the disconnection button
                disconnectButton.Enabled = true;
                // Enable the controls
                enableControls();

                // Tell the arduino to send the data to the PC
                //Try/Catch used in case if there is a problem with the COM Port
                try
                {
                    arduinoPort.WriteLine("$");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Timer - exception: " + ex.Message);
                    disconnectButton.PerformClick();
                    return;
                }
                
                timer1.Start();
            }
        }
        
        /*
         * Method called to set up the connection with the Arduino usb. This is done by grabbing every windows
         * com port, loop through them, read their outputs, and check to see if it matches our custom Arduino output
         * If one com port does match then the status is updated and saves that COM Port (via SerialPort object)
         * This method returns true if the Arduino port was found, false if it wasn't
         */
        private Boolean SetComPort()
        {
            //Try/Catch used in case if there is a problem trying to open and read each COM Port
            try
            {
                //A string array of all the COM Ports in windows
                string[] ports = SerialPort.GetPortNames();

                //If no ports were found, Show a message and return false
                if (ports.Length == 0)
                {
                    MessageBox.Show("Windows detected no connected COM Ports. Try unplugging and replugging in the USB ", "Warning");
                    Console.WriteLine("Windows detected no COM Ports connected");
                    return false;
                }

                //Loop through each port in the array to check if it matches our Arduino port
                foreach (string port in ports)
                {
                    Console.WriteLine("Checking Port: " + port);
                    //establish the port connetion
                    arduinoPort = new SerialPort(port, 115200);

                    //Calls DetectArduino and if the readline matches our expected custom Arduino string
                    //I enable data grabbing, open the connection, and update the status/return true
                    if (DetectArduino())
                    {
                        //arduinoPort.DtrEnable = true;     //not sure if this should be enabled or not
                        //arduinoPort.ReadTimeout = 300;
                        arduinoPort.Open();
                        arduinoPort.DataReceived += new SerialDataReceivedEventHandler(DataReceivedHandler);
                        Console.WriteLine("Arduino COM Port " + port + " opened");
                        return true;
                    }
                }

                Console.WriteLine("Arduino COM Port not found");
                //If no port matched after looping through all then display message and return false
                MessageBox.Show("Windows did not find the Arduino COM Port. Pleasey re-plugging in the USB cable and restarting the program", "Error");
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("SetComPort - exception: " + ex.Message);
                //If there was an error trying to set up the COM Port then display message and return false
                MessageBox.Show("Windows could not set up the COM Port", "Error");
                return false;
            }
        }

        /*
         * Helper method used for checking each Serial Port in Windows. A single port in the ports list (all windows ports)
         * is opened one at a time, have the output line read, and checks to see if it matches out custom Arduino message.
         * Our custom Arduino message will always output a string with "Arduino-" being the first part of it, with the full
         * Format being "Arduino-X-XX.X" where the first X is the status code (0-4) and the last XX.X being the temperature.
         * This method returns true if the Arduino is detected, false if it is not.
         */
        private bool DetectArduino()
        {
            //Try/Catch used in case if there is a problem trying to open and read each COM Port
            try
            {
                Console.WriteLine("...Detecting Arduino...");
                //Set a timeout in case if readLine times out
                arduinoPort.ReadTimeout = 1000;
                //Opens the serial port
                
                arduinoPort.Open();
                Console.WriteLine("Makes it here");
                arduinoPort.WriteLine("%");                                 // Tell arduino to Send '#'
                Thread.Sleep(50);                                           // Wait 50ms for a response
                readLine = arduinoPort.ReadLine().Trim();                   // Read a line from the serial buffer
                Console.WriteLine("DetectArduino readLine: " + readLine);   // Printout - expecting '#'
                arduinoPort.Close();                                        // Close the port - we only need one line

                // Checks to see if the beginning of the line read from the Serial Port matches the beginning part of our
                // expected arduino message "#"
                if (readLine != null && readLine.Length != 0 && readLine == "#")
                {
                    Console.WriteLine("Arduino - found");
                    return true;
                }
                else
                {
                    Console.WriteLine("Arduino - NOT found");
                    return false;
                }
            }
            catch (TimeoutException ex)
            {
                Console.WriteLine("Connection to COM Port timed out - exception: " + ex.Message);
                //If the connection timmed out trying to read the COM Port then return false
                return false;
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine("The specified port is not open - exception: " + ex.Message);
                //If the connection timmed out trying to read the COM Port then return false
                return false;
            }
            catch (IOException ex)
            {
                Console.WriteLine("IOException - exception: " + ex.Message);
                //If the connection timmed out trying to read the COM Port then return false
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error - exception: " + ex.Message);
                //If there was an error trying to open the COM Port then return false
                return false;
            }
        }

        private void disconnectButton_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Disconnect pressed");

            usbLabel.Text = "USB: Disconnected";
            usbLabel.ForeColor = System.Drawing.Color.Red;

            timer1.Stop();

            try
            {
                if (arduinoPort != null && arduinoPort.IsOpen)
                {
                    arduinoPort.WriteLine("!");
                    arduinoPort.Dispose();
                    Console.WriteLine("arduinoPort closed");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("disconnectButton_Click - exception: " + ex.Message);
                arduinoPort = null;
            }

            //Enables the connection button
            connectButton.Enabled = true;
            //Disables the disconnection button
            disconnectButton.Enabled = false;
            // Disable the controls
            disableControls();
        }

        private void DataReceivedHandler(object sender, SerialDataReceivedEventArgs e)
        {
            SerialPort sp = (SerialPort)sender;
            string readLine = sp.ReadLine().Trim();
            Console.WriteLine("Data Received:" + readLine);

            // #12345678.90-2499.9-1
            if (readLine.Length > 20 && readLine[0].Equals('#'))
            {
                if (double.Parse(readLine.Substring(1, 11)) >= .01 && double.Parse(readLine.Substring(1, 11)) <= 10000000)
                {
                    frequency = double.Parse(readLine.Substring(1, 11));
                    updateFrequencyLabel();
                }

                if (double.Parse(readLine.Substring(13, 6)) >= 2.5 && double.Parse(readLine.Substring(13, 6)) <= 2500)
                {
                    pkpkVoltage = double.Parse(readLine.Substring(13, 6));
                    updatePkPkLabel();
                }

                rmsVoltage = Math.Round((pkpkVoltage / (2 * 1.41421356237)), 2);
                updateRmsLabel(); 

                dBm = Math.Round((20 * Math.Log10((pkpkVoltage / 100) / Math.Pow(.05, .5))), 3);
                updatedBmLabel();

                if (double.Parse(readLine.Substring(20, 1)) == 0 || double.Parse(readLine.Substring(20, 1)) == 1)
                {
                    waveform = double.Parse(readLine.Substring(20, 1));
                    
                    if(waveform == 0)
                    {
                        Invoke(new MethodInvoker(delegate
                        {
                            sinusodialRadioButton.PerformClick();
                        }));
                        
                    }
                    else
                    {
                        Invoke(new MethodInvoker(delegate
                        {
                            squareRadioButton.PerformClick();
                        }));
                        
                    }
                }
            }   
        }

        private void updateFrequencyLabel()
        {
            Invoke(new MethodInvoker(delegate
            {
                frequencyLabelValue.Text = string.Format("{0:N2}", frequency).Replace(",", "");
            }));
        }

        private void updatePkPkLabel()
        {
            Invoke(new MethodInvoker(delegate
            {
                pkpkLabelValue.Text = string.Format("{0:N1}", pkpkVoltage).Replace(",", ""); //pkpkVoltage.ToString();
            }));
        }

        private void updateRmsLabel()
        {
            Invoke(new MethodInvoker(delegate
            {
                rmsLabelValue.Text = string.Format("{0:N2}", rmsVoltage).Replace(",", ""); // rmsVoltage.ToString();
            }));
        }

        private void updatedBmLabel()
        {
            Invoke(new MethodInvoker(delegate
            {
                dBmLabelValue.Text = string.Format("{0:N3}", dBm).Replace(",", "");  //dBm.ToString();
            }));
        }

        private void textBoxNumbers_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Only allow numbers and decimal points
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
            // Only allow one decimal point
            if (e.KeyChar == '.' && (sender as TextBox).Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }
        }

        private void waveformGroupBox_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioButton = sender as RadioButton;

            if (radioButton != null)
            {
                if (radioButton.Checked)
                {
                    if (sinusodialRadioButton.Checked)
                    {
                        waveform = 0;
                    }
                    else if (squareRadioButton.Checked)
                    {
                        waveform = 1;
                    }
                    sendSignalData();
                }
            }
        }

        private void sendSignalData()
        {
            String str1 = string.Format("{0:N2}", frequency).Replace(",", "").PadLeft(11, '0');
            String str2 = string.Format("{0:N1}", pkpkVoltage).Replace(",", "").PadLeft(6, '0');
            String str3 = waveform.ToString().PadLeft(1, '0');
            String str = "#" + str1 + "-" + str2 + "-" + str3;
            
            Console.WriteLine("sending arduino: " + str);
            
            //Try/Catch used in case if there is a problem with the COM Port
            try
            {
                arduinoPort.WriteLine(str);
            }
            catch (Exception ex)
            {
                Console.WriteLine("sendSignalData - exception: " + ex.Message);
                disconnectButton.PerformClick();
            }
        }

        private void generateSweepButton_Click(object sender, EventArgs e)
        {
            double freqStart = 0;
            double freqEnd = 0;
            double duration = 0;
            double cycles = 0;
            Boolean error = false;
            String errorMessage = "";
                        
            freqStart = double.Parse(freqStartTextBox.Text);
            switch (freqStartComboBox.Items[freqStartComboBox.SelectedIndex].ToString())
            {
                case "Hz":
                    freqStart *= 1;
                    break;

                case "KHz":
                    freqStart *= 1000;
                    break;

                case "MHz":
                    freqStart *= 1000000;
                    break;
            }
            Console.WriteLine("freqStart", freqStart);

            freqEnd = double.Parse(freqEndTextBox.Text);
            switch (freqEndComboBox.Items[freqEndComboBox.SelectedIndex].ToString())
            {
                case "Hz":
                    freqEnd *= 1;
                    break;

                case "KHz":
                    freqEnd *= 1000;
                    break;

                case "MHz":
                    freqEnd *= 1000000;
                    break;
            }
            Console.WriteLine("freqStart", freqStart);

            duration = double.Parse(durationTextBox.Text);
            cycles = double.Parse(cyclesTextBox.Text);

            // Check for errors
            if (freqStart < .01 || freqStart > 10000000)
            {
                error = true;
                errorMessage += "-The Start Frequency must be between .01 Hz and 10 MHz\n";
            }
            if (freqEnd < .01 || freqEnd > 10000000)
            {
                error = true;
                errorMessage += "-The End Frequency must be between .01 Hz and 10 MHz\n";
            }
            if (duration < 1 || duration > 30)
            {
                error = true;
                errorMessage += "-The Duration must be between 1 second and 30 seconds\n";
            }
            if (cycles < 1 || cycles > 300)
            {
                error = true;
                errorMessage += "-The Number of Steps must be between 1 cycle and 300 cycles\n";
            }
            else if ((cycles / duration) > 10)
            {
                error = true;
                errorMessage += "-The Number of Steps per second must be 10 or less\n";
            }

            if (!error)
            {
                frequency = freqStart;
                
                setAllControls(false);
                for (double d = 0; d <= duration; d += (duration / cycles))
                {
                    frequencyLabelValue.Text = string.Format("{0:N2}", frequency).Replace(",", "");
                    frequencyLabelValue.Update();

                    sendSignalData();
                    Thread.Sleep((int)((duration / cycles) * 1000));
                    frequency += (Math.Abs(freqStart - freqEnd) / cycles);
                }
                setAllControls(true);
            }
            else
            {
                MessageBox.Show(errorMessage, "Error");
            }                        
        }

        private void generateTableButton_Click(object sender, EventArgs e)
        {
            double freqStart = 0;
            double freqEnd = 0;
            double duration = 0;
            double cycles = 0;
            Boolean error = false;
            String errorMessage = "";

            freqStart = double.Parse(freqStartTextBox.Text);
            switch (freqStartComboBox.Items[freqStartComboBox.SelectedIndex].ToString())
            {
                case "Hz":
                    freqStart *= 1;
                    break;

                case "KHz":
                    freqStart *= 1000;
                    break;

                case "MHz":
                    freqStart *= 1000000;
                    break;
            }
            Console.WriteLine("freqStart", freqStart);

            freqEnd = double.Parse(freqEndTextBox.Text);
            switch (freqEndComboBox.Items[freqEndComboBox.SelectedIndex].ToString())
            {
                case "Hz":
                    freqEnd *= 1;
                    break;

                case "KHz":
                    freqEnd *= 1000;
                    break;

                case "MHz":
                    freqEnd *= 1000000;
                    break;
            }
            Console.WriteLine("freqStart", freqStart);

            duration = double.Parse(durationTextBox.Text);
            cycles = double.Parse(cyclesTextBox.Text);

            // Check for errors
            if (freqStart < .01 || freqStart > 10000000)
            {
                error = true;
                errorMessage += "-The Start Frequency must be between .01 Hz and 10 MHz\n";
            }
            if (freqEnd < .01 || freqEnd > 10000000)
            {
                error = true;
                errorMessage += "-The End Frequency must be between .01 Hz and 10 MHz\n";
            }
            if (duration < 1 || duration > 30)
            {
                error = true;
                errorMessage += "-The Duration must be between 1 second and 30 seconds\n";
            }
            if (cycles < 1 || cycles > 300)
            {
                error = true;
                errorMessage += "-The Number of Steps must be between 1 cycle and 300 cycles\n";
            }
            else if ((cycles / duration) > 10)
            {
                error = true;
                errorMessage += "-The Number of Steps per second must be 10 or less\n";
            }

            if (!error)
            {
                xlApp = new Excel.Application();
                if (xlApp == null)
                {
                    MessageBox.Show("Excel is not installed", "Error");
                    freqStartTextBox.Text = string.Empty;
                    freqEndTextBox.Text = string.Empty;
                    durationTextBox.Text = string.Empty;
                    cyclesTextBox.Text = string.Empty;
                    return;
                }

                object misValue = System.Reflection.Missing.Value;

                xlWorkBook = xlApp.Workbooks.Add(misValue);
                xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);

                int row = 1;
                double freq = freqStart;
                for (double d = 0; d <= duration; d += (duration/cycles))
                {
                    xlWorkSheet.Cells[row, 1] = d;
                    xlWorkSheet.Cells[row, 2] = freq;
                    freq += (Math.Abs(freqStart - freqEnd) / cycles);
                    row++;
                }

                saveFileDialog1.Filter = "Excel Files|*.xls;*.xlsx;*.xlsm";
                saveFileDialog1.FilterIndex = 2;
                saveFileDialog1.RestoreDirectory = true;
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        xlWorkBook.SaveAs(Path.GetFullPath(saveFileDialog1.FileName), Excel.XlFileFormat.xlWorkbookNormal, misValue, misValue, misValue, misValue, Excel.XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue);
                    }
                    catch (Exception) 
                    {
                        MessageBox.Show("Error saving excel file", "Error");
                    }
                }

                xlWorkBook.Close(true, misValue, misValue);
                xlApp.Quit();

                releaseObject(xlWorkSheet);
                releaseObject(xlWorkBook);
                releaseObject(xlApp);
            }
            else
            {
                MessageBox.Show(errorMessage, "Error");
            }

            freqStartTextBox.Text = string.Empty;
            freqEndTextBox.Text = string.Empty;
            durationTextBox.Text = string.Empty;
            cyclesTextBox.Text = string.Empty;
        }

        private void editTableButton_Click(object sender, EventArgs e)
        {
            xlApp = new Excel.Application();
            if (xlApp == null)
            {
                MessageBox.Show("Excel is not installed", "Error");
                return;
            }

            string directoryPath = "";
            openFileDialog1.Filter = "Excel Files|*.xls;*.xlsx;*.xlsm";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                directoryPath = Path.GetFullPath(openFileDialog1.FileName);
            }

            if (!Path.IsPathRooted(directoryPath))
            {
                xlApp.Quit();
                MessageBox.Show("Invalid file picked", "Error");
                return;
            }

            object misValue = System.Reflection.Missing.Value;
            xlWorkBook = xlApp.Workbooks.Open(directoryPath, 0, false, 5, "", "", true, Microsoft.Office.Interop.Excel.XlPlatform.xlWindows, "\t", false, false, 0, true, 1, 0);
            xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);

            xlApp.Visible = true;
        }

        private void downloadTableButton_Click(object sender, EventArgs e)
        {
            // Download from arduino
        }

        private void uploadTableButton_Click(object sender, EventArgs e)
        {
            // Send to arduino
        }

        private void createTableButton_Click(object sender, EventArgs e)
        {
            xlApp = new Excel.Application();
            if (xlApp == null)
            {
                MessageBox.Show("Excel is not installed", "Error");
                return;
            }

            object misValue = System.Reflection.Missing.Value;

            xlWorkBook = xlApp.Workbooks.Add(misValue);
            xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);

            xlApp.Visible = true;
        }

        private void runTableButton_Click(object sender, EventArgs e)
        {
            xlApp = new Excel.Application();
            if (xlApp == null)
            {
                MessageBox.Show("Excel is not installed", "Error");
                return;
            }

            string directoryPath = "";
            openFileDialog1.Filter = "Excel Files|*.xls;*.xlsx;*.xlsm";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                directoryPath = Path.GetFullPath(openFileDialog1.FileName);
            }

            if (!Path.IsPathRooted(directoryPath))
            {
                xlApp.Quit();
                MessageBox.Show("Invalid file picked", "Error");
                return;
            }

            xlWorkBook = xlApp.Workbooks.Open(directoryPath, 0, true, 5, "", "", true, Microsoft.Office.Interop.Excel.XlPlatform.xlWindows, "\t", false, false, 0, true, 1, 0);
            xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);
            range = xlWorkSheet.UsedRange;

            int rowCount = range.Rows.Count;
            int colCount = range.Columns.Count;
            Boolean error = false;
            String errorMessage = "";

            if (colCount == 2 && rowCount > 1)
            {
                // Buffer
                frequencyLabelValue.Text = "Buffering";
                frequencyLabelValue.Update();

                List<KeyValuePair<double, double>> buffer = new List<KeyValuePair<double, double>>();
                buffer.Add(new KeyValuePair<double, double>(0, (range.Cells[1, 2] as Excel.Range).Value2));
                if ((range.Cells[1, 2] as Excel.Range).Value2 < .01 || (range.Cells[1, 2] as Excel.Range).Value2 > 10000000)
                {
                    error = true;
                    errorMessage = "Incorrect frequency value on row: 1" + "\nAll frequencies must be between .01 Hz and 10 MHz";
                }

                for (int row = 2; row <= rowCount; row++)
                {
                    double time1 = (range.Cells[row - 1, 1] as Excel.Range).Value2;
                    double time2 = (range.Cells[row, 1] as Excel.Range).Value2;
                    double duration = time2 - time1;
                    if(duration < .1)
                    {
                        error = true;
                        errorMessage = "Time scale too small on row " + row + "\nDuration: " + duration + "\nDuration must be between above .01 seconds";
                        break;
                    }

                    double tableFrequency = (range.Cells[row, 2] as Excel.Range).Value2;
                    if (tableFrequency < .01 || tableFrequency > 10000000)
                    {
                        error = true;
                        errorMessage = "Incorrect frequency value on row: " + row + "\nFrequency: " + tableFrequency + "\nAll frequencies must be between .01 Hz and 10 MHz";
                        break;
                    }

                    buffer.Add(new KeyValuePair<double, double>(duration, tableFrequency));
                }

                // Error checking
                if(error)
                {
                    MessageBox.Show(errorMessage, "Error");
                    frequencyLabelValue.Text = string.Format("{0:N2}", frequency).Replace(",", "");
                    frequencyLabelValue.Update();
                    return;
                }

                // Execution
                for (int row = 0; row < rowCount; row++)
                {
                    frequency = buffer[row].Value;
                    frequencyLabelValue.Text = string.Format("{0:N2}", frequency).Replace(",", "");
                    frequencyLabelValue.Update();

                    sendSignalData();
                    Thread.Sleep((int)(buffer[row].Key * 1000));
                }
            }
            else
            {
                MessageBox.Show("Invalid table structure", "Error");
            }

            xlWorkBook.Close(true, null, null);
            xlApp.Quit();

            releaseObject(xlWorkSheet);
            releaseObject(xlWorkBook);
            releaseObject(xlApp);
        }

        private void enableControls()
        {
            waveformGroupBox.Enabled = true;

            freqStartTextBox.Enabled = true;
            freqEndTextBox.Enabled = true;
            durationTextBox.Enabled = true;
            cyclesTextBox.Enabled = true;
            freqStartComboBox.Enabled = true;
            freqEndComboBox.Enabled = true;
            generateSweepButton.Enabled = true;
            generateTableButton.Enabled = true;

            downloadTableButton.Enabled = true;
            uploadTableButton.Enabled = true;
            runTableButton.Enabled = true;

            freqTextBox.Enabled = true;
            pkpkTextBox.Enabled = true;
            rmsTextBox.Enabled = true;
            dBmTextBox.Enabled = true;

            enterButton.Enabled = true;
        }

        private void disableControls()
        {
            waveformGroupBox.Enabled = false;

            freqStartTextBox.Enabled = false;
            freqEndTextBox.Enabled = false;
            durationTextBox.Enabled = false;
            cyclesTextBox.Enabled = false;
            freqStartComboBox.Enabled = false;
            freqEndComboBox.Enabled = false;
            generateSweepButton.Enabled = false;
            generateTableButton.Enabled = false;

            downloadTableButton.Enabled = false;
            uploadTableButton.Enabled = false;
            runTableButton.Enabled = false;

            freqTextBox.Enabled = false;
            pkpkTextBox.Enabled = false;
            rmsTextBox.Enabled = false;
            dBmTextBox.Enabled = false;

            enterButton.Enabled = false;
        }

        private void setAllControls(Boolean state)
        {
            waveformGroupBox.Enabled = state;

            freqStartTextBox.Enabled = state;
            freqEndTextBox.Enabled = state;
            durationTextBox.Enabled = state;
            cyclesTextBox.Enabled = state;
            freqStartComboBox.Enabled = state;
            freqEndComboBox.Enabled = state;
            generateSweepButton.Enabled = state;
            generateTableButton.Enabled = state;

            downloadTableButton.Enabled = state;
            uploadTableButton.Enabled = state;
            editTableButton.Enabled = state;
            createTableButton.Enabled = state;
            runTableButton.Enabled = state;

            connectButton.Enabled = state;
            disconnectButton.Enabled = state;

            freqTextBox.Enabled = state;
            pkpkTextBox.Enabled = state;
            rmsTextBox.Enabled = state;
            dBmTextBox.Enabled = state;

            enterButton.Enabled = state;
        }

        private void releaseObject(object obj)
        {
            try
            {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(obj);
                obj = null;
            }
            catch (Exception ex)
            {
                obj = null;
                Console.WriteLine("Exception Occured while releasing object " + ex.ToString());
            }
            finally
            {
                GC.Collect();
            }
        }

        private void enterButton_Click(object sender, EventArgs e)
        {
            if (freqTextBox.Text != string.Empty)
            {
                if (double.Parse(freqTextBox.Text) >= .01 && double.Parse(freqTextBox.Text) <= 10000000)
                {
                    frequency = double.Parse(freqTextBox.Text);
                    updateFrequencyLabel();
                    sendSignalData();
                }
            }

            if ((pkpkTextBox.Text != string.Empty && rmsTextBox.Text != string.Empty) ||
                (pkpkTextBox.Text != string.Empty && dBmTextBox.Text != string.Empty) ||
                (dBmTextBox.Text != string.Empty && rmsTextBox.Text != string.Empty))
            {
                MessageBox.Show("You can only change one of the following: pkpk, rms, or dBm", "Error");
                return;
            }

            if (pkpkTextBox.Text != string.Empty)
            {
                if (double.Parse(pkpkTextBox.Text) >= 2.5 && double.Parse(pkpkTextBox.Text) <= 2500)
                {
                    pkpkVoltage = double.Parse(pkpkTextBox.Text);
                    updatePkPkLabel();

                    rmsVoltage = Math.Round((pkpkVoltage / (2 * 1.41421356237)), 2);
                    updateRmsLabel();

                    dBm = Math.Round((20 * Math.Log10((pkpkVoltage / 100) / Math.Pow(.05, .5))), 3);
                    updatedBmLabel();

                    sendSignalData();
                }
            }

            if (rmsTextBox.Text != string.Empty)
            {
                if (double.Parse(rmsTextBox.Text) >= .88 && double.Parse(rmsTextBox.Text) <= 883.88)
                {
                    rmsVoltage = double.Parse(rmsTextBox.Text);
                    updateRmsLabel();

                    pkpkVoltage = rmsVoltage * (2 * 1.41421356237);
                    updatePkPkLabel();

                    dBm = Math.Round((20 * Math.Log10((pkpkVoltage / 100) / Math.Pow(.05, .5))), 3);
                    updatedBmLabel();

                    sendSignalData();
                }
            }

            if (dBmTextBox.Text != string.Empty)
            {
                if (double.Parse(dBmTextBox.Text) >= -39.032 && double.Parse(dBmTextBox.Text) <= 20.970)
                {
                    dBm = double.Parse(dBmTextBox.Text);
                    updatedBmLabel();

                    rmsVoltage = 1000 * Math.Pow(.05, .5) * Math.Pow(Math.E, ((Math.Log(10, Math.E) / 20) * dBm));
                    updateRmsLabel();

                    pkpkVoltage = rmsVoltage * (2 * 1.41421356237);
                    updatePkPkLabel();

                    sendSignalData();
                }
            }

            freqTextBox.Text = string.Empty;
            pkpkTextBox.Text = string.Empty;
            rmsTextBox.Text = string.Empty;
            dBmTextBox.Text = string.Empty;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Closing Application");

            if (arduinoPort != null && arduinoPort.IsOpen)
            {
                disconnectButton.PerformClick();
            }
            
            Environment.Exit(0);
        }

        private void helpToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Add stuff here", "Help");
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("PC interface for the Frequency Generator made by Group 4", "Frequency Generator");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //Try/Catch used in case if there is a problem with the COM Port
            try
            {
                arduinoPort.WriteLine("$");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Timer - exception: " + ex.Message);
                disconnectButton.PerformClick();
            }
        }
    }
}