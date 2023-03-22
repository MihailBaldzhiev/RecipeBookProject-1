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
            components = new System.ComponentModel.Container();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            label4 = new Label();
            TimeRequired = new TextBox();
            label3 = new Label();
            label2 = new Label();
            btnPublish = new Button();
            label1 = new Label();
            Instructions = new TextBox();
            RecipeTitle = new TextBox();
            imageList1 = new ImageList(components);
            AccountUsername = new Label();
            tabControl1.SuspendLayout();
            tabPage2.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(357, 566);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = Color.White;
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(349, 538);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Home";
            tabPage1.Click += tabPage1_Click;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(label4);
            tabPage2.Controls.Add(TimeRequired);
            tabPage2.Controls.Add(label3);
            tabPage2.Controls.Add(label2);
            tabPage2.Controls.Add(btnPublish);
            tabPage2.Controls.Add(label1);
            tabPage2.Controls.Add(Instructions);
            tabPage2.Controls.Add(RecipeTitle);
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
            label3.Click += label3_Click_1;
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
            label2.Click += label2_Click;
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
            btnPublish.Click += button1_Click;
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
            label1.Click += label1_Click_1;
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
            RecipeTitle.TextChanged += textBox1_TextChanged;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth8Bit;
            imageList1.ImageSize = new Size(16, 16);
            imageList1.TransparentColor = Color.Transparent;
            // 
            // AccountUsername
            // 
            AccountUsername.AutoSize = true;
            AccountUsername.Location = new Point(312, 6);
            AccountUsername.Name = "AccountUsername";
            AccountUsername.Size = new Size(38, 15);
            AccountUsername.TabIndex = 1;
            AccountUsername.Text = "label3";
            AccountUsername.Click += label3_Click;
            // 
            // Recipes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(361, 569);
            Controls.Add(AccountUsername);
            Controls.Add(tabControl1);
            Name = "Recipes";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Recipes";
            tabControl1.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage2;
        private TabPage tabPage1;
        private ImageList imageList1;
        private Label label1;
        private TextBox Instructions;
        private TextBox RecipeTitle;
        private Button btnPublish;
        private Label label2;
        private Label AccountUsername;
        private TextBox TimeRequired;
        private Label label3;
        private Label label4;
    }
}