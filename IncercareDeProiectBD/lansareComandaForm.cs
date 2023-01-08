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
using System.Threading;

namespace IncercareDeProiectBD
{
    public partial class lansareComandaForm : Form
    {

        OracleConnection c = Class1.GetDBConnection();

        public lansareComandaForm()
        {
            InitializeComponent();
        }
        public void hideForm()
        {
            Hide();
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
            String nume = textBox1.Text;
            String prenume = textBox2.Text;
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
            cmd3.CommandText = "INSERT INTO COMANDA(IDCOMANDA, IDCLIENT, DATACOMANDA, TVA, TIPPLATA) VALUES (COMANDA_IDCOMANDA_SEQ.nextval, :IDCLIENT, SYSDATE, 9, :TIPPLATA)";
            
            OracleCommand cmd4 = new OracleCommand();
            cmd4.Connection = c;
            cmd4.CommandText = "SELECT * FROM COMANDA WHERE IDCLIENT = :IDCLIENT AND TIPPLATA = :TIPPLATA ORDER BY IDCOMANDA DESC";
            
            cmd3.Parameters.Add("IDCLIENT", textBox4.Text);
            cmd3.Parameters.Add("TIPPLATA", textBox5.Text);
            
            cmd4.Parameters.Add("IDCLIENT", textBox4.Text);
            cmd4.Parameters.Add("TIPPLATA", textBox5.Text);
            
            OracleDataReader dr3 = cmd3.ExecuteReader();

            OracleDataAdapter daNew = new OracleDataAdapter(cmd4);
            DataTable dtNew = new DataTable();
            daNew.Fill(dtNew);
            dataGridView2.DataSource = dtNew;

            MessageBox.Show("Comanda lansata cu succes! Vei fi redirectionat pentru a plasa produsele in comanda!");

            c.Close();

            var newForm = new continuareLansareComandaForm();
            hideForm();
            newForm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var newForm = new meniuForm();
            hideForm();
            newForm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var newForm = new clientForm();
            hideForm();
            newForm.Show();
        }
    }
}
