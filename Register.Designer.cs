namespace Recipe
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
            label6 = new Label();
            label5 = new Label();
            button2 = new Button();
            RegisterBtn = new Button();
            CheckbxShowPas = new CheckBox();
            txtComPassword = new TextBox();
            label4 = new Label();
            txtPassword = new TextBox();
            label3 = new Label();
            txtUsername = new TextBox();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Cursor = Cursors.Hand;
            label6.ForeColor = Color.FromArgb(0, 192, 192);
            label6.Location = new Point(92, 470);
            label6.Name = "label6";
            label6.Size = new Size(97, 17);
            label6.TabIndex = 32;
            label6.Text = "Back to LOGIN";
            label6.Click += label6_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = SystemColors.ButtonShadow;
            label5.Location = new Point(60, 447);
            label5.Name = "label5";
            label5.Size = new Size(163, 17);
            label5.TabIndex = 33;
            label5.Text = "Already Have an Account";
            // 
            // button2
            // 
            button2.BackColor = Color.White;
            button2.Cursor = Cursors.Hand;
            button2.FlatStyle = FlatStyle.Flat;
            button2.ForeColor = Color.FromArgb(0, 192, 192);
            button2.Location = new Point(34, 397);
            button2.Name = "button2";
            button2.Size = new Size(216, 35);
            button2.TabIndex = 30;
            button2.Text = "CLEAR";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // RegisterBtn
            // 
            RegisterBtn.BackColor = Color.FromArgb(0, 192, 192);
            RegisterBtn.Cursor = Cursors.Hand;
            RegisterBtn.FlatAppearance.BorderSize = 0;
            RegisterBtn.FlatStyle = FlatStyle.Flat;
            RegisterBtn.ForeColor = Color.White;
            RegisterBtn.Location = new Point(34, 343);
            RegisterBtn.Name = "RegisterBtn";
            RegisterBtn.Size = new Size(216, 35);
            RegisterBtn.TabIndex = 31;
            RegisterBtn.Text = "REGISTER";
            RegisterBtn.UseVisualStyleBackColor = false;
            RegisterBtn.Click += RegisterBtn_Click;
            // 
            // CheckbxShowPas
            // 
            CheckbxShowPas.AutoSize = true;
            CheckbxShowPas.Cursor = Cursors.Hand;
            CheckbxShowPas.FlatStyle = FlatStyle.Flat;
            CheckbxShowPas.ForeColor = SystemColors.ButtonShadow;
            CheckbxShowPas.Location = new Point(128, 288);
            CheckbxShowPas.Name = "CheckbxShowPas";
            CheckbxShowPas.Size = new Size(119, 21);
            CheckbxShowPas.TabIndex = 29;
            CheckbxShowPas.Text = "Show Password";
            CheckbxShowPas.UseVisualStyleBackColor = true;
            CheckbxShowPas.CheckedChanged += CheckbxShowPas_CheckedChanged;
            // 
            // txtComPassword
            // 
            txtComPassword.BackColor = Color.FromArgb(230, 231, 233);
            txtComPassword.BorderStyle = BorderStyle.None;
            txtComPassword.Font = new Font("MS Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtComPassword.Location = new Point(34, 254);
            txtComPassword.Multiline = true;
            txtComPassword.Name = "txtComPassword";
            txtComPassword.PasswordChar = '*';
            txtComPassword.Size = new Size(216, 28);
            txtComPassword.TabIndex = 28;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = SystemColors.ButtonShadow;
            label4.Location = new Point(34, 234);
            label4.Name = "label4";
            label4.Size = new Size(120, 17);
            label4.TabIndex = 27;
            label4.Text = "Confirm Password";
            // 
            // txtPassword
            // 
            txtPassword.BackColor = Color.FromArgb(230, 231, 233);
            txtPassword.BorderStyle = BorderStyle.None;
            txtPassword.Font = new Font("MS Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtPassword.Location = new Point(34, 189);
            txtPassword.Multiline = true;
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(216, 28);
            txtPassword.TabIndex = 26;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = SystemColors.ButtonShadow;
            label3.Location = new Point(34, 169);
            label3.Name = "label3";
            label3.Size = new Size(66, 17);
            label3.TabIndex = 25;
            label3.Text = "Password";
            // 
            // txtUsername
            // 
            txtUsername.BackColor = Color.FromArgb(230, 231, 233);
            txtUsername.BorderStyle = BorderStyle.None;
            txtUsername.Font = new Font("MS Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtUsername.Location = new Point(34, 124);
            txtUsername.Multiline = true;
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(216, 28);
            txtUsername.TabIndex = 24;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.ButtonShadow;
            label2.Location = new Point(34, 104);
            label2.Name = "label2";
            label2.Size = new Size(69, 17);
            label2.TabIndex = 23;
            label2.Text = "Username";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("MS UI Gothic", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(0, 192, 192);
            label1.Location = new Point(81, 51);
            label1.Name = "label1";
            label1.Size = new Size(102, 27);
            label1.TabIndex = 22;
            label1.Text = "Sign up";
            // 
            // Register
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.EnablePreventFocusChange;
            BackColor = Color.White;
            ClientSize = new Size(285, 544);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(button2);
            Controls.Add(RegisterBtn);
            Controls.Add(CheckbxShowPas);
            Controls.Add(txtComPassword);
            Controls.Add(label4);
            Controls.Add(txtPassword);
            Controls.Add(label3);
            Controls.Add(txtUsername);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            ForeColor = SystemColors.ButtonShadow;
            FormBorderStyle = FormBorderStyle.None;
            Name = "Register";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmRegister";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label6;
        private Label label5;
        private Button button2;
        private Button RegisterBtn;
        private CheckBox CheckbxShowPas;
        private TextBox txtComPassword;
        private Label label4;
        private TextBox txtPassword;
        private Label label3;
        private TextBox txtUsername;
        private Label label2;
        private Label label1;
    }
}