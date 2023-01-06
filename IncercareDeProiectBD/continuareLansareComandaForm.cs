using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Oracle.DataAccess.Client;

namespace IncercareDeProiectBD
{
    public partial class continuareLansareComandaForm : Form
    {

        OracleConnection c = Class1.GetDBConnection();

        public continuareLansareComandaForm()
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
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //c.Open();

            OracleCommand cmd2 = new OracleCommand();
            cmd2.Connection = c;
            cmd2.CommandText = "INSERT INTO PRODUSECOMANDA(IDPRODUSECOMANDA, IDCOMANDA, IDPRODUS, PRETPERUNITATE) VALUES (PRODUSECOMANDA_IDPRODCOM_SEQ.nextval, :IDCOMANDA, :IDPRODUS, (SELECT PRETDEVANZARE FROM PRODUS WHERE IDPRODUS = :IDPRODUS))";
            cmd2.Parameters.Add("IDCOMANDA", textBox1.Text);
            cmd2.Parameters.Add("IDPRODUS", textBox2.Text);
            //cmd2.Parameters.Add("IDPRODUS", textBox2.Text);
            OracleDataReader dr2 = cmd2.ExecuteReader();

            //c.Close();
        }

        private void buttonCloseApp_Click(object sender, EventArgs e)
        {
            c.Close();
            Application.Exit();
        }
    }
}
