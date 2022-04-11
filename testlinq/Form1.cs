using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;

using System.Threading.Tasks;
using System.Windows.Forms;

namespace testlinq
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_can_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //NEK
    
        private void button_log_Click(object sender, EventArgs e)
        {

                if (string.IsNullOrEmpty(textBox_id.Text) || string.IsNullOrEmpty(textBox_pass.Text))
                {
                    MessageBox.Show("Please enter your pass and id", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBox_id.Select();
                    return ;
                }
            nhutestDataContext test = new nhutestDataContext();

            var t = Convert.ToInt32(textBox_id.Text);
            //var q = (from p in test.dangnhaps
            //             where p.ID == t && p.Pass == textBox_pass.Text select p).First();
            try
            {
                var q = test.dangnhaps.Where(user => user.ID == t && user.Pass == textBox_pass.Text).First();

                mainform MForm = new mainform();
                    //this.Hide();
                    //hoặc
                    this.Visible = false;
                    MForm.ShowDialog();
                    this.Close();
                
            }
            catch (Exception)
            {

                MessageBox.Show("Check your pass and id again", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox_id.Select();
                return;

            }
            

        }
    }
}
