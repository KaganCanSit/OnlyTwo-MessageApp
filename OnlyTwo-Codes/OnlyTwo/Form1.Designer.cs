
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
            this.PlainTextBox = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.SendFlatButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.PlainTextGroupBox = new System.Windows.Forms.GroupBox();
            this.CipherTextGroupBox = new System.Windows.Forms.GroupBox();
            this.CipherTextBox = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.FindButton = new Bunifu.Framework.UI.BunifuImageButton();
            this.DeleteButton = new Bunifu.Framework.UI.BunifuImageButton();
            this.FindLabel = new System.Windows.Forms.Label();
            this.DeleteTextAllLabel = new System.Windows.Forms.Label();
            this.EncryptionGroupBox = new System.Windows.Forms.GroupBox();
            this.bunifuCheckbox1 = new Bunifu.Framework.UI.BunifuCheckbox();
            this.bunifuCheckbox2 = new Bunifu.Framework.UI.BunifuCheckbox();
            this.SHALabel = new System.Windows.Forms.Label();
            this.SpnLabel = new System.Windows.Forms.Label();
            this.AddGroupBox = new System.Windows.Forms.GroupBox();
            this.AddFileButton = new Bunifu.Framework.UI.BunifuThinButton2();
            this.PlainTextGroupBox.SuspendLayout();
            this.CipherTextGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FindButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DeleteButton)).BeginInit();
            this.EncryptionGroupBox.SuspendLayout();
            this.AddGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // PlainTextBox
            // 
            this.PlainTextBox.BorderColor = System.Drawing.Color.SeaGreen;
            this.PlainTextBox.Location = new System.Drawing.Point(6, 19);
            this.PlainTextBox.Multiline = true;
            this.PlainTextBox.Name = "PlainTextBox";
            this.PlainTextBox.Size = new System.Drawing.Size(569, 177);
            this.PlainTextBox.TabIndex = 0;
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
            this.SendFlatButton.Location = new System.Drawing.Point(582, 613);
            this.SendFlatButton.Name = "SendFlatButton";
            this.SendFlatButton.Normalcolor = System.Drawing.Color.Black;
            this.SendFlatButton.OnHovercolor = System.Drawing.Color.Red;
            this.SendFlatButton.OnHoverTextColor = System.Drawing.Color.White;
            this.SendFlatButton.selected = false;
            this.SendFlatButton.Size = new System.Drawing.Size(92, 33);
            this.SendFlatButton.TabIndex = 2;
            this.SendFlatButton.Text = "Send";
            this.SendFlatButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.SendFlatButton.Textcolor = System.Drawing.Color.White;
            this.SendFlatButton.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // PlainTextGroupBox
            // 
            this.PlainTextGroupBox.Controls.Add(this.DeleteTextAllLabel);
            this.PlainTextGroupBox.Controls.Add(this.DeleteButton);
            this.PlainTextGroupBox.Controls.Add(this.FindLabel);
            this.PlainTextGroupBox.Controls.Add(this.FindButton);
            this.PlainTextGroupBox.Controls.Add(this.PlainTextBox);
            this.PlainTextGroupBox.Location = new System.Drawing.Point(27, 56);
            this.PlainTextGroupBox.Name = "PlainTextGroupBox";
            this.PlainTextGroupBox.Size = new System.Drawing.Size(647, 202);
            this.PlainTextGroupBox.TabIndex = 3;
            this.PlainTextGroupBox.TabStop = false;
            this.PlainTextGroupBox.Text = "Plain Text";
            // 
            // CipherTextGroupBox
            // 
            this.CipherTextGroupBox.Controls.Add(this.CipherTextBox);
            this.CipherTextGroupBox.Location = new System.Drawing.Point(27, 264);
            this.CipherTextGroupBox.Name = "CipherTextGroupBox";
            this.CipherTextGroupBox.Size = new System.Drawing.Size(647, 202);
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
            this.CipherTextBox.Size = new System.Drawing.Size(569, 177);
            this.CipherTextBox.TabIndex = 0;
            // 
            // FindButton
            // 
            this.FindButton.BackColor = System.Drawing.Color.White;
            this.FindButton.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FindButton.Image = ((System.Drawing.Image)(resources.GetObject("FindButton.Image")));
            this.FindButton.ImageActive = null;
            this.FindButton.Location = new System.Drawing.Point(584, 19);
            this.FindButton.Name = "FindButton";
            this.FindButton.Size = new System.Drawing.Size(52, 35);
            this.FindButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.FindButton.TabIndex = 6;
            this.FindButton.TabStop = false;
            this.FindButton.Zoom = 10;
            // 
            // DeleteButton
            // 
            this.DeleteButton.BackColor = System.Drawing.Color.White;
            this.DeleteButton.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DeleteButton.Image = ((System.Drawing.Image)(resources.GetObject("DeleteButton.Image")));
            this.DeleteButton.ImageActive = null;
            this.DeleteButton.Location = new System.Drawing.Point(584, 85);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(52, 35);
            this.DeleteButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.DeleteButton.TabIndex = 7;
            this.DeleteButton.TabStop = false;
            this.DeleteButton.Zoom = 10;
            // 
            // FindLabel
            // 
            this.FindLabel.AutoSize = true;
            this.FindLabel.Location = new System.Drawing.Point(596, 57);
            this.FindLabel.Name = "FindLabel";
            this.FindLabel.Size = new System.Drawing.Size(27, 13);
            this.FindLabel.TabIndex = 5;
            this.FindLabel.Text = "Find";
            // 
            // DeleteTextAllLabel
            // 
            this.DeleteTextAllLabel.AutoSize = true;
            this.DeleteTextAllLabel.Location = new System.Drawing.Point(579, 123);
            this.DeleteTextAllLabel.Name = "DeleteTextAllLabel";
            this.DeleteTextAllLabel.Size = new System.Drawing.Size(62, 26);
            this.DeleteTextAllLabel.TabIndex = 6;
            this.DeleteTextAllLabel.Text = "Delete Text\r\nAll";
            this.DeleteTextAllLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // EncryptionGroupBox
            // 
            this.EncryptionGroupBox.Controls.Add(this.SpnLabel);
            this.EncryptionGroupBox.Controls.Add(this.SHALabel);
            this.EncryptionGroupBox.Controls.Add(this.bunifuCheckbox2);
            this.EncryptionGroupBox.Controls.Add(this.bunifuCheckbox1);
            this.EncryptionGroupBox.Location = new System.Drawing.Point(496, 7);
            this.EncryptionGroupBox.Name = "EncryptionGroupBox";
            this.EncryptionGroupBox.Size = new System.Drawing.Size(178, 49);
            this.EncryptionGroupBox.TabIndex = 5;
            this.EncryptionGroupBox.TabStop = false;
            this.EncryptionGroupBox.Text = "Encryption Type";
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
            // SHALabel
            // 
            this.SHALabel.AutoSize = true;
            this.SHALabel.Location = new System.Drawing.Point(31, 22);
            this.SHALabel.Name = "SHALabel";
            this.SHALabel.Size = new System.Drawing.Size(56, 13);
            this.SHALabel.TabIndex = 2;
            this.SHALabel.Text = "SHA 2566";
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
            // AddGroupBox
            // 
            this.AddGroupBox.Controls.Add(this.AddFileButton);
            this.AddGroupBox.Location = new System.Drawing.Point(27, 472);
            this.AddGroupBox.Name = "AddGroupBox";
            this.AddGroupBox.Size = new System.Drawing.Size(647, 135);
            this.AddGroupBox.TabIndex = 5;
            this.AddGroupBox.TabStop = false;
            this.AddGroupBox.Text = "Add Media";
            // 
            // AddFileButton
            // 
            this.AddFileButton.ActiveBorderThickness = 1;
            this.AddFileButton.ActiveCornerRadius = 20;
            this.AddFileButton.ActiveFillColor = System.Drawing.Color.Red;
            this.AddFileButton.ActiveForecolor = System.Drawing.Color.White;
            this.AddFileButton.ActiveLineColor = System.Drawing.Color.Red;
            this.AddFileButton.BackColor = System.Drawing.SystemColors.Control;
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
            this.AddFileButton.Location = new System.Drawing.Point(256, 93);
            this.AddFileButton.Margin = new System.Windows.Forms.Padding(5);
            this.AddFileButton.Name = "AddFileButton";
            this.AddFileButton.Size = new System.Drawing.Size(135, 34);
            this.AddFileButton.TabIndex = 2;
            this.AddFileButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(699, 658);
            this.Controls.Add(this.AddGroupBox);
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
            ((System.ComponentModel.ISupportInitialize)(this.FindButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DeleteButton)).EndInit();
            this.EncryptionGroupBox.ResumeLayout(false);
            this.EncryptionGroupBox.PerformLayout();
            this.AddGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private WindowsFormsControlLibrary1.BunifuCustomTextbox PlainTextBox;
        private Bunifu.Framework.UI.BunifuFlatButton SendFlatButton;
        private System.Windows.Forms.GroupBox PlainTextGroupBox;
        private System.Windows.Forms.Label DeleteTextAllLabel;
        private Bunifu.Framework.UI.BunifuImageButton DeleteButton;
        private System.Windows.Forms.Label FindLabel;
        private Bunifu.Framework.UI.BunifuImageButton FindButton;
        private System.Windows.Forms.GroupBox CipherTextGroupBox;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox CipherTextBox;
        private System.Windows.Forms.GroupBox EncryptionGroupBox;
        private System.Windows.Forms.Label SpnLabel;
        private System.Windows.Forms.Label SHALabel;
        private Bunifu.Framework.UI.BunifuCheckbox bunifuCheckbox2;
        private Bunifu.Framework.UI.BunifuCheckbox bunifuCheckbox1;
        private System.Windows.Forms.GroupBox AddGroupBox;
        private Bunifu.Framework.UI.BunifuThinButton2 AddFileButton;
    }
}

