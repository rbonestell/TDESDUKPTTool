namespace TDESDUKPTTool
{
    partial class frmKeyPartTool
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmKeyPartTool));
            this.lblKeyParts = new System.Windows.Forms.Label();
            this.txtKey = new System.Windows.Forms.TextBox();
            this.lblKey = new System.Windows.Forms.Label();
            this.lbKeyParts = new System.Windows.Forms.ListBox();
            this.btnDeleteKeyPart = new System.Windows.Forms.Button();
            this.txtKeyPart = new System.Windows.Forms.TextBox();
            this.lblKeyPart = new System.Windows.Forms.Label();
            this.btnAddKeyPart = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblKeyParts
            // 
            this.lblKeyParts.AutoSize = true;
            this.lblKeyParts.Location = new System.Drawing.Point(9, 55);
            this.lblKeyParts.Name = "lblKeyParts";
            this.lblKeyParts.Size = new System.Drawing.Size(52, 13);
            this.lblKeyParts.TabIndex = 0;
            this.lblKeyParts.Text = "Key Parts";
            // 
            // txtKey
            // 
            this.txtKey.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtKey.Font = new System.Drawing.Font("Courier New", 10F);
            this.txtKey.Location = new System.Drawing.Point(12, 228);
            this.txtKey.Name = "txtKey";
            this.txtKey.ReadOnly = true;
            this.txtKey.Size = new System.Drawing.Size(333, 23);
            this.txtKey.TabIndex = 8;
            // 
            // lblKey
            // 
            this.lblKey.AutoSize = true;
            this.lblKey.Location = new System.Drawing.Point(9, 212);
            this.lblKey.Name = "lblKey";
            this.lblKey.Size = new System.Drawing.Size(143, 13);
            this.lblKey.TabIndex = 7;
            this.lblKey.Text = "Resulting Key (XOR of Parts)";
            // 
            // lbKeyParts
            // 
            this.lbKeyParts.Font = new System.Drawing.Font("Courier New", 10F);
            this.lbKeyParts.FormattingEnabled = true;
            this.lbKeyParts.HorizontalScrollbar = true;
            this.lbKeyParts.ItemHeight = 16;
            this.lbKeyParts.Location = new System.Drawing.Point(12, 71);
            this.lbKeyParts.Name = "lbKeyParts";
            this.lbKeyParts.Size = new System.Drawing.Size(333, 132);
            this.lbKeyParts.TabIndex = 9;
            // 
            // btnDeleteKeyPart
            // 
            this.btnDeleteKeyPart.BackgroundImage = global::TDESDUKPTTool.Properties.Resources.x;
            this.btnDeleteKeyPart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnDeleteKeyPart.Location = new System.Drawing.Point(351, 70);
            this.btnDeleteKeyPart.Name = "btnDeleteKeyPart";
            this.btnDeleteKeyPart.Size = new System.Drawing.Size(25, 25);
            this.btnDeleteKeyPart.TabIndex = 10;
            this.btnDeleteKeyPart.UseVisualStyleBackColor = true;
            this.btnDeleteKeyPart.Click += new System.EventHandler(this.btnDeleteKeyPart_Click);
            // 
            // txtKeyPart
            // 
            this.txtKeyPart.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtKeyPart.Font = new System.Drawing.Font("Courier New", 10F);
            this.txtKeyPart.Location = new System.Drawing.Point(12, 25);
            this.txtKeyPart.Name = "txtKeyPart";
            this.txtKeyPart.Size = new System.Drawing.Size(333, 23);
            this.txtKeyPart.TabIndex = 12;
            this.txtKeyPart.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtKeyPart_KeyPress);
            // 
            // lblKeyPart
            // 
            this.lblKeyPart.AutoSize = true;
            this.lblKeyPart.Location = new System.Drawing.Point(9, 9);
            this.lblKeyPart.Name = "lblKeyPart";
            this.lblKeyPart.Size = new System.Drawing.Size(69, 13);
            this.lblKeyPart.TabIndex = 11;
            this.lblKeyPart.Text = "Add Key Part";
            // 
            // btnAddKeyPart
            // 
            this.btnAddKeyPart.BackgroundImage = global::TDESDUKPTTool.Properties.Resources.add;
            this.btnAddKeyPart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAddKeyPart.Location = new System.Drawing.Point(351, 24);
            this.btnAddKeyPart.Name = "btnAddKeyPart";
            this.btnAddKeyPart.Size = new System.Drawing.Size(25, 25);
            this.btnAddKeyPart.TabIndex = 13;
            this.btnAddKeyPart.UseVisualStyleBackColor = true;
            this.btnAddKeyPart.Click += new System.EventHandler(this.btnAddKeyPart_Click);
            // 
            // frmKeyPartTool
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 262);
            this.Controls.Add(this.btnAddKeyPart);
            this.Controls.Add(this.txtKeyPart);
            this.Controls.Add(this.lblKeyPart);
            this.Controls.Add(this.btnDeleteKeyPart);
            this.Controls.Add(this.lbKeyParts);
            this.Controls.Add(this.txtKey);
            this.Controls.Add(this.lblKey);
            this.Controls.Add(this.lblKeyParts);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmKeyPartTool";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Key Part Tool";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblKeyParts;
        private System.Windows.Forms.TextBox txtKey;
        private System.Windows.Forms.Label lblKey;
        private System.Windows.Forms.ListBox lbKeyParts;
        private System.Windows.Forms.Button btnDeleteKeyPart;
        private System.Windows.Forms.TextBox txtKeyPart;
        private System.Windows.Forms.Label lblKeyPart;
        private System.Windows.Forms.Button btnAddKeyPart;
    }
}