namespace ADO.NET_WinForm_HW1.ButtonForms
{
    partial class Sell
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
            this.bookLabel = new System.Windows.Forms.Label();
            this.bookCB = new System.Windows.Forms.ComboBox();
            this.priceLabel = new System.Windows.Forms.Label();
            this.quantLabel = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.quantTB = new System.Windows.Forms.TextBox();
            this.totalLabel = new System.Windows.Forms.Label();
            this.totalNumLabel = new System.Windows.Forms.Label();
            this.stockNumLabel = new System.Windows.Forms.Label();
            this.quantNumLabel = new System.Windows.Forms.Label();
            this.sellButton = new System.Windows.Forms.Button();
            this.sellNumLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // bookLabel
            // 
            this.bookLabel.AutoSize = true;
            this.bookLabel.Location = new System.Drawing.Point(16, 59);
            this.bookLabel.Name = "bookLabel";
            this.bookLabel.Size = new System.Drawing.Size(40, 17);
            this.bookLabel.TabIndex = 12;
            this.bookLabel.Text = "Book";
            // 
            // bookCB
            // 
            this.bookCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.bookCB.FormattingEnabled = true;
            this.bookCB.Location = new System.Drawing.Point(90, 59);
            this.bookCB.Name = "bookCB";
            this.bookCB.Size = new System.Drawing.Size(206, 24);
            this.bookCB.TabIndex = 13;
            this.bookCB.SelectedIndexChanged += new System.EventHandler(this.productCB_SelectedIndexChanged);
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Location = new System.Drawing.Point(87, 86);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(79, 17);
            this.priceLabel.TabIndex = 14;
            this.priceLabel.Text = "StockPrice:";
            // 
            // quantLabel
            // 
            this.quantLabel.AutoSize = true;
            this.quantLabel.Location = new System.Drawing.Point(87, 120);
            this.quantLabel.Name = "quantLabel";
            this.quantLabel.Size = new System.Drawing.Size(62, 17);
            this.quantLabel.TabIndex = 15;
            this.quantLabel.Text = "In Stock:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(344, 13);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1138, 402);
            this.dataGridView1.TabIndex = 20;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(20, 153);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 17);
            this.label8.TabIndex = 23;
            this.label8.Text = "Quantity";
            // 
            // quantTB
            // 
            this.quantTB.Location = new System.Drawing.Point(90, 151);
            this.quantTB.Name = "quantTB";
            this.quantTB.Size = new System.Drawing.Size(85, 22);
            this.quantTB.TabIndex = 24;
            this.quantTB.TextChanged += new System.EventHandler(this.quantTB_TextChanged);
            // 
            // totalLabel
            // 
            this.totalLabel.AutoSize = true;
            this.totalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalLabel.Location = new System.Drawing.Point(14, 386);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(76, 29);
            this.totalLabel.TabIndex = 25;
            this.totalLabel.Text = "Total:";
            // 
            // totalNumLabel
            // 
            this.totalNumLabel.AutoSize = true;
            this.totalNumLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalNumLabel.Location = new System.Drawing.Point(96, 386);
            this.totalNumLabel.Name = "totalNumLabel";
            this.totalNumLabel.Size = new System.Drawing.Size(27, 29);
            this.totalNumLabel.TabIndex = 26;
            this.totalNumLabel.Text = "0";
            // 
            // stockNumLabel
            // 
            this.stockNumLabel.AutoSize = true;
            this.stockNumLabel.Location = new System.Drawing.Point(172, 86);
            this.stockNumLabel.Name = "stockNumLabel";
            this.stockNumLabel.Size = new System.Drawing.Size(16, 17);
            this.stockNumLabel.TabIndex = 27;
            this.stockNumLabel.Text = "0";
            // 
            // quantNumLabel
            // 
            this.quantNumLabel.AutoSize = true;
            this.quantNumLabel.Location = new System.Drawing.Point(172, 120);
            this.quantNumLabel.Name = "quantNumLabel";
            this.quantNumLabel.Size = new System.Drawing.Size(16, 17);
            this.quantNumLabel.TabIndex = 28;
            this.quantNumLabel.Text = "0";
            // 
            // sellButton
            // 
            this.sellButton.Location = new System.Drawing.Point(251, 381);
            this.sellButton.Name = "sellButton";
            this.sellButton.Size = new System.Drawing.Size(87, 34);
            this.sellButton.TabIndex = 29;
            this.sellButton.Text = "Sell";
            this.sellButton.UseVisualStyleBackColor = true;
            this.sellButton.Click += new System.EventHandler(this.sellButton_Click);
            // 
            // sellNumLabel
            // 
            this.sellNumLabel.AutoSize = true;
            this.sellNumLabel.Location = new System.Drawing.Point(172, 103);
            this.sellNumLabel.Name = "sellNumLabel";
            this.sellNumLabel.Size = new System.Drawing.Size(16, 17);
            this.sellNumLabel.TabIndex = 31;
            this.sellNumLabel.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(87, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 17);
            this.label3.TabIndex = 30;
            this.label3.Text = "SellPrice:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Mistral", 15F);
            this.label2.Location = new System.Drawing.Point(14, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 30);
            this.label2.TabIndex = 33;
            this.label2.Text = "Sell Books";
            // 
            // Sell
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1494, 427);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.sellNumLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.sellButton);
            this.Controls.Add(this.quantNumLabel);
            this.Controls.Add(this.stockNumLabel);
            this.Controls.Add(this.totalNumLabel);
            this.Controls.Add(this.totalLabel);
            this.Controls.Add(this.quantTB);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.quantLabel);
            this.Controls.Add(this.priceLabel);
            this.Controls.Add(this.bookCB);
            this.Controls.Add(this.bookLabel);
            this.Name = "Sell";
            this.Text = "Sell Books";
            this.Load += new System.EventHandler(this.MakeSell_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label bookLabel;
        private System.Windows.Forms.ComboBox bookCB;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.Label quantLabel;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox quantTB;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.Label totalNumLabel;
        private System.Windows.Forms.Label stockNumLabel;
        private System.Windows.Forms.Label quantNumLabel;
        private System.Windows.Forms.Button sellButton;
        private System.Windows.Forms.Label sellNumLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}