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
        static string chaine = @"Data Source=\DESKTOP-6C4KUDE\User;Initial Catalog=BDGED_copy;Integrated Security=True";
        static SqlConnection cnx = new SqlConnection(chaine);
        static SqlCommand cmd = new SqlCommand();
        static SqlDataAdapter adapter = new SqlDataAdapter(cmd); 
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            cnx.Open();
            cmd.Connection = cnx;
            cmd.CommandText = "insert into livre(Nom , Prix, Auteur) values('" + comboBoxNom.Text + "','" + textBoxPrix.Text + "', '" + textBoxAuteur.Text + "') ";
            cmd.ExecuteNonQuery();
            cnx.Close();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            cnx.Open();
            cmd.Connection = cnx;
            cmd.CommandText = "update livre set Nom ='" + comboBoxNom.Text + "' where Auteur='" + textBoxAuteur.Text + "' ";
            cmd.ExecuteNonQuery();
            cnx.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            cnx.Open();
            cmd.Connection = cnx;
            cmd.CommandText = "delete from Livre where Nom de livre='" + comboBoxNom.Text + "' ";
            cmd.ExecuteNonQuery();
            cnx.Close();
        }

        private void comboBoxNom_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxNom.Items.Add("livret1");
            comboBoxNom.Items.Add("livret2"); 
            comboBoxNom.SelectedIndex = 0;
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            cmd.ExecuteNonQuery();
            cnx.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            cnx.Close();
        }
    }
}
