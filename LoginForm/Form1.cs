using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;




namespace LoginForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-OPNR2RB\SQLEXPRESS;Initial Catalog=AlexanderLasse;Integrated Security=True;Trust Server Certificate=True");
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button_Login_Click(object sender, EventArgs e)
        {
            String username, user_password;

            username = UserName.Text;

            user_password = Password.Text;

            try
            {
                String querry = "SELECT * FROM Login_New WHERE username = '" + UserName.Text + "' AND password = '" + Password.Text + "'";
                SqlDataAdapter sda = new SqlDataAdapter(querry, conn);

                DataTable dtable = new DataTable();
                sda.Fill(dtable);

                if (dtable.Rows.Count > 0)
                {

                    username = UserName.Text;

                    user_password = Password.Text;

                    // page thatneeded to be load next

                    Menu_Form form2 = new Menu_Form();
                    form2.Show();
                    this.Hide();
                }
                else
                {

                    MessageBox.Show("Invalid Login details", " Error ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    UserName.Clear();
                    Password.Clear();

                    // to focus username'

                    UserName.Focus();
                }

            }
            catch
            {
                MessageBox.Show("Invalid Login");
            }
            finally
            {
                conn.Close();
            }


        }

        private void button_Clear_Click(object sender, EventArgs e)
        {

            UserName.Clear();
            Password.Clear();
            UserName.Focus();

        }

        private void button_Exit_Click(object sender, EventArgs e)
        {
            DialogResult res;
            res = MessageBox.Show(" Do you want to exist", "Exist", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (res == DialogResult.Yes)
            {
                Application.Exit();

            }
            else 
            {

                this.Show();
            }


        }
    }
}
