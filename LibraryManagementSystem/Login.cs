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

namespace LibraryManagementSystem
{
    public partial class Login : Form
    {
        string path = "Data Source=SUFIYAAN;Initial Catalog=books;Integrated Security=True";
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter adpt;
        public Login()
        {
            InitializeComponent();
            con = new SqlConnection(path);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if(txtUName.Text=="" && txtPassword.Text == "")
                {

                }
                else
                {
                    cmd = new SqlCommand("select * from LoginUsers where Username=@Name and Pass=@Pass", con);
                    cmd.Parameters.Add("@Name", txtUName.Text);
                    cmd.Parameters.Add("@Pass", txtPassword.Text);
                    adpt = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    adpt.Fill(ds);

                    int count = ds.Tables[0].Rows.Count;
                    if (count == 1)
                    {
                        MessageBox.Show("You have successfully logged in");
                        Form1 form = new Form1();
                        this.Hide();
                        form.Show();
                    }
                    else
                    {
                        MessageBox.Show("Wrond Username or Password");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
