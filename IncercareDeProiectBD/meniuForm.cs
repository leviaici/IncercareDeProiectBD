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
    public partial class meniuForm : Form
    {

        OracleConnection c = Class1.GetDBConnection();

        public meniuForm()
        {
            InitializeComponent();
            c.Open();
            
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = c;
            cmd.CommandText = "SELECT IDPRODUS AS ID, (SELECT NUME FROM CATEGORIEPRODUS WHERE IDCATEGORIEPRODUS = PRODUS.IDCATEGORIEPRODUS) AS CATEGORIE, NUME, PRETDEVANZARE || ' LEI' AS PRET FROM PRODUS";
            OracleDataReader dr = cmd.ExecuteReader();

            OracleDataAdapter da = new OracleDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            OracleCommand cmd2 = new OracleCommand();
            cmd2.Connection = c;
            cmd2.CommandText = "SELECT P.IDCATEGORIEPRODUS, PC.NUME AS NUMECATEGORIE, MIN(P.PRETDEVANZARE) || ' Lei' AS PRETMINIM FROM PRODUS P JOIN CATEGORIEPRODUS PC ON PC.IDCATEGORIEPRODUS = P.IDCATEGORIEPRODUS GROUP BY P.IDCATEGORIEPRODUS, PC.NUME HAVING MIN(P.PRETDEVANZARE) <= 20 ORDER BY IDCATEGORIEPRODUS";
            OracleDataReader dr2 = cmd2.ExecuteReader();

            OracleDataAdapter da2 = new OracleDataAdapter(cmd2);
            DataTable dt2 = new DataTable();
            da2.Fill(dt2);
            dataGridView2.DataSource = dt2;

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
            var newForm = new lansareComandaForm();
            hideForm();
            newForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var newForm = new clientForm();
            hideForm();
            newForm.Show();
        }
    }
}
