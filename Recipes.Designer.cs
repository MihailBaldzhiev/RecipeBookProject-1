namespace Recipe
{
    partial class Recipes
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
            AccountUsername = new Label();
            tabPage3 = new TabPage();
            listBox1 = new ListBox();
            buttonRefresh = new Button();
            tabPage2 = new TabPage();
            label4 = new Label();
            TimeRequired = new TextBox();
            Instructions = new TextBox();
            RecipeTitle = new TextBox();
            label3 = new Label();
            label2 = new Label();
            btnPublish = new Button();
            label1 = new Label();
            tabControl2 = new TabControl();
            tabPage3.SuspendLayout();
            tabPage2.SuspendLayout();
            tabControl2.SuspendLayout();
            SuspendLayout();
            // 
            // AccountUsername
            // 
            AccountUsername.AutoSize = true;
            AccountUsername.Location = new Point(312, 6);
            AccountUsername.Name = "AccountUsername";
            AccountUsername.Size = new Size(38, 15);
            AccountUsername.TabIndex = 1;
            AccountUsername.Text = "label3";
            AccountUsername.Click += AccountUsername_Click;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(listBox1);
            tabPage3.Controls.Add(buttonRefresh);
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(349, 538);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Home";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(5, 6);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(340, 499);
            listBox1.TabIndex = 2;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged_1;
            // 
            // buttonRefresh
            // 
            buttonRefresh.BackColor = Color.FromArgb(0, 192, 192);
            buttonRefresh.FlatAppearance.BorderSize = 0;
            buttonRefresh.Font = new Font("Segoe UI Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            buttonRefresh.ForeColor = Color.White;
            buttonRefresh.Location = new Point(135, 509);
            buttonRefresh.Name = "buttonRefresh";
            buttonRefresh.Size = new Size(75, 23);
            buttonRefresh.TabIndex = 1;
            buttonRefresh.Text = "Refresh";
            buttonRefresh.UseVisualStyleBackColor = false;
            buttonRefresh.Click += buttonRefresh_Click_1;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(label4);
            tabPage2.Controls.Add(TimeRequired);
            tabPage2.Controls.Add(Instructions);
            tabPage2.Controls.Add(RecipeTitle);
            tabPage2.Controls.Add(label3);
            tabPage2.Controls.Add(label2);
            tabPage2.Controls.Add(btnPublish);
            tabPage2.Controls.Add(label1);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(349, 538);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Add Recipe";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(315, 38);
            label4.Name = "label4";
            label4.Size = new Size(28, 15);
            label4.TabIndex = 7;
            label4.Text = "min";
            // 
            // TimeRequired
            // 
            TimeRequired.Location = new Point(240, 28);
            TimeRequired.Multiline = true;
            TimeRequired.Name = "TimeRequired";
            TimeRequired.Size = new Size(74, 25);
            TimeRequired.TabIndex = 6;
            // 
            // Instructions
            // 
            Instructions.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            Instructions.Location = new Point(18, 81);
            Instructions.Multiline = true;
            Instructions.Name = "Instructions";
            Instructions.Size = new Size(314, 401);
            Instructions.TabIndex = 1;
            // 
            // RecipeTitle
            // 
            RecipeTitle.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            RecipeTitle.Location = new Point(18, 28);
            RecipeTitle.Name = "RecipeTitle";
            RecipeTitle.Size = new Size(209, 25);
            RecipeTitle.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.White;
            label3.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(0, 192, 192);
            label3.Location = new Point(240, 10);
            label3.Name = "label3";
            label3.Size = new Size(99, 15);
            label3.TabIndex = 5;
            label3.Text = "Time Required:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(0, 192, 192);
            label2.Location = new Point(18, 63);
            label2.Name = "label2";
            label2.Size = new Size(84, 15);
            label2.TabIndex = 4;
            label2.Text = "Instructions:";
            // 
            // btnPublish
            // 
            btnPublish.BackColor = Color.FromArgb(0, 192, 192);
            btnPublish.Cursor = Cursors.Hand;
            btnPublish.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnPublish.ForeColor = Color.White;
            btnPublish.Location = new Point(121, 488);
            btnPublish.Name = "btnPublish";
            btnPublish.Size = new Size(106, 32);
            btnPublish.TabIndex = 3;
            btnPublish.Text = "Publish";
            btnPublish.UseVisualStyleBackColor = false;
            btnPublish.Click += btnPublish_Click_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(0, 192, 192);
            label1.Location = new Point(18, 10);
            label1.Name = "label1";
            label1.Size = new Size(82, 15);
            label1.TabIndex = 2;
            label1.Text = "Recipe Title:";
            // 
            // tabControl2
            // 
            tabControl2.Controls.Add(tabPage2);
            tabControl2.Controls.Add(tabPage3);
            tabControl2.Location = new Point(0, 0);
            tabControl2.Name = "tabControl2";
            tabControl2.SelectedIndex = 0;
            tabControl2.Size = new Size(357, 566);
            tabControl2.TabIndex = 0;
            // 
            // Recipes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(361, 569);
            Controls.Add(AccountUsername);
            Controls.Add(tabControl2);
            Name = "Recipes";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Recipes";
            tabPage3.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            tabControl2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label AccountUsername;
        private TabPage tabPage3;
        private Button buttonRefresh;
        private TabPage tabPage2;
        private Label label4;
        private TextBox TimeRequired;
        private TextBox Instructions;
        private TextBox RecipeTitle;
        private Label label3;
        private Label label2;
        private Button btnPublish;
        private Label label1;
        private TabControl tabControl2;
        private ListBox listBox1;
    }
}