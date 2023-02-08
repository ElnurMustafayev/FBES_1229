namespace GettingStarted {
    partial class Form1 {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.CounterTextbox = new System.Windows.Forms.TextBox();
            this.PlusButton = new System.Windows.Forms.Button();
            this.MinusButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CounterTextbox
            // 
            this.CounterTextbox.BackColor = System.Drawing.SystemColors.HighlightText;
            this.CounterTextbox.Font = new System.Drawing.Font("Romantic", 64F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CounterTextbox.Location = new System.Drawing.Point(12, 167);
            this.CounterTextbox.Name = "CounterTextbox";
            this.CounterTextbox.ReadOnly = true;
            this.CounterTextbox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.CounterTextbox.Size = new System.Drawing.Size(226, 112);
            this.CounterTextbox.TabIndex = 0;
            this.CounterTextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // PlusButton
            // 
            this.PlusButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.PlusButton.Font = new System.Drawing.Font("Segoe UI", 84F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PlusButton.ForeColor = System.Drawing.SystemColors.Control;
            this.PlusButton.Location = new System.Drawing.Point(254, 12);
            this.PlusButton.Name = "PlusButton";
            this.PlusButton.Size = new System.Drawing.Size(280, 200);
            this.PlusButton.TabIndex = 1;
            this.PlusButton.Text = "+";
            this.PlusButton.UseVisualStyleBackColor = false;
            this.PlusButton.Click += new System.EventHandler(this.PlusButton_Click);
            // 
            // MinusButton
            // 
            this.MinusButton.BackColor = System.Drawing.Color.Red;
            this.MinusButton.Font = new System.Drawing.Font("Segoe UI", 84F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MinusButton.ForeColor = System.Drawing.SystemColors.Control;
            this.MinusButton.Location = new System.Drawing.Point(254, 238);
            this.MinusButton.Name = "MinusButton";
            this.MinusButton.Size = new System.Drawing.Size(280, 200);
            this.MinusButton.TabIndex = 2;
            this.MinusButton.Text = "-";
            this.MinusButton.UseVisualStyleBackColor = false;
            this.MinusButton.Click += new System.EventHandler(this.MinusButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(546, 450);
            this.Controls.Add(this.MinusButton);
            this.Controls.Add(this.PlusButton);
            this.Controls.Add(this.CounterTextbox);
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox CounterTextbox;
        private Button PlusButton;
        private Button MinusButton;
    }
}