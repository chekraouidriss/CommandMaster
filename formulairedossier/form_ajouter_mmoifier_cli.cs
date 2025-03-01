using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Markup;
using System.Windows.Media;

namespace gstion_de_commande.formulairedossier
{
    
    
    public partial class form_ajouter_mmoifier_cli : Form
    {
        private const string ConnectionString = "Data Source=AMINEICAME\\SQLEXPRESS;Initial Catalog=gestion_de_commandeNEW;Integrated Security=True";
        SqlConnection Mycnx;
        public form_ajouter_mmoifier_cli()
        {
            InitializeComponent();
            Mycnx = new SqlConnection(ConnectionString);

        }

        private void bntenreg_Click(object sender, EventArgs e)
        {
            if (testoblig() != null)
            {
                MessageBox.Show(testoblig(), "obligatoire", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; 
            }

            string id = textID.Text;
            string nom = textNOM.Text;
            string prenom = textPrenom.Text;
            string adres = textadrs.Text;
            int tel = int.Parse(texttel.Text);
            string ville = texville.Text;

            try
            {
                Mycnx.Open();

                string query = "INSERT INTO Client (id, nom, prenom, adresse, téléphone, pays) VALUES (@id, @nom, @prenom, @adresse, @tel, @ville)";
                using (SqlCommand command = new SqlCommand(query, Mycnx))
                {
                    command.Parameters.AddWithValue("@id", id);
                    command.Parameters.AddWithValue("@nom", nom);
                    command.Parameters.AddWithValue("@prenom", prenom);
                    command.Parameters.AddWithValue("@adresse", adres);
                    command.Parameters.AddWithValue("@tel", tel);
                    command.Parameters.AddWithValue("@ville", ville);

                    int rowsAffected = command.ExecuteNonQuery();
                    MessageBox.Show("Client ajouté avec succès !");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de l'ajout du client : " + ex.Message);
            }
            finally
            {
                if (Mycnx.State == ConnectionState.Open)
                {
                    Mycnx.Close();
                    
                }
            }
        }


        string testoblig()
        {
            if (textNOM.Text == "")
            {
                return "entrer le nom du client";
            }
            if (textPrenom.Text == "")
            {
                return "entrer le prenom du client";
            }
            if (textadrs.Text == "")
            {
                return "entrer l'adresse du client";
            }
            if (texttel.Text == "")
            {
                return "entrer le numero du client";
            }
            if (texville.Text == "")
            {
                return "entrer la ville du client";
            }
            else { return null; }
        }

        private void bntsort_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void texttel_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar<48 || e.KeyChar > 75)
            {
                e.Handled = true;
            }
            if (e.KeyChar == 8)
            {
                e.Handled = false;
            }
        }
        
        private void bntactu_Click(object sender, EventArgs e)
        {
            textNOM.Text = " ";
            textPrenom.Text = " ";
            textadrs.Text = " ";
            texttel.Text = " ";
            texville.Text = " ";
        }


        public form_ajouter_mmoifier_cli(string clientId)
        {
            InitializeComponent();
            Mycnx = new SqlConnection(ConnectionString);

            
            LoadClientDetails(clientId);
        }

        private void LoadClientDetails(string clientId)
        {
            try
            {
                Mycnx.Open();

                string query = "SELECT * FROM Client WHERE id = @clientId";
                using (SqlCommand command = new SqlCommand(query, Mycnx))
                {
                    command.Parameters.AddWithValue("@clientId", clientId);

                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                       
                        textID.Text = reader["id"].ToString();
                        textNOM.Text = reader["nom"].ToString();
                        textPrenom.Text = reader["prenom"].ToString();
                        textadrs.Text = reader["adresse"].ToString();
                        texttel.Text = reader["téléphone"].ToString();
                        texville.Text = reader["pays"].ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors du chargement des détails du client : " + ex.Message);
            }
            finally
            {
                if (Mycnx.State == ConnectionState.Open)
                {
                    Mycnx.Close();
                }
            }
        }





        private void form_ajouter_mmoifier_cli_Load(object sender, EventArgs e)
        {

        }

        private void form_ajouter_mmoifier_cli_Leave(object sender, EventArgs e)
        {

        }

        private void texttel_TextChanged(object sender, EventArgs e)
        {

        }

        private void textNOM_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
