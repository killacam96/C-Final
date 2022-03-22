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
    public partial class DepositForm : Form
    {
        SQLQueries queries = new SQLQueries();
        public DepositForm()
        {
            InitializeComponent();
        }

        private void DepositBtn_Click(object sender, EventArgs e)
        {
            double amount = Convert.ToDouble(AmountBox.Text);
            try
            {
                queries.DepositInsert(amount, dateTimePicker1.Value, 2);
                MessageBox.Show("deposit captured");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
    }
}
