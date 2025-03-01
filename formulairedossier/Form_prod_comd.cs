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
    public partial class Form_prod_comd : Form
    {
        private const string ConnectionString = "Data Source=AMINEICAME\\SQLEXPRESS;Initial Catalog=gestion_de_commandeNEW;Integrated Security=True";
        SqlConnection Mycnx;
        public Form_prod_comd()
        {
            InitializeComponent();
            Mycnx = new SqlConnection(ConnectionString);
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void bntquiter_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void textquant_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsDigit(e.KeyChar)&& e.KeyChar != 8)
            {
                e.Handled = true;
            }        
        }

        private void textremise_TextChanged(object sender, EventArgs e)
        {
            if (textremise.Text != "")
            {
                int quant = int.Parse(textquant.Text);
                int prix = int.Parse(lblPrix.Text);
                int total = quant * prix;
                int remise = int.Parse(textremise.Text );
                texttotal.Text = (total - (total * remise / 100)).ToString();
            }
            else
            {

                int quant = int.Parse(textquant.Text);
                int prix = int.Parse(lblPrix.Text);
                texttotal.Text = (quant*prix).ToString();
            }
        }

        private void textremise_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void textquant_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textquant.Text))
            {
                texttotal.Text = lblPrix.Text;
            }
            else
            {
                int quant;
                if (int.TryParse(textquant.Text, out quant))
                {
                    int stock = int.Parse(lblStock.Text);
                    if (quant > stock)
                    {
                        MessageBox.Show("La quantité dépasse le stock disponible : " + stock.ToString());
                        textquant.Text = ""; 
                    }
                    else
                    {
                        int prix = int.Parse(lblPrix.Text);
                        texttotal.Text = (quant * prix).ToString();
                    }
                }
                else
                {
                    MessageBox.Show("Veuillez saisir une quantité valide.");
                }
            }
        }

        
        private void button1_Click(object sender, EventArgs e)
        {
               
                int id = int.Parse(textid.Text); 
                int idprod = int.Parse(lblid.Text);
                int qte = int.Parse(textquant.Text);
                int prix = int.Parse(lblPrix.Text);
                int remise = int.Parse(textremise.Text); 
                int total = int.Parse(texttotal.Text); 

                try
                {
                    Mycnx.Open();

                    string query = "INSERT INTO Lignecommande (num_cmd,num_prod,qte, prix, remise, total) VALUES (@num_cmd,@num_prod, @qte,@prix, @remise, @total)";
                    using (SqlCommand command = new SqlCommand(query, Mycnx))
                    {

                        command.Parameters.AddWithValue("@num_cmd", id);
                        command.Parameters.AddWithValue("@num_prod", idprod);
                        command.Parameters.AddWithValue("@qte", qte);
                        command.Parameters.AddWithValue("@prix", prix);
                        command.Parameters.AddWithValue("@remise", remise);
                        command.Parameters.AddWithValue("@total", total);

                        int rowsAffected = command.ExecuteNonQuery();
                        MessageBox.Show("Données de la commande enregistrées avec succès !");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erreur lors de l'enregistrement des données de la commande : " + ex.Message);
                }
                finally
                {
                    if (Mycnx.State == ConnectionState.Open)
                    {
                        Mycnx.Close();
                    }
                }

            

        }

        private void Form_prod_comd_Load(object sender, EventArgs e)
        {
            
        }

        private void texttotal_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
