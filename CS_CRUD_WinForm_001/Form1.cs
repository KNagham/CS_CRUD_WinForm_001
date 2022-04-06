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
    public partial class ListBox : Form
    {
        SqlConnection conn;
        SqlCommand cmd;
        string sqlQuery;
        //SqlDataReader reader;
        public ListBox()
        {   
            InitializeComponent();
            DbConnection();
            Update();
            Clear();
        }

        private void DbConnection()
        {
            conn = new SqlConnection("Data Source=MPGNBNK;Initial Catalog=test_001;Integrated Security=True");
        }
        private void Clear()
        {
            txtId.Text = "";
            txtVorname.Text = "";
            txtName.Text = "";
            txtAlter.Text = "";
            txtNote.Text = "";
            txtFach.Text = "";
            checkBoxAbgeschlossen.Checked = false;
        }
        private void btnInsert_Click(object sender, EventArgs e)
        {
            //txtVorname.Text = "Khaled";
            conn.Open();
            string sqlQuery = "insert into [benutzer] (vorname, name, age, fach, note, abgeschlossen) Values (@vorname,@name, @age, @fach, @note, @abgeschlossen)";
            cmd = new SqlCommand(sqlQuery, conn);
            cmd.Parameters.AddWithValue("@vorname", txtVorname.Text);
            cmd.Parameters.AddWithValue("@name", txtName.Text);
            cmd.Parameters.AddWithValue("@age", int.Parse(txtAlter.Text));
            cmd.Parameters.AddWithValue("@fach", txtFach.Text);
            cmd.Parameters.AddWithValue("@note",double.Parse(txtNote.Text));
            cmd.Parameters.AddWithValue("@abgeschlossen",checkBoxAbgeschlossen.Checked );
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Insert Seccessfully");
            Clear();
            Update();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            conn.Open();
            sqlQuery = "Update [benutzer] set vorname = @vorname, name = @name, age = @age, fach = @fach, note = @note, abgeschlossen = @abgeschlossen Where id = @id";
            cmd = new SqlCommand(sqlQuery, conn);
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
            Clear();
            Update();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            conn.Open();
            sqlQuery = "Delete from [benutzer] where id = @id";
            cmd = new SqlCommand(sqlQuery, conn);
            cmd.Parameters.AddWithValue("@id", int.Parse(txtId.Text));
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Delete Seccessfully");
            Clear();
            Update();
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            conn.Open();
            if (txtId.Text != "")
            {
                sqlQuery = "Select * From [benutzer] Where id = @id";
                cmd = new SqlCommand(sqlQuery, conn);
                cmd.Parameters.AddWithValue("@id", int.Parse(txtId.Text));
            }
            else if (txtVorname.Text != "")
            {
                sqlQuery = "Select * From [benutzer] Where vorname = @vorname";
                cmd = new SqlCommand(sqlQuery, conn);
                cmd.Parameters.AddWithValue("@vorname", txtVorname.Text);
            }
            else if (txtName.Text != "")
            {
                sqlQuery = "Select * From [benutzer] Where name = @name";
                cmd = new SqlCommand(sqlQuery, conn);
                cmd.Parameters.AddWithValue("@name", txtName.Text);
            }
            else if (txtAlter.Text != "")
            {
                sqlQuery = "Select * From [benutzer] Where age = @age";
                cmd = new SqlCommand(sqlQuery, conn);
                cmd.Parameters.AddWithValue("@age", int.Parse(txtAlter.Text));
            }
            else if (txtFach.Text != "")
            {
                sqlQuery = "Select * From [benutzer] Where fach = @fach";
                cmd = new SqlCommand(sqlQuery, conn);
                cmd.Parameters.AddWithValue("@fach", txtFach.Text);
            }
            else if (txtNote.Text != "")
            {
                sqlQuery = "Select * From [benutzer] Where note = @note";
                cmd = new SqlCommand(sqlQuery, conn);
                cmd.Parameters.AddWithValue("@note", int.Parse(txtNote.Text));
            }
            else if (checkBoxAbgeschlossen.Checked != false)
            {
                sqlQuery = "Select * From [benutzer] Where abgeschlossen = @abgeschlossen";
                cmd = new SqlCommand(sqlQuery, conn);
                cmd.Parameters.AddWithValue("@abgeschlossen", checkBoxAbgeschlossen.Checked);
            }
            else
            {
                sqlQuery = "Select * From [benutzer]";
                cmd = new SqlCommand(sqlQuery, conn);
            }
            DataTable dataTable = new DataTable();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd);
            sqlDataAdapter.Fill(dataTable);
            dataGridBenutzer.DataSource = dataTable;
            conn.Close();
            Clear();
        }
        private void Update()
        {
            conn.Open();
            sqlQuery = "Select * From [benutzer]";
            cmd = new SqlCommand(sqlQuery, conn);
            DataTable dataTable = new DataTable(); //empty table
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd);  //data
            sqlDataAdapter.Fill(dataTable); //data are being filled into the empty table
            dataGridBenutzer.DataSource = dataTable;
            conn.Close();
        }

    }
}