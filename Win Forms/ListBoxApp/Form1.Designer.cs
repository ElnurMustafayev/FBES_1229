namespace ListBoxApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.NameTextbox = new System.Windows.Forms.TextBox();
            this.NameLabel = new System.Windows.Forms.Label();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.PasswordTextbox = new System.Windows.Forms.TextBox();
            this.RegisterButton = new System.Windows.Forms.Button();
            this.messageLabel = new System.Windows.Forms.Label();
            this.UsersListbox = new System.Windows.Forms.ListBox();
            this.UserPictureBox = new System.Windows.Forms.PictureBox();
            this.ImageLable = new System.Windows.Forms.Label();
            this.ImageUrlTextbox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.UserPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // NameTextbox
            // 
            this.NameTextbox.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NameTextbox.Location = new System.Drawing.Point(179, 60);
            this.NameTextbox.Name = "NameTextbox";
            this.NameTextbox.Size = new System.Drawing.Size(341, 32);
            this.NameTextbox.TabIndex = 0;
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NameLabel.Location = new System.Drawing.Point(12, 63);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(66, 25);
            this.NameLabel.TabIndex = 1;
            this.NameLabel.Text = "Name:";
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PasswordLabel.Location = new System.Drawing.Point(12, 119);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(95, 25);
            this.PasswordLabel.TabIndex = 2;
            this.PasswordLabel.Text = "Password:";
            // 
            // PasswordTextbox
            // 
            this.PasswordTextbox.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PasswordTextbox.Location = new System.Drawing.Point(179, 116);
            this.PasswordTextbox.Name = "PasswordTextbox";
            this.PasswordTextbox.Size = new System.Drawing.Size(341, 32);
            this.PasswordTextbox.TabIndex = 3;
            // 
            // RegisterButton
            // 
            this.RegisterButton.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RegisterButton.Location = new System.Drawing.Point(380, 431);
            this.RegisterButton.Name = "RegisterButton";
            this.RegisterButton.Size = new System.Drawing.Size(140, 40);
            this.RegisterButton.TabIndex = 4;
            this.RegisterButton.Text = "Register";
            this.RegisterButton.UseVisualStyleBackColor = true;
            this.RegisterButton.Click += new System.EventHandler(this.RegisterButton_Click);
            // 
            // messageLabel
            // 
            this.messageLabel.AutoSize = true;
            this.messageLabel.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.messageLabel.Location = new System.Drawing.Point(12, 20);
            this.messageLabel.Name = "messageLabel";
            this.messageLabel.Size = new System.Drawing.Size(0, 25);
            this.messageLabel.TabIndex = 5;
            // 
            // UsersListbox
            // 
            this.UsersListbox.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.UsersListbox.FormattingEnabled = true;
            this.UsersListbox.ItemHeight = 25;
            this.UsersListbox.Location = new System.Drawing.Point(12, 502);
            this.UsersListbox.Name = "UsersListbox";
            this.UsersListbox.Size = new System.Drawing.Size(510, 129);
            this.UsersListbox.TabIndex = 6;
            this.UsersListbox.SelectedIndexChanged += new System.EventHandler(this.UsersListbox_SelectedIndexChanged);
            // 
            // UserPictureBox
            // 
            this.UserPictureBox.Location = new System.Drawing.Point(12, 223);
            this.UserPictureBox.Name = "UserPictureBox";
            this.UserPictureBox.Size = new System.Drawing.Size(296, 248);
            this.UserPictureBox.TabIndex = 7;
            this.UserPictureBox.TabStop = false;
            // 
            // ImageLable
            // 
            this.ImageLable.AutoSize = true;
            this.ImageLable.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ImageLable.Location = new System.Drawing.Point(12, 172);
            this.ImageLable.Name = "ImageLable";
            this.ImageLable.Size = new System.Drawing.Size(106, 25);
            this.ImageLable.TabIndex = 8;
            this.ImageLable.Text = "Image URL:";
            // 
            // ImageUrlTextbox
            // 
            this.ImageUrlTextbox.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ImageUrlTextbox.Location = new System.Drawing.Point(179, 169);
            this.ImageUrlTextbox.Name = "ImageUrlTextbox";
            this.ImageUrlTextbox.Size = new System.Drawing.Size(341, 32);
            this.ImageUrlTextbox.TabIndex = 9;
            this.ImageUrlTextbox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ImageUrlTextbox_KeyDown);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 643);
            this.Controls.Add(this.ImageUrlTextbox);
            this.Controls.Add(this.ImageLable);
            this.Controls.Add(this.UserPictureBox);
            this.Controls.Add(this.UsersListbox);
            this.Controls.Add(this.messageLabel);
            this.Controls.Add(this.RegisterButton);
            this.Controls.Add(this.PasswordTextbox);
            this.Controls.Add(this.PasswordLabel);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.NameTextbox);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.UserPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox NameTextbox;
        private Label NameLabel;
        private Label PasswordLabel;
        private TextBox PasswordTextbox;
        private Button RegisterButton;
        private Label messageLabel;
        private ListBox UsersListbox;
        private PictureBox UserPictureBox;
        private Label ImageLable;
        private TextBox ImageUrlTextbox;
    }
}