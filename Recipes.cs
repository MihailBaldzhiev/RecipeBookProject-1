using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Recipe.Data;
using Recipe.Models;

namespace Recipe
{
    public partial class Recipes : Form
    {
        private int lastLabelY = 10;
        private Dictionary<string, string> recipeData = new Dictionary<string, string>();
        private Panel recipePanel;

        private static RecipeContext recipeContext = new RecipeContext();
        RecipeLogic recipeLogic = new RecipeLogic(recipeContext);
        public Recipes()
        {
            InitializeComponent();

            tabControl2.SizeMode = TabSizeMode.Fixed;
            tabControl2.Multiline = false;
            recipePanel = new Panel
            {
                AutoScroll = true,
                Dock = DockStyle.Fill
            };

            // Add the Panel to the first TabPage
            tabPage2.Controls.Add(recipePanel);
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*string title = RecipeTitle.Text;
            string ingredients = Ingredients.Text;

            // Create a label for the recipe title.
            Label lblRecipeTitle = new Label
            {
                Text = title,
                AutoSize = true,
                TextAlign = ContentAlignment.MiddleCenter
            };

            // Position the label in the center of the first tab (tabPage1).
            int centerX = (tabPage1.Width - lblRecipeTitle.Width) / 2;
            int centerY = tabPage1.Controls.OfType<Label>().Count() * (lblRecipeTitle.Height + 5);
            lblRecipeTitle.Location = new Point(centerX, centerY);

            // Add the label to the first tab (tabPage1).
            tabPage1.Controls.Add(lblRecipeTitle);

            // Clear the input fields.
            RecipeTitle.Clear();
            Ingredients.Clear();*/
            //----------------------------------------------------------------------
            /*Label recipeLabel = new Label();
            recipeLabel.Text = RecipeTitle.Text;
            recipeLabel.AutoSize = true;
            recipeLabel.Location = new Point((tabPage1.Width - recipeLabel.Width) / 2, lastLabelY);

            // Add the Label to the first TabPage
            tabPage1.Controls.Add(recipeLabel);

            // Update the position for the next Label
            lastLabelY += recipeLabel.Height + 10;

            // Clear the TextBoxes
            RecipeTitle.Text = "";
            Ingredients.Text = "";

            // Set up a Click event for the newly created Label
            recipeLabel.Click += (labelSender, labelEventArgs) =>
            {
                // Redirect the user to the title and the ingredients
                tabControl1.SelectedIndex = 1;
                RecipeTitle.Text = recipeLabel.Text;

                // Here, you should load the ingredients associated with the recipe title.
                // You may need to store the ingredients in a Dictionary or another data structure.
            };*/
            //-----------------------------------------------------------------------
            /*Label recipeLabel = new Label();
            recipeLabel.Text = RecipeTitle.Text;
            recipeLabel.AutoSize = true;
            recipeLabel.Location = new Point((tabPage1.Width - recipeLabel.Width) / 2, lastLabelY);

            // Add the Label to the first TabPage
            tabPage1.Controls.Add(recipeLabel);

            // Update the position for the next Label
            lastLabelY += recipeLabel.Height + 10;

            // Store the recipe title and ingredients in the dictionary
            recipeData.Add(RecipeTitle.Text, Ingredients.Text);

            // Clear the TextBoxes
            RecipeTitle.Text = "";
            Ingredients.Text = "";

            // Set up a Click event for the newly created Label
            recipeLabel.Click += (labelSender, labelEventArgs) =>
            {
                // Create a new Form as a popup message
                Form popupForm = new Form();
                popupForm.Text = recipeLabel.Text;
                popupForm.Size = new Size(300, 300);
                popupForm.StartPosition = FormStartPosition.CenterParent;

                // Create a TextBox to display the ingredients
                TextBox ingredientsBox = new TextBox();
                ingredientsBox.Multiline = true;
                ingredientsBox.ReadOnly = true;
                ingredientsBox.Dock = DockStyle.Fill;
                ingredientsBox.Text = recipeData[recipeLabel.Text];

                // Add the TextBox to the popup Form
                popupForm.Controls.Add(ingredientsBox);

                // Show the popup Form
                popupForm.Show();
            };*/
            // Create a new Label and set its properties
            Label recipeLabel = new Label();
            recipeLabel.Text = RecipeTitle.Text;
            recipeLabel.AutoSize = true;
            recipeLabel.Location = new Point(10, lastLabelY);


            // Add the Label to the Panel in the first TabPage
            recipePanel.Controls.Add(recipeLabel);

            // Update the position for the next Label
            lastLabelY += recipeLabel.Height + 10;

            // Store the recipe title and ingredients in the dictionary
            //recipeData.Add(RecipeTitle.Text, Instructions.Text);


            // Clear the TextBoxes
            RecipeTitle.Text = "";
            Instructions.Text = "";
            TimeRequired.Text = "";

            // Set up a Click event for the newly created Label
            recipeLabel.Click += (labelSender, labelEventArgs) =>
            {
                // Create a new Form as a popup message
                Form popupForm = new Form();
                popupForm.Text = "Recipe Details";
                popupForm.Size = new Size(400, 400);
                popupForm.StartPosition = FormStartPosition.CenterParent;

                // Create a Label for the recipe title
                Label titleLabel = new Label();
                titleLabel.Text = "Title:";
                titleLabel.AutoSize = true;
                titleLabel.Location = new Point(10, 10);

                // Create a Label to display the recipe title
                Label titleValueLabel = new Label();
                titleValueLabel.Text = recipeLabel.Text;
                titleValueLabel.AutoSize = true;
                titleValueLabel.Location = new Point(40, 10);

                // Create a Label for the ingredients
                Label ingredientsLabel = new Label();
                ingredientsLabel.Text = "Instructions:";
                ingredientsLabel.AutoSize = true;
                ingredientsLabel.Location = new Point(10, 40);

                Label timeRequiredLabel = new Label();
                timeRequiredLabel.Text = "Time Required:";
                timeRequiredLabel.AutoSize = true;
                timeRequiredLabel.Location = new Point(250, 10);

                //timeRequiredValue.Text needs to be fixed
                Label timeRequiredValueLabel = new Label();
                timeRequiredValueLabel.Text = "51";
                timeRequiredValueLabel.AutoSize = true;
                timeRequiredValueLabel.Location = new Point(340, 10);

                // Create a TextBox to display the ingredients
                TextBox ingredientsBox = new TextBox();
                ingredientsBox.Multiline = true;
                ingredientsBox.ReadOnly = true;
                ingredientsBox.Location = new Point(10, 70);
                ingredientsBox.Size = new Size(360, 280);
                ingredientsBox.Text = recipeData[recipeLabel.Text];

                // Add the Labels and TextBox to the popup Form
                popupForm.Controls.Add(titleLabel);
                popupForm.Controls.Add(titleValueLabel);
                popupForm.Controls.Add(ingredientsLabel);
                popupForm.Controls.Add(ingredientsBox);
                popupForm.Controls.Add(timeRequiredLabel);
                popupForm.Controls.Add(timeRequiredValueLabel);

                // Show the popup Form
                popupForm.Show();
            };
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click_1(object sender, EventArgs e)
        {

        }

        private void RecipeTitle_TextChanged(object sender, EventArgs e)
        {

        }

        private void TimeRequired_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnPublish_Click(object sender, EventArgs e)
        {
            RecipeModel recipe = new RecipeModel();
            recipe.Name = RecipeTitle.Text;
            recipe.TimeRequired = int.Parse(TimeRequired.Text);
            recipe.Instructions = Instructions.Text;
            //implement author functionality
            recipe.Author = "Not implemented!";
            recipeLogic.Add(recipe);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var recipes = recipeLogic.GetAll();

            if (recipes == null)
            {
                listBox1.Items.Add("No recipes.");
            }
            else
            {
                foreach (var item in recipes)
                {
                    listBox1.Items.Add(item.Id + item.Name + item.Author);
                }
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            var recipes = recipeLogic.GetAll();

            if (recipes == null)
            {
                listBox1.Items.Add("No recipes.");
            }
            else
            {
                foreach (var item in recipes)
                {
                    listBox1.Items.Add(item.Id + item.Name + item.Author);
                }
            }
        }
    }
}
