namespace CheckingDiskUsageFolderWinForm
{
    partial class Rotary2040RPController
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Rotary2040RPController));
            this.btnChooseFolder = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnResetCOMPort = new System.Windows.Forms.Button();
            this.pbSettings = new System.Windows.Forms.ProgressBar();
            this.btnDisconnect = new System.Windows.Forms.Button();
            this.btnConnect = new System.Windows.Forms.Button();
            this.cbParity = new System.Windows.Forms.ComboBox();
            this.cbDataBits = new System.Windows.Forms.ComboBox();
            this.cbBaudRate = new System.Windows.Forms.ComboBox();
            this.cbCOMPort = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnStockSetup = new System.Windows.Forms.Button();
            this.btnHoming = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnNewStock = new System.Windows.Forms.Button();
            this.btnResetLeft = new System.Windows.Forms.Button();
            this.btnResetRight = new System.Windows.Forms.Button();
            this.txbDeg = new System.Windows.Forms.TextBox();
            this.btnSetCopy = new System.Windows.Forms.Button();
            this.txbFolderPath = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.txbSetCopy = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.txbReadData = new System.Windows.Forms.TextBox();
            this.txbSendData = new System.Windows.Forms.TextBox();
            this.btnSendData = new System.Windows.Forms.Button();
            this.txbDisplayDiskUsage = new System.Windows.Forms.TextBox();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.txbDelayTime = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dtgvListFileName = new System.Windows.Forms.DataGridView();
            this.FileNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnMode = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvListFileName)).BeginInit();
            this.SuspendLayout();
            // 
            // btnChooseFolder
            // 
            this.btnChooseFolder.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChooseFolder.ForeColor = System.Drawing.Color.Crimson;
            this.btnChooseFolder.Location = new System.Drawing.Point(272, 40);
            this.btnChooseFolder.Name = "btnChooseFolder";
            this.btnChooseFolder.Size = new System.Drawing.Size(222, 42);
            this.btnChooseFolder.TabIndex = 0;
            this.btnChooseFolder.Text = "Folder";
            this.btnChooseFolder.UseVisualStyleBackColor = true;
            this.btnChooseFolder.Click += new System.EventHandler(this.btnChooseFolder_Click);
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.ForeColor = System.Drawing.Color.Green;
            this.btnStart.Location = new System.Drawing.Point(1102, 612);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(182, 45);
            this.btnStart.TabIndex = 2;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnResetCOMPort);
            this.groupBox1.Controls.Add(this.pbSettings);
            this.groupBox1.Controls.Add(this.btnDisconnect);
            this.groupBox1.Controls.Add(this.btnConnect);
            this.groupBox1.Controls.Add(this.cbParity);
            this.groupBox1.Controls.Add(this.cbDataBits);
            this.groupBox1.Controls.Add(this.cbBaudRate);
            this.groupBox1.Controls.Add(this.cbCOMPort);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(38, 33);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(324, 387);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Settings";
            // 
            // btnResetCOMPort
            // 
            this.btnResetCOMPort.Image = ((System.Drawing.Image)(resources.GetObject("btnResetCOMPort.Image")));
            this.btnResetCOMPort.Location = new System.Drawing.Point(277, 46);
            this.btnResetCOMPort.Margin = new System.Windows.Forms.Padding(4);
            this.btnResetCOMPort.Name = "btnResetCOMPort";
            this.btnResetCOMPort.Size = new System.Drawing.Size(40, 30);
            this.btnResetCOMPort.TabIndex = 14;
            this.btnResetCOMPort.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnResetCOMPort.UseVisualStyleBackColor = true;
            this.btnResetCOMPort.Click += new System.EventHandler(this.btnResetCOMPort_Click);
            // 
            // pbSettings
            // 
            this.pbSettings.Location = new System.Drawing.Point(71, 305);
            this.pbSettings.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbSettings.Name = "pbSettings";
            this.pbSettings.Size = new System.Drawing.Size(185, 46);
            this.pbSettings.TabIndex = 13;
            // 
            // btnDisconnect
            // 
            this.btnDisconnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDisconnect.Location = new System.Drawing.Point(168, 246);
            this.btnDisconnect.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDisconnect.Name = "btnDisconnect";
            this.btnDisconnect.Size = new System.Drawing.Size(132, 39);
            this.btnDisconnect.TabIndex = 12;
            this.btnDisconnect.Text = "Disconnect";
            this.btnDisconnect.UseVisualStyleBackColor = true;
            this.btnDisconnect.Click += new System.EventHandler(this.btnDisconnect_Click);
            // 
            // btnConnect
            // 
            this.btnConnect.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnConnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConnect.Location = new System.Drawing.Point(19, 246);
            this.btnConnect.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(132, 39);
            this.btnConnect.TabIndex = 11;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // cbParity
            // 
            this.cbParity.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbParity.FormattingEnabled = true;
            this.cbParity.Items.AddRange(new object[] {
            "None",
            "Odd",
            "Even",
            "Mark",
            "Space"});
            this.cbParity.Location = new System.Drawing.Point(149, 171);
            this.cbParity.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbParity.Name = "cbParity";
            this.cbParity.Size = new System.Drawing.Size(121, 24);
            this.cbParity.TabIndex = 9;
            this.cbParity.Text = "None";
            // 
            // cbDataBits
            // 
            this.cbDataBits.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDataBits.FormattingEnabled = true;
            this.cbDataBits.Location = new System.Drawing.Point(149, 130);
            this.cbDataBits.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbDataBits.Name = "cbDataBits";
            this.cbDataBits.Size = new System.Drawing.Size(121, 24);
            this.cbDataBits.TabIndex = 8;
            this.cbDataBits.Text = "8";
            // 
            // cbBaudRate
            // 
            this.cbBaudRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbBaudRate.FormattingEnabled = true;
            this.cbBaudRate.Items.AddRange(new object[] {
            "4800",
            "9600",
            "19200",
            "38400",
            "57600",
            "115200",
            "128000"});
            this.cbBaudRate.Location = new System.Drawing.Point(149, 91);
            this.cbBaudRate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbBaudRate.Name = "cbBaudRate";
            this.cbBaudRate.Size = new System.Drawing.Size(121, 24);
            this.cbBaudRate.TabIndex = 7;
            this.cbBaudRate.Text = "9600";
            // 
            // cbCOMPort
            // 
            this.cbCOMPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCOMPort.FormattingEnabled = true;
            this.cbCOMPort.Location = new System.Drawing.Point(149, 50);
            this.cbCOMPort.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbCOMPort.Name = "cbCOMPort";
            this.cbCOMPort.Size = new System.Drawing.Size(121, 24);
            this.cbCOMPort.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 174);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Parity";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Data Bits";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Baud Rate";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "COM Port";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnStockSetup);
            this.panel1.Controls.Add(this.btnHoming);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.btnNewStock);
            this.panel1.Controls.Add(this.btnResetLeft);
            this.panel1.Controls.Add(this.btnResetRight);
            this.panel1.Controls.Add(this.txbDeg);
            this.panel1.Controls.Add(this.btnSetCopy);
            this.panel1.Controls.Add(this.btnChooseFolder);
            this.panel1.Controls.Add(this.txbFolderPath);
            this.panel1.Controls.Add(this.textBox5);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.txbSetCopy);
            this.panel1.Location = new System.Drawing.Point(790, 33);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(543, 484);
            this.panel1.TabIndex = 6;
            // 
            // btnStockSetup
            // 
            this.btnStockSetup.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStockSetup.ForeColor = System.Drawing.Color.Crimson;
            this.btnStockSetup.Location = new System.Drawing.Point(158, 347);
            this.btnStockSetup.Name = "btnStockSetup";
            this.btnStockSetup.Size = new System.Drawing.Size(231, 40);
            this.btnStockSetup.TabIndex = 36;
            this.btnStockSetup.Text = "Stock Setup";
            this.btnStockSetup.UseVisualStyleBackColor = true;
            this.btnStockSetup.Click += new System.EventHandler(this.btnStockSetup_Click);
            // 
            // btnHoming
            // 
            this.btnHoming.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHoming.ForeColor = System.Drawing.Color.Crimson;
            this.btnHoming.Location = new System.Drawing.Point(158, 285);
            this.btnHoming.Name = "btnHoming";
            this.btnHoming.Size = new System.Drawing.Size(231, 40);
            this.btnHoming.TabIndex = 35;
            this.btnHoming.Text = "Homing";
            this.btnHoming.UseVisualStyleBackColor = true;
            this.btnHoming.Click += new System.EventHandler(this.btnHoming_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(125, 317);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(8, 8);
            this.button2.TabIndex = 34;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btnNewStock
            // 
            this.btnNewStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewStock.ForeColor = System.Drawing.Color.Crimson;
            this.btnNewStock.Location = new System.Drawing.Point(158, 223);
            this.btnNewStock.Name = "btnNewStock";
            this.btnNewStock.Size = new System.Drawing.Size(231, 40);
            this.btnNewStock.TabIndex = 33;
            this.btnNewStock.Text = "New Stock";
            this.btnNewStock.UseVisualStyleBackColor = true;
            this.btnNewStock.Click += new System.EventHandler(this.btnNewStock_Click);
            // 
            // btnResetLeft
            // 
            this.btnResetLeft.Image = ((System.Drawing.Image)(resources.GetObject("btnResetLeft.Image")));
            this.btnResetLeft.Location = new System.Drawing.Point(104, 173);
            this.btnResetLeft.Margin = new System.Windows.Forms.Padding(4);
            this.btnResetLeft.Name = "btnResetLeft";
            this.btnResetLeft.Size = new System.Drawing.Size(47, 38);
            this.btnResetLeft.TabIndex = 32;
            this.btnResetLeft.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnResetLeft.UseVisualStyleBackColor = true;
            this.btnResetLeft.Click += new System.EventHandler(this.btnResetLeft_Click);
            // 
            // btnResetRight
            // 
            this.btnResetRight.Image = ((System.Drawing.Image)(resources.GetObject("btnResetRight.Image")));
            this.btnResetRight.Location = new System.Drawing.Point(396, 174);
            this.btnResetRight.Margin = new System.Windows.Forms.Padding(4);
            this.btnResetRight.Name = "btnResetRight";
            this.btnResetRight.Size = new System.Drawing.Size(51, 36);
            this.btnResetRight.TabIndex = 31;
            this.btnResetRight.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnResetRight.UseVisualStyleBackColor = true;
            this.btnResetRight.Click += new System.EventHandler(this.btnResetRight_Click);
            // 
            // txbDeg
            // 
            this.txbDeg.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbDeg.Location = new System.Drawing.Point(158, 174);
            this.txbDeg.Name = "txbDeg";
            this.txbDeg.Size = new System.Drawing.Size(231, 34);
            this.txbDeg.TabIndex = 30;
            this.txbDeg.Text = "0.1";
            this.txbDeg.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnSetCopy
            // 
            this.btnSetCopy.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSetCopy.ForeColor = System.Drawing.Color.SaddleBrown;
            this.btnSetCopy.Location = new System.Drawing.Point(272, 121);
            this.btnSetCopy.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSetCopy.Name = "btnSetCopy";
            this.btnSetCopy.Size = new System.Drawing.Size(222, 40);
            this.btnSetCopy.TabIndex = 29;
            this.btnSetCopy.Text = "Set Copies Number";
            this.btnSetCopy.UseVisualStyleBackColor = true;
            this.btnSetCopy.Click += new System.EventHandler(this.btnSetCopy_Click);
            // 
            // txbFolderPath
            // 
            this.txbFolderPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbFolderPath.Location = new System.Drawing.Point(35, 43);
            this.txbFolderPath.Name = "txbFolderPath";
            this.txbFolderPath.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txbFolderPath.Size = new System.Drawing.Size(231, 32);
            this.txbFolderPath.TabIndex = 1;
            this.txbFolderPath.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox5
            // 
            this.textBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox5.ForeColor = System.Drawing.Color.OrangeRed;
            this.textBox5.Location = new System.Drawing.Point(35, 16);
            this.textBox5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.Size = new System.Drawing.Size(459, 22);
            this.textBox5.TabIndex = 27;
            this.textBox5.Text = "Choose a folder";
            this.textBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox2.ForeColor = System.Drawing.Color.SaddleBrown;
            this.textBox2.Location = new System.Drawing.Point(35, 94);
            this.textBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(459, 22);
            this.textBox2.TabIndex = 25;
            this.textBox2.Text = "Number of copies";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txbSetCopy
            // 
            this.txbSetCopy.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbSetCopy.Location = new System.Drawing.Point(35, 123);
            this.txbSetCopy.Multiline = true;
            this.txbSetCopy.Name = "txbSetCopy";
            this.txbSetCopy.Size = new System.Drawing.Size(231, 35);
            this.txbSetCopy.TabIndex = 24;
            this.txbSetCopy.Text = "10";
            this.txbSetCopy.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox4.Location = new System.Drawing.Point(206, 433);
            this.textBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(100, 22);
            this.textBox4.TabIndex = 23;
            this.textBox4.Text = "Read Data";
            this.textBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox3.Location = new System.Drawing.Point(38, 433);
            this.textBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(100, 22);
            this.textBox3.TabIndex = 22;
            this.textBox3.Text = "Send Data";
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txbReadData
            // 
            this.txbReadData.Location = new System.Drawing.Point(206, 473);
            this.txbReadData.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbReadData.Multiline = true;
            this.txbReadData.Name = "txbReadData";
            this.txbReadData.Size = new System.Drawing.Size(151, 73);
            this.txbReadData.TabIndex = 21;
            // 
            // txbSendData
            // 
            this.txbSendData.Location = new System.Drawing.Point(38, 473);
            this.txbSendData.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbSendData.Multiline = true;
            this.txbSendData.Name = "txbSendData";
            this.txbSendData.Size = new System.Drawing.Size(151, 73);
            this.txbSendData.TabIndex = 20;
            // 
            // btnSendData
            // 
            this.btnSendData.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSendData.Location = new System.Drawing.Point(38, 561);
            this.btnSendData.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSendData.Name = "btnSendData";
            this.btnSendData.Size = new System.Drawing.Size(115, 50);
            this.btnSendData.TabIndex = 31;
            this.btnSendData.Text = "Send";
            this.btnSendData.UseVisualStyleBackColor = true;
            this.btnSendData.Click += new System.EventHandler(this.btnSendData_Click);
            // 
            // txbDisplayDiskUsage
            // 
            this.txbDisplayDiskUsage.Location = new System.Drawing.Point(38, 635);
            this.txbDisplayDiskUsage.Name = "txbDisplayDiskUsage";
            this.txbDisplayDiskUsage.ReadOnly = true;
            this.txbDisplayDiskUsage.Size = new System.Drawing.Size(317, 22);
            this.txbDisplayDiskUsage.TabIndex = 32;
            this.txbDisplayDiskUsage.Text = " Disk usage of current file:";
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // txbDelayTime
            // 
            this.txbDelayTime.Location = new System.Drawing.Point(127, 672);
            this.txbDelayTime.Name = "txbDelayTime";
            this.txbDelayTime.Size = new System.Drawing.Size(228, 22);
            this.txbDelayTime.TabIndex = 33;
            this.txbDelayTime.Text = "5";
            this.txbDelayTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(38, 675);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 16);
            this.label5.TabIndex = 34;
            this.label5.Text = " Delay Time:";
            // 
            // dtgvListFileName
            // 
            this.dtgvListFileName.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvListFileName.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvListFileName.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FileNameColumn});
            this.dtgvListFileName.Location = new System.Drawing.Point(397, 32);
            this.dtgvListFileName.Name = "dtgvListFileName";
            this.dtgvListFileName.RowHeadersWidth = 51;
            this.dtgvListFileName.RowTemplate.Height = 24;
            this.dtgvListFileName.Size = new System.Drawing.Size(355, 485);
            this.dtgvListFileName.TabIndex = 35;
            // 
            // FileNameColumn
            // 
            this.FileNameColumn.HeaderText = "File Name";
            this.FileNameColumn.MinimumWidth = 6;
            this.FileNameColumn.Name = "FileNameColumn";
            // 
            // btnMode
            // 
            this.btnMode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMode.ForeColor = System.Drawing.Color.Red;
            this.btnMode.Location = new System.Drawing.Point(874, 612);
            this.btnMode.Name = "btnMode";
            this.btnMode.Size = new System.Drawing.Size(182, 45);
            this.btnMode.TabIndex = 36;
            this.btnMode.Text = "Mode Multi";
            this.btnMode.UseVisualStyleBackColor = true;
            this.btnMode.Click += new System.EventHandler(this.btnMode_Click);
            // 
            // Rotary2040RPController
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1369, 720);
            this.Controls.Add(this.btnMode);
            this.Controls.Add(this.dtgvListFileName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txbDelayTime);
            this.Controls.Add(this.txbDisplayDiskUsage);
            this.Controls.Add(this.btnSendData);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.txbSendData);
            this.Controls.Add(this.txbReadData);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox4);
            this.Name = "Rotary2040RPController";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rotary 2040RP Controller";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvListFileName)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnChooseFolder;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnResetCOMPort;
        private System.Windows.Forms.ProgressBar pbSettings;
        private System.Windows.Forms.Button btnDisconnect;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.ComboBox cbParity;
        private System.Windows.Forms.ComboBox cbDataBits;
        private System.Windows.Forms.ComboBox cbBaudRate;
        private System.Windows.Forms.ComboBox cbCOMPort;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSetCopy;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox txbSetCopy;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox txbReadData;
        private System.Windows.Forms.TextBox txbSendData;
        private System.Windows.Forms.Button btnSendData;
        private System.Windows.Forms.TextBox txbDisplayDiskUsage;
        private System.Windows.Forms.TextBox txbDeg;
        private System.Windows.Forms.Button btnNewStock;
        private System.Windows.Forms.Button btnResetLeft;
        private System.Windows.Forms.Button btnResetRight;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.TextBox txbDelayTime;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txbFolderPath;
        private System.Windows.Forms.DataGridView dtgvListFileName;
        private System.Windows.Forms.DataGridViewTextBoxColumn FileNameColumn;
        private System.Windows.Forms.Button btnStockSetup;
        private System.Windows.Forms.Button btnHoming;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnMode;
    }
}

