using _4thsemprj1.forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dapper;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Crypto.Generators;
using _4thsemprj1.Models;
using Org.BouncyCastle.Utilities.Collections;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace _4thsemprj1
{
    public partial class Loginform : Form
    {
        public Loginform()
        {
            InitializeComponent();
            Load += Form1_Load1;
        }

        private void Form1_Load1(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void logInbtn_Click(object sender, EventArgs e)
        {
            var password = pWordtxt.Text;
            var username = uNametxt.Text;

            //check if username and passsword has been input 
            if(string.IsNullOrEmpty(username))
            {
                MessageBox.Show("Please input username");
                return;
            }
            if (string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please input password");
                return;
            }

            //check from database
            if(IsUserPasswordSame(username, password))
            {
                var dashboard = new Dashboard();
                this.Hide();
                dashboard.ShowDialog();
                Show();
            }

            else
            {
                MessageBox.Show("Username/Password incorrect");
            }
        }

        private bool IsUserPasswordSame(string username, string password)
        {
            //get connection
            var conn = Connection.GetDbConnection();

            //define query
            var query = "SELECT * FROM login where UserName = @user_name";

            var user = conn.QueryFirstOrDefault<LoginModel>(query, new
            {
                user_name = username,
            });

            if (user == null)
            {
                return false;
            }
            else
            {
                if (BCrypt.Net.BCrypt.Verify(password, user.PassWord)) 
                {
                    return true;
                }
                else return false;
            }

        }

        private void registerbtn_Click(object sender, EventArgs e)
        {
            var username = uNametxt.Text;
            var password = pWordtxt.Text;

            var hashedPassword = BCrypt.Net.BCrypt.HashPassword(password);

            //get connection
            var conn = Connection.GetDbConnection();

            var userCountQuery = "SELECT count(*) FROM `login`;";

            var userCount = conn.QueryFirstOrDefault<int>(userCountQuery);

            if (userCount > 0)
            {
                MessageBox.Show("Multiple user registration not supported");
                uNametxt.Clear();
                pWordtxt.Clear();
                uNametxt.Focus();
                return;
                
            }




            //define query
            var query = "INSERT INTO `login` (`ID`, `UserName`, `PassWord`) VALUES (NULL, @user_name, @user_password);";

            //Execute query

            conn.Execute(query, new
            {
                user_name = username,
                user_password = hashedPassword,
            });
            MessageBox.Show("Registration Complete");

            uNametxt.Clear();
            pWordtxt.Clear();
            uNametxt.Focus();
        }
    }
}
