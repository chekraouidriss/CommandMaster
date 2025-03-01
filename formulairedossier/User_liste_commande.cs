using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gstion_de_commande.formulairedossier
{
    public partial class User_liste_commande : UserControl
    {
        private static User_liste_commande usercamd;
        public static User_liste_commande inc
        {
            get
            {
                if (usercamd == null)
                {
                    usercamd = new User_liste_commande();
                }
                return usercamd;
            }
        }
        public User_liste_commande()
        {
            InitializeComponent();
        }

        private void User_liste_commande_Load(object sender, EventArgs e)
        {

        }

        private void bntajoutPROD_Click(object sender, EventArgs e)
        {
            formulairedossier.newform_ligne_commande frrmcom = new formulairedossier.newform_ligne_commande();
            frrmcom.ShowDialog();

        }

        private void dvgprod_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
