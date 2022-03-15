using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C_Sharp_Final
{
    public partial class Form1 : Form
    {

        SQLQueries queries = new SQLQueries();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = new DataTable();
                dt = queries.IdentifierUser(usernameBox.Text, passwordBox.Text);

                if (dt.Rows.Count > 0)
                {
                    this.Hide();
                    MainForm startMain = new MainForm();
                    startMain.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Wrong Username or Password");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
