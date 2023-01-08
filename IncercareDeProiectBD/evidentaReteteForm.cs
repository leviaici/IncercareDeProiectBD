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
    public partial class evidentaReteteForm : Form
    {

        OracleConnection c = Class1.GetDBConnection();

        public evidentaReteteForm()
        {
            InitializeComponent();
            c.Open();

            OracleCommand cmd = new OracleCommand();
            cmd.Connection = c;
            cmd.CommandText = "SELECT * FROM RETETA ORDER BY IDRETETA";
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

        private void button5_Click(object sender, EventArgs e)
        {
            c.Open();

            OracleCommand cmd = new OracleCommand();
            cmd.Connection = c;
            cmd.CommandText = "SELECT * FROM RETETA ORDER BY IDRETETA";
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
            cmd.CommandText = "INSERT INTO RETETA(IDRETETA, IDBUCATAR, NUME) VALUES (INGREDIENT_IDINGREDIENT_SEQ.nextval, :IDBUCATAR, :NUME)";
            cmd.Parameters.Add("IDBUCATAR", textBox7.Text);
            cmd.Parameters.Add("NUME", textBox6.Text);
            OracleDataReader dr = cmd.ExecuteReader();


            OracleCommand cmd2 = new OracleCommand();
            cmd2.Connection = c;
            cmd2.CommandText = "SELECT * FROM RETETA WHERE IDRETETA = (SELECT MAX(IDRETETA) FROM RETETA)";
            OracleDataReader dr2 = cmd2.ExecuteReader();

            OracleDataAdapter da = new OracleDataAdapter(cmd2);
            DataTable dt2 = new DataTable();
            da.Fill(dt2);
            dataGridView2.DataSource = dt2;

            MessageBox.Show("Vei fi redirectionat la pagina de organizare retete pentru a finaliza reteta!");

            var newForm = new evidentaOrganizareRetete();
            hideForm();
            newForm.Show();

            c.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            c.Open();

            OracleCommand cmd = new OracleCommand();
            cmd.Connection = c;
            cmd.CommandText = "SELECT * FROM RETETA WHERE IDRETETA = :IDRETETA";
            cmd.Parameters.Add("IDRETETA", textBox8.Text);
            OracleDataReader dr = cmd.ExecuteReader();

            OracleDataAdapter da = new OracleDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            OracleCommand cmd2 = new OracleCommand();
            cmd2.Connection = c;
            cmd2.CommandText = "SELECT DR.IDDETALIURETETA, DR.IDRETETA, DR.IDINGREDIENT, I.NUME AS INGREDIENT, DR.CANTITATE || ' ' || I.UNITATEMASURA AS CANTITATENECESARA FROM DETALIURETETA DR JOIN INGREDIENT I ON I.IDINGREDIENT = DR.IDINGREDIENT WHERE DR.IDRETETA = :IDRETETA ORDER BY I.IDINGREDIENT";
            cmd2.Parameters.Add("IDRETETA", textBox8.Text);
            OracleDataReader dr2 = cmd2.ExecuteReader();

            OracleDataAdapter da2 = new OracleDataAdapter(cmd2);
            DataTable dt2 = new DataTable();
            da2.Fill(dt2);
            dataGridView2.DataSource = dt2;

            c.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            c.Open();

            OracleCommand cmd = new OracleCommand();
            cmd.Connection = c;
            cmd.CommandText = "DELETE FROM RETETA WHERE IDRETETA = :IDRETETA";
            cmd.Parameters.Add("IDRETETA", textBox8.Text);
            OracleDataReader dr = cmd.ExecuteReader();

            c.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            c.Open();

            OracleCommand cmd = new OracleCommand();
            cmd.Connection = c;
            cmd.CommandText = "UPDATE RETETA SET IDBUCATAR = :IDBUCATAR, NUME = :NUME WHERE IDRETETA = :IDRETETA";
            cmd.Parameters.Add("IDBUCATAR", textBox7.Text);
            cmd.Parameters.Add("NUME", textBox6.Text);
            cmd.Parameters.Add("IDRETETA", textBox8.Text);
            OracleDataReader dr = cmd.ExecuteReader();

            MessageBox.Show("Vei fi redirectionat la pagina de organizare retete pentru a finaliza reteta!");

            var newForm = new evidentaOrganizareRetete();
            hideForm();
            newForm.Show();

            c.Close();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            var newForm = new managerLogatForm();
            hideForm();
            newForm.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            c.Open();

            OracleCommand cmd = new OracleCommand();
            cmd.Connection = c;
            cmd.CommandText = "SELECT * FROM RETETA ORDER BY IDBUCATAR";
            OracleDataReader dr = cmd.ExecuteReader();

            OracleDataAdapter da = new OracleDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            c.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            c.Open();

            OracleCommand cmd = new OracleCommand();
            cmd.Connection = c;
            cmd.CommandText = "SELECT * FROM RETETA ORDER BY NUME";
            OracleDataReader dr = cmd.ExecuteReader();

            OracleDataAdapter da = new OracleDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            c.Close();
        }
    }
}
