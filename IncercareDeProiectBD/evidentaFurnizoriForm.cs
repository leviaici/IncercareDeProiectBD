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
    public partial class evidentaFurnizoriForm : Form
    {

        OracleConnection c = Class1.GetDBConnection();

        public evidentaFurnizoriForm()
        {
            InitializeComponent();
            c.Open();

            OracleCommand cmd = new OracleCommand();
            cmd.Connection = c;
            cmd.CommandText = "SELECT F.IDFURNIZOR, F.IDINGREDIENT, I.NUME AS INGREDIENT, F.NUME AS FURNIZOR, F.CANTITATE || ' ' || I.UNITATEMASURA AS CANTITATE FROM FURNIZOR F JOIN INGREDIENT I ON I.IDINGREDIENT = F.IDINGREDIENT";
            OracleDataReader dr = cmd.ExecuteReader();

            OracleDataAdapter da = new OracleDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            c.Close();
        }

        private void evidentaFurnizoriForm_Load(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            c.Open();

            OracleCommand cmd = new OracleCommand();
            cmd.Connection = c;
            cmd.CommandText = "INSERT INTO INGREDIENT(IDINGREDIENT, NUME, UNITATEMASURA) VALUES (INGREDIENT_IDINGREDIENT_SEQ.nextval, :NUME, :UNITATEMASURA)";
            cmd.Parameters.Add("NUME", textBox2.Text);
            cmd.Parameters.Add("UNITATEMASURA", textBox3.Text);
            OracleDataReader dr = cmd.ExecuteReader();

            OracleCommand cmd2 = new OracleCommand();
            cmd2.Connection = c;
            cmd2.CommandText = "SELECT * FROM INGREDIENT WHERE IDINGREDIENT = INGREDIENT_IDINGREDIENT_SEQ.currval";
            OracleDataReader dr2 = cmd2.ExecuteReader();

            OracleDataAdapter da2 = new OracleDataAdapter(cmd);
            DataTable dt2 = new DataTable();
            da2.Fill(dt2);
            dataGridView1.DataSource = dt2;

            c.Close();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            c.Open();

            OracleCommand cmd = new OracleCommand();
            cmd.Connection = c;
            cmd.CommandText = "UPDATE INGREDIENT SET CANTITATE = (INGREDIENT.CANTITATE + (SELECT CANTITATE FROM FURNIZOR WHERE IDINGREDIENT = :IDINGREDIENT)) WHERE IDINGREDIENT = :IDingredient)";
            cmd.Parameters.Add("IDINGREDIENT", textBox8.Text);
            cmd.Parameters.Add("IDINGREDIENT", textBox8.Text);
            OracleDataReader dr = cmd.ExecuteReader();

            c.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            c.Open();

            OracleCommand cmd = new OracleCommand();
            cmd.Connection = c;
            cmd.CommandText = "SELECT F.IDFURNIZOR, F.IDINGREDIENT, I.NUME AS INGREDIENT, F.NUME AS FURNIZOR, F.CANTITATE || ' ' || I.UNITATEMASURA AS CANTITATE FROM FURNIZOR F JOIN INGREDIENT I ON I.IDINGREDIENT = F.IDINGREDIENT WHERE F.IDFURNIZOR = :IDFURNIZOR";
            cmd.Parameters.Add("IDFURNIZOR", textBox8.Text);
            OracleDataReader dr = cmd.ExecuteReader();

            OracleDataAdapter da = new OracleDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            c.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            c.Open();

            OracleCommand cmd = new OracleCommand();
            cmd.Connection = c;
            cmd.CommandText = "DELETE FROM FURNIZOR WHERE IDFURNIZOR = :IDFURNIZOR";
            cmd.Parameters.Add("IDFURNIZOR", textBox8.Text);
            OracleDataReader dr = cmd.ExecuteReader();

            c.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            c.Open();

            OracleCommand cmd = new OracleCommand();
            cmd.Connection = c;
            cmd.CommandText = "UPDATE FURNIZOR SET IDINGREDIENT = :IDINGREDIENT, NUME = :NUME, CANTITATE = :CANTITATE WHERE IDFURNIZOR = :IDFURNIZOR";
            cmd.Parameters.Add("IDINGREDIENT", textBox7.Text);
            cmd.Parameters.Add("NUME", textBox6.Text);
            cmd.Parameters.Add("CANTITATE", textBox5.Text);
            cmd.Parameters.Add("IDFURNIZOR", textBox8.Text);
            OracleDataReader dr = cmd.ExecuteReader();

            c.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            c.Open();

            OracleCommand cmd = new OracleCommand();
            cmd.Connection = c;
            cmd.CommandText = "SELECT * FROM INGREDIENT";
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
            cmd.CommandText = "SELECT F.IDFURNIZOR, F.IDINGREDIENT, I.NUME AS INGREDIENT, F.NUME AS FURNIZOR, F.CANTITATE || ' ' || I.UNITATEMASURA AS CANTITATE FROM FURNIZOR F JOIN INGREDIENT I ON I.IDINGREDIENT = F.IDINGREDIENT";
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
    }
}
