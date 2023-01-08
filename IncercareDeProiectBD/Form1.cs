using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Client;

namespace IncercareDeProiectBD
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void hideForm()
        {
            Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonClient_Click(object sender, EventArgs e)
        {
            var newForm = new clientForm();
            hideForm();
            newForm.Show();
        }

        private void buttonManager_Click(object sender, EventArgs e)
        {
            var newForm = new managerForm();
            hideForm();
            newForm.Show();
        }
    }
}
