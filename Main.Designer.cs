namespace ADO.NET_WinForm_HW1
{
    partial class Main
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
            this.dataGV = new System.Windows.Forms.DataGridView();
            this.searchTB = new System.Windows.Forms.TextBox();
            this.runButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.authorButton = new System.Windows.Forms.Button();
            this.genreButton = new System.Windows.Forms.Button();
            this.seriesButton = new System.Windows.Forms.Button();
            this.buyerButton = new System.Windows.Forms.Button();
            this.bookButton = new System.Windows.Forms.Button();
            this.welcomeLabel = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.paramCB = new System.Windows.Forms.ComboBox();
            this.setAsideButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.manageButton = new System.Windows.Forms.Button();
            this.newNameTB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.newLastnameTB = new System.Windows.Forms.TextBox();
            this.applyName = new System.Windows.Forms.Button();
            this.applyLastname = new System.Windows.Forms.Button();
            this.applyPassword = new System.Windows.Forms.Button();
            this.applyUsername = new System.Windows.Forms.Button();
            this.newPassword = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.newUsername = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGV)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGV
            // 
            this.dataGV.AllowUserToAddRows = false;
            this.dataGV.AllowUserToDeleteRows = false;
            this.dataGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGV.Location = new System.Drawing.Point(223, 83);
            this.dataGV.Name = "dataGV";
            this.dataGV.ReadOnly = true;
            this.dataGV.RowHeadersWidth = 51;
            this.dataGV.RowTemplate.Height = 24;
            this.dataGV.Size = new System.Drawing.Size(760, 249);
            this.dataGV.TabIndex = 15;
            // 
            // searchTB
            // 
            this.searchTB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.searchTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.searchTB.Location = new System.Drawing.Point(567, 51);
            this.searchTB.Name = "searchTB";
            this.searchTB.Size = new System.Drawing.Size(285, 24);
            this.searchTB.TabIndex = 17;
            // 
            // runButton
            // 
            this.runButton.Location = new System.Drawing.Point(858, 49);
            this.runButton.Name = "runButton";
            this.runButton.Size = new System.Drawing.Size(59, 26);
            this.runButton.TabIndex = 18;
            this.runButton.Text = "Run";
            this.runButton.UseVisualStyleBackColor = true;
            this.runButton.Click += new System.EventHandler(this.runButton_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(923, 49);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(60, 26);
            this.button1.TabIndex = 19;
            this.button1.Text = "Clear";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // authorButton
            // 
            this.authorButton.Location = new System.Drawing.Point(12, 51);
            this.authorButton.Name = "authorButton";
            this.authorButton.Size = new System.Drawing.Size(204, 35);
            this.authorButton.TabIndex = 20;
            this.authorButton.Text = "Authors";
            this.authorButton.UseVisualStyleBackColor = true;
            this.authorButton.Click += new System.EventHandler(this.authorButton_Click);
            // 
            // genreButton
            // 
            this.genreButton.Location = new System.Drawing.Point(12, 92);
            this.genreButton.Name = "genreButton";
            this.genreButton.Size = new System.Drawing.Size(204, 35);
            this.genreButton.TabIndex = 21;
            this.genreButton.Text = "Genres";
            this.genreButton.UseVisualStyleBackColor = true;
            this.genreButton.Click += new System.EventHandler(this.genreButton_Click);
            // 
            // seriesButton
            // 
            this.seriesButton.Location = new System.Drawing.Point(12, 133);
            this.seriesButton.Name = "seriesButton";
            this.seriesButton.Size = new System.Drawing.Size(204, 35);
            this.seriesButton.TabIndex = 22;
            this.seriesButton.Text = "Series";
            this.seriesButton.UseVisualStyleBackColor = true;
            this.seriesButton.Click += new System.EventHandler(this.seriesButton_Click);
            // 
            // buyerButton
            // 
            this.buyerButton.Location = new System.Drawing.Point(12, 174);
            this.buyerButton.Name = "buyerButton";
            this.buyerButton.Size = new System.Drawing.Size(204, 35);
            this.buyerButton.TabIndex = 23;
            this.buyerButton.Text = "Buyers";
            this.buyerButton.UseVisualStyleBackColor = true;
            this.buyerButton.Click += new System.EventHandler(this.buyerButton_Click);
            // 
            // bookButton
            // 
            this.bookButton.Location = new System.Drawing.Point(12, 256);
            this.bookButton.Name = "bookButton";
            this.bookButton.Size = new System.Drawing.Size(204, 35);
            this.bookButton.TabIndex = 24;
            this.bookButton.Text = "Books";
            this.bookButton.UseVisualStyleBackColor = true;
            this.bookButton.Click += new System.EventHandler(this.bookButton_Click);
            // 
            // welcomeLabel
            // 
            this.welcomeLabel.AutoSize = true;
            this.welcomeLabel.Font = new System.Drawing.Font("MV Boli", 16.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomeLabel.Location = new System.Drawing.Point(12, 9);
            this.welcomeLabel.Name = "welcomeLabel";
            this.welcomeLabel.Size = new System.Drawing.Size(239, 37);
            this.welcomeLabel.TabIndex = 25;
            this.welcomeLabel.Text = "Welcome, Mister";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Lime;
            this.button2.Location = new System.Drawing.Point(12, 297);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(204, 35);
            this.button2.TabIndex = 26;
            this.button2.Text = "Sell";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label1.Location = new System.Drawing.Point(222, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 24);
            this.label1.TabIndex = 27;
            this.label1.Text = "Find book by:";
            // 
            // paramCB
            // 
            this.paramCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.paramCB.FormattingEnabled = true;
            this.paramCB.Items.AddRange(new object[] {
            "All",
            "Name",
            "Author",
            "Genre",
            "Series"});
            this.paramCB.Location = new System.Drawing.Point(353, 51);
            this.paramCB.Name = "paramCB";
            this.paramCB.Size = new System.Drawing.Size(208, 24);
            this.paramCB.TabIndex = 28;
            // 
            // setAsideButton
            // 
            this.setAsideButton.Location = new System.Drawing.Point(12, 215);
            this.setAsideButton.Name = "setAsideButton";
            this.setAsideButton.Size = new System.Drawing.Size(204, 35);
            this.setAsideButton.TabIndex = 29;
            this.setAsideButton.Text = "Set Aside";
            this.setAsideButton.UseVisualStyleBackColor = true;
            this.setAsideButton.Click += new System.EventHandler(this.setAsideButton_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.applyPassword);
            this.panel1.Controls.Add(this.applyUsername);
            this.panel1.Controls.Add(this.newPassword);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.newUsername);
            this.panel1.Controls.Add(this.applyLastname);
            this.panel1.Controls.Add(this.applyName);
            this.panel1.Controls.Add(this.newLastnameTB);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.newNameTB);
            this.panel1.Location = new System.Drawing.Point(223, 338);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(760, 123);
            this.panel1.TabIndex = 30;
            this.panel1.Visible = false;
            // 
            // manageButton
            // 
            this.manageButton.BackColor = System.Drawing.Color.Aqua;
            this.manageButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.manageButton.Location = new System.Drawing.Point(12, 426);
            this.manageButton.Name = "manageButton";
            this.manageButton.Size = new System.Drawing.Size(204, 35);
            this.manageButton.TabIndex = 31;
            this.manageButton.Text = "Manage Account";
            this.manageButton.UseVisualStyleBackColor = false;
            this.manageButton.Click += new System.EventHandler(this.manageButton_Click);
            // 
            // newNameTB
            // 
            this.newNameTB.Location = new System.Drawing.Point(164, 8);
            this.newNameTB.Name = "newNameTB";
            this.newNameTB.Size = new System.Drawing.Size(160, 22);
            this.newNameTB.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic);
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Change Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic);
            this.label3.Location = new System.Drawing.Point(12, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Change Lastname";
            // 
            // newLastnameTB
            // 
            this.newLastnameTB.Location = new System.Drawing.Point(164, 36);
            this.newLastnameTB.Name = "newLastnameTB";
            this.newLastnameTB.Size = new System.Drawing.Size(160, 22);
            this.newLastnameTB.TabIndex = 5;
            // 
            // applyName
            // 
            this.applyName.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F);
            this.applyName.Location = new System.Drawing.Point(330, 8);
            this.applyName.Name = "applyName";
            this.applyName.Size = new System.Drawing.Size(75, 23);
            this.applyName.TabIndex = 6;
            this.applyName.Text = "Apply";
            this.applyName.UseVisualStyleBackColor = true;
            this.applyName.Click += new System.EventHandler(this.applyName_Click);
            // 
            // applyLastname
            // 
            this.applyLastname.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F);
            this.applyLastname.Location = new System.Drawing.Point(330, 36);
            this.applyLastname.Name = "applyLastname";
            this.applyLastname.Size = new System.Drawing.Size(75, 23);
            this.applyLastname.TabIndex = 7;
            this.applyLastname.Text = "Apply";
            this.applyLastname.UseVisualStyleBackColor = true;
            this.applyLastname.Click += new System.EventHandler(this.applyLastname_Click);
            // 
            // applyPassword
            // 
            this.applyPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F);
            this.applyPassword.Location = new System.Drawing.Point(330, 92);
            this.applyPassword.Name = "applyPassword";
            this.applyPassword.Size = new System.Drawing.Size(75, 23);
            this.applyPassword.TabIndex = 13;
            this.applyPassword.Text = "Apply";
            this.applyPassword.UseVisualStyleBackColor = true;
            this.applyPassword.Click += new System.EventHandler(this.applyPassword_Click);
            // 
            // applyUsername
            // 
            this.applyUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F);
            this.applyUsername.Location = new System.Drawing.Point(330, 64);
            this.applyUsername.Name = "applyUsername";
            this.applyUsername.Size = new System.Drawing.Size(75, 23);
            this.applyUsername.TabIndex = 12;
            this.applyUsername.Text = "Apply";
            this.applyUsername.UseVisualStyleBackColor = true;
            this.applyUsername.Click += new System.EventHandler(this.applyUsername_Click);
            // 
            // newPassword
            // 
            this.newPassword.Location = new System.Drawing.Point(164, 92);
            this.newPassword.Name = "newPassword";
            this.newPassword.Size = new System.Drawing.Size(160, 22);
            this.newPassword.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic);
            this.label4.Location = new System.Drawing.Point(12, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 18);
            this.label4.TabIndex = 10;
            this.label4.Text = "Change Password";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic);
            this.label5.Location = new System.Drawing.Point(12, 65);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(132, 18);
            this.label5.TabIndex = 9;
            this.label5.Text = "Change Username";
            // 
            // newUsername
            // 
            this.newUsername.Location = new System.Drawing.Point(164, 64);
            this.newUsername.Name = "newUsername";
            this.newUsername.Size = new System.Drawing.Size(160, 22);
            this.newUsername.TabIndex = 8;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Red;
            this.button3.Location = new System.Drawing.Point(507, 37);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(149, 50);
            this.button3.TabIndex = 14;
            this.button3.Text = "Delete Account";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(463, 94);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(250, 20);
            this.label6.TabIndex = 15;
            this.label6.Text = "Relog after applied changes!";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(995, 467);
            this.Controls.Add(this.manageButton);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.setAsideButton);
            this.Controls.Add(this.paramCB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.welcomeLabel);
            this.Controls.Add(this.bookButton);
            this.Controls.Add(this.buyerButton);
            this.Controls.Add(this.seriesButton);
            this.Controls.Add(this.genreButton);
            this.Controls.Add(this.authorButton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.runButton);
            this.Controls.Add(this.searchTB);
            this.Controls.Add(this.dataGV);
            this.MaximumSize = new System.Drawing.Size(1013, 514);
            this.MinimumSize = new System.Drawing.Size(1013, 514);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Management";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGV)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGV;
        private System.Windows.Forms.TextBox searchTB;
        private System.Windows.Forms.Button runButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button authorButton;
        private System.Windows.Forms.Button genreButton;
        private System.Windows.Forms.Button seriesButton;
        private System.Windows.Forms.Button buyerButton;
        private System.Windows.Forms.Button bookButton;
        private System.Windows.Forms.Label welcomeLabel;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox paramCB;
        private System.Windows.Forms.Button setAsideButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button manageButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox newNameTB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox newLastnameTB;
        private System.Windows.Forms.Button applyName;
        private System.Windows.Forms.Button applyLastname;
        private System.Windows.Forms.Button applyUsername;
        private System.Windows.Forms.TextBox newPassword;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox newUsername;
        private System.Windows.Forms.Button applyPassword;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label6;
    }
}

