using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using Oracle.ManagedDataAccess.Client;
using Oracle.DataAccess.Client;

namespace IncercareDeProiectBD
{
    public partial class verificareComandaForm : Form
    {

        OracleConnection c = Class1.GetDBConnection();

        public verificareComandaForm()
        {
            InitializeComponent();
        }

        private void buttonCloseApp_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            c.Open();
            //OracleConnection con = new OracleConnection("DATA SOURCE =(ADDRESS = (PROTOCOL = TCP)(HOST = 193.226.51.37)(PORT = 1521))(CONNECT_DATA = (SERVER = DEDICATED)(SERVICE_NAME = o11g)));Password=adriangeorge#21;User ID=adriangeorgeleventiu");
            //SqlConnection con = new SqlConnection("DATA SOURCE=193.226.51.37:1521/o11g;PERSIST SECURITY INFO=True;USER ID=ADRIANGEORGELEVENTIU");
            //OracleCollectionType conn = new OracleConnection();
            //OracleConnection con = new OracleConnection("DATA SOURCE=193.226.51.37:1521/o11g;PERSIST SECURITY INFO=True;USER ID=ADRIANGEORGELEVENTIU
            //con.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = c;
            cmd.CommandText = "SELECT * FROM COMANDA WHERE IDCOMANDA = @IDCOMANDA";
           // OracleCommand cmd = new OracleCommand("SELECT * FROM COMANDA WHERE IDCOMANDA = @IDCOMANDA", c);
            cmd.Parameters.Add("@IDCOMANDA", int.Parse(textBox3.Text));
            OracleDataAdapter da = new OracleDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
    }
}
