namespace ADO.NET_WinForm_HW1.ButtonForms
{
    partial class Aside
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
            this.bookCB = new System.Windows.Forms.ComboBox();
            this.typeLabel = new System.Windows.Forms.Label();
            this.addButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.deleteButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.buyerCB = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.quantTB = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.quantNumLabel = new System.Windows.Forms.Label();
            this.quantLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // bookCB
            // 
            this.bookCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.bookCB.FormattingEnabled = true;
            this.bookCB.Location = new System.Drawing.Point(106, 84);
            this.bookCB.Name = "bookCB";
            this.bookCB.Size = new System.Drawing.Size(172, 24);
            this.bookCB.TabIndex = 0;
            this.bookCB.SelectedIndexChanged += new System.EventHandler(this.bookCB_SelectedIndexChanged);
            // 
            // typeLabel
            // 
            this.typeLabel.AutoSize = true;
            this.typeLabel.Location = new System.Drawing.Point(13, 87);
            this.typeLabel.Name = "typeLabel";
            this.typeLabel.Size = new System.Drawing.Size(40, 17);
            this.typeLabel.TabIndex = 11;
            this.typeLabel.Text = "Book";
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(203, 177);
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
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(1010, 319);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(75, 23);
            this.deleteButton.TabIndex = 22;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(756, 322);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(232, 17);
            this.label4.TabIndex = 25;
            this.label4.Text = "Choose one cell on Row to Delete it";
            // 
            // buyerCB
            // 
            this.buyerCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.buyerCB.FormattingEnabled = true;
            this.buyerCB.Location = new System.Drawing.Point(106, 54);
            this.buyerCB.Name = "buyerCB";
            this.buyerCB.Size = new System.Drawing.Size(172, 24);
            this.buyerCB.TabIndex = 26;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 17);
            this.label2.TabIndex = 28;
            this.label2.Text = "Buyer";
            // 
            // quantTB
            // 
            this.quantTB.Location = new System.Drawing.Point(106, 149);
            this.quantTB.Name = "quantTB";
            this.quantTB.Size = new System.Drawing.Size(172, 22);
            this.quantTB.TabIndex = 34;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 152);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 17);
            this.label7.TabIndex = 36;
            this.label7.Text = "Quantity";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Mistral", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(10, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(199, 30);
            this.label8.TabIndex = 37;
            this.label8.Text = "Set book aside for buyer";
            // 
            // quantNumLabel
            // 
            this.quantNumLabel.AutoSize = true;
            this.quantNumLabel.Location = new System.Drawing.Point(188, 111);
            this.quantNumLabel.Name = "quantNumLabel";
            this.quantNumLabel.Size = new System.Drawing.Size(16, 17);
            this.quantNumLabel.TabIndex = 41;
            this.quantNumLabel.Text = "0";
            // 
            // quantLabel
            // 
            this.quantLabel.AutoSize = true;
            this.quantLabel.Location = new System.Drawing.Point(103, 111);
            this.quantLabel.Name = "quantLabel";
            this.quantLabel.Size = new System.Drawing.Size(62, 17);
            this.quantLabel.TabIndex = 39;
            this.quantLabel.Text = "In Stock:";
            // 
            // Aside
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1097, 349);
            this.Controls.Add(this.quantNumLabel);
            this.Controls.Add(this.quantLabel);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.quantTB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buyerCB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.typeLabel);
            this.Controls.Add(this.bookCB);
            this.Name = "Aside";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Set Aside";
            this.Load += new System.EventHandler(this.Book_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox bookCB;
        private System.Windows.Forms.Label typeLabel;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox buyerCB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox quantTB;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label quantNumLabel;
        private System.Windows.Forms.Label quantLabel;
    }
}