﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Oracle.DataAccess.Client;

namespace IncercareDeProiectBD
{
    public partial class anulareComandaForm : Form
    {

        OracleConnection c = Class1.GetDBConnection();

        public anulareComandaForm()
        {
            InitializeComponent();
        }

        private void buttonCloseApp_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void anulareComandaForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            c.Open();
            OracleCommand cmd = new OracleCommand("DELETE FROM COMANDA WHERE IDCOMANDA = @IDCOMANDA; COMMIT;", c);
            cmd.Parameters.Add("@IDCOMANDA", int.Parse(textBox1.Text));
            MessageBox.Show("Comanda anulata cu succes!");
        }
    }
}
