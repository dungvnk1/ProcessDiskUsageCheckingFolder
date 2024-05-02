namespace CheckingDiskUsageFolderWinForm
{
    partial class DiskProcessCheckingTool
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DiskProcessCheckingTool));
            this.btnChooseFolder = new System.Windows.Forms.Button();
            this.txbFolderPath = new System.Windows.Forms.TextBox();
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
            this.btnSetCopy = new System.Windows.Forms.Button();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.txbSetCopy = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.txbReadData = new System.Windows.Forms.TextBox();
            this.txbSendData = new System.Windows.Forms.TextBox();
            this.btnSendData = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnChooseFolder
            // 
            this.btnChooseFolder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChooseFolder.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.btnChooseFolder.Location = new System.Drawing.Point(415, 43);
            this.btnChooseFolder.Name = "btnChooseFolder";
            this.btnChooseFolder.Size = new System.Drawing.Size(182, 30);
            this.btnChooseFolder.TabIndex = 0;
            this.btnChooseFolder.Text = "Choose Folder";
            this.btnChooseFolder.UseVisualStyleBackColor = true;
            this.btnChooseFolder.Click += new System.EventHandler(this.btnChooseFolder_Click);
            // 
            // txbFolderPath
            // 
            this.txbFolderPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbFolderPath.Location = new System.Drawing.Point(35, 43);
            this.txbFolderPath.Name = "txbFolderPath";
            this.txbFolderPath.Size = new System.Drawing.Size(374, 30);
            this.txbFolderPath.TabIndex = 1;
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.ForeColor = System.Drawing.Color.LimeGreen;
            this.btnStart.Location = new System.Drawing.Point(807, 561);
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
            this.btnResetCOMPort.Location = new System.Drawing.Point(277, 42);
            this.btnResetCOMPort.Margin = new System.Windows.Forms.Padding(4);
            this.btnResetCOMPort.Name = "btnResetCOMPort";
            this.btnResetCOMPort.Size = new System.Drawing.Size(40, 38);
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
            this.btnDisconnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.btnConnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.cbParity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbParity.FormattingEnabled = true;
            this.cbParity.Items.AddRange(new object[] {
            "None",
            "Odd",
            "Even",
            "Mark",
            "Space"});
            this.cbParity.Location = new System.Drawing.Point(149, 168);
            this.cbParity.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbParity.Name = "cbParity";
            this.cbParity.Size = new System.Drawing.Size(121, 28);
            this.cbParity.TabIndex = 9;
            this.cbParity.Text = "None";
            // 
            // cbDataBits
            // 
            this.cbDataBits.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDataBits.FormattingEnabled = true;
            this.cbDataBits.Location = new System.Drawing.Point(149, 127);
            this.cbDataBits.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbDataBits.Name = "cbDataBits";
            this.cbDataBits.Size = new System.Drawing.Size(121, 28);
            this.cbDataBits.TabIndex = 8;
            this.cbDataBits.Text = "8";
            // 
            // cbBaudRate
            // 
            this.cbBaudRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbBaudRate.FormattingEnabled = true;
            this.cbBaudRate.Items.AddRange(new object[] {
            "4800",
            "9600",
            "19200",
            "38400",
            "57600",
            "115200",
            "128000"});
            this.cbBaudRate.Location = new System.Drawing.Point(149, 88);
            this.cbBaudRate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbBaudRate.Name = "cbBaudRate";
            this.cbBaudRate.Size = new System.Drawing.Size(121, 28);
            this.cbBaudRate.TabIndex = 7;
            this.cbBaudRate.Text = "9600";
            // 
            // cbCOMPort
            // 
            this.cbCOMPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCOMPort.FormattingEnabled = true;
            this.cbCOMPort.Location = new System.Drawing.Point(149, 47);
            this.cbCOMPort.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbCOMPort.Name = "cbCOMPort";
            this.cbCOMPort.Size = new System.Drawing.Size(121, 28);
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
            this.panel1.Controls.Add(this.btnSetCopy);
            this.panel1.Controls.Add(this.btnChooseFolder);
            this.panel1.Controls.Add(this.txbFolderPath);
            this.panel1.Controls.Add(this.textBox5);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.txbSetCopy);
            this.panel1.Location = new System.Drawing.Point(392, 33);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(632, 387);
            this.panel1.TabIndex = 6;
            // 
            // btnSetCopy
            // 
            this.btnSetCopy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSetCopy.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.btnSetCopy.Location = new System.Drawing.Point(415, 119);
            this.btnSetCopy.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSetCopy.Name = "btnSetCopy";
            this.btnSetCopy.Size = new System.Drawing.Size(182, 30);
            this.btnSetCopy.TabIndex = 29;
            this.btnSetCopy.Text = "Set Copies Number";
            this.btnSetCopy.UseVisualStyleBackColor = true;
            this.btnSetCopy.Click += new System.EventHandler(this.btnSetCopy_Click);
            // 
            // textBox5
            // 
            this.textBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox5.ForeColor = System.Drawing.Color.OrangeRed;
            this.textBox5.Location = new System.Drawing.Point(35, 16);
            this.textBox5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.Size = new System.Drawing.Size(374, 22);
            this.textBox5.TabIndex = 27;
            this.textBox5.Text = "Choose a folder";
            this.textBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox2.ForeColor = System.Drawing.Color.SaddleBrown;
            this.textBox2.Location = new System.Drawing.Point(35, 88);
            this.textBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(374, 22);
            this.textBox2.TabIndex = 25;
            this.textBox2.Text = "Number of copies";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txbSetCopy
            // 
            this.txbSetCopy.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbSetCopy.Location = new System.Drawing.Point(35, 117);
            this.txbSetCopy.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbSetCopy.Multiline = true;
            this.txbSetCopy.Name = "txbSetCopy";
            this.txbSetCopy.Size = new System.Drawing.Size(374, 30);
            this.txbSetCopy.TabIndex = 24;
            this.txbSetCopy.Text = "1";
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
            // DiskProcessCheckingTool
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1061, 633);
            this.Controls.Add(this.btnSendData);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.txbSendData);
            this.Controls.Add(this.txbReadData);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox4);
            this.Name = "DiskProcessCheckingTool";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rotary 2040RP Controller";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Button btnChooseFolder;
        private System.Windows.Forms.TextBox txbFolderPath;
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
    }
}

