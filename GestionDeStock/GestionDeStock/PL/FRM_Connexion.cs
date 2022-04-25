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
    public partial class FRM_Connexion : Form
    {
        private dbStockContext db;
        private Form frammenu;
        BL.CLS_Connexion C = new BL.CLS_Connexion();
        public FRM_Connexion(Form Menu)
        {
            InitializeComponent();
            this.frammenu = Menu;
            db = new dbStockContext();
        }
        string testobligatoire()
        {
            if (txtnom.Text == "" || txtnom.Text == "Nom d'utlisateur")
            {
                return "Entrer votre Nom";
            }
            if (txtmotdepasse.Text == "" || txtmotdepasse.Text == "Mot de passe")
            {
                return "Entrer votre Mot de passe";
            }
            return null;
        }
        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FRM_Connexion_Load(object sender, EventArgs e)
        {
        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void txtnom_Enter(object sender, EventArgs e)
        {
            if (txtnom.Text == "Nom d'utlisateur")
            {
                txtnom.Text = "";
                txtnom.ForeColor = Color.WhiteSmoke;
            }
        }

        private void txtnom_Leave(object sender, EventArgs e)
        {
            if (txtnom.Text == "")
            {
                txtnom.Text = "Nom d'utlisateur";
                txtnom.ForeColor = Color.Silver;
            }
        }

        private void txtmotdepasse_Enter(object sender, EventArgs e)
        {
            if (txtmotdepasse.Text == "Mot de passe")
            {
                txtmotdepasse.Text = "";
                txtmotdepasse.UseSystemPasswordChar = false;
                txtmotdepasse.PasswordChar = '*';
                txtmotdepasse.ForeColor = Color.WhiteSmoke;
            }
        }

        private void txtmotdepasse_Leave(object sender, EventArgs e)
        {

            if (txtmotdepasse.Text == "")
            {
                txtmotdepasse.Text = "Mot de passe";
                txtmotdepasse.UseSystemPasswordChar = true; // deactiver pasword char
                txtmotdepasse.ForeColor = Color.Silver;
            }
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            if (testobligatoire() == null)
            {
                if (C.ConnexionValide(db, txtnom.Text, txtmotdepasse.Text) == true)// user existe
                {
                    MessageBox.Show("Connexion a réussi", "Connexion", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    (frammenu as FRM_Menu).activerform();
                    this.Close();
                }
                else // fase n'existe pas
                {
                    MessageBox.Show("Connexion a échoué", "Connexion", MessageBoxButtons.OK, MessageBoxIcon.Error);
    
                 }
            }
            else
            {
                MessageBox.Show(testobligatoire(), "obligatoire", MessageBoxButtons.OK, MessageBoxIcon.Error);
   
            }
        }
    }
}
