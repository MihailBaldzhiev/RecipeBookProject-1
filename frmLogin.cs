using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Recipe.Models;
using Recipe.Data;

namespace Recipe
{
    public partial class frmLogin : Form
    {
        //SqlConnection connection = new SqlConnection("database = RecipeDB");
        //SqlCommand command = new SqlCommand();
        //SqlDataAdapter data = new SqlDataAdapter();
	
	private static UserContext userContext = new UserContext();
	UserLogic userLogic = new UserLogic(userContext);

		
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {
        }

        private void label6_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void CheckbxShowPas_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
        }

        private void label3_Click(object sender, EventArgs e)
        {
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            //connection.Open();
            //string login = "SELECT * FROM users WHERE username = '" + txtUsername.Text + "' AND password = '" + txtPassword.Text + "'";
            //command = new SqlCommand(login, connection);
            //SqlDataReader dataReader = command.ExecuteReader();

	    bool success = userLogic.CheckIfExists(txtUsername.Text, txtPassword.Text);
	

            if (success == true)
            {
                new Recipes().Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid Username or Password", "Login Failed",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUsername.Text = "";
                txtPassword.Text = "";
                txtUsername.Focus();
            }

        }

        private void CheckbxShowPas_CheckedChanged_1(object sender, EventArgs e)
        {
            if (CheckbxShowPas.Checked)
            {
                txtPassword.PasswordChar = '\0';
            }
            else
            {
                txtPassword.PasswordChar = '*';
            }

        }

        private void label6_Click_1(object sender, EventArgs e)
        {
            new frmRegister().Show();
            this.Hide();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            txtUsername.Text = "";
            txtPassword.Text = "";
            txtUsername.Focus();

        }
    }
}
