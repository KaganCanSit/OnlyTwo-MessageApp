
namespace OnlyTwo
{
    partial class MainForm
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.SendFlatButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.PlainTextGroupBox = new System.Windows.Forms.GroupBox();
            this.CipherTextGroupBox = new System.Windows.Forms.GroupBox();
            this.CipherTextBox = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.EncryptionGroupBox = new System.Windows.Forms.GroupBox();
            this.SpnLabel = new System.Windows.Forms.Label();
            this.SHALabel = new System.Windows.Forms.Label();
            this.bunifuCheckbox2 = new Bunifu.Framework.UI.BunifuCheckbox();
            this.bunifuCheckbox1 = new Bunifu.Framework.UI.BunifuCheckbox();
            this.AddFileButton = new Bunifu.Framework.UI.BunifuThinButton2();
            this.KeygenTextBox = new System.Windows.Forms.TextBox();
            this.KeyLabel = new System.Windows.Forms.Label();
            this.DeleteButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.FindButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.FindTextBox = new System.Windows.Forms.TextBox();
            this.FindLabel = new System.Windows.Forms.Label();
            this.PlainRichTextBox = new System.Windows.Forms.RichTextBox();
            this.PlainTextGroupBox.SuspendLayout();
            this.CipherTextGroupBox.SuspendLayout();
            this.EncryptionGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // SendFlatButton
            // 
            this.SendFlatButton.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.SendFlatButton.BackColor = System.Drawing.Color.Black;
            this.SendFlatButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SendFlatButton.BorderRadius = 0;
            this.SendFlatButton.ButtonText = "Send";
            this.SendFlatButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SendFlatButton.DisabledColor = System.Drawing.Color.Gray;
            this.SendFlatButton.Iconcolor = System.Drawing.Color.Transparent;
            this.SendFlatButton.Iconimage = null;
            this.SendFlatButton.Iconimage_right = null;
            this.SendFlatButton.Iconimage_right_Selected = null;
            this.SendFlatButton.Iconimage_Selected = null;
            this.SendFlatButton.IconMarginLeft = 0;
            this.SendFlatButton.IconMarginRight = 0;
            this.SendFlatButton.IconRightVisible = true;
            this.SendFlatButton.IconRightZoom = 0D;
            this.SendFlatButton.IconVisible = true;
            this.SendFlatButton.IconZoom = 90D;
            this.SendFlatButton.IsTab = false;
            this.SendFlatButton.Location = new System.Drawing.Point(12, 472);
            this.SendFlatButton.Name = "SendFlatButton";
            this.SendFlatButton.Normalcolor = System.Drawing.Color.Black;
            this.SendFlatButton.OnHovercolor = System.Drawing.Color.Red;
            this.SendFlatButton.OnHoverTextColor = System.Drawing.Color.White;
            this.SendFlatButton.selected = false;
            this.SendFlatButton.Size = new System.Drawing.Size(677, 33);
            this.SendFlatButton.TabIndex = 2;
            this.SendFlatButton.Text = "Send";
            this.SendFlatButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.SendFlatButton.Textcolor = System.Drawing.Color.White;
            this.SendFlatButton.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // PlainTextGroupBox
            // 
            this.PlainTextGroupBox.Controls.Add(this.PlainRichTextBox);
            this.PlainTextGroupBox.Controls.Add(this.FindLabel);
            this.PlainTextGroupBox.Controls.Add(this.FindTextBox);
            this.PlainTextGroupBox.Controls.Add(this.FindButton);
            this.PlainTextGroupBox.Controls.Add(this.DeleteButton);
            this.PlainTextGroupBox.Controls.Add(this.AddFileButton);
            this.PlainTextGroupBox.Location = new System.Drawing.Point(12, 56);
            this.PlainTextGroupBox.Name = "PlainTextGroupBox";
            this.PlainTextGroupBox.Size = new System.Drawing.Size(677, 202);
            this.PlainTextGroupBox.TabIndex = 3;
            this.PlainTextGroupBox.TabStop = false;
            this.PlainTextGroupBox.Text = "Plain Text";
            // 
            // CipherTextGroupBox
            // 
            this.CipherTextGroupBox.Controls.Add(this.CipherTextBox);
            this.CipherTextGroupBox.Location = new System.Drawing.Point(12, 264);
            this.CipherTextGroupBox.Name = "CipherTextGroupBox";
            this.CipherTextGroupBox.Size = new System.Drawing.Size(677, 202);
            this.CipherTextGroupBox.TabIndex = 4;
            this.CipherTextGroupBox.TabStop = false;
            this.CipherTextGroupBox.Text = "CipherText";
            // 
            // CipherTextBox
            // 
            this.CipherTextBox.BorderColor = System.Drawing.Color.SeaGreen;
            this.CipherTextBox.Location = new System.Drawing.Point(6, 19);
            this.CipherTextBox.Multiline = true;
            this.CipherTextBox.Name = "CipherTextBox";
            this.CipherTextBox.Size = new System.Drawing.Size(662, 177);
            this.CipherTextBox.TabIndex = 0;
            // 
            // EncryptionGroupBox
            // 
            this.EncryptionGroupBox.Controls.Add(this.SpnLabel);
            this.EncryptionGroupBox.Controls.Add(this.SHALabel);
            this.EncryptionGroupBox.Controls.Add(this.bunifuCheckbox2);
            this.EncryptionGroupBox.Controls.Add(this.bunifuCheckbox1);
            this.EncryptionGroupBox.Location = new System.Drawing.Point(511, 7);
            this.EncryptionGroupBox.Name = "EncryptionGroupBox";
            this.EncryptionGroupBox.Size = new System.Drawing.Size(178, 49);
            this.EncryptionGroupBox.TabIndex = 5;
            this.EncryptionGroupBox.TabStop = false;
            this.EncryptionGroupBox.Text = "Encryption Type";
            // 
            // SpnLabel
            // 
            this.SpnLabel.AutoSize = true;
            this.SpnLabel.Location = new System.Drawing.Point(140, 23);
            this.SpnLabel.Name = "SpnLabel";
            this.SpnLabel.Size = new System.Drawing.Size(29, 13);
            this.SpnLabel.TabIndex = 3;
            this.SpnLabel.Text = "SPN";
            // 
            // SHALabel
            // 
            this.SHALabel.AutoSize = true;
            this.SHALabel.Location = new System.Drawing.Point(31, 22);
            this.SHALabel.Name = "SHALabel";
            this.SHALabel.Size = new System.Drawing.Size(56, 13);
            this.SHALabel.TabIndex = 2;
            this.SHALabel.Text = "SHA 2566";
            // 
            // bunifuCheckbox2
            // 
            this.bunifuCheckbox2.BackColor = System.Drawing.Color.Red;
            this.bunifuCheckbox2.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.bunifuCheckbox2.Checked = true;
            this.bunifuCheckbox2.CheckedOnColor = System.Drawing.Color.Red;
            this.bunifuCheckbox2.ForeColor = System.Drawing.Color.White;
            this.bunifuCheckbox2.Location = new System.Drawing.Point(114, 19);
            this.bunifuCheckbox2.Name = "bunifuCheckbox2";
            this.bunifuCheckbox2.Size = new System.Drawing.Size(20, 20);
            this.bunifuCheckbox2.TabIndex = 1;
            // 
            // bunifuCheckbox1
            // 
            this.bunifuCheckbox1.BackColor = System.Drawing.Color.Red;
            this.bunifuCheckbox1.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.bunifuCheckbox1.Checked = true;
            this.bunifuCheckbox1.CheckedOnColor = System.Drawing.Color.Red;
            this.bunifuCheckbox1.ForeColor = System.Drawing.Color.White;
            this.bunifuCheckbox1.Location = new System.Drawing.Point(6, 19);
            this.bunifuCheckbox1.Name = "bunifuCheckbox1";
            this.bunifuCheckbox1.Size = new System.Drawing.Size(20, 20);
            this.bunifuCheckbox1.TabIndex = 0;
            // 
            // AddFileButton
            // 
            this.AddFileButton.ActiveBorderThickness = 1;
            this.AddFileButton.ActiveCornerRadius = 20;
            this.AddFileButton.ActiveFillColor = System.Drawing.Color.Red;
            this.AddFileButton.ActiveForecolor = System.Drawing.Color.White;
            this.AddFileButton.ActiveLineColor = System.Drawing.Color.Red;
            this.AddFileButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.AddFileButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("AddFileButton.BackgroundImage")));
            this.AddFileButton.ButtonText = "Add File";
            this.AddFileButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddFileButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddFileButton.ForeColor = System.Drawing.Color.Red;
            this.AddFileButton.IdleBorderThickness = 1;
            this.AddFileButton.IdleCornerRadius = 20;
            this.AddFileButton.IdleFillColor = System.Drawing.Color.White;
            this.AddFileButton.IdleForecolor = System.Drawing.Color.Red;
            this.AddFileButton.IdleLineColor = System.Drawing.Color.Red;
            this.AddFileButton.Location = new System.Drawing.Point(499, 162);
            this.AddFileButton.Margin = new System.Windows.Forms.Padding(5);
            this.AddFileButton.Name = "AddFileButton";
            this.AddFileButton.Size = new System.Drawing.Size(169, 33);
            this.AddFileButton.TabIndex = 2;
            this.AddFileButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // KeygenTextBox
            // 
            this.KeygenTextBox.Location = new System.Drawing.Point(18, 30);
            this.KeygenTextBox.Name = "KeygenTextBox";
            this.KeygenTextBox.Size = new System.Drawing.Size(487, 20);
            this.KeygenTextBox.TabIndex = 6;
            // 
            // KeyLabel
            // 
            this.KeyLabel.AutoSize = true;
            this.KeyLabel.Location = new System.Drawing.Point(18, 13);
            this.KeyLabel.Name = "KeyLabel";
            this.KeyLabel.Size = new System.Drawing.Size(104, 13);
            this.KeyLabel.TabIndex = 7;
            this.KeyLabel.Text = "Key to the Message:";
            // 
            // DeleteButton
            // 
            this.DeleteButton.Activecolor = System.Drawing.Color.Transparent;
            this.DeleteButton.BackColor = System.Drawing.Color.Transparent;
            this.DeleteButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.DeleteButton.BorderRadius = 3;
            this.DeleteButton.ButtonText = "Delete All Text";
            this.DeleteButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DeleteButton.DisabledColor = System.Drawing.Color.Gray;
            this.DeleteButton.Iconcolor = System.Drawing.Color.Transparent;
            this.DeleteButton.Iconimage = ((System.Drawing.Image)(resources.GetObject("DeleteButton.Iconimage")));
            this.DeleteButton.Iconimage_right = null;
            this.DeleteButton.Iconimage_right_Selected = null;
            this.DeleteButton.Iconimage_Selected = null;
            this.DeleteButton.IconMarginLeft = 5;
            this.DeleteButton.IconMarginRight = 0;
            this.DeleteButton.IconRightVisible = true;
            this.DeleteButton.IconRightZoom = 0D;
            this.DeleteButton.IconVisible = true;
            this.DeleteButton.IconZoom = 90D;
            this.DeleteButton.IsTab = false;
            this.DeleteButton.Location = new System.Drawing.Point(499, 119);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Normalcolor = System.Drawing.Color.Transparent;
            this.DeleteButton.OnHovercolor = System.Drawing.Color.Red;
            this.DeleteButton.OnHoverTextColor = System.Drawing.Color.Black;
            this.DeleteButton.selected = false;
            this.DeleteButton.Size = new System.Drawing.Size(169, 35);
            this.DeleteButton.TabIndex = 2;
            this.DeleteButton.Text = "Delete All Text";
            this.DeleteButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.DeleteButton.Textcolor = System.Drawing.Color.Red;
            this.DeleteButton.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // FindButton
            // 
            this.FindButton.Activecolor = System.Drawing.Color.Transparent;
            this.FindButton.BackColor = System.Drawing.Color.Transparent;
            this.FindButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.FindButton.BorderRadius = 3;
            this.FindButton.ButtonText = "Find";
            this.FindButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FindButton.DisabledColor = System.Drawing.Color.Gray;
            this.FindButton.Iconcolor = System.Drawing.Color.Transparent;
            this.FindButton.Iconimage = ((System.Drawing.Image)(resources.GetObject("FindButton.Iconimage")));
            this.FindButton.Iconimage_right = null;
            this.FindButton.Iconimage_right_Selected = null;
            this.FindButton.Iconimage_Selected = null;
            this.FindButton.IconMarginLeft = 5;
            this.FindButton.IconMarginRight = 0;
            this.FindButton.IconRightVisible = true;
            this.FindButton.IconRightZoom = 120D;
            this.FindButton.IconVisible = true;
            this.FindButton.IconZoom = 90D;
            this.FindButton.IsTab = false;
            this.FindButton.Location = new System.Drawing.Point(499, 64);
            this.FindButton.Name = "FindButton";
            this.FindButton.Normalcolor = System.Drawing.Color.Transparent;
            this.FindButton.OnHovercolor = System.Drawing.Color.Red;
            this.FindButton.OnHoverTextColor = System.Drawing.Color.Black;
            this.FindButton.selected = false;
            this.FindButton.Size = new System.Drawing.Size(169, 35);
            this.FindButton.TabIndex = 3;
            this.FindButton.Text = "Find";
            this.FindButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.FindButton.Textcolor = System.Drawing.Color.Red;
            this.FindButton.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FindButton.Click += new System.EventHandler(this.FindButton_Click);
            // 
            // FindTextBox
            // 
            this.FindTextBox.Location = new System.Drawing.Point(499, 38);
            this.FindTextBox.Name = "FindTextBox";
            this.FindTextBox.Size = new System.Drawing.Size(169, 20);
            this.FindTextBox.TabIndex = 1;
            // 
            // FindLabel
            // 
            this.FindLabel.AutoSize = true;
            this.FindLabel.Location = new System.Drawing.Point(499, 19);
            this.FindLabel.Name = "FindLabel";
            this.FindLabel.Size = new System.Drawing.Size(71, 13);
            this.FindLabel.TabIndex = 4;
            this.FindLabel.Text = "Find Keyword";
            // 
            // PlainRichTextBox
            // 
            this.PlainRichTextBox.Location = new System.Drawing.Point(6, 19);
            this.PlainRichTextBox.Name = "PlainRichTextBox";
            this.PlainRichTextBox.Size = new System.Drawing.Size(487, 176);
            this.PlainRichTextBox.TabIndex = 5;
            this.PlainRichTextBox.Text = "";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(704, 519);
            this.Controls.Add(this.KeyLabel);
            this.Controls.Add(this.KeygenTextBox);
            this.Controls.Add(this.CipherTextGroupBox);
            this.Controls.Add(this.EncryptionGroupBox);
            this.Controls.Add(this.PlainTextGroupBox);
            this.Controls.Add(this.SendFlatButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "OnlyTwo";
            this.PlainTextGroupBox.ResumeLayout(false);
            this.PlainTextGroupBox.PerformLayout();
            this.CipherTextGroupBox.ResumeLayout(false);
            this.CipherTextGroupBox.PerformLayout();
            this.EncryptionGroupBox.ResumeLayout(false);
            this.EncryptionGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Bunifu.Framework.UI.BunifuFlatButton SendFlatButton;
        private System.Windows.Forms.GroupBox PlainTextGroupBox;
        private System.Windows.Forms.GroupBox CipherTextGroupBox;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox CipherTextBox;
        private System.Windows.Forms.GroupBox EncryptionGroupBox;
        private System.Windows.Forms.Label SpnLabel;
        private System.Windows.Forms.Label SHALabel;
        private Bunifu.Framework.UI.BunifuCheckbox bunifuCheckbox2;
        private Bunifu.Framework.UI.BunifuCheckbox bunifuCheckbox1;
        private Bunifu.Framework.UI.BunifuThinButton2 AddFileButton;
        private System.Windows.Forms.TextBox KeygenTextBox;
        private System.Windows.Forms.Label KeyLabel;
        private Bunifu.Framework.UI.BunifuFlatButton DeleteButton;
        private System.Windows.Forms.TextBox FindTextBox;
        private Bunifu.Framework.UI.BunifuFlatButton FindButton;
        private System.Windows.Forms.Label FindLabel;
        private System.Windows.Forms.RichTextBox PlainRichTextBox;
    }
}

