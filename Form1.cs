using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Book
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }
            private void btnBooks_Click(object sender, EventArgs e)
            {
                Form2 form2 = new Form2();
                form2.ShowDialog();
            }

            private void btnInventory_Click(object sender, EventArgs e)
            {
                Form3 form3 = new Form3();
                form3.ShowDialog();
            }

            private void btnSearch_Click(object sender, EventArgs e)
            {
                Form4  form4 = new Form4();
                form4.ShowDialog();
            }

            private void btnExit_Click(object sender, EventArgs e)
            {
                DialogResult result = MessageBox.Show("Вы уверены, что хотите выйти?", "Выход",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                    Application.Exit();
            }
        
    }
}
    

