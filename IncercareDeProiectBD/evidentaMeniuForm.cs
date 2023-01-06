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
    public partial class evidentaMeniuForm : Form
    {

        OracleConnection c = Class1.GetDBConnection();

        public evidentaMeniuForm()
        {
            InitializeComponent();
            c.Open();

            OracleCommand cmd = new OracleCommand();
            cmd.Connection = c;
            cmd.CommandText = "SELECT P.IDPRODUS, P.NUME AS NUMEPRODUS, P.PRETDEPRODUCTIE || ' LEI' AS PRETDEPRODUCTIE, P.PRETDEVANZARE || ' LEI' AS PRETDEVANZARE, CP.NUME AS CATEGORIEPRODUS, R.IDRETETA, B.NUME || ' ' || B.PRENUME AS NUMEBUCATAR, B.POST FROM PRODUS P JOIN CATEGORIEPRODUS CP ON CP.IDCATEGORIEPRODUS = P.IDCATEGORIEPRODUS JOIN RETETA R ON R.IDRETETA = P.IDRETETA JOIN BUCATAR B ON B.IDBUCATAR = R.IDBUCATAR ORDER BY IDPRODUS";
            OracleDataReader dr = cmd.ExecuteReader();

            OracleDataAdapter da = new OracleDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            c.Close();
        }

        private void evidentaMeniuForm_Load(object sender, EventArgs e)
        {

        }

        private void buttonCloseApp_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            c.Open();

            OracleCommand cmd = new OracleCommand();
            cmd.Connection = c;
            cmd.CommandText = "INSERT INTO RETETA(IDRETETA, IDBUCATAR, NUME) VALUES (RETETA_IDRETETA_SEQ.nextval, :IDBUCATAR, :NUME)";
            cmd.Parameters.Add("IDBUCATAR", textBox6.Text);
            cmd.Parameters.Add("NUME", textBox2.Text);
            OracleDataReader dr = cmd.ExecuteReader();

            OracleCommand cmd2 = new OracleCommand();
            cmd2.Connection = c;
            cmd2.CommandText = "INSERT INTO PRODUS(IDPRODUS, IDCATEGORIEPRODUS, IDRETETA, NUME, PRETDEPRODUCTIE, PRETDEVANZARE) VALUES (PRODUS_IDPRODUS_SEQ.nextval, :IDCATEGORIEPRODUS, RETETA_IDRETETA_SEQ.currval, :NUME, :PRETDEPRODUCTIE, :PRETDEVANZARE)";
            cmd2.Parameters.Add("IDCATEGORIEPRODUS", textBox4.Text);
            cmd2.Parameters.Add("NUME", textBox2.Text);
            cmd2.Parameters.Add("PRETDEPRODUCTIE", textBox3.Text);
            cmd2.Parameters.Add("PRETDEVANZARE", textBox5.Text);
            OracleDataReader dr2 = cmd2.ExecuteReader();


            c.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            c.Open();

            OracleCommand cmd = new OracleCommand();
            cmd.Connection = c;
            cmd.CommandText = "DELETE FROM PRODUS WHERE IDPRODUS = :IDPRODUS";
            cmd.Parameters.Add("IDPRODUS", textBox1.Text);
            OracleDataReader dr = cmd.ExecuteReader();

            c.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            c.Open();

            OracleCommand cmd = new OracleCommand();
            cmd.Connection = c;
            cmd.CommandText = "SELECT P.IDPRODUS, P.NUME AS NUMEPRODUS, P.PRETDEPRODUCTIE || ' LEI' AS PRETDEPRODUCTIE, P.PRETDEVANZARE || ' LEI' AS PRETDEVANZARE, CP.NUME AS CATEGORIEPRODUS, R.IDRETETA, B.NUME || ' ' || B.PRENUME AS NUMEBUCATAR, B.POST FROM PRODUS P JOIN CATEGORIEPRODUS CP ON CP.IDCATEGORIEPRODUS = P.IDCATEGORIEPRODUS JOIN RETETA R ON R.IDRETETA = P.IDRETETA JOIN BUCATAR B ON B.IDBUCATAR = R.IDBUCATAR ORDER BY IDPRODUS";
            OracleDataReader dr = cmd.ExecuteReader();

            OracleDataAdapter da = new OracleDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            c.Close();
        }
    }
}
