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
    public partial class evidentaBucatariForm : Form
    {
        OracleConnection c = Class1.GetDBConnection();

        public evidentaBucatariForm()
        {
            InitializeComponent();

            c.Open();

            OracleCommand cmd = new OracleCommand();
            cmd.Connection = c;
            cmd.CommandText = "SELECT * FROM BUCATAR";
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

        private void button4_Click(object sender, EventArgs e)
        {
            c.Open();

            OracleCommand cmd = new OracleCommand();
            cmd.Connection = c;
            cmd.CommandText = "SELECT * FROM BUCATAR";
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
            cmd.CommandText = "SELECT * FROM BUCATAR WHERE NUME = :NUME AND PRENUME = :PRENUME";
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
            cmd.CommandText = "UPDATE BUCATAR SET NUME = :NUME, PRENUME = :PRENUME, POST = :POST, VARSTA = :VARSTA, SEX = :SEX, SALARIU = :SALARIU WHERE IDBUCATAR = :IDBUCATAR";
            cmd.Parameters.Add("NUME", textBox2.Text);
            cmd.Parameters.Add("PRENUME", textBox3.Text);
            cmd.Parameters.Add("POST", textBox6.Text);
            cmd.Parameters.Add("VARSTA", textBox5.Text);
            cmd.Parameters.Add("SEX", textBox4.Text);
            cmd.Parameters.Add("SALARIU", textBox9.Text);
            cmd.Parameters.Add("IDBUCATAR", textBox1.Text);
            OracleDataReader dr = cmd.ExecuteReader();

            c.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            c.Open();

            OracleCommand cmd = new OracleCommand();
            cmd.Connection = c;
            cmd.CommandText = "UPDATE BUCATAR SET DATAPLECARE = SYSDATE WHERE IDBUCATAR = :IDBUCATAR AND NUME = :NUME AND PRENUME = :PRENUME AND POST = :POST";
            cmd.Parameters.Add("IDBUCATAR", textBox1.Text);
            cmd.Parameters.Add("NUME", textBox2.Text);
            cmd.Parameters.Add("PRENUME", textBox3.Text);
            cmd.Parameters.Add("POST", textBox6.Text);
            OracleDataReader dr = cmd.ExecuteReader();

            c.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            c.Open();

            OracleCommand cmd = new OracleCommand();
            cmd.Connection = c;
            cmd.CommandText = "INSERT INTO BUCATAR (IDBUCATAR, NUME, PRENUME, POST, VARSTA, SEX, SALARIU, DATAANGAJARE, DATAPLECARE) VALUES (BUCATAR_IDBUCATAR_SEQ.nextval, :NUME, :PRENUME, :POST, :VARSTA, :SEX, :SALARIU, SYSDATE, NULL)";
            cmd.Parameters.Add("NUME", textBox2.Text);
            cmd.Parameters.Add("PRENUME", textBox3.Text);
            cmd.Parameters.Add("POST", textBox6.Text);
            cmd.Parameters.Add("VARSTA", textBox5.Text);
            cmd.Parameters.Add("SEX", textBox4.Text);
            cmd.Parameters.Add("SALARIU", textBox9.Text);
            OracleDataReader dr = cmd.ExecuteReader();

            c.Close();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            var newForm = new managerLogatForm();
            hideForm();
            newForm.Show();
        }
    }
}
