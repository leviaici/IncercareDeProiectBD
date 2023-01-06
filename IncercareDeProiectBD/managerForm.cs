using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IncercareDeProiectBD
{
    public partial class managerForm : Form
    {

        int counter = 0;

        public managerForm()
        {
            InitializeComponent();
        }

        public void hideForm()
        {
            Hide();
        }

        private void managerForm_Load(object sender, EventArgs e)
        {
     
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            counter++;
            if(textBox1.Text != "admin" || textBox2.Text!= "admin")
            {
                MessageBox.Show("Creditentiale gresite!");
                if (counter == 3)
                {
                    MessageBox.Show("Ti-am spus! Accesul persoanelor neautorizate este strict interzis! ciscopapa55!");
                    Application.Exit();
                }
            }
                else
            {
                var newForm = new managerLogatForm();
                hideForm();
                newForm.Show();
            }
        }
    }
}
