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
    public partial class evidentaIngredienteForm : Form
    {

        OracleConnection c = Class1.GetDBConnection();

        public evidentaIngredienteForm()
        {
            InitializeComponent();
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

        private void evidentaIngredienteForm_Load(object sender, EventArgs e)
        {

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
            cmd.CommandText = "SELECT * FROM INGREDIENT";
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
            cmd.CommandText = "INSERT INTO INGREDIENT(IDINGREDIENT, NUME, UNITATEMASURA) VALUES (INGREDIENT_IDINGREDIENT_SEQ.nextval, :NUME, :UNITATEMASURA)";
            cmd.Parameters.Add("NUME", textBox2.Text);
            cmd.Parameters.Add("UNITATEMASURA", textBox3.Text);
            OracleDataReader dr = cmd.ExecuteReader();

            c.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            c.Open();

            OracleCommand cmd = new OracleCommand();
            cmd.Connection = c;
            cmd.CommandText = "DELETE FROM INGREDIENT WHERE IDINGREDIENT = :IDINGREDIENT";
            cmd.Parameters.Add("IDINGREDIENT", textBox1.Text);
            OracleDataReader dr = cmd.ExecuteReader();

            c.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            c.Open();

            OracleCommand cmd = new OracleCommand();
            cmd.Connection = c;
            cmd.CommandText = "SELECT * FROM INGREDIENT WHERE IDINGREDIENT = :IDINGREDIENT";
            cmd.Parameters.Add("IDINGREDIENT", textBox1.Text);
            OracleDataReader dr = cmd.ExecuteReader();

            c.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            c.Open();

            OracleCommand cmd = new OracleCommand();
            cmd.Connection = c;
            cmd.CommandText = "SELECT I.IDINGREDIENT, I.NUME AS INGREDIENT, I.CANTITATE AS STOC, DR.CANTITATE AS CANTITATENECESARA, I.UNITATEMASURA, P.NUME AS PRODUS, R.IDRETETA FROM INGREDIENT I JOIN DETALIURETETA DR ON DR.IDINGREDIENT = I.IDINGREDIENT JOIN RETETA R ON R.IDRETETA = DR.IDRETETA JOIN PRODUS P ON P.IDRETETA = R.IDRETETA WHERE I.IDINGREDIENT = :IDINGREDIENTT";
            cmd.Parameters.Add("IDINGREDIENT", textBox1.Text);
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
            cmd.CommandText = "UPDATE INGREDIENT SET NUME = :NUME, CANTITATE = :CANTITATE, UNITATEMASURA = :UNITATEMASURA WHERE IDINGREDIENT = :IDINGREDIENT";
            cmd.Parameters.Add("NUME", textBox2.Text);
            cmd.Parameters.Add("UNITATEMASURA", textBox3.Text);
            cmd.Parameters.Add("UNITATEMASURA", textBox4.Text);
            cmd.Parameters.Add("IDINGREDIENT", textBox1.Text);
            OracleDataReader dr = cmd.ExecuteReader();

            c.Close();
        }
    }
}
