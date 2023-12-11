namespace RiceInventory
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            dataGridViewInventory = new DataGridView();
            txtItemName = new TextBox();
            txtQuantity = new TextBox();
            txtPrice = new TextBox();
            btnInsert = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnRetrieve = new Button();
            button1 = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewInventory).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewInventory
            // 
            dataGridViewInventory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewInventory.Location = new Point(201, 81);
            dataGridViewInventory.Name = "dataGridViewInventory";
            dataGridViewInventory.RowTemplate.Height = 25;
            dataGridViewInventory.Size = new Size(427, 231);
            dataGridViewInventory.TabIndex = 0;
            // 
            // txtItemName
            // 
            txtItemName.Location = new Point(32, 81);
            txtItemName.Name = "txtItemName";
            txtItemName.Size = new Size(100, 23);
            txtItemName.TabIndex = 1;
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(32, 148);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(100, 23);
            txtQuantity.TabIndex = 2;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(32, 215);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(100, 23);
            txtPrice.TabIndex = 3;
            // 
            // btnInsert
            // 
            btnInsert.BackColor = Color.Transparent;
            btnInsert.FlatStyle = FlatStyle.Flat;
            btnInsert.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnInsert.Location = new Point(201, 343);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(75, 23);
            btnInsert.TabIndex = 4;
            btnInsert.Text = "Insert";
            btnInsert.UseVisualStyleBackColor = false;
            btnInsert.Click += btnInsert_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.Transparent;
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnUpdate.Location = new Point(314, 343);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(75, 23);
            btnUpdate.TabIndex = 5;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Transparent;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnDelete.Location = new Point(415, 343);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 6;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnRetrieve
            // 
            btnRetrieve.BackColor = Color.Transparent;
            btnRetrieve.FlatStyle = FlatStyle.Flat;
            btnRetrieve.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnRetrieve.Location = new Point(518, 343);
            btnRetrieve.Name = "btnRetrieve";
            btnRetrieve.Size = new Size(75, 23);
            btnRetrieve.TabIndex = 7;
            btnRetrieve.Text = "Retrieve";
            btnRetrieve.UseVisualStyleBackColor = false;
            btnRetrieve.Click += btnRetrieve_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(687, 19);
            button1.Name = "button1";
            button1.Size = new Size(83, 26);
            button1.TabIndex = 8;
            button1.Text = "Back";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(32, 130);
            label2.Name = "label2";
            label2.Size = new Size(59, 17);
            label2.TabIndex = 10;
            label2.Text = "Quantity";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(32, 197);
            label3.Name = "label3";
            label3.Size = new Size(38, 17);
            label3.TabIndex = 11;
            label3.Text = "Price";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Century Gothic", 25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(260, 19);
            label4.Name = "label4";
            label4.Size = new Size(284, 40);
            label4.TabIndex = 12;
            label4.Text = "RICE INVENTORY";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(32, 63);
            label1.Name = "label1";
            label1.Size = new Size(74, 17);
            label1.TabIndex = 9;
            label1.Text = "Item Name";
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.for3;
            ClientSize = new Size(800, 450);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(btnRetrieve);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnInsert);
            Controls.Add(txtPrice);
            Controls.Add(txtQuantity);
            Controls.Add(txtItemName);
            Controls.Add(dataGridViewInventory);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form3";
            Text = "Inventory";
            ((System.ComponentModel.ISupportInitialize)dataGridViewInventory).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewInventory;
        private TextBox txtItemName;
        private TextBox txtQuantity;
        private TextBox txtPrice;
        private Button btnInsert;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnRetrieve;
        private Button button1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label1;
    }
}