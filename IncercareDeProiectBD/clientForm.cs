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
    public partial class clientForm : Form
    {
        public clientForm()
        {
            InitializeComponent();
        }

        public void hideForm()
        {
            Hide();
        }

        private void clientForm_Load(object sender, EventArgs e)
        {
            
        }

        private void buttonCloseApp_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var newForm = new verificareComandaForm();
            hideForm();
            newForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var newForm = new lansareComandaForm();
            hideForm();
            newForm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var newForm = new anulareComandaForm();
            hideForm();
            newForm.Show();
        }
    }
}
