namespace FrequencyGenerator
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.downloadTableButton = new System.Windows.Forms.Button();
            this.changePkpkLabel = new System.Windows.Forms.Label();
            this.pkpkLabel = new System.Windows.Forms.Label();
            this.arduinoPort = new System.IO.Ports.SerialPort(this.components);
            this.usbLabel = new System.Windows.Forms.Label();
            this.disconnectButton = new System.Windows.Forms.Button();
            this.connectButton = new System.Windows.Forms.Button();
            this.startFrequencyLabel = new System.Windows.Forms.Label();
            this.endFrequencyLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.durationUnitsLabel = new System.Windows.Forms.Label();
            this.freqStartTextBox = new System.Windows.Forms.TextBox();
            this.freqEndTextBox = new System.Windows.Forms.TextBox();
            this.durationTextBox = new System.Windows.Forms.TextBox();
            this.sweepGroupBox = new System.Windows.Forms.GroupBox();
            this.generateTableButton = new System.Windows.Forms.Button();
            this.generateSweepButton = new System.Windows.Forms.Button();
            this.cyclesTextBox = new System.Windows.Forms.TextBox();
            this.cyclesLabel = new System.Windows.Forms.Label();
            this.freqStartComboBox = new System.Windows.Forms.ComboBox();
            this.freqEndComboBox = new System.Windows.Forms.ComboBox();
            this.generateChartButton = new System.Windows.Forms.Button();
            this.editTableButton = new System.Windows.Forms.Button();
            this.createTableButton = new System.Windows.Forms.Button();
            this.runTableButton = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.tableControlsGroupBox = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.changeRmsLabel = new System.Windows.Forms.Label();
            this.changedBmLabel = new System.Windows.Forms.Label();
            this.changeFrequencyLabel = new System.Windows.Forms.Label();
            this.waveformGroupBox = new System.Windows.Forms.GroupBox();
            this.sinusodialRadioButton = new System.Windows.Forms.RadioButton();
            this.squareRadioButton = new System.Windows.Forms.RadioButton();
            this.signalGroupBox = new System.Windows.Forms.GroupBox();
            this.enterButton = new System.Windows.Forms.Button();
            this.dbmUnitsLabel2 = new System.Windows.Forms.Label();
            this.dBmTextBox = new System.Windows.Forms.TextBox();
            this.freqTextBox = new System.Windows.Forms.TextBox();
            this.pkpkTextBox = new System.Windows.Forms.TextBox();
            this.rmsUnitsLabel2 = new System.Windows.Forms.Label();
            this.freqUnitsLabel2 = new System.Windows.Forms.Label();
            this.pkpkUnitsLabel2 = new System.Windows.Forms.Label();
            this.rmsTextBox = new System.Windows.Forms.TextBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.dbmUnitsLabel = new System.Windows.Forms.Label();
            this.frequencyLabel = new System.Windows.Forms.Label();
            this.rmsLabel = new System.Windows.Forms.Label();
            this.rmsUnitsLabel = new System.Windows.Forms.Label();
            this.dBmLabel = new System.Windows.Forms.Label();
            this.freqUnitsLabel = new System.Windows.Forms.Label();
            this.pkpkUnitsLabel = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dBmLabelValue = new System.Windows.Forms.Label();
            this.rmsLabelValue = new System.Windows.Forms.Label();
            this.pkpkLabelValue = new System.Windows.Forms.Label();
            this.frequencyLabelValue = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.voltageTextBox = new System.Windows.Forms.TextBox();
            this.voltageLabel = new System.Windows.Forms.Label();
            this.voltageComboBox = new System.Windows.Forms.ComboBox();
            this.defaultsButton = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.sweepGroupBox.SuspendLayout();
            this.tableControlsGroupBox.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.waveformGroupBox.SuspendLayout();
            this.signalGroupBox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(432, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpToolStripMenuItem1,
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // helpToolStripMenuItem1
            // 
            this.helpToolStripMenuItem1.Name = "helpToolStripMenuItem1";
            this.helpToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.helpToolStripMenuItem1.Text = "Help";
            this.helpToolStripMenuItem1.Click += new System.EventHandler(this.helpToolStripMenuItem1_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // downloadTableButton
            // 
            this.downloadTableButton.Enabled = false;
            this.downloadTableButton.Location = new System.Drawing.Point(9, 19);
            this.downloadTableButton.Name = "downloadTableButton";
            this.downloadTableButton.Size = new System.Drawing.Size(101, 23);
            this.downloadTableButton.TabIndex = 33;
            this.downloadTableButton.Text = "Extra";
            this.toolTip1.SetToolTip(this.downloadTableButton, "Download a table from the Signal Generator");
            this.downloadTableButton.UseVisualStyleBackColor = true;
            this.downloadTableButton.Click += new System.EventHandler(this.downloadTableButton_Click);
            // 
            // changePkpkLabel
            // 
            this.changePkpkLabel.AutoSize = true;
            this.changePkpkLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changePkpkLabel.ForeColor = System.Drawing.Color.Black;
            this.changePkpkLabel.Location = new System.Drawing.Point(6, 54);
            this.changePkpkLabel.Name = "changePkpkLabel";
            this.changePkpkLabel.Size = new System.Drawing.Size(34, 13);
            this.changePkpkLabel.TabIndex = 3;
            this.changePkpkLabel.Text = "pkpk:";
            this.toolTip1.SetToolTip(this.changePkpkLabel, "Peak to Peak Voltage");
            // 
            // pkpkLabel
            // 
            this.pkpkLabel.AutoSize = true;
            this.pkpkLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pkpkLabel.ForeColor = System.Drawing.Color.Black;
            this.pkpkLabel.Location = new System.Drawing.Point(6, 64);
            this.pkpkLabel.Name = "pkpkLabel";
            this.pkpkLabel.Size = new System.Drawing.Size(41, 16);
            this.pkpkLabel.TabIndex = 3;
            this.pkpkLabel.Text = "pkpk:";
            this.toolTip1.SetToolTip(this.pkpkLabel, "Peak to Peak Voltage");
            // 
            // arduinoPort
            // 
            this.arduinoPort.BaudRate = 115200;
            this.arduinoPort.PortName = "COM3";
            // 
            // usbLabel
            // 
            this.usbLabel.AutoSize = true;
            this.usbLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usbLabel.ForeColor = System.Drawing.Color.Red;
            this.usbLabel.Location = new System.Drawing.Point(38, 48);
            this.usbLabel.Name = "usbLabel";
            this.usbLabel.Size = new System.Drawing.Size(101, 13);
            this.usbLabel.TabIndex = 21;
            this.usbLabel.Text = "USB: Disconnected";
            // 
            // disconnectButton
            // 
            this.disconnectButton.Enabled = false;
            this.disconnectButton.Location = new System.Drawing.Point(87, 19);
            this.disconnectButton.Name = "disconnectButton";
            this.disconnectButton.Size = new System.Drawing.Size(75, 23);
            this.disconnectButton.TabIndex = 20;
            this.disconnectButton.Text = "Disconnect";
            this.disconnectButton.UseVisualStyleBackColor = true;
            this.disconnectButton.Click += new System.EventHandler(this.disconnectButton_Click);
            // 
            // connectButton
            // 
            this.connectButton.Location = new System.Drawing.Point(6, 19);
            this.connectButton.Name = "connectButton";
            this.connectButton.Size = new System.Drawing.Size(75, 23);
            this.connectButton.TabIndex = 19;
            this.connectButton.Text = "Connect";
            this.connectButton.UseVisualStyleBackColor = true;
            this.connectButton.Click += new System.EventHandler(this.connectButton_Click);
            // 
            // startFrequencyLabel
            // 
            this.startFrequencyLabel.AutoSize = true;
            this.startFrequencyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startFrequencyLabel.ForeColor = System.Drawing.Color.Black;
            this.startFrequencyLabel.Location = new System.Drawing.Point(6, 23);
            this.startFrequencyLabel.Name = "startFrequencyLabel";
            this.startFrequencyLabel.Size = new System.Drawing.Size(82, 13);
            this.startFrequencyLabel.TabIndex = 22;
            this.startFrequencyLabel.Text = "Start Frequency";
            // 
            // endFrequencyLabel
            // 
            this.endFrequencyLabel.AutoSize = true;
            this.endFrequencyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.endFrequencyLabel.ForeColor = System.Drawing.Color.Black;
            this.endFrequencyLabel.Location = new System.Drawing.Point(6, 52);
            this.endFrequencyLabel.Name = "endFrequencyLabel";
            this.endFrequencyLabel.Size = new System.Drawing.Size(79, 13);
            this.endFrequencyLabel.TabIndex = 23;
            this.endFrequencyLabel.Text = "End Frequency";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(6, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 24;
            this.label3.Text = "Duration";
            // 
            // durationUnitsLabel
            // 
            this.durationUnitsLabel.AutoSize = true;
            this.durationUnitsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.durationUnitsLabel.ForeColor = System.Drawing.Color.Black;
            this.durationUnitsLabel.Location = new System.Drawing.Point(216, 81);
            this.durationUnitsLabel.Name = "durationUnitsLabel";
            this.durationUnitsLabel.Size = new System.Drawing.Size(47, 13);
            this.durationUnitsLabel.TabIndex = 25;
            this.durationUnitsLabel.Text = "seconds";
            // 
            // freqStartTextBox
            // 
            this.freqStartTextBox.Enabled = false;
            this.freqStartTextBox.Location = new System.Drawing.Point(115, 20);
            this.freqStartTextBox.MaxLength = 11;
            this.freqStartTextBox.Name = "freqStartTextBox";
            this.freqStartTextBox.Size = new System.Drawing.Size(95, 20);
            this.freqStartTextBox.TabIndex = 26;
            this.freqStartTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxNumbers_KeyPress);
            // 
            // freqEndTextBox
            // 
            this.freqEndTextBox.Enabled = false;
            this.freqEndTextBox.Location = new System.Drawing.Point(115, 49);
            this.freqEndTextBox.MaxLength = 8;
            this.freqEndTextBox.Name = "freqEndTextBox";
            this.freqEndTextBox.Size = new System.Drawing.Size(95, 20);
            this.freqEndTextBox.TabIndex = 27;
            this.freqEndTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxNumbers_KeyPress);
            // 
            // durationTextBox
            // 
            this.durationTextBox.Enabled = false;
            this.durationTextBox.Location = new System.Drawing.Point(115, 78);
            this.durationTextBox.MaxLength = 2;
            this.durationTextBox.Name = "durationTextBox";
            this.durationTextBox.Size = new System.Drawing.Size(95, 20);
            this.durationTextBox.TabIndex = 28;
            this.durationTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxNumbers_KeyPress);
            // 
            // sweepGroupBox
            // 
            this.sweepGroupBox.Controls.Add(this.voltageComboBox);
            this.sweepGroupBox.Controls.Add(this.voltageTextBox);
            this.sweepGroupBox.Controls.Add(this.voltageLabel);
            this.sweepGroupBox.Controls.Add(this.generateTableButton);
            this.sweepGroupBox.Controls.Add(this.generateSweepButton);
            this.sweepGroupBox.Controls.Add(this.startFrequencyLabel);
            this.sweepGroupBox.Controls.Add(this.freqEndTextBox);
            this.sweepGroupBox.Controls.Add(this.cyclesTextBox);
            this.sweepGroupBox.Controls.Add(this.endFrequencyLabel);
            this.sweepGroupBox.Controls.Add(this.label3);
            this.sweepGroupBox.Controls.Add(this.cyclesLabel);
            this.sweepGroupBox.Controls.Add(this.durationTextBox);
            this.sweepGroupBox.Controls.Add(this.freqStartTextBox);
            this.sweepGroupBox.Controls.Add(this.durationUnitsLabel);
            this.sweepGroupBox.Controls.Add(this.freqStartComboBox);
            this.sweepGroupBox.Controls.Add(this.freqEndComboBox);
            this.sweepGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sweepGroupBox.ForeColor = System.Drawing.Color.Black;
            this.sweepGroupBox.Location = new System.Drawing.Point(12, 276);
            this.sweepGroupBox.Name = "sweepGroupBox";
            this.sweepGroupBox.Size = new System.Drawing.Size(272, 199);
            this.sweepGroupBox.TabIndex = 32;
            this.sweepGroupBox.TabStop = false;
            this.sweepGroupBox.Text = "Generate Sweep";
            // 
            // generateTableButton
            // 
            this.generateTableButton.Enabled = false;
            this.generateTableButton.Location = new System.Drawing.Point(9, 165);
            this.generateTableButton.Name = "generateTableButton";
            this.generateTableButton.Size = new System.Drawing.Size(101, 23);
            this.generateTableButton.TabIndex = 38;
            this.generateTableButton.Text = "Generate Table";
            this.generateTableButton.UseVisualStyleBackColor = true;
            this.generateTableButton.Click += new System.EventHandler(this.generateTableButton_Click);
            // 
            // generateSweepButton
            // 
            this.generateSweepButton.Enabled = false;
            this.generateSweepButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generateSweepButton.Location = new System.Drawing.Point(115, 165);
            this.generateSweepButton.Name = "generateSweepButton";
            this.generateSweepButton.Size = new System.Drawing.Size(95, 23);
            this.generateSweepButton.TabIndex = 33;
            this.generateSweepButton.Text = "Generate Sweep";
            this.generateSweepButton.UseVisualStyleBackColor = true;
            this.generateSweepButton.Click += new System.EventHandler(this.generateSweepButton_Click);
            // 
            // cyclesTextBox
            // 
            this.cyclesTextBox.Enabled = false;
            this.cyclesTextBox.Location = new System.Drawing.Point(115, 107);
            this.cyclesTextBox.Name = "cyclesTextBox";
            this.cyclesTextBox.Size = new System.Drawing.Size(95, 20);
            this.cyclesTextBox.TabIndex = 33;
            this.cyclesTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxNumbers_KeyPress);
            // 
            // cyclesLabel
            // 
            this.cyclesLabel.AutoSize = true;
            this.cyclesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cyclesLabel.ForeColor = System.Drawing.Color.Black;
            this.cyclesLabel.Location = new System.Drawing.Point(6, 110);
            this.cyclesLabel.Name = "cyclesLabel";
            this.cyclesLabel.Size = new System.Drawing.Size(86, 13);
            this.cyclesLabel.TabIndex = 32;
            this.cyclesLabel.Text = "Number of Steps";
            // 
            // freqStartComboBox
            // 
            this.freqStartComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.freqStartComboBox.Enabled = false;
            this.freqStartComboBox.FormattingEnabled = true;
            this.freqStartComboBox.Items.AddRange(new object[] {
            "Hz",
            "KHz",
            "MHz"});
            this.freqStartComboBox.Location = new System.Drawing.Point(216, 20);
            this.freqStartComboBox.Name = "freqStartComboBox";
            this.freqStartComboBox.Size = new System.Drawing.Size(47, 21);
            this.freqStartComboBox.TabIndex = 29;
            this.freqStartComboBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxNumbers_KeyPress);
            // 
            // freqEndComboBox
            // 
            this.freqEndComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.freqEndComboBox.Enabled = false;
            this.freqEndComboBox.FormattingEnabled = true;
            this.freqEndComboBox.Items.AddRange(new object[] {
            "Hz",
            "KHz",
            "MHz"});
            this.freqEndComboBox.Location = new System.Drawing.Point(216, 49);
            this.freqEndComboBox.Name = "freqEndComboBox";
            this.freqEndComboBox.Size = new System.Drawing.Size(47, 21);
            this.freqEndComboBox.TabIndex = 30;
            // 
            // generateChartButton
            // 
            this.generateChartButton.Location = new System.Drawing.Point(9, 48);
            this.generateChartButton.Name = "generateChartButton";
            this.generateChartButton.Size = new System.Drawing.Size(101, 23);
            this.generateChartButton.TabIndex = 34;
            this.generateChartButton.Text = "Generate Chart";
            this.generateChartButton.UseVisualStyleBackColor = true;
            this.generateChartButton.Click += new System.EventHandler(this.uploadTableButton_Click);
            // 
            // editTableButton
            // 
            this.editTableButton.Location = new System.Drawing.Point(9, 77);
            this.editTableButton.Name = "editTableButton";
            this.editTableButton.Size = new System.Drawing.Size(101, 23);
            this.editTableButton.TabIndex = 35;
            this.editTableButton.Text = "Edit Table";
            this.editTableButton.UseVisualStyleBackColor = true;
            this.editTableButton.Click += new System.EventHandler(this.editTableButton_Click);
            // 
            // createTableButton
            // 
            this.createTableButton.Location = new System.Drawing.Point(9, 106);
            this.createTableButton.Name = "createTableButton";
            this.createTableButton.Size = new System.Drawing.Size(101, 23);
            this.createTableButton.TabIndex = 36;
            this.createTableButton.Text = "Create New Table";
            this.createTableButton.UseVisualStyleBackColor = true;
            this.createTableButton.Click += new System.EventHandler(this.createTableButton_Click);
            // 
            // runTableButton
            // 
            this.runTableButton.Enabled = false;
            this.runTableButton.Location = new System.Drawing.Point(9, 135);
            this.runTableButton.Name = "runTableButton";
            this.runTableButton.Size = new System.Drawing.Size(101, 23);
            this.runTableButton.TabIndex = 37;
            this.runTableButton.Text = "Run Table";
            this.runTableButton.UseVisualStyleBackColor = true;
            this.runTableButton.Click += new System.EventHandler(this.runTableButton_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "sweepTable";
            this.openFileDialog1.Title = "Browse Excel Files";
            // 
            // tableControlsGroupBox
            // 
            this.tableControlsGroupBox.Controls.Add(this.runTableButton);
            this.tableControlsGroupBox.Controls.Add(this.downloadTableButton);
            this.tableControlsGroupBox.Controls.Add(this.createTableButton);
            this.tableControlsGroupBox.Controls.Add(this.generateChartButton);
            this.tableControlsGroupBox.Controls.Add(this.editTableButton);
            this.tableControlsGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableControlsGroupBox.Location = new System.Drawing.Point(296, 276);
            this.tableControlsGroupBox.Name = "tableControlsGroupBox";
            this.tableControlsGroupBox.Size = new System.Drawing.Size(122, 168);
            this.tableControlsGroupBox.TabIndex = 38;
            this.tableControlsGroupBox.TabStop = false;
            this.tableControlsGroupBox.Text = "Table Controls";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.disconnectButton);
            this.groupBox2.Controls.Add(this.connectButton);
            this.groupBox2.Controls.Add(this.usbLabel);
            this.groupBox2.Location = new System.Drawing.Point(216, 201);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(169, 69);
            this.groupBox2.TabIndex = 39;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Connection Status";
            // 
            // changeRmsLabel
            // 
            this.changeRmsLabel.AutoSize = true;
            this.changeRmsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeRmsLabel.ForeColor = System.Drawing.Color.Black;
            this.changeRmsLabel.Location = new System.Drawing.Point(6, 83);
            this.changeRmsLabel.Name = "changeRmsLabel";
            this.changeRmsLabel.Size = new System.Drawing.Size(26, 13);
            this.changeRmsLabel.TabIndex = 4;
            this.changeRmsLabel.Text = "rms:";
            // 
            // changedBmLabel
            // 
            this.changedBmLabel.AutoSize = true;
            this.changedBmLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changedBmLabel.ForeColor = System.Drawing.Color.Black;
            this.changedBmLabel.Location = new System.Drawing.Point(6, 112);
            this.changedBmLabel.Name = "changedBmLabel";
            this.changedBmLabel.Size = new System.Drawing.Size(31, 13);
            this.changedBmLabel.TabIndex = 5;
            this.changedBmLabel.Text = "dBm:";
            // 
            // changeFrequencyLabel
            // 
            this.changeFrequencyLabel.AutoSize = true;
            this.changeFrequencyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeFrequencyLabel.ForeColor = System.Drawing.Color.Black;
            this.changeFrequencyLabel.Location = new System.Drawing.Point(6, 25);
            this.changeFrequencyLabel.Name = "changeFrequencyLabel";
            this.changeFrequencyLabel.Size = new System.Drawing.Size(57, 13);
            this.changeFrequencyLabel.TabIndex = 1;
            this.changeFrequencyLabel.Text = "frequency:";
            // 
            // waveformGroupBox
            // 
            this.waveformGroupBox.Controls.Add(this.sinusodialRadioButton);
            this.waveformGroupBox.Controls.Add(this.squareRadioButton);
            this.waveformGroupBox.Enabled = false;
            this.waveformGroupBox.Location = new System.Drawing.Point(127, 201);
            this.waveformGroupBox.Name = "waveformGroupBox";
            this.waveformGroupBox.Size = new System.Drawing.Size(83, 69);
            this.waveformGroupBox.TabIndex = 40;
            this.waveformGroupBox.TabStop = false;
            this.waveformGroupBox.Text = "Waveform";
            // 
            // sinusodialRadioButton
            // 
            this.sinusodialRadioButton.AutoSize = true;
            this.sinusodialRadioButton.Checked = true;
            this.sinusodialRadioButton.ForeColor = System.Drawing.Color.Black;
            this.sinusodialRadioButton.Location = new System.Drawing.Point(6, 19);
            this.sinusodialRadioButton.Name = "sinusodialRadioButton";
            this.sinusodialRadioButton.Size = new System.Drawing.Size(73, 17);
            this.sinusodialRadioButton.TabIndex = 4;
            this.sinusodialRadioButton.TabStop = true;
            this.sinusodialRadioButton.Text = "Sinusodial";
            this.sinusodialRadioButton.UseVisualStyleBackColor = true;
            this.sinusodialRadioButton.CheckedChanged += new System.EventHandler(this.waveformGroupBox_CheckedChanged);
            // 
            // squareRadioButton
            // 
            this.squareRadioButton.AutoSize = true;
            this.squareRadioButton.ForeColor = System.Drawing.Color.Black;
            this.squareRadioButton.Location = new System.Drawing.Point(6, 42);
            this.squareRadioButton.Name = "squareRadioButton";
            this.squareRadioButton.Size = new System.Drawing.Size(59, 17);
            this.squareRadioButton.TabIndex = 5;
            this.squareRadioButton.Text = "Square";
            this.squareRadioButton.UseVisualStyleBackColor = true;
            this.squareRadioButton.CheckedChanged += new System.EventHandler(this.waveformGroupBox_CheckedChanged);
            // 
            // signalGroupBox
            // 
            this.signalGroupBox.Controls.Add(this.defaultsButton);
            this.signalGroupBox.Controls.Add(this.enterButton);
            this.signalGroupBox.Controls.Add(this.dbmUnitsLabel2);
            this.signalGroupBox.Controls.Add(this.changeFrequencyLabel);
            this.signalGroupBox.Controls.Add(this.changeRmsLabel);
            this.signalGroupBox.Controls.Add(this.dBmTextBox);
            this.signalGroupBox.Controls.Add(this.freqTextBox);
            this.signalGroupBox.Controls.Add(this.pkpkTextBox);
            this.signalGroupBox.Controls.Add(this.rmsUnitsLabel2);
            this.signalGroupBox.Controls.Add(this.changePkpkLabel);
            this.signalGroupBox.Controls.Add(this.changedBmLabel);
            this.signalGroupBox.Controls.Add(this.freqUnitsLabel2);
            this.signalGroupBox.Controls.Add(this.pkpkUnitsLabel2);
            this.signalGroupBox.Controls.Add(this.rmsTextBox);
            this.signalGroupBox.Location = new System.Drawing.Point(216, 27);
            this.signalGroupBox.Name = "signalGroupBox";
            this.signalGroupBox.Size = new System.Drawing.Size(202, 168);
            this.signalGroupBox.TabIndex = 55;
            this.signalGroupBox.TabStop = false;
            this.signalGroupBox.Text = "Enter Signal";
            // 
            // enterButton
            // 
            this.enterButton.Enabled = false;
            this.enterButton.Location = new System.Drawing.Point(92, 135);
            this.enterButton.Name = "enterButton";
            this.enterButton.Size = new System.Drawing.Size(75, 23);
            this.enterButton.TabIndex = 56;
            this.enterButton.Text = "Enter";
            this.enterButton.UseVisualStyleBackColor = true;
            this.enterButton.Click += new System.EventHandler(this.enterButton_Click);
            // 
            // dbmUnitsLabel2
            // 
            this.dbmUnitsLabel2.AutoSize = true;
            this.dbmUnitsLabel2.Location = new System.Drawing.Point(171, 112);
            this.dbmUnitsLabel2.Name = "dbmUnitsLabel2";
            this.dbmUnitsLabel2.Size = new System.Drawing.Size(28, 13);
            this.dbmUnitsLabel2.TabIndex = 59;
            this.dbmUnitsLabel2.Text = "dBm";
            // 
            // dBmTextBox
            // 
            this.dBmTextBox.Enabled = false;
            this.dBmTextBox.Location = new System.Drawing.Point(92, 109);
            this.dBmTextBox.MaxLength = 7;
            this.dBmTextBox.Name = "dBmTextBox";
            this.dBmTextBox.Size = new System.Drawing.Size(75, 20);
            this.dBmTextBox.TabIndex = 58;
            this.dBmTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxNumbers_KeyPress);
            // 
            // freqTextBox
            // 
            this.freqTextBox.Enabled = false;
            this.freqTextBox.Location = new System.Drawing.Point(92, 22);
            this.freqTextBox.MaxLength = 11;
            this.freqTextBox.Name = "freqTextBox";
            this.freqTextBox.Size = new System.Drawing.Size(75, 20);
            this.freqTextBox.TabIndex = 34;
            this.freqTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxNumbers_KeyPress);
            // 
            // pkpkTextBox
            // 
            this.pkpkTextBox.Enabled = false;
            this.pkpkTextBox.Location = new System.Drawing.Point(92, 51);
            this.pkpkTextBox.MaxLength = 6;
            this.pkpkTextBox.Name = "pkpkTextBox";
            this.pkpkTextBox.Size = new System.Drawing.Size(75, 20);
            this.pkpkTextBox.TabIndex = 56;
            this.pkpkTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxNumbers_KeyPress);
            // 
            // rmsUnitsLabel2
            // 
            this.rmsUnitsLabel2.AutoSize = true;
            this.rmsUnitsLabel2.Location = new System.Drawing.Point(171, 83);
            this.rmsUnitsLabel2.Name = "rmsUnitsLabel2";
            this.rmsUnitsLabel2.Size = new System.Drawing.Size(22, 13);
            this.rmsUnitsLabel2.TabIndex = 58;
            this.rmsUnitsLabel2.Text = "mV";
            // 
            // freqUnitsLabel2
            // 
            this.freqUnitsLabel2.AutoSize = true;
            this.freqUnitsLabel2.Location = new System.Drawing.Point(171, 25);
            this.freqUnitsLabel2.Name = "freqUnitsLabel2";
            this.freqUnitsLabel2.Size = new System.Drawing.Size(20, 13);
            this.freqUnitsLabel2.TabIndex = 56;
            this.freqUnitsLabel2.Text = "Hz";
            // 
            // pkpkUnitsLabel2
            // 
            this.pkpkUnitsLabel2.AutoSize = true;
            this.pkpkUnitsLabel2.Location = new System.Drawing.Point(171, 54);
            this.pkpkUnitsLabel2.Name = "pkpkUnitsLabel2";
            this.pkpkUnitsLabel2.Size = new System.Drawing.Size(22, 13);
            this.pkpkUnitsLabel2.TabIndex = 57;
            this.pkpkUnitsLabel2.Text = "mV";
            // 
            // rmsTextBox
            // 
            this.rmsTextBox.Enabled = false;
            this.rmsTextBox.Location = new System.Drawing.Point(92, 80);
            this.rmsTextBox.MaxLength = 6;
            this.rmsTextBox.Name = "rmsTextBox";
            this.rmsTextBox.Size = new System.Drawing.Size(75, 20);
            this.rmsTextBox.TabIndex = 57;
            this.rmsTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxNumbers_KeyPress);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.FileName = "sweepTable";
            // 
            // dbmUnitsLabel
            // 
            this.dbmUnitsLabel.AutoSize = true;
            this.dbmUnitsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dbmUnitsLabel.Location = new System.Drawing.Point(159, 132);
            this.dbmUnitsLabel.Name = "dbmUnitsLabel";
            this.dbmUnitsLabel.Size = new System.Drawing.Size(36, 16);
            this.dbmUnitsLabel.TabIndex = 59;
            this.dbmUnitsLabel.Text = "dBm";
            // 
            // frequencyLabel
            // 
            this.frequencyLabel.AutoSize = true;
            this.frequencyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.frequencyLabel.ForeColor = System.Drawing.Color.Black;
            this.frequencyLabel.Location = new System.Drawing.Point(6, 30);
            this.frequencyLabel.Name = "frequencyLabel";
            this.frequencyLabel.Size = new System.Drawing.Size(70, 16);
            this.frequencyLabel.TabIndex = 1;
            this.frequencyLabel.Text = "frequency:";
            // 
            // rmsLabel
            // 
            this.rmsLabel.AutoSize = true;
            this.rmsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rmsLabel.ForeColor = System.Drawing.Color.Black;
            this.rmsLabel.Location = new System.Drawing.Point(6, 98);
            this.rmsLabel.Name = "rmsLabel";
            this.rmsLabel.Size = new System.Drawing.Size(33, 16);
            this.rmsLabel.TabIndex = 4;
            this.rmsLabel.Text = "rms:";
            // 
            // rmsUnitsLabel
            // 
            this.rmsUnitsLabel.AutoSize = true;
            this.rmsUnitsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rmsUnitsLabel.Location = new System.Drawing.Point(159, 98);
            this.rmsUnitsLabel.Name = "rmsUnitsLabel";
            this.rmsUnitsLabel.Size = new System.Drawing.Size(28, 16);
            this.rmsUnitsLabel.TabIndex = 58;
            this.rmsUnitsLabel.Text = "mV";
            // 
            // dBmLabel
            // 
            this.dBmLabel.AutoSize = true;
            this.dBmLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dBmLabel.ForeColor = System.Drawing.Color.Black;
            this.dBmLabel.Location = new System.Drawing.Point(6, 132);
            this.dBmLabel.Name = "dBmLabel";
            this.dBmLabel.Size = new System.Drawing.Size(39, 16);
            this.dBmLabel.TabIndex = 5;
            this.dBmLabel.Text = "dBm:";
            // 
            // freqUnitsLabel
            // 
            this.freqUnitsLabel.AutoSize = true;
            this.freqUnitsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.freqUnitsLabel.Location = new System.Drawing.Point(159, 30);
            this.freqUnitsLabel.Name = "freqUnitsLabel";
            this.freqUnitsLabel.Size = new System.Drawing.Size(24, 16);
            this.freqUnitsLabel.TabIndex = 56;
            this.freqUnitsLabel.Text = "Hz";
            // 
            // pkpkUnitsLabel
            // 
            this.pkpkUnitsLabel.AutoSize = true;
            this.pkpkUnitsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pkpkUnitsLabel.Location = new System.Drawing.Point(159, 64);
            this.pkpkUnitsLabel.Name = "pkpkUnitsLabel";
            this.pkpkUnitsLabel.Size = new System.Drawing.Size(28, 16);
            this.pkpkUnitsLabel.TabIndex = 57;
            this.pkpkUnitsLabel.Text = "mV";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dBmLabelValue);
            this.groupBox1.Controls.Add(this.rmsLabelValue);
            this.groupBox1.Controls.Add(this.dbmUnitsLabel);
            this.groupBox1.Controls.Add(this.frequencyLabel);
            this.groupBox1.Controls.Add(this.pkpkLabelValue);
            this.groupBox1.Controls.Add(this.rmsLabel);
            this.groupBox1.Controls.Add(this.frequencyLabelValue);
            this.groupBox1.Controls.Add(this.rmsUnitsLabel);
            this.groupBox1.Controls.Add(this.pkpkLabel);
            this.groupBox1.Controls.Add(this.dBmLabel);
            this.groupBox1.Controls.Add(this.freqUnitsLabel);
            this.groupBox1.Controls.Add(this.pkpkUnitsLabel);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(198, 168);
            this.groupBox1.TabIndex = 60;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Signal";
            // 
            // dBmLabelValue
            // 
            this.dBmLabelValue.AutoSize = true;
            this.dBmLabelValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dBmLabelValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.dBmLabelValue.Location = new System.Drawing.Point(82, 132);
            this.dBmLabelValue.Name = "dBmLabelValue";
            this.dBmLabelValue.Size = new System.Drawing.Size(12, 16);
            this.dBmLabelValue.TabIndex = 63;
            this.dBmLabelValue.Text = "-";
            // 
            // rmsLabelValue
            // 
            this.rmsLabelValue.AutoSize = true;
            this.rmsLabelValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rmsLabelValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.rmsLabelValue.Location = new System.Drawing.Point(82, 98);
            this.rmsLabelValue.Name = "rmsLabelValue";
            this.rmsLabelValue.Size = new System.Drawing.Size(12, 16);
            this.rmsLabelValue.TabIndex = 64;
            this.rmsLabelValue.Text = "-";
            // 
            // pkpkLabelValue
            // 
            this.pkpkLabelValue.AutoSize = true;
            this.pkpkLabelValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pkpkLabelValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.pkpkLabelValue.Location = new System.Drawing.Point(82, 64);
            this.pkpkLabelValue.Name = "pkpkLabelValue";
            this.pkpkLabelValue.Size = new System.Drawing.Size(12, 16);
            this.pkpkLabelValue.TabIndex = 62;
            this.pkpkLabelValue.Text = "-";
            // 
            // frequencyLabelValue
            // 
            this.frequencyLabelValue.AutoSize = true;
            this.frequencyLabelValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.frequencyLabelValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.frequencyLabelValue.Location = new System.Drawing.Point(82, 30);
            this.frequencyLabelValue.Name = "frequencyLabelValue";
            this.frequencyLabelValue.Size = new System.Drawing.Size(12, 16);
            this.frequencyLabelValue.TabIndex = 61;
            this.frequencyLabelValue.Text = "-";
            // 
            // timer1
            // 
            this.timer1.Interval = 250;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // voltageTextBox
            // 
            this.voltageTextBox.Enabled = false;
            this.voltageTextBox.Location = new System.Drawing.Point(115, 136);
            this.voltageTextBox.Name = "voltageTextBox";
            this.voltageTextBox.Size = new System.Drawing.Size(95, 20);
            this.voltageTextBox.TabIndex = 40;
            // 
            // voltageLabel
            // 
            this.voltageLabel.AutoSize = true;
            this.voltageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.voltageLabel.ForeColor = System.Drawing.Color.Black;
            this.voltageLabel.Location = new System.Drawing.Point(6, 139);
            this.voltageLabel.Name = "voltageLabel";
            this.voltageLabel.Size = new System.Drawing.Size(43, 13);
            this.voltageLabel.TabIndex = 39;
            this.voltageLabel.Text = "Voltage";
            // 
            // voltageComboBox
            // 
            this.voltageComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.voltageComboBox.Enabled = false;
            this.voltageComboBox.FormattingEnabled = true;
            this.voltageComboBox.Items.AddRange(new object[] {
            "mV",
            "V"});
            this.voltageComboBox.Location = new System.Drawing.Point(216, 136);
            this.voltageComboBox.Name = "voltageComboBox";
            this.voltageComboBox.Size = new System.Drawing.Size(47, 21);
            this.voltageComboBox.TabIndex = 41;
            // 
            // defaultsButton
            // 
            this.defaultsButton.Enabled = false;
            this.defaultsButton.Location = new System.Drawing.Point(9, 135);
            this.defaultsButton.Name = "defaultsButton";
            this.defaultsButton.Size = new System.Drawing.Size(75, 23);
            this.defaultsButton.TabIndex = 60;
            this.defaultsButton.Text = "Defaults";
            this.defaultsButton.UseVisualStyleBackColor = true;
            this.defaultsButton.Click += new System.EventHandler(this.defaultsButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(432, 486);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.signalGroupBox);
            this.Controls.Add(this.waveformGroupBox);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.sweepGroupBox);
            this.Controls.Add(this.tableControlsGroupBox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Signal Generator Control Panel";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.sweepGroupBox.ResumeLayout(false);
            this.sweepGroupBox.PerformLayout();
            this.tableControlsGroupBox.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.waveformGroupBox.ResumeLayout(false);
            this.waveformGroupBox.PerformLayout();
            this.signalGroupBox.ResumeLayout(false);
            this.signalGroupBox.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.IO.Ports.SerialPort arduinoPort;
        private System.Windows.Forms.Label usbLabel;
        private System.Windows.Forms.Button disconnectButton;
        private System.Windows.Forms.Button connectButton;
        private System.Windows.Forms.Label startFrequencyLabel;
        private System.Windows.Forms.Label endFrequencyLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label durationUnitsLabel;
        private System.Windows.Forms.TextBox freqStartTextBox;
        private System.Windows.Forms.TextBox freqEndTextBox;
        private System.Windows.Forms.TextBox durationTextBox;
        private System.Windows.Forms.GroupBox sweepGroupBox;
        private System.Windows.Forms.TextBox cyclesTextBox;
        private System.Windows.Forms.Label cyclesLabel;
        private System.Windows.Forms.ComboBox freqEndComboBox;
        private System.Windows.Forms.ComboBox freqStartComboBox;
        private System.Windows.Forms.Button generateSweepButton;
        private System.Windows.Forms.Button downloadTableButton;
        private System.Windows.Forms.Button generateChartButton;
        private System.Windows.Forms.Button editTableButton;
        private System.Windows.Forms.Button createTableButton;
        private System.Windows.Forms.Button runTableButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.GroupBox tableControlsGroupBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label changePkpkLabel;
        private System.Windows.Forms.Label changeRmsLabel;
        private System.Windows.Forms.Label changedBmLabel;
        private System.Windows.Forms.Label changeFrequencyLabel;
        private System.Windows.Forms.GroupBox waveformGroupBox;
        private System.Windows.Forms.RadioButton sinusodialRadioButton;
        private System.Windows.Forms.RadioButton squareRadioButton;
        private System.Windows.Forms.GroupBox signalGroupBox;
        private System.Windows.Forms.TextBox dBmTextBox;
        private System.Windows.Forms.TextBox rmsTextBox;
        private System.Windows.Forms.TextBox pkpkTextBox;
        private System.Windows.Forms.TextBox freqTextBox;
        private System.Windows.Forms.Label dbmUnitsLabel2;
        private System.Windows.Forms.Label rmsUnitsLabel2;
        private System.Windows.Forms.Label pkpkUnitsLabel2;
        private System.Windows.Forms.Label freqUnitsLabel2;
        private System.Windows.Forms.Button generateTableButton;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button enterButton;
        private System.Windows.Forms.Label dbmUnitsLabel;
        private System.Windows.Forms.Label frequencyLabel;
        private System.Windows.Forms.Label rmsLabel;
        private System.Windows.Forms.Label rmsUnitsLabel;
        private System.Windows.Forms.Label pkpkLabel;
        private System.Windows.Forms.Label dBmLabel;
        private System.Windows.Forms.Label freqUnitsLabel;
        private System.Windows.Forms.Label pkpkUnitsLabel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label dBmLabelValue;
        private System.Windows.Forms.Label rmsLabelValue;
        private System.Windows.Forms.Label pkpkLabelValue;
        private System.Windows.Forms.Label frequencyLabelValue;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox voltageTextBox;
        private System.Windows.Forms.Label voltageLabel;
        private System.Windows.Forms.ComboBox voltageComboBox;
        private System.Windows.Forms.Button defaultsButton;
    }
}

