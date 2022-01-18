namespace ADO.NET_WinForm_HW1
{
    partial class LoginRegister
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.loginTB = new System.Windows.Forms.TextBox();
            this.passTB = new System.Windows.Forms.TextBox();
            this.loginButton = new System.Windows.Forms.Button();
            this.RegisterButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Old English Text MT", 17F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label1.Location = new System.Drawing.Point(137, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "Login";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Old English Text MT", 17F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label2.Location = new System.Drawing.Point(106, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 34);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password";
            // 
            // loginTB
            // 
            this.loginTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginTB.Location = new System.Drawing.Point(59, 121);
            this.loginTB.Name = "loginTB";
            this.loginTB.Size = new System.Drawing.Size(244, 26);
            this.loginTB.TabIndex = 2;
            // 
            // passTB
            // 
            this.passTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passTB.Location = new System.Drawing.Point(59, 202);
            this.passTB.Name = "passTB";
            this.passTB.Size = new System.Drawing.Size(244, 26);
            this.passTB.TabIndex = 3;
            this.passTB.UseSystemPasswordChar = true;
            // 
            // loginButton
            // 
            this.loginButton.Location = new System.Drawing.Point(96, 251);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(81, 28);
            this.loginButton.TabIndex = 4;
            this.loginButton.Text = "Log In";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // RegisterButton
            // 
            this.RegisterButton.Location = new System.Drawing.Point(183, 251);
            this.RegisterButton.Name = "RegisterButton";
            this.RegisterButton.Size = new System.Drawing.Size(81, 28);
            this.RegisterButton.TabIndex = 5;
            this.RegisterButton.Text = "Register";
            this.RegisterButton.UseVisualStyleBackColor = true;
            this.RegisterButton.Click += new System.EventHandler(this.RegisterButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(93, 231);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 17);
            this.label3.TabIndex = 6;
            // 
            // LoginRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 433);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.RegisterButton);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.passTB);
            this.Controls.Add(this.loginTB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "LoginRegister";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LoginRegister_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox loginTB;
        private System.Windows.Forms.TextBox passTB;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.Button RegisterButton;
        private System.Windows.Forms.Label label3;
    }
}