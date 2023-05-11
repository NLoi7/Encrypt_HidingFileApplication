namespace A1d2
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.openCoverFileDialog = new System.Windows.Forms.OpenFileDialog();
			this.openMessageFileDialog = new System.Windows.Forms.OpenFileDialog();
			this.saveStegoFileDialog = new System.Windows.Forms.SaveFileDialog();
			this.statusStrip1 = new System.Windows.Forms.StatusStrip();
			this.lblStatus = new System.Windows.Forms.ToolStripStatusLabel();
			this.openStegoFileDialog = new System.Windows.Forms.OpenFileDialog();
			this.saveExtractedFileDialog = new System.Windows.Forms.SaveFileDialog();
			this.tabRecover = new System.Windows.Forms.TabPage();
			this.groupBoxStego = new System.Windows.Forms.GroupBox();
			this.btnBrowseStego = new System.Windows.Forms.Button();
			this.lblFileNameStego = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.lblStegoFileSize = new System.Windows.Forms.Label();
			this.lblStegoFileType = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.tbInputKey = new System.Windows.Forms.TextBox();
			this.cbOpenRecoveredFile = new System.Windows.Forms.CheckBox();
			this.btnDecrypt = new System.Windows.Forms.Button();
			this.tabHide = new System.Windows.Forms.TabPage();
			this.groupBoxCover = new System.Windows.Forms.GroupBox();
			this.btnBrowseCover = new System.Windows.Forms.Button();
			this.lblFileNameCover = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.lblCoverFileSize = new System.Windows.Forms.Label();
			this.lblCoverFileType = new System.Windows.Forms.Label();
			this.groupBoxMessage = new System.Windows.Forms.GroupBox();
			this.btnBrowseMessage = new System.Windows.Forms.Button();
			this.lblFileNameMessage = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.lblMessageFileSize = new System.Windows.Forms.Label();
			this.lblMessageFileType = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.tbGeneratedKey = new System.Windows.Forms.TextBox();
			this.btnEncrypt = new System.Windows.Forms.Button();
			this.cbOpenStegoFile = new System.Windows.Forms.CheckBox();
			this.tabMain = new System.Windows.Forms.TabControl();
			this.statusStrip1.SuspendLayout();
			this.tabRecover.SuspendLayout();
			this.groupBoxStego.SuspendLayout();
			this.tabHide.SuspendLayout();
			this.groupBoxCover.SuspendLayout();
			this.groupBoxMessage.SuspendLayout();
			this.tabMain.SuspendLayout();
			this.SuspendLayout();
			// 
			// openCoverFileDialog
			// 
			this.openCoverFileDialog.InitialDirectory = "Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)";
			this.openCoverFileDialog.RestoreDirectory = true;
			this.openCoverFileDialog.Title = "Select Cover File";
			// 
			// openMessageFileDialog
			// 
			this.openMessageFileDialog.InitialDirectory = "Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)";
			this.openMessageFileDialog.RestoreDirectory = true;
			this.openMessageFileDialog.Title = "Select File to Hide";
			// 
			// saveStegoFileDialog
			// 
			this.saveStegoFileDialog.InitialDirectory = "Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)";
			this.saveStegoFileDialog.RestoreDirectory = true;
			this.saveStegoFileDialog.Title = "Save Stego File";
			// 
			// statusStrip1
			// 
			this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStatus});
			this.statusStrip1.Location = new System.Drawing.Point(0, 320);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
			this.statusStrip1.Size = new System.Drawing.Size(832, 26);
			this.statusStrip1.TabIndex = 1;
			this.statusStrip1.Text = "statusStrip1";
			this.statusStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.statusStrip1_ItemClicked);
			// 
			// lblStatus
			// 
			this.lblStatus.BackColor = System.Drawing.Color.Gold;
			this.lblStatus.Name = "lblStatus";
			this.lblStatus.Size = new System.Drawing.Size(812, 20);
			this.lblStatus.Spring = true;
			this.lblStatus.Text = "Ready";
			this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// openStegoFileDialog
			// 
			this.openStegoFileDialog.RestoreDirectory = true;
			this.openStegoFileDialog.Title = "Select Stego File";
			// 
			// saveExtractedFileDialog
			// 
			this.saveExtractedFileDialog.RestoreDirectory = true;
			// 
			// tabRecover
			// 
			this.tabRecover.Controls.Add(this.groupBoxStego);
			this.tabRecover.Location = new System.Drawing.Point(4, 28);
			this.tabRecover.Margin = new System.Windows.Forms.Padding(4);
			this.tabRecover.Name = "tabRecover";
			this.tabRecover.Padding = new System.Windows.Forms.Padding(4);
			this.tabRecover.Size = new System.Drawing.Size(824, 281);
			this.tabRecover.TabIndex = 1;
			this.tabRecover.Text = "Recover";
			this.tabRecover.UseVisualStyleBackColor = true;
			// 
			// groupBoxStego
			// 
			this.groupBoxStego.Controls.Add(this.btnDecrypt);
			this.groupBoxStego.Controls.Add(this.cbOpenRecoveredFile);
			this.groupBoxStego.Controls.Add(this.tbInputKey);
			this.groupBoxStego.Controls.Add(this.label9);
			this.groupBoxStego.Controls.Add(this.lblStegoFileType);
			this.groupBoxStego.Controls.Add(this.lblStegoFileSize);
			this.groupBoxStego.Controls.Add(this.label8);
			this.groupBoxStego.Controls.Add(this.label7);
			this.groupBoxStego.Controls.Add(this.lblFileNameStego);
			this.groupBoxStego.Controls.Add(this.btnBrowseStego);
			this.groupBoxStego.Location = new System.Drawing.Point(11, 7);
			this.groupBoxStego.Margin = new System.Windows.Forms.Padding(4);
			this.groupBoxStego.Name = "groupBoxStego";
			this.groupBoxStego.Padding = new System.Windows.Forms.Padding(4);
			this.groupBoxStego.Size = new System.Drawing.Size(803, 250);
			this.groupBoxStego.TabIndex = 0;
			this.groupBoxStego.TabStop = false;
			this.groupBoxStego.Text = "Stego file";
			// 
			// btnBrowseStego
			// 
			this.btnBrowseStego.Location = new System.Drawing.Point(8, 23);
			this.btnBrowseStego.Margin = new System.Windows.Forms.Padding(4);
			this.btnBrowseStego.Name = "btnBrowseStego";
			this.btnBrowseStego.Size = new System.Drawing.Size(100, 28);
			this.btnBrowseStego.TabIndex = 0;
			this.btnBrowseStego.Text = "Browse";
			this.btnBrowseStego.UseVisualStyleBackColor = true;
			this.btnBrowseStego.Click += new System.EventHandler(this.btnBrowseStego_Click);
			// 
			// lblFileNameStego
			// 
			this.lblFileNameStego.AutoSize = true;
			this.lblFileNameStego.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblFileNameStego.Location = new System.Drawing.Point(4, 74);
			this.lblFileNameStego.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblFileNameStego.Name = "lblFileNameStego";
			this.lblFileNameStego.Size = new System.Drawing.Size(112, 17);
			this.lblFileNameStego.TabIndex = 1;
			this.lblFileNameStego.Text = "No file chosen";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(4, 102);
			this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(34, 16);
			this.label7.TabIndex = 2;
			this.label7.Text = "size:";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(4, 130);
			this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(36, 16);
			this.label8.TabIndex = 3;
			this.label8.Text = "type:";
			// 
			// lblStegoFileSize
			// 
			this.lblStegoFileSize.AutoSize = true;
			this.lblStegoFileSize.Location = new System.Drawing.Point(61, 102);
			this.lblStegoFileSize.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblStegoFileSize.Name = "lblStegoFileSize";
			this.lblStegoFileSize.Size = new System.Drawing.Size(11, 16);
			this.lblStegoFileSize.TabIndex = 4;
			this.lblStegoFileSize.Text = "-";
			// 
			// lblStegoFileType
			// 
			this.lblStegoFileType.AutoSize = true;
			this.lblStegoFileType.Location = new System.Drawing.Point(61, 130);
			this.lblStegoFileType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblStegoFileType.Name = "lblStegoFileType";
			this.lblStegoFileType.Size = new System.Drawing.Size(11, 16);
			this.lblStegoFileType.TabIndex = 5;
			this.lblStegoFileType.Text = "-";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(4, 165);
			this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(83, 16);
			this.label9.TabIndex = 6;
			this.label9.Text = "Passphrase:";
			// 
			// tbInputKey
			// 
			this.tbInputKey.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbInputKey.Location = new System.Drawing.Point(91, 161);
			this.tbInputKey.Margin = new System.Windows.Forms.Padding(4);
			this.tbInputKey.Name = "tbInputKey";
			this.tbInputKey.PasswordChar = '*';
			this.tbInputKey.Size = new System.Drawing.Size(585, 24);
			this.tbInputKey.TabIndex = 1;
			// 
			// cbOpenRecoveredFile
			// 
			this.cbOpenRecoveredFile.AutoSize = true;
			this.cbOpenRecoveredFile.Location = new System.Drawing.Point(8, 222);
			this.cbOpenRecoveredFile.Margin = new System.Windows.Forms.Padding(4);
			this.cbOpenRecoveredFile.Name = "cbOpenRecoveredFile";
			this.cbOpenRecoveredFile.Size = new System.Drawing.Size(252, 20);
			this.cbOpenRecoveredFile.TabIndex = 7;
			this.cbOpenRecoveredFile.Text = "&Open extracted hidden file when done";
			this.cbOpenRecoveredFile.UseVisualStyleBackColor = true;
			// 
			// btnDecrypt
			// 
			this.btnDecrypt.Location = new System.Drawing.Point(507, 199);
			this.btnDecrypt.Margin = new System.Windows.Forms.Padding(4);
			this.btnDecrypt.Name = "btnDecrypt";
			this.btnDecrypt.Size = new System.Drawing.Size(171, 43);
			this.btnDecrypt.TabIndex = 8;
			this.btnDecrypt.Text = "&RECOVER";
			this.btnDecrypt.UseVisualStyleBackColor = true;
			this.btnDecrypt.Click += new System.EventHandler(this.btnDecrypt_Click);
			// 
			// tabHide
			// 
			this.tabHide.Controls.Add(this.cbOpenStegoFile);
			this.tabHide.Controls.Add(this.btnEncrypt);
			this.tabHide.Controls.Add(this.tbGeneratedKey);
			this.tabHide.Controls.Add(this.label6);
			this.tabHide.Controls.Add(this.groupBoxMessage);
			this.tabHide.Controls.Add(this.groupBoxCover);
			this.tabHide.Location = new System.Drawing.Point(4, 28);
			this.tabHide.Margin = new System.Windows.Forms.Padding(4);
			this.tabHide.Name = "tabHide";
			this.tabHide.Padding = new System.Windows.Forms.Padding(4);
			this.tabHide.Size = new System.Drawing.Size(824, 281);
			this.tabHide.TabIndex = 0;
			this.tabHide.Text = "Hide";
			this.tabHide.UseVisualStyleBackColor = true;
			// 
			// groupBoxCover
			// 
			this.groupBoxCover.Controls.Add(this.lblCoverFileType);
			this.groupBoxCover.Controls.Add(this.lblCoverFileSize);
			this.groupBoxCover.Controls.Add(this.label3);
			this.groupBoxCover.Controls.Add(this.label2);
			this.groupBoxCover.Controls.Add(this.lblFileNameCover);
			this.groupBoxCover.Controls.Add(this.btnBrowseCover);
			this.groupBoxCover.Location = new System.Drawing.Point(11, 7);
			this.groupBoxCover.Margin = new System.Windows.Forms.Padding(4);
			this.groupBoxCover.Name = "groupBoxCover";
			this.groupBoxCover.Padding = new System.Windows.Forms.Padding(4);
			this.groupBoxCover.Size = new System.Drawing.Size(373, 176);
			this.groupBoxCover.TabIndex = 0;
			this.groupBoxCover.TabStop = false;
			this.groupBoxCover.Text = "Cover file";
			// 
			// btnBrowseCover
			// 
			this.btnBrowseCover.Location = new System.Drawing.Point(8, 23);
			this.btnBrowseCover.Margin = new System.Windows.Forms.Padding(4);
			this.btnBrowseCover.Name = "btnBrowseCover";
			this.btnBrowseCover.Size = new System.Drawing.Size(100, 28);
			this.btnBrowseCover.TabIndex = 1;
			this.btnBrowseCover.Text = "Browse";
			this.btnBrowseCover.UseVisualStyleBackColor = true;
			this.btnBrowseCover.Click += new System.EventHandler(this.btnBrowseCover_Click);
			// 
			// lblFileNameCover
			// 
			this.lblFileNameCover.AutoSize = true;
			this.lblFileNameCover.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblFileNameCover.Location = new System.Drawing.Point(4, 74);
			this.lblFileNameCover.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblFileNameCover.Name = "lblFileNameCover";
			this.lblFileNameCover.Size = new System.Drawing.Size(112, 17);
			this.lblFileNameCover.TabIndex = 2;
			this.lblFileNameCover.Text = "No file chosen";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(4, 102);
			this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(34, 16);
			this.label2.TabIndex = 3;
			this.label2.Text = "size:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(4, 130);
			this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(36, 16);
			this.label3.TabIndex = 4;
			this.label3.Text = "type:";
			// 
			// lblCoverFileSize
			// 
			this.lblCoverFileSize.AutoSize = true;
			this.lblCoverFileSize.Location = new System.Drawing.Point(65, 102);
			this.lblCoverFileSize.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblCoverFileSize.Name = "lblCoverFileSize";
			this.lblCoverFileSize.Size = new System.Drawing.Size(11, 16);
			this.lblCoverFileSize.TabIndex = 5;
			this.lblCoverFileSize.Text = "-";
			// 
			// lblCoverFileType
			// 
			this.lblCoverFileType.AutoSize = true;
			this.lblCoverFileType.Location = new System.Drawing.Point(65, 130);
			this.lblCoverFileType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblCoverFileType.Name = "lblCoverFileType";
			this.lblCoverFileType.Size = new System.Drawing.Size(11, 16);
			this.lblCoverFileType.TabIndex = 6;
			this.lblCoverFileType.Text = "-";
			// 
			// groupBoxMessage
			// 
			this.groupBoxMessage.Controls.Add(this.lblMessageFileType);
			this.groupBoxMessage.Controls.Add(this.lblMessageFileSize);
			this.groupBoxMessage.Controls.Add(this.label5);
			this.groupBoxMessage.Controls.Add(this.label4);
			this.groupBoxMessage.Controls.Add(this.lblFileNameMessage);
			this.groupBoxMessage.Controls.Add(this.btnBrowseMessage);
			this.groupBoxMessage.Location = new System.Drawing.Point(392, 7);
			this.groupBoxMessage.Margin = new System.Windows.Forms.Padding(4);
			this.groupBoxMessage.Name = "groupBoxMessage";
			this.groupBoxMessage.Padding = new System.Windows.Forms.Padding(4);
			this.groupBoxMessage.Size = new System.Drawing.Size(400, 176);
			this.groupBoxMessage.TabIndex = 1;
			this.groupBoxMessage.TabStop = false;
			this.groupBoxMessage.Text = "File to hide";
			this.groupBoxMessage.Enter += new System.EventHandler(this.groupBoxMessage_Enter);
			// 
			// btnBrowseMessage
			// 
			this.btnBrowseMessage.Location = new System.Drawing.Point(8, 23);
			this.btnBrowseMessage.Margin = new System.Windows.Forms.Padding(4);
			this.btnBrowseMessage.Name = "btnBrowseMessage";
			this.btnBrowseMessage.Size = new System.Drawing.Size(100, 28);
			this.btnBrowseMessage.TabIndex = 0;
			this.btnBrowseMessage.Text = "Browse";
			this.btnBrowseMessage.UseVisualStyleBackColor = true;
			this.btnBrowseMessage.Click += new System.EventHandler(this.btnBrowseMessage_Click);
			// 
			// lblFileNameMessage
			// 
			this.lblFileNameMessage.AutoSize = true;
			this.lblFileNameMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblFileNameMessage.Location = new System.Drawing.Point(4, 74);
			this.lblFileNameMessage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblFileNameMessage.Name = "lblFileNameMessage";
			this.lblFileNameMessage.Size = new System.Drawing.Size(112, 17);
			this.lblFileNameMessage.TabIndex = 1;
			this.lblFileNameMessage.Text = "No file chosen";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(4, 102);
			this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(34, 16);
			this.label4.TabIndex = 2;
			this.label4.Text = "size:";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(4, 130);
			this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(36, 16);
			this.label5.TabIndex = 3;
			this.label5.Text = "type:";
			// 
			// lblMessageFileSize
			// 
			this.lblMessageFileSize.AutoSize = true;
			this.lblMessageFileSize.Location = new System.Drawing.Point(71, 102);
			this.lblMessageFileSize.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblMessageFileSize.Name = "lblMessageFileSize";
			this.lblMessageFileSize.Size = new System.Drawing.Size(11, 16);
			this.lblMessageFileSize.TabIndex = 4;
			this.lblMessageFileSize.Text = "-";
			// 
			// lblMessageFileType
			// 
			this.lblMessageFileType.AutoSize = true;
			this.lblMessageFileType.Location = new System.Drawing.Point(71, 130);
			this.lblMessageFileType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblMessageFileType.Name = "lblMessageFileType";
			this.lblMessageFileType.Size = new System.Drawing.Size(11, 16);
			this.lblMessageFileType.TabIndex = 5;
			this.lblMessageFileType.Text = "-";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(7, 198);
			this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(83, 16);
			this.label6.TabIndex = 2;
			this.label6.Text = "Passphrase:";
			// 
			// tbGeneratedKey
			// 
			this.tbGeneratedKey.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbGeneratedKey.Location = new System.Drawing.Point(97, 194);
			this.tbGeneratedKey.Margin = new System.Windows.Forms.Padding(4);
			this.tbGeneratedKey.MaxLength = 64;
			this.tbGeneratedKey.Name = "tbGeneratedKey";
			this.tbGeneratedKey.PasswordChar = '*';
			this.tbGeneratedKey.Size = new System.Drawing.Size(585, 24);
			this.tbGeneratedKey.TabIndex = 3;
			this.tbGeneratedKey.TextChanged += new System.EventHandler(this.tbGeneratedKey_TextChanged);
			// 
			// btnEncrypt
			// 
			this.btnEncrypt.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.btnEncrypt.BackColor = System.Drawing.Color.Gainsboro;
			this.btnEncrypt.Location = new System.Drawing.Point(304, 226);
			this.btnEncrypt.Margin = new System.Windows.Forms.Padding(4);
			this.btnEncrypt.Name = "btnEncrypt";
			this.btnEncrypt.Size = new System.Drawing.Size(171, 43);
			this.btnEncrypt.TabIndex = 5;
			this.btnEncrypt.Text = "&HIDE";
			this.btnEncrypt.UseVisualStyleBackColor = false;
			this.btnEncrypt.Click += new System.EventHandler(this.btnEncrypt_Click);
			// 
			// cbOpenStegoFile
			// 
			this.cbOpenStegoFile.AutoSize = true;
			this.cbOpenStegoFile.Checked = true;
			this.cbOpenStegoFile.CheckState = System.Windows.Forms.CheckState.Checked;
			this.cbOpenStegoFile.Location = new System.Drawing.Point(11, 239);
			this.cbOpenStegoFile.Margin = new System.Windows.Forms.Padding(4);
			this.cbOpenStegoFile.Name = "cbOpenStegoFile";
			this.cbOpenStegoFile.Size = new System.Drawing.Size(190, 20);
			this.cbOpenStegoFile.TabIndex = 6;
			this.cbOpenStegoFile.Text = "&Open Stego-file when done";
			this.cbOpenStegoFile.UseVisualStyleBackColor = true;
			// 
			// tabMain
			// 
			this.tabMain.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
			this.tabMain.Controls.Add(this.tabHide);
			this.tabMain.Controls.Add(this.tabRecover);
			this.tabMain.Location = new System.Drawing.Point(0, 0);
			this.tabMain.Margin = new System.Windows.Forms.Padding(4);
			this.tabMain.Name = "tabMain";
			this.tabMain.SelectedIndex = 0;
			this.tabMain.Size = new System.Drawing.Size(832, 313);
			this.tabMain.TabIndex = 0;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Yellow;
			this.ClientSize = new System.Drawing.Size(832, 346);
			this.Controls.Add(this.statusStrip1);
			this.Controls.Add(this.tabMain);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(4);
			this.MaximizeBox = false;
			this.Name = "Form1";
			this.Text = "Project NHOM10";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.statusStrip1.ResumeLayout(false);
			this.statusStrip1.PerformLayout();
			this.tabRecover.ResumeLayout(false);
			this.groupBoxStego.ResumeLayout(false);
			this.groupBoxStego.PerformLayout();
			this.tabHide.ResumeLayout(false);
			this.tabHide.PerformLayout();
			this.groupBoxCover.ResumeLayout(false);
			this.groupBoxCover.PerformLayout();
			this.groupBoxMessage.ResumeLayout(false);
			this.groupBoxMessage.PerformLayout();
			this.tabMain.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog openCoverFileDialog;
        private System.Windows.Forms.OpenFileDialog openMessageFileDialog;
        private System.Windows.Forms.SaveFileDialog saveStegoFileDialog;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblStatus;
        private System.Windows.Forms.OpenFileDialog openStegoFileDialog;
        private System.Windows.Forms.SaveFileDialog saveExtractedFileDialog;
		private System.Windows.Forms.TabPage tabRecover;
		private System.Windows.Forms.GroupBox groupBoxStego;
		private System.Windows.Forms.Button btnDecrypt;
		private System.Windows.Forms.CheckBox cbOpenRecoveredFile;
		private System.Windows.Forms.TextBox tbInputKey;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label lblStegoFileType;
		private System.Windows.Forms.Label lblStegoFileSize;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label lblFileNameStego;
		private System.Windows.Forms.Button btnBrowseStego;
		private System.Windows.Forms.TabPage tabHide;
		private System.Windows.Forms.CheckBox cbOpenStegoFile;
		private System.Windows.Forms.Button btnEncrypt;
		private System.Windows.Forms.TextBox tbGeneratedKey;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.GroupBox groupBoxMessage;
		private System.Windows.Forms.Label lblMessageFileType;
		private System.Windows.Forms.Label lblMessageFileSize;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label lblFileNameMessage;
		private System.Windows.Forms.Button btnBrowseMessage;
		private System.Windows.Forms.GroupBox groupBoxCover;
		private System.Windows.Forms.Label lblCoverFileType;
		private System.Windows.Forms.Label lblCoverFileSize;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label lblFileNameCover;
		private System.Windows.Forms.Button btnBrowseCover;
		private System.Windows.Forms.TabControl tabMain;
	}
}

