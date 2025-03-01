using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Markup;

namespace gstion_de_commande.formulairedossier
{
    
    public partial class Form_cnx : Form
    {
        
        private Form formmunue;

        public Form_cnx(Form formmunue)
        {
            InitializeComponent();
            this.formmunue = formmunue;
            textpwd.PasswordChar = '*';
        }

       

        private void bntquiter_Click(object sender, EventArgs e)
        {
            Close();
        }

       

        private void Form_cnx_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=AMINEICAME\\SQLEXPRESS;Initial Catalog=gestion_de_commandeNEW;Integrated Security=True";
           
            string username = textutilis.Text;
            string password = textpwd.Text;

            
           

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    
                    string query = "SELECT COUNT(*) FROM utilisateure WHERE nom_util = @username AND mdp = @password";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@username", username);
                        command.Parameters.AddWithValue("@password", password); 

                        int userCount = (int)command.ExecuteScalar();

                        if (userCount > 0)
                        {
                            MessageBox.Show("Connexion réussie à la base de données!");
                            (formmunue as form_menu).activeForm();


                            form_menu formmenu = new form_menu();
                            formmenu.ShowDialog();
                        }
                        else
                        {
                            MessageBox.Show("Nom d'utilisateur ou mot de passe incorrect.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur de connexion à la base de données : " + ex.Message);
            }
        }


        private void textpwd_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
    
}
