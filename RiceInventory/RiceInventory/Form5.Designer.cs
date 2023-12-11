namespace RiceInventory
{
    partial class Form5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form5));
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            btnCreateAccount = new Button();
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(146, 97);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(159, 23);
            txtUsername.TabIndex = 0;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(145, 160);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(160, 23);
            txtPassword.TabIndex = 1;
            // 
            // btnCreateAccount
            // 
            btnCreateAccount.BackColor = Color.Transparent;
            btnCreateAccount.FlatStyle = FlatStyle.Flat;
            btnCreateAccount.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnCreateAccount.Location = new Point(51, 236);
            btnCreateAccount.Name = "btnCreateAccount";
            btnCreateAccount.Size = new Size(119, 32);
            btnCreateAccount.TabIndex = 2;
            btnCreateAccount.Text = "Create";
            btnCreateAccount.UseVisualStyleBackColor = false;
            btnCreateAccount.Click += btnCreateAccount_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(210, 236);
            button1.Name = "button1";
            button1.Size = new Size(114, 32);
            button1.TabIndex = 3;
            button1.Text = "Back to Login";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(40, 103);
            label1.Name = "label1";
            label1.Size = new Size(100, 17);
            label1.TabIndex = 4;
            label1.Text = "Enter Username";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(40, 160);
            label2.Name = "label2";
            label2.Size = new Size(96, 17);
            label2.TabIndex = 5;
            label2.Text = "Enter Password";
            // 
            // Form5
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.for_5;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(393, 377);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(btnCreateAccount);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form5";
            Text = "Create Account";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtUsername;
        private TextBox txtPassword;
        private Button btnCreateAccount;
        private Button button1;
        private Label label1;
        private Label label2;
    }
}