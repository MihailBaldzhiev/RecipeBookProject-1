﻿using System;
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
using Recipe.Utils;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Recipe
{
    public partial class Recipes : Form
    {
        private Dictionary<string, string> recipeData = new Dictionary<string, string>();
        private Panel recipePanel;
        public Recipes(string username)
        {
            InitializeComponent();

            tabControl2.SizeMode = TabSizeMode.Fixed;
            tabControl2.Multiline = false;
            recipePanel = new Panel
            {
                AutoScroll = true,
                Dock = DockStyle.Fill
            };

            AccountUsername.Text = username;
            // Add the Panel to the first TabPage
            tabPage2.Controls.Add(recipePanel);
            Refresh();
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

        private void btnPublish_Click_1(object sender, EventArgs e)
        {
            bool result = RecipeService.Add(RecipeTitle.Text, TimeRequired.Text, AccountUsername.Text, Instructions.Text);
            if (result == false)
            {
                MessageBox.Show("Time Required must be a whole number", "Format Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                RecipeTitle.Text = "";
                Instructions.Text = "";
                TimeRequired.Text = "";
            }
            Refresh();
        }


        private void buttonRefresh_Click_1(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            var recipes = RecipeService.GetAll();

            if (recipes == null)
            {
                listBox1.Items.Add("No recipes.");
            }
            else
            {
                foreach (var item in recipes)
                {
                    listBox1.Items.Add(item.Name);
                }
            }
        }

        private void listBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            var recipes = RecipeService.GetAll();
            string recipeName = listBox1.GetItemText(listBox1.SelectedItem);
            if (recipes == null)
            {
                listBox1.Items.Add("No recipes.");
            }
            else
            {
                listBox1.Items.Clear();
                foreach (var item in recipes)
                {
                    listBox1.Items.Add(item.Name);
                }
            }

            RecipeModel selectedRecipe = RecipeService.Get(recipeName);
            Form popupForm = new Form();
            popupForm.Text = "Recipe Details";
            popupForm.Size = new Size(400, 430);
            popupForm.StartPosition = FormStartPosition.CenterParent;

            Label titleLabel = new Label();
            titleLabel.Text = "Title:";
            titleLabel.AutoSize = true;
            titleLabel.Location = new Point(10, 10);

            Label titleValueLabel = new Label();
            titleValueLabel.Text = selectedRecipe.Name;
            titleValueLabel.AutoSize = true;
            titleValueLabel.Location = new Point(40, 10);

            Label ingredientsLabel = new Label();
            ingredientsLabel.Text = "Instructions:";
            ingredientsLabel.AutoSize = true;
            ingredientsLabel.Location = new Point(10, 70);

            Label authorLabel = new Label();
            authorLabel.Text = "Author:";
            authorLabel.AutoSize = true;
            authorLabel.Location = new Point(10, 40);

            Label authorLabelValue = new Label();
            authorLabelValue.Text = selectedRecipe.Author;
            authorLabelValue.AutoSize = true;
            authorLabelValue.Location = new Point(60, 40);

            Label timeRequiredLabel = new Label();
            timeRequiredLabel.Text = "Time Required:";
            timeRequiredLabel.AutoSize = true;
            timeRequiredLabel.Location = new Point(230, 10);

            //timeRequiredValue.Text needs to be fixed
            Label timeRequiredValueLabel = new Label();
            timeRequiredValueLabel.Text = selectedRecipe.TimeRequired.ToString();
            timeRequiredValueLabel.AutoSize = true;
            timeRequiredValueLabel.Location = new Point(320, 10);

            // Create a TextBox to display the ingredients
            TextBox ingredientsBox = new TextBox();
            ingredientsBox.Multiline = true;
            ingredientsBox.ReadOnly = true;
            ingredientsBox.Location = new Point(10, 100);
            ingredientsBox.Size = new Size(360, 280);
            ingredientsBox.Text = selectedRecipe.Instructions;

            popupForm.Controls.Add(titleLabel);
            popupForm.Controls.Add(titleValueLabel);
            popupForm.Controls.Add(ingredientsLabel);
            popupForm.Controls.Add(ingredientsBox);
            popupForm.Controls.Add(timeRequiredLabel);
            popupForm.Controls.Add(timeRequiredValueLabel);
            popupForm.Controls.Add(authorLabel);
            popupForm.Controls.Add(authorLabelValue);

            if (AccountUsername.Text == "admin" || AccountUsername.Text == selectedRecipe.Author)
            {
                Button deleteRecipeButton = new Button();
                deleteRecipeButton.Text = "Delete Recipe";
                deleteRecipeButton.AutoSize = true;
                deleteRecipeButton.Location = new Point(150, 358);
                deleteRecipeButton.Click += DeleteRecipeButton_Click;
                popupForm.Controls.Add(deleteRecipeButton);
                popupForm.Show();
            }
            else
            {
                popupForm.Show();
            }
        }

        private void DeleteRecipeButton_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            Form form = button.FindForm();
            Label recipeLabel = (Label)form.Controls[1];
            RecipeModel recipe = RecipeService.Get(recipeLabel.Text);
            RecipeService.Delete(recipe.Id);
            form.Close();
            Refresh();
        }

        private void Refresh()
        {
            var recipes = RecipeService.GetAll();
            if (recipes == null)
            {
                listBox1.Items.Add("No recipes.");
            }
            else
            {
                listBox1.Items.Clear();
                foreach (var item in recipes)
                {
                    listBox1.Items.Add(item.Name);
                }
            }
        }

        private void AccountUsername_Click(object sender, EventArgs e)
        {
        }
    }
}
