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

namespace gstion_de_commande.formulairedossier
{
    public partial class User_liste_prod : UserControl
    {
        private const string ConnectionString = "Data Source=AMINEICAME\\SQLEXPRESS;Initial Catalog=gestion_de_commandeNEW;Integrated Security=True";
        SqlConnection Mycnx;
        private string SelectedProductId;
        private static User_liste_prod userprod;
        public static User_liste_prod inc
        {
            get
            {
                if (userprod == null)
                {
                    userprod = new User_liste_prod();
                }
                return userprod;
            }
        }
        public User_liste_prod()
        {
            InitializeComponent();
            Mycnx = new SqlConnection(ConnectionString);
        }

        private void User_liste_prod_Load(object sender, EventArgs e)
        {
            dvgprod.CellFormatting += dvgprod_CellFormatting;
            AfficherProduits();
        }

        private void txtrecherche_Enter(object sender, EventArgs e)
        {
            if (txtrecherche.Text == "recherche")
            {
                txtrecherche.Clear();
                txtrecherche.ForeColor = Color.Black;
            }
        }

       private void AfficherProduits()
        {
            try
            {
                Mycnx.Open();

                string query = "SELECT * FROM Produits"; 

                using (SqlCommand command = new SqlCommand(query, Mycnx))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable table = new DataTable();
                    adapter.Fill(table);

                    dvgprod.DataSource = table;
                    dvgprod.DefaultCellStyle.ForeColor = Color.Black;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de la récupération des produits : " + ex.Message);
            }
            finally
            {
                if (Mycnx.State == ConnectionState.Open)
                {
                    Mycnx.Close();
                }
            } 
        }


        private void bntajoutPROD_Click(object sender, EventArgs e)
        {
            formulairedossier.form_ajouter_modifier_PROD frmajouPROD = new formulairedossier.form_ajouter_modifier_PROD();
            frmajouPROD.ShowDialog();

            AfficherProduits();
        }

        private void dvgprod_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0) 
            {
                DataGridViewRow row = dvgprod.Rows[e.RowIndex];
                
                string selectedProductId = row.Cells["num_prod"].Value.ToString(); 
                                                                                   
                SelectedProductId = selectedProductId;
            }
        }

        private void dvgprod_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 4)
            {
                
                int quantityValue;
                if (int.TryParse(e.Value?.ToString(), out quantityValue))
                {
                    
                    if (quantityValue == 0)
                    {
                        e.CellStyle.BackColor = Color.Red;
                    }
                    if (quantityValue > 0)
                    {
                        e.CellStyle.BackColor = Color.LightGreen;
                    }
                }
            }
        }


        private void txtrecherche_TextChanged(object sender, EventArgs e)
        {
            string searchTerm = txtrecherche.Text.Trim();

            if (searchTerm != "")
            {
                
                string query = "SELECT * FROM Produits WHERE libelle LIKE @searchTerm";

                try
                {
                    Mycnx.Open();
                    using (SqlCommand command = new SqlCommand(query, Mycnx))
                    {
                        command.Parameters.AddWithValue("@searchTerm", "%" + searchTerm + "%");

                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        DataTable table = new DataTable();
                        adapter.Fill(table);

                        dvgprod.DataSource = table; 
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erreur lors de la recherche de produits : " + ex.Message);
                }
                finally
                {
                    if (Mycnx.State == ConnectionState.Open)
                    {
                        Mycnx.Close();
                    }
                }
            }
            else
            {
                
                AfficherProduits();
            }
        }

        private void bntsuppPROD_Click(object sender, EventArgs e)
        {
            
            if (!string.IsNullOrEmpty(SelectedProductId))
            {
                try
                {
                    Mycnx.Open();

                    
                    string deleteQuery = "DELETE FROM Produits WHERE num_prod = @productId";

                    using (SqlCommand deleteCommand = new SqlCommand(deleteQuery, Mycnx))
                    {
                        deleteCommand.Parameters.AddWithValue("@productId", SelectedProductId);

                        int rowsAffected = deleteCommand.ExecuteNonQuery();
                        MessageBox.Show("Produit supprimé avec succès !");
                        
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erreur lors de la suppression du produit : " + ex.Message);
                }
                finally
                {
                    if (Mycnx.State == ConnectionState.Open)
                    {
                        Mycnx.Close();
                        AfficherProduits();
                    }
                }
            }
            else
            {
                MessageBox.Show("Sélectionnez un produit à supprimer.");
            }
        }

        private void comborech_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedCategory = comborech.SelectedItem.ToString();

            if (selectedCategory != "Toutes les catégories") 
            {
                try
                {
                    Mycnx.Open();

                    
                    string query = "SELECT * FROM Produits WHERE num_categorie = (SELECT num_categorie FROM Categorie WHERE nom_categorie = @selectedCategory)";

                    using (SqlCommand command = new SqlCommand(query, Mycnx))
                    {
                        command.Parameters.AddWithValue("@selectedCategory", selectedCategory);

                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        DataTable table = new DataTable();
                        adapter.Fill(table);

                        dvgprod.DataSource = table; 
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erreur lors de la récupération des produits de la catégorie : " + ex.Message);
                }
                finally
                {
                    if (Mycnx.State == ConnectionState.Open)
                    {
                        Mycnx.Close();
                    }
                }
            }
            else
            {
                
                AfficherProduits();
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
                string selectedOrder = combofiltre.SelectedItem.ToString();

                try
                {
                    Mycnx.Open();

                    string query = "SELECT * FROM Produits";

                    
                    if (selectedOrder == "Du moins cher au plus cher")
                    {
                        query += " ORDER BY prix ASC"; 
                    }
                    else if (selectedOrder == "Du plus cher au moins cher")
                    {
                        query += " ORDER BY prix DESC"; 
                    }

                    using (SqlCommand command = new SqlCommand(query, Mycnx))
                    {
                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        DataTable table = new DataTable();
                        adapter.Fill(table);

                        dvgprod.DataSource = table; 
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erreur lors de la récupération des produits : " + ex.Message);
                }
                finally
                {
                    if (Mycnx.State == ConnectionState.Open)
                    {
                        Mycnx.Close();
                    }
                }
            

        }

       


        private void bntMODIFPROD_Click(object sender, EventArgs e)
        {

           
                if (!string.IsNullOrEmpty(SelectedProductId))
                {
                   
                    int selectedProductId = Convert.ToInt32(SelectedProductId);

                    form_ajouter_modifier_PROD frmModifierProduit = new form_ajouter_modifier_PROD(selectedProductId);
                   
                    frmModifierProduit.labtitre.Text = "Modifier un client";
                    frmModifierProduit.bntactu.Visible = false;
                   
                   

                    frmModifierProduit.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Sélectionnez un produit à modifier.");
                }
            


        }
    }
}
