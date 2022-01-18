namespace ADO.NET_WinForm_HW1.ButtonForms
{
    partial class Register
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
            this.nameTB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lastnameTB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.loginTB = new System.Windows.Forms.TextBox();
            this.passTB = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.registerButton = new System.Windows.Forms.Button();
            this.infoLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(30, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // nameTB
            // 
            this.nameTB.Location = new System.Drawing.Point(138, 111);
            this.nameTB.Name = "nameTB";
            this.nameTB.Size = new System.Drawing.Size(187, 22);
            this.nameTB.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(30, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Lastname";
            // 
            // lastnameTB
            // 
            this.lastnameTB.Location = new System.Drawing.Point(138, 139);
            this.lastnameTB.Name = "lastnameTB";
            this.lastnameTB.Size = new System.Drawing.Size(187, 22);
            this.lastnameTB.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(30, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Login";
            // 
            // loginTB
            // 
            this.loginTB.Location = new System.Drawing.Point(138, 182);
            this.loginTB.Name = "loginTB";
            this.loginTB.Size = new System.Drawing.Size(187, 22);
            this.loginTB.TabIndex = 5;
            // 
            // passTB
            // 
            this.passTB.Location = new System.Drawing.Point(138, 210);
            this.passTB.Name = "passTB";
            this.passTB.Size = new System.Drawing.Size(187, 22);
            this.passTB.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.Location = new System.Drawing.Point(30, 210);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Password";
            // 
            // registerButton
            // 
            this.registerButton.Location = new System.Drawing.Point(34, 267);
            this.registerButton.Name = "registerButton";
            this.registerButton.Size = new System.Drawing.Size(291, 26);
            this.registerButton.TabIndex = 8;
            this.registerButton.Text = "Register";
            this.registerButton.UseVisualStyleBackColor = true;
            this.registerButton.Click += new System.EventHandler(this.registerButton_Click);
            // 
            // infoLabel
            // 
            this.infoLabel.AutoSize = true;
            this.infoLabel.Location = new System.Drawing.Point(31, 247);
            this.infoLabel.Name = "infoLabel";
            this.infoLabel.Size = new System.Drawing.Size(0, 17);
            this.infoLabel.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Niagara Engraved", 20F);
            this.label5.Location = new System.Drawing.Point(28, 47);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 36);
            this.label5.TabIndex = 10;
            this.label5.Text = "Registration";
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 433);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.infoLabel);
            this.Controls.Add(this.registerButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.passTB);
            this.Controls.Add(this.loginTB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lastnameTB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nameTB);
            this.Controls.Add(this.label1);
            this.Name = "Register";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registration";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nameTB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox lastnameTB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox loginTB;
        private System.Windows.Forms.TextBox passTB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button registerButton;
        private System.Windows.Forms.Label infoLabel;
        private System.Windows.Forms.Label label5;
    }
}