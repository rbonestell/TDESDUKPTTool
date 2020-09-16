namespace TDESDUKPTTool
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.txtBDK = new System.Windows.Forms.TextBox();
            this.lblBDK = new System.Windows.Forms.Label();
            this.lblKSN = new System.Windows.Forms.Label();
            this.txtKSN = new System.Windows.Forms.TextBox();
            this.btnANSIKey = new System.Windows.Forms.Button();
            this.btnANSIKSN = new System.Windows.Forms.Button();
            this.txtEncryptedData = new System.Windows.Forms.TextBox();
            this.lblEncryptedData = new System.Windows.Forms.Label();
            this.btnEncrypt = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDecryptedData = new System.Windows.Forms.TextBox();
            this.lnkWikipediaDUKPT = new System.Windows.Forms.LinkLabel();
            this.msMainMenu = new System.Windows.Forms.MenuStrip();
            this.tsmiFile = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiExit = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiMore = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiBDKKeyPartTool = new System.Windows.Forms.ToolStripMenuItem();
            this.btnDecrypt = new System.Windows.Forms.Button();
            this.rbPINVariant = new System.Windows.Forms.RadioButton();
            this.rbDataVariant = new System.Windows.Forms.RadioButton();
            this.gbEncryptedDataVariant = new System.Windows.Forms.GroupBox();
            this.lnkKeyVariants = new System.Windows.Forms.LinkLabel();
            this.llWarning = new System.Windows.Forms.LinkLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.msMainMenu.SuspendLayout();
            this.gbEncryptedDataVariant.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBDK
            // 
            this.txtBDK.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtBDK.Font = new System.Drawing.Font("Courier New", 8F);
            this.txtBDK.Location = new System.Drawing.Point(12, 45);
            this.txtBDK.Name = "txtBDK";
            this.txtBDK.Size = new System.Drawing.Size(440, 20);
            this.txtBDK.TabIndex = 0;
            this.txtBDK.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBDK_KeyPress);
            // 
            // lblBDK
            // 
            this.lblBDK.AutoSize = true;
            this.lblBDK.Location = new System.Drawing.Point(12, 29);
            this.lblBDK.Name = "lblBDK";
            this.lblBDK.Size = new System.Drawing.Size(103, 13);
            this.lblBDK.TabIndex = 1;
            this.lblBDK.Text = "Base Derivation Key";
            // 
            // lblKSN
            // 
            this.lblKSN.AutoSize = true;
            this.lblKSN.Location = new System.Drawing.Point(9, 68);
            this.lblKSN.Name = "lblKSN";
            this.lblKSN.Size = new System.Drawing.Size(94, 13);
            this.lblKSN.TabIndex = 3;
            this.lblKSN.Text = "Key Serial Number";
            // 
            // txtKSN
            // 
            this.txtKSN.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtKSN.Font = new System.Drawing.Font("Courier New", 8F);
            this.txtKSN.Location = new System.Drawing.Point(12, 84);
            this.txtKSN.Name = "txtKSN";
            this.txtKSN.Size = new System.Drawing.Size(440, 20);
            this.txtKSN.TabIndex = 2;
            this.txtKSN.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtKSN_KeyPress);
            // 
            // btnANSIKey
            // 
            this.btnANSIKey.Location = new System.Drawing.Point(458, 44);
            this.btnANSIKey.Name = "btnANSIKey";
            this.btnANSIKey.Size = new System.Drawing.Size(75, 21);
            this.btnANSIKey.TabIndex = 4;
            this.btnANSIKey.Text = "ANSI BDK";
            this.btnANSIKey.UseVisualStyleBackColor = true;
            this.btnANSIKey.Click += new System.EventHandler(this.btnANSIKey_Click);
            // 
            // btnANSIKSN
            // 
            this.btnANSIKSN.Location = new System.Drawing.Point(458, 83);
            this.btnANSIKSN.Name = "btnANSIKSN";
            this.btnANSIKSN.Size = new System.Drawing.Size(75, 21);
            this.btnANSIKSN.TabIndex = 5;
            this.btnANSIKSN.Text = "ANSI KSN";
            this.btnANSIKSN.UseVisualStyleBackColor = true;
            this.btnANSIKSN.Click += new System.EventHandler(this.btnANSIKSN_Click);
            // 
            // txtEncryptedData
            // 
            this.txtEncryptedData.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtEncryptedData.Font = new System.Drawing.Font("Courier New", 8F);
            this.txtEncryptedData.Location = new System.Drawing.Point(12, 126);
            this.txtEncryptedData.Multiline = true;
            this.txtEncryptedData.Name = "txtEncryptedData";
            this.txtEncryptedData.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtEncryptedData.Size = new System.Drawing.Size(521, 98);
            this.txtEncryptedData.TabIndex = 6;
            this.txtEncryptedData.WordWrap = false;
            this.txtEncryptedData.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEncryptedData_KeyPress);
            // 
            // lblEncryptedData
            // 
            this.lblEncryptedData.AutoSize = true;
            this.lblEncryptedData.Location = new System.Drawing.Point(9, 110);
            this.lblEncryptedData.Name = "lblEncryptedData";
            this.lblEncryptedData.Size = new System.Drawing.Size(151, 13);
            this.lblEncryptedData.TabIndex = 7;
            this.lblEncryptedData.Text = "Encrypted Data (Hexadecimal)";
            // 
            // btnEncrypt
            // 
            this.btnEncrypt.Location = new System.Drawing.Point(278, 283);
            this.btnEncrypt.Name = "btnEncrypt";
            this.btnEncrypt.Size = new System.Drawing.Size(255, 27);
            this.btnEncrypt.TabIndex = 8;
            this.btnEncrypt.Text = "▲ Encrypt";
            this.btnEncrypt.UseVisualStyleBackColor = true;
            this.btnEncrypt.Click += new System.EventHandler(this.btnEncrypt_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 314);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Decrypted Data (ASCII)";
            // 
            // txtDecryptedData
            // 
            this.txtDecryptedData.Font = new System.Drawing.Font("Courier New", 8F);
            this.txtDecryptedData.Location = new System.Drawing.Point(12, 330);
            this.txtDecryptedData.Multiline = true;
            this.txtDecryptedData.Name = "txtDecryptedData";
            this.txtDecryptedData.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtDecryptedData.Size = new System.Drawing.Size(521, 98);
            this.txtDecryptedData.TabIndex = 10;
            this.txtDecryptedData.WordWrap = false;
            // 
            // lnkWikipediaDUKPT
            // 
            this.lnkWikipediaDUKPT.AutoSize = true;
            this.lnkWikipediaDUKPT.Location = new System.Drawing.Point(376, 440);
            this.lnkWikipediaDUKPT.Name = "lnkWikipediaDUKPT";
            this.lnkWikipediaDUKPT.Size = new System.Drawing.Size(157, 13);
            this.lnkWikipediaDUKPT.TabIndex = 12;
            this.lnkWikipediaDUKPT.TabStop = true;
            this.lnkWikipediaDUKPT.Text = "More about DUKPT (Wikipedia)";
            this.lnkWikipediaDUKPT.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.lnkWikipediaDUKPT.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkWikipediaDUKPT_LinkClicked);
            // 
            // msMainMenu
            // 
            this.msMainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiFile,
            this.tsmiMore});
            this.msMainMenu.Location = new System.Drawing.Point(0, 0);
            this.msMainMenu.Name = "msMainMenu";
            this.msMainMenu.Size = new System.Drawing.Size(545, 24);
            this.msMainMenu.TabIndex = 13;
            this.msMainMenu.Text = "menuStrip1";
            // 
            // tsmiFile
            // 
            this.tsmiFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiExit});
            this.tsmiFile.Name = "tsmiFile";
            this.tsmiFile.Size = new System.Drawing.Size(37, 20);
            this.tsmiFile.Text = "&File";
            // 
            // tsmiExit
            // 
            this.tsmiExit.Name = "tsmiExit";
            this.tsmiExit.Size = new System.Drawing.Size(93, 22);
            this.tsmiExit.Text = "E&xit";
            this.tsmiExit.Click += new System.EventHandler(this.tsmiExit_Click);
            // 
            // tsmiMore
            // 
            this.tsmiMore.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiBDKKeyPartTool});
            this.tsmiMore.Name = "tsmiMore";
            this.tsmiMore.Size = new System.Drawing.Size(47, 20);
            this.tsmiMore.Text = "&More";
            // 
            // tsmiBDKKeyPartTool
            // 
            this.tsmiBDKKeyPartTool.Name = "tsmiBDKKeyPartTool";
            this.tsmiBDKKeyPartTool.Size = new System.Drawing.Size(142, 22);
            this.tsmiBDKKeyPartTool.Text = "&Key Part Tool";
            this.tsmiBDKKeyPartTool.Click += new System.EventHandler(this.tsmiBDKKeyPartTool_Click);
            // 
            // btnDecrypt
            // 
            this.btnDecrypt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnDecrypt.Location = new System.Drawing.Point(12, 283);
            this.btnDecrypt.Name = "btnDecrypt";
            this.btnDecrypt.Size = new System.Drawing.Size(255, 27);
            this.btnDecrypt.TabIndex = 9;
            this.btnDecrypt.Text = "Decrypt ▼";
            this.btnDecrypt.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDecrypt.UseVisualStyleBackColor = true;
            this.btnDecrypt.Click += new System.EventHandler(this.btnDecrypt_Click);
            // 
            // rbPINVariant
            // 
            this.rbPINVariant.AutoSize = true;
            this.rbPINVariant.Location = new System.Drawing.Point(232, 18);
            this.rbPINVariant.Name = "rbPINVariant";
            this.rbPINVariant.Size = new System.Drawing.Size(79, 17);
            this.rbPINVariant.TabIndex = 14;
            this.rbPINVariant.Text = "PIN Variant";
            this.rbPINVariant.UseVisualStyleBackColor = true;
            // 
            // rbDataVariant
            // 
            this.rbDataVariant.AutoSize = true;
            this.rbDataVariant.Checked = true;
            this.rbDataVariant.Location = new System.Drawing.Point(83, 20);
            this.rbDataVariant.Name = "rbDataVariant";
            this.rbDataVariant.Size = new System.Drawing.Size(84, 17);
            this.rbDataVariant.TabIndex = 15;
            this.rbDataVariant.TabStop = true;
            this.rbDataVariant.Text = "Data Variant";
            this.rbDataVariant.UseVisualStyleBackColor = true;
            // 
            // gbEncryptedDataVariant
            // 
            this.gbEncryptedDataVariant.Controls.Add(this.lnkKeyVariants);
            this.gbEncryptedDataVariant.Controls.Add(this.rbDataVariant);
            this.gbEncryptedDataVariant.Controls.Add(this.rbPINVariant);
            this.gbEncryptedDataVariant.Location = new System.Drawing.Point(15, 231);
            this.gbEncryptedDataVariant.Name = "gbEncryptedDataVariant";
            this.gbEncryptedDataVariant.Size = new System.Drawing.Size(518, 46);
            this.gbEncryptedDataVariant.TabIndex = 17;
            this.gbEncryptedDataVariant.TabStop = false;
            this.gbEncryptedDataVariant.Text = "Key Derivation";
            // 
            // lnkKeyVariants
            // 
            this.lnkKeyVariants.AutoSize = true;
            this.lnkKeyVariants.Location = new System.Drawing.Point(397, 20);
            this.lnkKeyVariants.Name = "lnkKeyVariants";
            this.lnkKeyVariants.Size = new System.Drawing.Size(106, 13);
            this.lnkKeyVariants.TabIndex = 18;
            this.lnkKeyVariants.TabStop = true;
            this.lnkKeyVariants.Text = "DUKPT Key Variants";
            this.lnkKeyVariants.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.lnkKeyVariants.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkKeyVariants_LinkClicked);
            // 
            // llWarning
            // 
            this.llWarning.AutoSize = true;
            this.llWarning.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llWarning.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.llWarning.Location = new System.Drawing.Point(27, 440);
            this.llWarning.Name = "llWarning";
            this.llWarning.Size = new System.Drawing.Size(58, 13);
            this.llWarning.TabIndex = 18;
            this.llWarning.TabStop = true;
            this.llWarning.Text = "Warning!";
            this.llWarning.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.llWarning.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llWarning_LinkClicked);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TDESDUKPTTool.Properties.Resources.warning;
            this.pictureBox1.Location = new System.Drawing.Point(12, 434);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(15, 24);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 465);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.llWarning);
            this.Controls.Add(this.gbEncryptedDataVariant);
            this.Controls.Add(this.lnkWikipediaDUKPT);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDecryptedData);
            this.Controls.Add(this.btnDecrypt);
            this.Controls.Add(this.btnEncrypt);
            this.Controls.Add(this.lblEncryptedData);
            this.Controls.Add(this.txtEncryptedData);
            this.Controls.Add(this.btnANSIKSN);
            this.Controls.Add(this.btnANSIKey);
            this.Controls.Add(this.lblKSN);
            this.Controls.Add(this.txtKSN);
            this.Controls.Add(this.lblBDK);
            this.Controls.Add(this.txtBDK);
            this.Controls.Add(this.msMainMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.msMainMenu;
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TDES DUKPT Tool";
            this.msMainMenu.ResumeLayout(false);
            this.msMainMenu.PerformLayout();
            this.gbEncryptedDataVariant.ResumeLayout(false);
            this.gbEncryptedDataVariant.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBDK;
        private System.Windows.Forms.Label lblBDK;
        private System.Windows.Forms.Label lblKSN;
        private System.Windows.Forms.TextBox txtKSN;
        private System.Windows.Forms.Button btnANSIKey;
        private System.Windows.Forms.Button btnANSIKSN;
        private System.Windows.Forms.TextBox txtEncryptedData;
        private System.Windows.Forms.Label lblEncryptedData;
        private System.Windows.Forms.Button btnEncrypt;
        private System.Windows.Forms.Button btnDecrypt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDecryptedData;
        private System.Windows.Forms.LinkLabel lnkWikipediaDUKPT;
        private System.Windows.Forms.MenuStrip msMainMenu;
        private System.Windows.Forms.ToolStripMenuItem tsmiFile;
        private System.Windows.Forms.ToolStripMenuItem tsmiExit;
        private System.Windows.Forms.ToolStripMenuItem tsmiMore;
        private System.Windows.Forms.ToolStripMenuItem tsmiBDKKeyPartTool;
        private System.Windows.Forms.RadioButton rbPINVariant;
        private System.Windows.Forms.RadioButton rbDataVariant;
        private System.Windows.Forms.GroupBox gbEncryptedDataVariant;
        private System.Windows.Forms.LinkLabel lnkKeyVariants;
        private System.Windows.Forms.LinkLabel llWarning;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

