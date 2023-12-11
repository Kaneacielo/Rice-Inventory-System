namespace RiceInventory
{
    partial class Form4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            dataGridViewRecords = new DataGridView();
            button1 = new Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewRecords).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewRecords
            // 
            dataGridViewRecords.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewRecords.Location = new Point(193, 87);
            dataGridViewRecords.Name = "dataGridViewRecords";
            dataGridViewRecords.RowTemplate.Height = 25;
            dataGridViewRecords.Size = new Size(419, 225);
            dataGridViewRecords.TabIndex = 0;
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(692, 26);
            button1.Name = "button1";
            button1.Size = new Size(75, 40);
            button1.TabIndex = 1;
            button1.Text = "BACK";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Century Gothic", 25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(318, 26);
            label1.Name = "label1";
            label1.Size = new Size(177, 40);
            label1.TabIndex = 2;
            label1.Text = "RECORDS";
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.for4;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(dataGridViewRecords);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form4";
            Text = "Records";
            ((System.ComponentModel.ISupportInitialize)dataGridViewRecords).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewRecords;
        private Button button1;
        private Label label1;
    }
}