using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionDeStock.PL
{
    public partial class FRM_Menu : Form
    {
        public FRM_Menu()
        {
            InitializeComponent();
            panel3.Size = new Size(229, 612);
            pnlparameter.Visible = false;
        }
        // deactiver formulaire 
        void deactiverform()
        {
            btnclient.Enabled = false;
            btnproduit.Enabled = false;
            btncategorie.Enabled = false;
            btncommande.Enabled = false;
            btnutilisateur.Enabled = false;
            btncopie.Enabled = false;
            btnrestaurer.Enabled = false;
            btndeconnecter.Enabled = false;
            btnproduit.Enabled = false;
            pnlbut.Enabled = false;
            btndeconnecter.Enabled = false;
        }
        //active formulaire
        public void activerform()
        {
            btnclient.Enabled = true;
            btnproduit.Enabled = true;
            btncategorie.Enabled = true;
            btncommande.Enabled = true;
            btnutilisateur.Enabled = true;
            btncopie.Enabled = true;
            btnrestaurer.Enabled = true;
            btndeconnecter.Enabled = true;
            btnproduit.Enabled = true;
            pnlbut.Enabled = true;
            btndeconnecter.Enabled = true;
            pnlparameter.Visible = false;
        }


        private void btnstart_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnminimise_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnproduit_Click(object sender, EventArgs e)
        {
            pnlbut.Top = btnproduit.Top;
        }

        private void btnutilisateur_Click(object sender, EventArgs e)
        {
            pnlbut.Top = btnutilisateur.Top;
        }

        private void btncategorie_Click(object sender, EventArgs e)
        {
            pnlbut.Top = btncategorie.Top;

        }

        private void btncommande_Click(object sender, EventArgs e)
        {
            pnlbut.Top = btncommande.Top;
        }

        private void button4_Click_1(object sender, EventArgs e)
        {

            if (panel3.Width == 229)
            {
                panel3.Size = new Size(82, 612);
            }
            else
            {
                panel3.Size = new Size(229, 612);
            }
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnclient_Click(object sender, EventArgs e)
        {
            pnlbut.Top = btnclient.Top;
            if (!pnlaficher.Controls.Contains(USER_Liste_Client.Instance))
            {
                pnlaficher.Controls.Add(USER_Liste_Client.Instance);
                USER_Liste_Client.Instance.Dock = DockStyle.Fill;
                USER_Liste_Client.Instance.BringToFront();
            }
            else
            {
                USER_Liste_Client.Instance.BringToFront();
            }

        }

        private void btnparameter_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void btnparameter_Click_1(object sender, EventArgs e)
        {
            pnlparameter.Size = new Size(293, 250);
            pnlparameter.Visible = !pnlparameter.Visible;
        }

        private void btnconnecter_Click(object sender, EventArgs e)
        {
         FRM_Connexion frmc = new FRM_Connexion(this); // this = frm-menu
            frmc.ShowDialog();
        }

        private void FRM_Menu_Load(object sender, EventArgs e)
        {
            deactiverform();
        }

        private void btndeconnecter_Click(object sender, EventArgs e)
        {
            deactiverform();
        }
    }
}
