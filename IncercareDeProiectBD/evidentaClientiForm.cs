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
            cmd.CommandText = "SELECT * FROM CLIENT ORDER BY IDCLIENT";
            OracleDataReader dr = cmd.ExecuteReader();

            OracleDataAdapter da = new OracleDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            c.Close();
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
            cmd.CommandText = "DELETE FROM CLIENT WHERE IDCLIENT = :IDCLIENT";
            cmd.Parameters.Add("IDCLIENT", textBox1.Text);
            OracleDataReader dr = cmd.ExecuteReader();

            c.Close();
        }
        
        private void button4_Click(object sender, EventArgs e)
        {
            c.Open();

            OracleCommand cmd = new OracleCommand();
            cmd.Connection = c;
            cmd.CommandText = "SELECT * FROM CLIENT ORDER BY IDCLIENT";
            OracleDataReader dr = cmd.ExecuteReader();

            OracleDataAdapter da = new OracleDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            c.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            c.Open();

            OracleCommand cmd = new OracleCommand();
            cmd.Connection = c;
            cmd.CommandText = "SELECT CL.IDCLIENT, CL.NUME || ' ' || CL.PRENUME AS NUMECLIENT, CO.IDCOMANDA, CO.DATACOMANDA, CO.TOTAL, CO.TVA, CO.TIPPLATA, PC.IDPRODUSECOMANDA, PC.IDPRODUS, PC.PRETPERUNITATE FROM CLIENT CL JOIN COMANDA CO ON CL.IDCLIENT = CO.IDCLIENT JOIN PRODUSECOMANDA PC ON PC.IDCOMANDA = CO.IDCOMANDA WHERE CL.IDCLIENT = :IDCLIENT";
            cmd.Parameters.Add("IDCLIENT", textBox1.Text);
            OracleDataReader dr = cmd.ExecuteReader();
            OracleDataAdapter da = new OracleDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            c.Close();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            var newForm = new managerLogatForm();
            hideForm();
            newForm.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            c.Open();

            OracleCommand cmd = new OracleCommand();
            cmd.Connection = c;
            cmd.CommandText = "SELECT * FROM CLIENT ORDER BY NUME";
            OracleDataReader dr = cmd.ExecuteReader();

            OracleDataAdapter da = new OracleDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            c.Close();
        }
    }
}
