using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient ;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gstion_de_commande.formulairedossier
{
    public partial class form_menu : Form
    {
        public form_menu()
        {
            InitializeComponent();
            panel1.Size = new Size(229, 612);
            panelparam.Visible = false;
            Form_cnx formCnx = new Form_cnx(this);
        }

       

        public void activeForm()
        {
            bntclient.Enabled = true;
            bntprod.Enabled = true;
            bntcomm.Enabled = true;
            pnlbnt.Visible = true;
        }


        private void bntclient_Click(object sender, EventArgs e)
        {
            pnlbnt.Top = bntclient.Top;
            if (!pnlfiche.Controls.Contains(User_liste_client.inc))
            {
                pnlfiche.Controls.Add(User_liste_client.inc);
                User_liste_client.inc.Dock = DockStyle.Fill;
                User_liste_client.inc.BringToFront();
            }
            else
            {
                User_liste_client.inc.BringToFront();
            }
        }
        
        private void bntprod_Click_1(object sender, EventArgs e)
        {
            pnlbnt.Top = bntprod.Top;
            if (!pnlfiche.Controls.Contains(User_liste_prod.inc))
            {
                pnlfiche.Controls.Add(User_liste_prod.inc);
                User_liste_prod.inc.Dock = DockStyle.Fill;
                User_liste_prod.inc.BringToFront();
            }
            else
            {
                User_liste_prod.inc.BringToFront();
            }

        }


        private void button2_Click(object sender, EventArgs e)
        {
            if(panel1.Width== 229)
            {
                panel1.Size= new Size(82, 612);
            }
            else
            {
                panel1.Size = new Size(229, 612);
            }
        }
        
       

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }


       

       

        private void bntcomm_Click_1(object sender, EventArgs e)
        {
            pnlbnt.Top = bntcomm.Top;
            if (!pnlfiche.Controls.Contains(User_liste_commande.inc))
            {
                pnlfiche.Controls.Add(User_liste_commande.inc);
                User_liste_commande.inc.Dock = DockStyle.Fill;
                User_liste_commande.inc.BringToFront();
            }
            else
            {
                User_liste_commande.inc.BringToFront();
            }
        }

     

     

       


        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            panelparam.Size = new Size(340, 121);
            panelparam.Visible = !panelparam.Visible;
        }

        private void button1_Click_2(object sender, EventArgs e)
        {

            Form_cnx formcnx = new Form_cnx(this);
            formcnx.ShowDialog();
        }

        private void form_menu_Load(object sender, EventArgs e)
        {
            
        }

      

       

        private void pnfich_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint_1(object sender, PaintEventArgs e)
        {

        }
    }
}
