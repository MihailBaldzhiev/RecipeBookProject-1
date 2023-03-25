using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Recipe.Models;
using Recipe.Data;
using MySqlX.XDevAPI;
using Recipe.Utils;
using Session = Recipe.Utils.Session;

namespace Recipe
{
    public partial class Register : Form
    {
        //SqlConnection connection = new SqlConnection("database = RecipeDB");
        //SqlCommand command = new SqlCommand();
        //SqlDataAdapter data = new SqlDataAdapter();


        public Register()
        {
            InitializeComponent();
        }

        private void frmRegister_Load(object sender, EventArgs e)
        {

        }

        private void RegisterBtn_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "" && txtPassword.Text == "" && txtComPassword.Text == "")
            {
                MessageBox.Show("Username and Password fields are empty", "Sign Up failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtPassword.Text == txtComPassword.Text)
            {
                // connection.Open();
                //string register = "INSERT INTO users VALUES ('" + txtUsername + "', '" + txtPassword + "')";
                //command = new SqlCommand(register, connection);
                //command.ExecuteNonQuery();
                //connection.Close();

                UserModel user = new UserModel();
                user.Username = txtUsername.Text;
                user.Password = txtPassword.Text;
                UserService.AddUser(user);



                txtUsername.Text = "";
                txtPassword.Text = "";
                txtComPassword.Text = "";

                MessageBox.Show("Your Account has been Successfully Created", "Registration Successfull",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Passwords do not match", "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPassword.Text = "";
                txtComPassword.Text = "";   
                txtPassword.Focus();
            }
        }

        private void CheckbxShowPas_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckbxShowPas.Checked)
            {
                txtPassword.PasswordChar = '\0';
                txtComPassword.PasswordChar = '\0';
            }
            else
            {
                txtPassword.PasswordChar = '*';
                txtComPassword.PasswordChar = '*';
            }

        }

        private void label6_Click(object sender, EventArgs e)
        {
            new Login().Show();
            this.Hide();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtUsername.Text = "";
            txtPassword.Text = "";
            txtComPassword.Text = "";
            txtUsername.Focus();

        }
    }
}
