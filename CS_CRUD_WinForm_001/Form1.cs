using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CS_CRUD_WinForm_001
{
    public partial class Form1 : Form
    {
        SqlConnection conn;
        SqlCommand cmd;
        //SqlDataReader reader;
        public Form1()
        {   
            InitializeComponent();
            DbConnection();
        }

        private void DbConnection()
        {
            conn = new SqlConnection("Data Source=MPGNBNK;Initial Catalog=test_001;Integrated Security=True");
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            //txtVorname.Text = "Khaled";
            conn.Open();
            string SqlQuery = "insert into [benutzer] (vorname, name, age, fach, note, abgeschlossen) Values (@vorname,@name, @age, @fach, @note, @abgeschlossen)";
            cmd = new SqlCommand(SqlQuery, conn);
            cmd.Parameters.AddWithValue("@vorname", txtVorname.Text);
            cmd.Parameters.AddWithValue("@name", txtName.Text);
            cmd.Parameters.AddWithValue("@age", int.Parse(txtAlter.Text));
            cmd.Parameters.AddWithValue("@fach", txtFach.Text);
            cmd.Parameters.AddWithValue("@note",double.Parse(txtNote.Text));
            cmd.Parameters.AddWithValue("@abgeschlossen",checkBoxAbgeschlossen.Checked );
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Insert Seccessfully");
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            conn.Open();
            string SqlQuery1 = "Update [benutzer] set vorname = @vorname, name = @name, age = @age, fach = @fach, note = @note, abgeschlossen = @abgeschlossen Where id = @id";
            cmd = new SqlCommand(SqlQuery1, conn);
            cmd.Parameters.AddWithValue("@id", int.Parse(txtId.Text));
            cmd.Parameters.AddWithValue("@vorname", txtVorname.Text);
            cmd.Parameters.AddWithValue("@name", txtName.Text);
            cmd.Parameters.AddWithValue("@age", int.Parse(txtAlter.Text));
            cmd.Parameters.AddWithValue("@fach", txtFach.Text);
            cmd.Parameters.AddWithValue("@note", double.Parse(txtNote.Text));
            cmd.Parameters.AddWithValue("@abgeschlossen", checkBoxAbgeschlossen.Checked);
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Update Seccessfully");
        }
    }
}