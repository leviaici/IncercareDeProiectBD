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
    public partial class managerLogatForm : Form
    {
        public managerLogatForm()
        {
            InitializeComponent();
        }
        public void hideForm()
        {
            Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var newForm = new evidentaClientiForm();
            hideForm();
            newForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var newForm = new evidentaBucatariForm();
            hideForm();
            newForm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var newForm = new evidentaMeniuForm();
            hideForm();
            newForm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var newForm = new evidentaIngredienteForm();
            hideForm();
            newForm.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            var newForm = new evidentaFurnizoriForm();
            hideForm();
            newForm.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            var newForm = new evidentaReteteForm();
            hideForm();
            newForm.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            var newForm = new evidentaComenziForm();
            hideForm();
            newForm.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            var newForm = new evidentaProduseDinComenziForm();
            hideForm();
            newForm.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            var newForm = new evidentaOrganizareRetete();
            hideForm();
            newForm.Show();
        }

        private void buttonCloseApp_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
