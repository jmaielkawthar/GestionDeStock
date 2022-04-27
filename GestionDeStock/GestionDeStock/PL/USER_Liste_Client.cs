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
    public partial class USER_Liste_Client : UserControl
    {
        private static USER_Liste_Client Userclient;
        private dbStockContext db;
        // creer un instance pour le usercontrole
        public static USER_Liste_Client Instance
        {
            get
            {
                if(Userclient==null)
                {
                    Userclient = new USER_Liste_Client();
                }
                return Userclient;
            }
        }
        public USER_Liste_Client()
        {
            InitializeComponent();
            db = new dbStockContext();
        }
        // ajouter dans la datagrid view 
        public void Actualisedatagrid()
        {
            db = new dbStockContext();
            dvgclient.Rows.Clear(); // vider datagrid view
            foreach(var S in db.Clients)
            {
                // ajouter les lignes dans datagrid 
                dvgclient.Rows.Add(false , S.ID_Client, S.Nom_Client, S.Prenom_Client,  S.Adresse_Client, S.Telephonne_Client, S.Email_Client, S.Pays_Client,S.Ville_Client );
            }
        }
        // verifier combien de ligne est selctiooner
        public string Selectverif()
        {
            int Nombreligneselect = 0;
            for(int i=0; i< dvgclient.Rows.Count; i++)
            {
                if((bool)dvgclient.Rows[i].Cells[0].Value==true )// si ligne es selectionner
                {
                    Nombreligneselect++;
                }
            }
            if(Nombreligneselect == 0)
            {
                return "selectionner le client que vous-voulez modifier";
            }
            if (Nombreligneselect > 1)
            {
                return "selectionner seulement 1 seul client pour modifier";
            }
            return null;
        }
        private void btnajouter_Click(object sender, EventArgs e)
        {
            PL.FRM_Ajouter_Modifier_Client frmclient = new FRM_Ajouter_Modifier_Client(this);
            frmclient.ShowDialog();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void boxrechercher_TextChanged(object sender, EventArgs e)
        {

        }

        private void boxrechercher_Enter(object sender, EventArgs e)
        {
            if(boxrechercher.Text == "Rechercher")
            {
                boxrechercher.Text = "";
                boxrechercher.ForeColor = Color.Black;
            }
        }

        private void dvgclient_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void USER_Liste_Client_Load(object sender, EventArgs e)
        {
            Actualisedatagrid();
        }
        public int IDselect;
        private void btnmodifier_Click(object sender, EventArgs e)
        {
            PL.FRM_Ajouter_Modifier_Client frmclient = new FRM_Ajouter_Modifier_Client(this);
            if (Selectverif()== null)
            {
                frmclient.lblTitle.Text = "Modifier Client";
                frmclient.btnactualiser.Visible = false;
                frmclient.ShowDialog();
            }
            else
            {
                MessageBox.Show(Selectverif(), "modification", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
    }
}
