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
    public partial class FRM_Ajouter_Modifier_Client : Form
    {
        private UserControl usclient;
        public FRM_Ajouter_Modifier_Client(UserControl userC)
        {
            InitializeComponent();
            this.usclient = userC;
        }
        // les comp obligatoires
        string testobligatoire()
        {
            if(txtnom.Text =="" || txtnom.Text=="Nom de Client")
            {
                return "Entrer le nom de client";
            }
            if (txtemail.Text == "" || txtemail.Text == "Email Client")
            {
                return "Entrer le email de client";
            }
            //if (txtemail.Text != "" || txtemail.Text != "Email Client")
            //{
            //    try
            //    {
            //        new MailAdresse(txtemail.Text); // pour verifier email si valide ou nn
            //    }
            //    catch(Exception e)
            //    {
            //        return "Email Invalide";
            //    }
            //}
            return null;
        }
        private void FRM_Ajouter_Modifier_Client_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnactualiser_Click(object sender, EventArgs e)
        {
            txtnom.Text = "Nom de Client"; txtnom.ForeColor = Color.Silver;
            txtprenom.Text = "Prenom de Client"; txtprenom.ForeColor = Color.Silver;
            txtadresse.Text = "Adresse Client"; txtadresse.ForeColor = Color.Silver;
            txttelephone.Text = "Telephone Client"; txttelephone.ForeColor = Color.Silver;
            txtemail.Text = "Email Client"; txtemail.ForeColor = Color.Silver;
            txtpays.Text = "Pays Client"; txtpays.ForeColor = Color.Silver;
            txtville.Text = "Ville Client"; txtville.ForeColor = Color.Silver;

        }

        private void txtnom_Enter(object sender, EventArgs e)
        {
            if(txtnom.Text == "Nom de Client")
            {
                txtnom.Text = "";
                txtnom.ForeColor = Color.White;
            }
        }

        private void txtnom_Leave(object sender, EventArgs e)
        {
            if (txtnom.Text == "")
            {
                txtnom.Text = "Nom de Client";
                txtnom.ForeColor = Color.Silver;
            }
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txttelephone_KeyPress(object sender, KeyPressEventArgs e)
        {
            // textbox numeric
            if(e.KeyChar < 48 || e.KeyChar> 57) // code asci des numero
            {
                e.Handled = true;
            }
            if(e.KeyChar==8)
            {
                e.Handled = false;
            }
        }

        private void btnenregistrer_Click(object sender, EventArgs e)
        {
            if (testobligatoire() !=null)
            {
                MessageBox.Show(testobligatoire(), "obligatoire", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                BL.CLS_Client clclient = new BL.CLS_Client();
                if(clclient.Ajouter_Client(txtnom.Text, txtprenom.Text,txtadresse.Text , txttelephone.Text, txtemail.Text, txtpays.Text, txtville.Text)==true )
                {
                    MessageBox.Show("client ajouter avec succes", "Ajouter", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    (usclient as USER_Liste_Client).Actualisedatagrid();
                }
                else
                {
                    MessageBox.Show("Nom et prenom de client deja existe ", "Ajouter", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
            }
        }

        private void txtemail_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtemail_Enter(object sender, EventArgs e)
        {
            if (txtemail.Text == "Email Client")
            {
                txtemail.Text = "";
                txtemail.ForeColor = Color.White;
            }
        }

        private void txtemail_Leave(object sender, EventArgs e)
        {
            if (txtemail.Text == "")
            {
                txtemail.Text = "Email Client";
                txtemail.ForeColor = Color.Silver;
            }
        }

        private void txtnom_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtprenom_Enter(object sender, EventArgs e)
        {
            if (txtprenom.Text == "Prenom de Client")
            {
                txtprenom.Text = "";
                txtprenom.ForeColor = Color.White;
            }
        }

        private void txtprenom_Leave(object sender, EventArgs e)
        {
            if (txtprenom.Text == "")
            {
                txtprenom.Text = "Prenom de Client";
                txtprenom.ForeColor = Color.Silver;
            }
        }

        private void txttelephone_TextChanged(object sender, EventArgs e)
        {

        }

        private void txttelephone_Enter(object sender, EventArgs e)
        {
            if (txttelephone.Text == "Telephone Client")
            {
                txttelephone.Text = "";
                txttelephone.ForeColor = Color.White;
            }
        }

        private void txttelephone_Leave(object sender, EventArgs e)
        {
            if (txttelephone.Text == "")
            {
                txttelephone.Text = "Telephone Client";
                txttelephone.ForeColor = Color.Silver;
            }
        }

        private void txtadresse_Enter(object sender, EventArgs e)
        {
            if (txtadresse.Text == "Adresse Client")
            {
                txtadresse.Text = "";
                txtadresse.ForeColor = Color.White;
            }
        }

        private void txtadresse_Leave(object sender, EventArgs e)
        {
            if (txtadresse.Text == "")
            {
                txtadresse.Text = "Pays Client";
                txtadresse.ForeColor = Color.Silver;
            }
        }

        private void txtpays_Enter(object sender, EventArgs e)
        {
            if (txtpays.Text == "Pays Client")
            {
                txtpays.Text = "";
                txtpays.ForeColor = Color.White;
            }
        }

        private void txtville_Enter(object sender, EventArgs e)
        {
            if (txtville.Text == "Ville Client")
            {
                txtville.Text = "";
                txtville.ForeColor = Color.White;
            }
        }

        private void txtville_Leave(object sender, EventArgs e)
        {
            if (txtville.Text == "")
            {
                txtville.Text = "Ville Client";
                txtville.ForeColor = Color.Silver;
            }
        }
    }
}
