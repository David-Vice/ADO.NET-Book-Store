namespace ADO.NET_WinForm_HW1.ButtonForms
{
    partial class Book
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
            this.auhtorCB = new System.Windows.Forms.ComboBox();
            this.stationeryLabel = new System.Windows.Forms.Label();
            this.nameTB = new System.Windows.Forms.TextBox();
            this.typeLabel = new System.Windows.Forms.Label();
            this.yearLabel = new System.Windows.Forms.Label();
            this.yearTB = new System.Windows.Forms.TextBox();
            this.addButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.stockpriceTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.deleteButton = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.genreCB = new System.Windows.Forms.ComboBox();
            this.seriesCB = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pageLabel = new System.Windows.Forms.Label();
            this.pagesTB = new System.Windows.Forms.TextBox();
            this.sellpriceTB = new System.Windows.Forms.TextBox();
            this.quantTB = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // auhtorCB
            // 
            this.auhtorCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.auhtorCB.FormattingEnabled = true;
            this.auhtorCB.Location = new System.Drawing.Point(105, 109);
            this.auhtorCB.Name = "auhtorCB";
            this.auhtorCB.Size = new System.Drawing.Size(172, 24);
            this.auhtorCB.TabIndex = 0;
            // 
            // stationeryLabel
            // 
            this.stationeryLabel.AutoSize = true;
            this.stationeryLabel.Location = new System.Drawing.Point(12, 84);
            this.stationeryLabel.Name = "stationeryLabel";
            this.stationeryLabel.Size = new System.Drawing.Size(45, 17);
            this.stationeryLabel.TabIndex = 9;
            this.stationeryLabel.Text = "Name";
            // 
            // nameTB
            // 
            this.nameTB.Location = new System.Drawing.Point(105, 81);
            this.nameTB.Name = "nameTB";
            this.nameTB.Size = new System.Drawing.Size(172, 22);
            this.nameTB.TabIndex = 1;
            // 
            // typeLabel
            // 
            this.typeLabel.AutoSize = true;
            this.typeLabel.Location = new System.Drawing.Point(12, 112);
            this.typeLabel.Name = "typeLabel";
            this.typeLabel.Size = new System.Drawing.Size(50, 17);
            this.typeLabel.TabIndex = 11;
            this.typeLabel.Text = "Author";
            // 
            // yearLabel
            // 
            this.yearLabel.AutoSize = true;
            this.yearLabel.Location = new System.Drawing.Point(13, 230);
            this.yearLabel.Name = "yearLabel";
            this.yearLabel.Size = new System.Drawing.Size(38, 17);
            this.yearLabel.TabIndex = 12;
            this.yearLabel.Text = "Year";
            // 
            // yearTB
            // 
            this.yearTB.Location = new System.Drawing.Point(105, 227);
            this.yearTB.Name = "yearTB";
            this.yearTB.Size = new System.Drawing.Size(172, 22);
            this.yearTB.TabIndex = 2;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(202, 339);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 14;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(310, 9);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridView1.Size = new System.Drawing.Size(775, 304);
            this.dataGridView1.TabIndex = 15;
            // 
            // stockpriceTB
            // 
            this.stockpriceTB.Location = new System.Drawing.Point(105, 255);
            this.stockpriceTB.Name = "stockpriceTB";
            this.stockpriceTB.Size = new System.Drawing.Size(172, 22);
            this.stockpriceTB.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 258);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 17);
            this.label1.TabIndex = 17;
            this.label1.Text = "Stock Price";
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(1010, 348);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(75, 23);
            this.deleteButton.TabIndex = 22;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(1010, 319);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(75, 23);
            this.updateButton.TabIndex = 23;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(730, 322);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(264, 17);
            this.label3.TabIndex = 24;
            this.label3.Text = "Choose and Update each cell separately";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(730, 351);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(232, 17);
            this.label4.TabIndex = 25;
            this.label4.Text = "Choose one cell on Row to Delete it";
            // 
            // genreCB
            // 
            this.genreCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.genreCB.FormattingEnabled = true;
            this.genreCB.Location = new System.Drawing.Point(105, 139);
            this.genreCB.Name = "genreCB";
            this.genreCB.Size = new System.Drawing.Size(172, 24);
            this.genreCB.TabIndex = 26;
            // 
            // seriesCB
            // 
            this.seriesCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.seriesCB.FormattingEnabled = true;
            this.seriesCB.Location = new System.Drawing.Point(105, 169);
            this.seriesCB.Name = "seriesCB";
            this.seriesCB.Size = new System.Drawing.Size(172, 24);
            this.seriesCB.TabIndex = 27;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 17);
            this.label2.TabIndex = 28;
            this.label2.Text = "Genre";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 172);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 17);
            this.label5.TabIndex = 29;
            this.label5.Text = "Series";
            // 
            // pageLabel
            // 
            this.pageLabel.AutoSize = true;
            this.pageLabel.Location = new System.Drawing.Point(12, 202);
            this.pageLabel.Name = "pageLabel";
            this.pageLabel.Size = new System.Drawing.Size(48, 17);
            this.pageLabel.TabIndex = 30;
            this.pageLabel.Text = "Pages";
            // 
            // pagesTB
            // 
            this.pagesTB.Location = new System.Drawing.Point(105, 199);
            this.pagesTB.Name = "pagesTB";
            this.pagesTB.Size = new System.Drawing.Size(172, 22);
            this.pagesTB.TabIndex = 31;
            // 
            // sellpriceTB
            // 
            this.sellpriceTB.Location = new System.Drawing.Point(105, 283);
            this.sellpriceTB.Name = "sellpriceTB";
            this.sellpriceTB.Size = new System.Drawing.Size(172, 22);
            this.sellpriceTB.TabIndex = 33;
            // 
            // quantTB
            // 
            this.quantTB.Location = new System.Drawing.Point(105, 311);
            this.quantTB.Name = "quantTB";
            this.quantTB.Size = new System.Drawing.Size(172, 22);
            this.quantTB.TabIndex = 34;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 286);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 17);
            this.label6.TabIndex = 35;
            this.label6.Text = "Sell Price";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 314);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 17);
            this.label7.TabIndex = 36;
            this.label7.Text = "Quantity";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Mistral", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(13, 13);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(124, 30);
            this.label8.TabIndex = 37;
            this.label8.Text = "Manage Books";
            // 
            // Book
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1097, 383);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.quantTB);
            this.Controls.Add(this.sellpriceTB);
            this.Controls.Add(this.pagesTB);
            this.Controls.Add(this.pageLabel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.seriesCB);
            this.Controls.Add(this.genreCB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.stockpriceTB);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.yearTB);
            this.Controls.Add(this.yearLabel);
            this.Controls.Add(this.typeLabel);
            this.Controls.Add(this.nameTB);
            this.Controls.Add(this.stationeryLabel);
            this.Controls.Add(this.auhtorCB);
            this.Name = "Book";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Books";
            this.Load += new System.EventHandler(this.Book_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox auhtorCB;
        private System.Windows.Forms.Label stationeryLabel;
        private System.Windows.Forms.TextBox nameTB;
        private System.Windows.Forms.Label typeLabel;
        private System.Windows.Forms.Label yearLabel;
        private System.Windows.Forms.TextBox yearTB;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox stockpriceTB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox genreCB;
        private System.Windows.Forms.ComboBox seriesCB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label pageLabel;
        private System.Windows.Forms.TextBox pagesTB;
        private System.Windows.Forms.TextBox sellpriceTB;
        private System.Windows.Forms.TextBox quantTB;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}