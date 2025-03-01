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
using static System.Net.Mime.MediaTypeNames;

namespace gstion_de_commande.formulairedossier
{
    public partial class form_ajouter_modifier_PROD : Form
    {

        private const string ConnectionString = "Data Source=AMINEICAME\\SQLEXPRESS;Initial Catalog=gestion_de_commandeNEW;Integrated Security=True";
        SqlConnection Mycnx;
        public form_ajouter_modifier_PROD()
        {
                InitializeComponent();
                Mycnx = new SqlConnection(ConnectionString);
                

        }
        
        public form_ajouter_modifier_PROD(int productId)
        {
            InitializeComponent();
            Mycnx = new SqlConnection(ConnectionString);
            LoadProductDetails(productId);

        }
        private void LoadProductDetails(int productId)
        {
            try
            {
                Mycnx.Open();

                string query = "SELECT * FROM Produits WHERE num_prod = @productId";
                using (SqlCommand command = new SqlCommand(query, Mycnx))
                {
                    command.Parameters.AddWithValue("@productId", productId);

                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                       
                       
                        textNOMPROD.Text = reader["libelle"].ToString();
                        textPRIX.Text = reader["prix"].ToString();
                        textQUANT.Text = reader["qte_stock"].ToString();
                        textcat.Text = reader["num_categorie"].ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors du chargement des détails du produit : " + ex.Message);
            }
            finally
            {
                if (Mycnx.State == ConnectionState.Open)
                {
                    Mycnx.Close();
                }
            }
        }

        string testobliga()
        {
               
                if (textNOMPROD.Text == "")
                {
                    return "entrer le Nom du produit";
                }
                if (textQUANT.Text == "")
                {
                    return "entrer la quantite";
                }
                if (textPRIX.Text == "")
                {
                    return "entrer le prix du produit";
                }
                else { return null; }
        }

       

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void form_ajouter_modifier_PROD_Load(object sender, EventArgs e)
        {

        }

        private void textNOMPROD_TextChanged(object sender, EventArgs e)
        {

        }

        private void textNOMPROD_Enter(object sender, EventArgs e)
        {

        }

        private void bntsort_Click(object sender, EventArgs e)
        {
            Close();
        }

       

        private void bntactu_Click(object sender, EventArgs e)
        {
           
            textNOMPROD.Text = "";
            textQUANT.Text = "";
            textPRIX.Text = "";
            textcat.Text = "";
           
        }

      

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void bntenreg_Click_1(object sender, EventArgs e)
        {
                if (testobliga() != null)
                {
                    MessageBox.Show(testobliga(), "obligatoire", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                
                string libelle = textNOMPROD.Text;
                Single prix;
                if (!Single.TryParse(textPRIX.Text, out prix))
                {
                    MessageBox.Show("Veuillez entrer un prix valide.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                int quantite;
                if (!int.TryParse(textQUANT.Text, out quantite))
                {
                    MessageBox.Show("Veuillez entrer une quantité valide.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                int cate; 
                if (!int.TryParse(textcat.Text, out cate))
                {
                    MessageBox.Show("Numéro de catégorie invalide.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                try
                {
                    Mycnx.Open();

                    string query = "INSERT INTO Produits (libelle, prix, qte_stock, num_categorie) VALUES (@libelle, @prix, @quantite, @numCategorie)";
                    using (SqlCommand command = new SqlCommand(query, Mycnx))
                    {
                        command.Parameters.AddWithValue("@libelle", libelle);
                        command.Parameters.AddWithValue("@prix", prix);
                        command.Parameters.AddWithValue("@quantite", quantite);
                        command.Parameters.AddWithValue("@numCategorie", cate);

                        int rowsAffected = command.ExecuteNonQuery();
                        MessageBox.Show("Produit ajouté avec succès !");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erreur lors de l'ajout du produit : " + ex.Message);
                }
                finally
                {
                    if (Mycnx.State == ConnectionState.Open)
                    {
                        Mycnx.Close();
                    }
                }
            

        }

       
    }
}
