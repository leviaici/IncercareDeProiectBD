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
    public partial class evidentaComenziForm : Form
    {

        OracleConnection c = Class1.GetDBConnection();

        public evidentaComenziForm()
        {
            InitializeComponent();
            c.Open();

            OracleCommand cmd = new OracleCommand();
            cmd.Connection = c;
            cmd.CommandText = "SELECT * FROM COMANDA";
            OracleDataReader dr = cmd.ExecuteReader();

            OracleDataAdapter da = new OracleDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            c.Close();
        }

        private void buttonCloseApp_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            c.Open();

            OracleCommand cmd = new OracleCommand();
            cmd.Connection = c;
            cmd.CommandText = "SELECT * FROM COMANDA";
            OracleDataReader dr = cmd.ExecuteReader();

            OracleDataAdapter da = new OracleDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            c.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            c.Open();

            OracleCommand cmd = new OracleCommand();
            cmd.Connection = c;
            cmd.CommandText = "INSERT INTO COMANDA(IDCOMANDA, IDCLIENT, DATACOMANDA, TOTAL, TVA, TIPPLATA) VALUES (COMANDA_IDCOMANDA_SEQ.nextval, :IDCLIENT, TO_DATE(:DATACOMANDA, 'MM/DD/YYYY HH24:MI:SS'), :TOTAL, 9, :TIPPLATA)";
            cmd.Parameters.Add("IDCLIENT", textBox2.Text);
            cmd.Parameters.Add("DATACOMANDA", textBox4.Text);
            cmd.Parameters.Add("TOTAL", textBox3.Text);
            cmd.Parameters.Add("TIPPLATA", textBox5.Text);
            OracleDataReader dr = cmd.ExecuteReader();

            c.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            c.Open();

            OracleCommand cmd = new OracleCommand();
            cmd.Connection = c;
            cmd.CommandText = "SELECT * FROM COMANDA WHERE IDCOMANDA = :IDCOMANDA";
            cmd.Parameters.Add("IDCOMANDA", textBox1.Text);
            OracleDataReader dr = cmd.ExecuteReader();

            OracleDataAdapter da = new OracleDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            c.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            c.Open();

            OracleCommand cmd = new OracleCommand();
            cmd.Connection = c;
            cmd.CommandText = "DELETE FROM COMANDA WHERE IDCOMANDA = :IDCOMANDA";
            cmd.Parameters.Add("IDCOMANDA", textBox1.Text);
            OracleDataReader dr = cmd.ExecuteReader();

            c.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            c.Open();

            OracleCommand cmd = new OracleCommand();
            cmd.Connection = c;
            cmd.CommandText = "SELECT * FROM COMANDA WHERE IDCLIENT = :IDCLIENT";
            cmd.Parameters.Add("IDCLIENT", textBox2.Text);
            OracleDataReader dr = cmd.ExecuteReader();

            OracleDataAdapter da = new OracleDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            c.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            c.Open();

            OracleCommand cmd = new OracleCommand();
            cmd.Connection = c;
            cmd.CommandText = "UPDATE COMANDA SET IDCLIENT = :IDCLIENT, DATACOMANDA = TO_DATE(:DATACOMANDA, 'MM/DD/YYYY HH24:MI:SS'), TOTAL = :TOTAL, TIPPLATA = :TIPPLATA WHERE IDCOMANDA = :IDCOMANDA";
            cmd.Parameters.Add("IDCLIENT", textBox2.Text);
            cmd.Parameters.Add("DATACOMANDA", textBox4.Text);
            cmd.Parameters.Add("TOTAL", textBox3.Text);
            cmd.Parameters.Add("TIPPLATA", textBox5.Text);
            cmd.Parameters.Add("IDCOMANDA", textBox1.Text);
            OracleDataReader dr = cmd.ExecuteReader();

            c.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            c.Open();

            OracleCommand cmd = new OracleCommand();
            cmd.Connection = c;
            cmd.CommandText = "DELETE FROM COMANDA WHERE IDCLIENT = :IDCLIENT";
            cmd.Parameters.Add("IDCLIENT", textBox2.Text);
            OracleDataReader dr = cmd.ExecuteReader();

            c.Close();
        }
    }
}
