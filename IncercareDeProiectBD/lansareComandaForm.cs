using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Client;

namespace IncercareDeProiectBD
{
    public partial class lansareComandaForm : Form
    {

        OracleConnection c = Class1.GetDBConnection();

        public lansareComandaForm()
        {
            InitializeComponent();
        }

        private void buttonCloseApp_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            c.Open();

            OracleCommand cmd1 = new OracleCommand();
            cmd1.Connection = c;
            cmd1.CommandText = "INSERT INTO CLIENT(IDCLIENT, NUME, PRENUME) VALUES (CLIENT_IDCLIENT_SEQ.nextval, :Nume, :Prenume)";
            String nume = "'" + textBox1.Text + "'";
            String prenume = "'" + textBox2.Text + "'";
            cmd1.Parameters.Add("Nume", nume);
            cmd1.Parameters.Add("Preume", prenume);
            OracleDataReader dr1 = cmd1.ExecuteReader();
            MessageBox.Show("ID generat cu succes!");


            OracleCommand cmd2 = new OracleCommand();
            cmd2.Connection = c;
            cmd2.CommandText = "SELECT * FROM CLIENT WHERE NUME = :NUME AND PRENUME = :PRENUME AND IDCLIENT = (SELECT MAX(IDCLIENT) FROM CLIENT)";
            cmd2.Parameters.Add("Nume", nume);
            cmd2.Parameters.Add("Preume", prenume);
            OracleDataReader dr2 = cmd2.ExecuteReader();

            OracleDataAdapter da = new OracleDataAdapter(cmd2);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            c.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            c.Open();

            OracleCommand cmd3 = new OracleCommand();
            cmd3.Connection = c;
            cmd3.CommandText = "INSERT INTO COMANDA(IDCOMANDA, IDCLIENT, DATACOMANDA, TOTAL, TVA, TIPPLATA) VALUES (COMANDA_IDCOMANDA_SEQ.nextval, :IDCLIENT, SYSDATE, :TOTAL, 9, :TIPPLATA)";
            cmd3.Parameters.Add("IDCLIENT", textBox4.Text);
            cmd3.Parameters.Add("TOTAL", textBox3.Text);
            cmd3.Parameters.Add("TIPPLATA", textBox5.Text);
            OracleDataReader dr3 = cmd3.ExecuteReader();

            MessageBox.Show("Comanda lansata cu succes!");
            c.Close();
        }
    }
}
