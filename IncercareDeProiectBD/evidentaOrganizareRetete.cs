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
    public partial class evidentaOrganizareRetete : Form
    {

        OracleConnection c = Class1.GetDBConnection();

        public evidentaOrganizareRetete()
        {
            InitializeComponent();
            c.Open();

            OracleCommand cmd = new OracleCommand();
            cmd.Connection = c;
            cmd.CommandText = "SELECT DR.IDDETALIURETETA, DR.IDRETETA, R.NUME AS PRODUS, DR.IDINGREDIENT, I.NUME, DR.CANTITATE || ' ' || I.UNITATEMASURA AS CANTITATE FROM DETALIURETETA DR JOIN RETETA R ON DR.IDRETETA = R.IDRETETA JOIN INGREDIENT I ON I.IDINGREDIENT = DR.IDINGREDIENT";
            OracleDataReader dr = cmd.ExecuteReader();

            OracleDataAdapter da = new OracleDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            OracleCommand cmd2 = new OracleCommand();
            cmd2.Connection = c;
            cmd2.CommandText = "SELECT * FROM INGREDIENT";
            OracleDataReader dr2 = cmd2.ExecuteReader();

            OracleDataAdapter da2 = new OracleDataAdapter(cmd2);
            DataTable dt2 = new DataTable();
            da2.Fill(dt2);
            dataGridView2.DataSource = dt2;

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
            cmd.CommandText = "SELECT DR.IDDETALIURETETA, DR.IDRETETA, R.NUME AS PRODUS, DR.IDINGREDIENT, I.NUME, DR.CANTITATE || ' ' || I.UNITATEMASURA AS CANTITATE FROM DETALIURETETA DR JOIN RETETA R ON DR.IDRETETA = R.IDRETETA JOIN INGREDIENT I ON I.IDINGREDIENT = DR.IDINGREDIENT";
            OracleDataReader dr = cmd.ExecuteReader();

            OracleDataAdapter da = new OracleDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            OracleCommand cmd2 = new OracleCommand();
            cmd2.Connection = c;
            cmd2.CommandText = "SELECT * FROM INGREDIENT";
            OracleDataReader dr2 = cmd2.ExecuteReader();

            OracleDataAdapter da2 = new OracleDataAdapter(cmd2);
            DataTable dt2 = new DataTable();
            da2.Fill(dt2);
            dataGridView2.DataSource = dt2;

            c.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            c.Open();

            OracleCommand cmd = new OracleCommand();
            cmd.Connection = c;
            cmd.CommandText = "INSERT INTO DETALIURETETA(IDDETALIURETETA, IDRETETA, IDINGREDIENT, CANTITATE) VALUES (DETALIURETETA_IDDETRET_SEQ.nextval, :IDRETETA, :IDINGREDIENT, :CANTITATE)";
            cmd.Parameters.Add("IDRETETA", textBox1.Text);
            cmd.Parameters.Add("IDINGREDIENT", textBox2.Text);
            cmd.Parameters.Add("CANTITATE", textBox4.Text);
            OracleDataReader dr = cmd.ExecuteReader();

            c.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            c.Open();

            OracleCommand cmd = new OracleCommand();
            cmd.Connection = c;
            cmd.CommandText = "SELECT DR.IDDETALIURETETA, DR.IDRETETA, R.NUME AS PRODUS, DR.IDINGREDIENT, I.NUME, DR.CANTITATE || ' ' || I.UNITATEMASURA AS CANTITATE FROM DETALIURETETA DR JOIN RETETA R ON DR.IDRETETA = R.IDRETETA JOIN INGREDIENT I ON I.IDINGREDIENT = DR.IDINGREDIENT WHERE DR.IDDETALIURETETA = :IDDETALIURETETA";
            cmd.Parameters.Add("IDDETALIURETETA", textBox3.Text);
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
            cmd.CommandText = "DELETE FROM DETALIURETETA WHERE IDDETALIURETETA = :IDDETALIURETETA";
            cmd.Parameters.Add("IDDETALIURETETA", textBox3.Text);
            OracleDataReader dr = cmd.ExecuteReader();

            c.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            c.Open();

            OracleCommand cmd = new OracleCommand();
            cmd.Connection = c;
            cmd.CommandText = "UPDATE DETALIURETETA SET IDRETETA = :IDRETETA, IDINGREDIENT = :IDINGREDIENT, CANTITATE = :CANTITATE WHERE IDDETALIURETETA = :IDDETALIURETETA";
            cmd.Parameters.Add("IDRETETA", textBox1.Text);
            cmd.Parameters.Add("IDINGREDIENT", textBox2.Text);
            cmd.Parameters.Add("CANTITATE", textBox4.Text);
            cmd.Parameters.Add("IDDETALIURETETA", textBox3.Text);
            OracleDataReader dr = cmd.ExecuteReader();

            c.Close();
        }
    }
}
