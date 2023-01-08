﻿using System;
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
    public partial class evidentaProduseDinComenziForm : Form
    {

        OracleConnection c = Class1.GetDBConnection();

        public evidentaProduseDinComenziForm()
        {
            InitializeComponent();
            c.Open();

            OracleCommand cmd = new OracleCommand();
            cmd.Connection = c;
            cmd.CommandText = "SELECT PC.IDPRODUSECOMANDA, PC.IDCOMANDA, PC.IDPRODUS, P.NUME, PC.PRETPERUNITATE FROM PRODUSECOMANDA PC JOIN PRODUS P ON P.IDPRODUS = PC.IDPRODUS";
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
            cmd.CommandText = "SELECT PC.IDPRODUSECOMANDA, PC.IDCOMANDA, PC.IDPRODUS, P.NUME, PC.PRETPERUNITATE FROM PRODUSECOMANDA PC JOIN PRODUS P ON P.IDPRODUS = PC.IDPRODUS";
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
            cmd.CommandText = "SELECT PC.IDPRODUSECOMANDA, PC.IDCOMANDA, PC.IDPRODUS, P.NUME, PC.PRETPERUNITATE FROM PRODUSECOMANDA PC JOIN PRODUS P ON P.IDPRODUS = PC.IDPRODUS WHERE PC.IDPRODUSECOMANDA = :IDPRODUSECOMANDA";
            cmd.Parameters.Add("IDPRODUSECOMANDA", textBox1.Text);
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
            cmd.CommandText = "SELECT PC.IDPRODUSECOMANDA, PC.IDCOMANDA, PC.IDPRODUS, P.NUME, PC.PRETPERUNITATE FROM PRODUSECOMANDA PC JOIN PRODUS P ON P.IDPRODUS = PC.IDPRODUS WHERE PC.IDCOMANDA = :IDCOMANDA";
            cmd.Parameters.Add("IDCOMANDA", textBox2.Text);
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
            cmd.CommandText = "DELETE FROM PRODUSECOMANDA WHERE IDPRODUSECOMANDA = :IDPRODUSECOMANDA";
            cmd.Parameters.Add("IDPRODUSECOMANDA", textBox1.Text);
            OracleDataReader dr = cmd.ExecuteReader();

            c.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            c.Open();

            OracleCommand cmd = new OracleCommand();
            cmd.Connection = c;
            cmd.CommandText = "INSERT INTO PRODUSECOMANDA(IDPRODUSECOMANDA, IDCOMANDA, IDPRODUS, PRETPERUNITATE) VALUES (PRODUSECOMANDA_IDPRODCOM_SEQ.nextval, :IDCOMANDA, :IDPRODUS, :PRET)";
            cmd.Parameters.Add("IDCOMANDA", textBox2.Text);
            cmd.Parameters.Add("IDPRODUS", textBox4.Text);
            cmd.Parameters.Add("PRET", textBox3.Text);
            OracleDataReader dr = cmd.ExecuteReader();

            c.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            var newForm = new evidentaComenziForm();
            hideForm();
            newForm.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            c.Open();

            OracleCommand cmd = new OracleCommand();
            cmd.Connection = c;
            cmd.CommandText = "UPDATE PRODUSECOMANDA SET IDCOMANDA = :IDCOMANDA, IDPRODUS = :IDPRODUS, PRETPERUNITATE = :PRETPERUNITATE WHERE IDPRODUSECOMANDA = :IDPRODUSECOMANDA";
            cmd.Parameters.Add("IDCOMANDA", textBox2.Text);
            cmd.Parameters.Add("IDPRODUS", textBox4.Text);
            cmd.Parameters.Add("PRETPERUNITATE", textBox3.Text);
            cmd.Parameters.Add("IDPRODUSECOMANDA", textBox1.Text);
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
