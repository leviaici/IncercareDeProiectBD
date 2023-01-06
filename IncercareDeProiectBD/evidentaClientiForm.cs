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
    public partial class evidentaClientiForm : Form
    {

        OracleConnection c = Class1.GetDBConnection();

        public evidentaClientiForm()
        {
            InitializeComponent();
            c.Open();

            OracleCommand cmd = new OracleCommand();
            cmd.Connection = c;
            cmd.CommandText = "SELECT * FROM CLIENT";
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

        private void button1_Click(object sender, EventArgs e)
        {
            c.Open();

            OracleCommand cmd = new OracleCommand();
            cmd.Connection = c;
            cmd.CommandText = "SELECT * FROM CLIENT WHERE NUME = :NUME AND PRENUME = :PRENUME";
            cmd.Parameters.Add("NUME", textBox2.Text);
            cmd.Parameters.Add("PRENUME", textBox3.Text);
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
            cmd.CommandText = "UPDATE CLIENT SET NUME = :NUME, PRENUME = :PRENUME WHERE IDCLIENT = :IDCLIENT";
            cmd.Parameters.Add("NUME", textBox2.Text);
            cmd.Parameters.Add("PRENUME", textBox3.Text);
            cmd.Parameters.Add("IDCLIENT", textBox1.Text);
            OracleDataReader dr = cmd.ExecuteReader();

            c.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            c.Open();

            OracleCommand cmd = new OracleCommand();
            cmd.Connection = c;
            cmd.CommandText = "DELETE FROM CLIENT WHERE NUME = :NUME AND PRENUME = :PRENUME AND IDCLIENT = :IDCLIENT";
            cmd.Parameters.Add("NUME", textBox2.Text);
            cmd.Parameters.Add("PRENUME", textBox3.Text);
            cmd.Parameters.Add("IDCLIENT", textBox1.Text);
            OracleDataReader dr = cmd.ExecuteReader();

            c.Close();
        }
        //TBA afisam pentru manager la client - comanda + produsele din comanda clientului
        private void button4_Click(object sender, EventArgs e)
        {
            c.Open();

            OracleCommand cmd = new OracleCommand();
            cmd.Connection = c;
            cmd.CommandText = "SELECT * FROM CLIENT";
            OracleDataReader dr = cmd.ExecuteReader();

            OracleDataAdapter da = new OracleDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            c.Close();
        }
    }
}
