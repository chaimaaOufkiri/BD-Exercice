using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;



namespace BD_Exercice
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        static string chaine = @"Data Source=DESKTOP-6C4KUDE\SQLEXPRESS;Initial Catalog=database;Integrated Security=True";
        static SqlConnection cnx = new SqlConnection (chaine);
        static SqlCommand cmd = new SqlCommand();
        static SqlDataAdapter adapter = new SqlDataAdapter(cmd); 

        private void btnNew_Click(object sender, EventArgs e)
        {
            cnx.Open();
            cmd.Connection = cnx;
            cmd.CommandText = "insert into livre(Nom , Prix, Auteur) values('" + comboBoxNom.Text + "','" + textBoxPrix.Text + "', '" + textBoxAuteur.Text + "') ";
            btnDelete.Enabled = false;
            btnEdit.Enabled = false;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            cnx.Open();
            cmd.Connection = cnx;
            cmd.CommandText = "update livre set Nom ='" + comboBoxNom.Text + "' where Auteur='" + textBoxAuteur.Text + "'";
            btnNew.Enabled = false;
            btnDelete.Enabled = false;
        }


        private void btnDelete_Click(object sender, EventArgs e)
        {
            cnx.Open();
            cmd.Connection = cnx;
            cmd.CommandText = "delete from livre where Nom='" + comboBoxNom.Text + "' ";
            btnNew.Enabled = false;
            btnEdit.Enabled = false;
        }
       

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if(btnNew.Enabled|| btnDelete.Enabled || btnEdit.Enabled)
            {
                cmd.ExecuteNonQuery();
                cnx.Close();
            }
            btnCancel.Enabled = false;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (btnNew.Enabled || btnDelete.Enabled || btnEdit.Enabled)
            {
                cnx.Close();
            }
            btnConfirm.Enabled = false;
        }
        private void btnAfficher_Click(object sender, EventArgs e)
        {
            cmd.CommandText = "select * from livre ";
            adapter.SelectCommand = cmd;
            DataTable dt = new DataTable();
            dt.Clear();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
        }
    }
}
