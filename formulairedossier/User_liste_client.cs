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

    public partial class User_liste_client : UserControl
    {
        private const string ConnectionString = " Data Source=AMINEICAME\\SQLEXPRESS;Initial Catalog=gestion_de_commandeNEW;Integrated Security=True";
        SqlConnection Mycnx;
        private static User_liste_client userclient;
        public static User_liste_client inc
        {
            get
            {
                if (userclient == null)
                {
                    userclient = new User_liste_client();
                }
                return userclient;
            }
        }
        public User_liste_client()
        {
            InitializeComponent();
            Mycnx = new SqlConnection(ConnectionString);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            formulairedossier.form_ajouter_mmoifier_cli frmajout = new formulairedossier.form_ajouter_mmoifier_cli();
            frmajout.ShowDialog();
            AfficherClients();
        }

        private void AfficherClients()
        {
            try
            {
                Mycnx.Open();

                string query = "SELECT * FROM Client";

                using (SqlCommand command = new SqlCommand(query, Mycnx))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable table = new DataTable();
                    adapter.Fill(table);

                    dvgclient.DataSource = table;
                    dvgclient.DefaultCellStyle.ForeColor = Color.Black;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de la récupération des clients : " + ex.Message);
            }
            finally
            {
                if (Mycnx.State == ConnectionState.Open)
                {
                    Mycnx.Close();
                }
            }
        }

        private void User_liste_client_Load(object sender, EventArgs e)
        {
            AfficherClients();
        }

        private void txtrecherche_Enter(object sender, EventArgs e)
        {
            if (txtrecherche.Text == "recherche")
            {
                txtrecherche.Clear();
                txtrecherche.ForeColor = Color.Black;
            }
        }

        private void txtrecherche_TextChanged(object sender, EventArgs e)
        {
            string searchTerm = txtrecherche.Text.Trim();

            if (searchTerm != "")
            {
                
                string query = "SELECT * FROM Client WHERE nom LIKE @searchTerm";

                try
                {
                    Mycnx.Open();
                    using (SqlCommand command = new SqlCommand(query, Mycnx))
                    {
                        command.Parameters.AddWithValue("@searchTerm", "%" + searchTerm + "%");

                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        DataTable table = new DataTable();
                        adapter.Fill(table);

                        dvgclient.DataSource = table; 
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erreur lors de la recherche de clients : " + ex.Message);
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
                
                AfficherClients();
            }
        }


        private void button2_Click(object sender, EventArgs e)
        {
            if (dvgclient.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dvgclient.SelectedRows[0];
                string selectedClientId = selectedRow.Cells["id"].Value.ToString();

                
                form_ajouter_mmoifier_cli cli = new form_ajouter_mmoifier_cli(selectedClientId);
                cli.labtitre.Text = "Modifier un client";
                cli.bntactu.Visible = false;
                cli.ShowDialog();
            }
            else
            {
                MessageBox.Show("Sélectionnez un client à modifier.");
            }
        }



        private void txtrecherche_Leave(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(selectedClientId))
            {
                MessageBox.Show("Sélectionnez un client à supprimer.");
                return;
            }

            try
            {
                Mycnx.Open();

               
                string checkQuery = "SELECT COUNT(*) FROM Client WHERE id = @clientId";

                using (SqlCommand checkCommand = new SqlCommand(checkQuery, Mycnx))
                {
                    checkCommand.Parameters.AddWithValue("@clientId", selectedClientId);

                    int clientCount = Convert.ToInt32(checkCommand.ExecuteScalar());

                    if (clientCount == 0)
                    {
                        MessageBox.Show("Le client n'existe pas dans la base de données !");
                        return;
                    }
                }

                
                string deleteQuery = "DELETE FROM Client WHERE id = @clientId";

                using (SqlCommand deleteCommand = new SqlCommand(deleteQuery, Mycnx))
                {
                    deleteCommand.Parameters.AddWithValue("@clientId", selectedClientId);

                    int rowsAffected = deleteCommand.ExecuteNonQuery();
                    MessageBox.Show("Client supprimé avec succès !");
                    
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de la suppression du client : " + ex.Message);
            }
            finally
            {
                if (Mycnx.State == ConnectionState.Open)
                {
                    Mycnx.Close();
                    AfficherClients();
                }
            }
        

        }
        private string selectedClientId;

        private void dvgclient_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0 && e.ColumnIndex >= 0) 
            {
                DataGridViewRow row = dvgclient.Rows[e.RowIndex];
                selectedClientId = row.Cells["id"].Value.ToString(); 
            }
            else
            {
                
                MessageBox.Show("La cellule est vide ou non sélectionnée.");
            }


        }

        private void comborech_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
