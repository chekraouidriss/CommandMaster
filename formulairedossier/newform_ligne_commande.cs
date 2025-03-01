using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gstion_de_commande.formulairedossier
{
    public partial class newform_ligne_commande : Form
    {
        private const string ConnectionString = "Data Source=AMINEICAME\\SQLEXPRESS;Initial Catalog=gestion_de_commandeNEW;Integrated Security=True";
        SqlConnection Mycnx; 

        public newform_ligne_commande()
        {
            InitializeComponent();
            Mycnx = new SqlConnection(ConnectionString);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            formulairedossier.form_ajouter_mmoifier_cli frrmcom = new formulairedossier.form_ajouter_mmoifier_cli();
            frrmcom.ShowDialog();
        }

        private void bntquite_Click(object sender, EventArgs e)
        {
            Close();
        }

        private DataTable GetProductsFromDatabase()
        {
            DataTable productsTable = new DataTable();

            try
            {
                Mycnx.Open();

                string query = "SELECT * FROM Produits";

                using (SqlCommand command = new SqlCommand(query, Mycnx))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    adapter.Fill(productsTable);
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

            return productsTable;
        }

        private void AfficherProduitsCommandes()
        {
            try
            {
                Mycnx.Open();

                string query = "SELECT num_cmd,num_prod,qte,prix,remise,total FROM LigneCommande"; 

                using (SqlCommand command = new SqlCommand(query, Mycnx))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataSet dataSet = new DataSet();
                    adapter.Fill(dataSet, "LigneCommande"); 
                    dvgprodcmd.DataSource = dataSet.Tables["LigneCommande"]; 
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de la récupération des produits commandés : " + ex.Message);
            }
            finally
            {
                if (Mycnx.State == ConnectionState.Open)
                {
                    Mycnx.Close();
                }
            }
        }

        private void newform_ligne_commande_Load(object sender, EventArgs e)
        {
            AfficherProduitsCommandes();
            AfficherProduits();
            ChargerNomsClients();
        }

        private void ChargerNomsClients()
        {
            try
            {
                Mycnx.Open();

                string query = "SELECT nom FROM Client";
                using (SqlCommand command = new SqlCommand(query, Mycnx))
                {
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        string nomClient = reader["nom"].ToString();
                        comboBoxClients.Items.Add(nomClient);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors du chargement des noms de clients : " + ex.Message);
            }
            finally
            {
                if (Mycnx.State == ConnectionState.Open)
                {
                    Mycnx.Close();
                }
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

                    dvgprods.DataSource = table;
                    
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


        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string searchTerm = textBox1.Text.Trim();

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

                        dvgprods.DataSource = table; 
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
                    else
                    {
                    AfficherProduits();

                    }
                }
                 
            }
           

        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (textBox1.Text == "recherche")
            {
                textBox1.Text = "";
            }
        }

        private void dvgprods_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            formulairedossier.Form_prod_comd frmc = new Form_prod_comd();
            if ((int)dvgprods.CurrentRow.Cells[4].Value == 0)
            {
                MessageBox.Show("stock vide", "stock", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                
                frmc.lbNom.Text = dvgprods.CurrentRow.Cells[1].Value.ToString();
                frmc.lblPrix.Text = dvgprods.CurrentRow.Cells[2].Value.ToString();
                frmc.lblStock.Text = dvgprods.CurrentRow.Cells[3].Value.ToString();
                
                frmc.ShowDialog();
            }
        }

        private void dvgprodcmd_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dvgprodcmd.SelectedRows.Count == 0)
            {
                MessageBox.Show("Veuillez sélectionner une ligne à supprimer.", "Sélectionnez une ligne", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return; 
            }

            int idProduit = Convert.ToInt32(dvgprodcmd.SelectedRows[0].Cells["num_prod"].Value);
            int idCommande = Convert.ToInt32(dvgprodcmd.SelectedRows[0].Cells["num_cmd"].Value);

            try
            {
                Mycnx.Open();

                string query = "DELETE FROM LigneCommande WHERE num_prod = @idProduit AND num_cmd = @idCommande";

                using (SqlCommand command = new SqlCommand(query, Mycnx))
                {
                    command.Parameters.AddWithValue("@idProduit", idProduit);
                    command.Parameters.AddWithValue("@idCommande", idCommande);
                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Produit de la commande supprimé avec succès !");
                        
                    }
                    else
                    {
                        MessageBox.Show("Impossible de supprimer le produit de la commande.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de la suppression du produit de la commande : " + ex.Message);
            }
            finally
            {
                if (Mycnx.State == ConnectionState.Open)
                {
                    Mycnx.Close();
                }
            }


        }

        private void CalculerTotals()
        {
            decimal totalHT = 0;
            decimal totalTTC = 0;

            foreach (DataGridViewRow row in dvgprodcmd.Rows)
            {
                
                decimal prixUnitaire = Convert.ToDecimal(row.Cells["prix"].Value);
                decimal remise = Convert.ToDecimal(row.Cells["remise"].Value);
                int quantite = Convert.ToInt32(row.Cells["qte"].Value);

                
                decimal totalLigneHT = prixUnitaire * quantite - remise;
                totalHT += totalLigneHT;

                
                decimal tva = Convert.ToDecimal(texttva.Text); 
                decimal totalLigneTTC = totalLigneHT * (1 + tva);
                totalTTC += totalLigneTTC;
            }

            
            txtTotalHT.Text = totalHT.ToString("N2");
            txtTotalTTC.Text = totalTTC.ToString("N2");
        }

       


        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
