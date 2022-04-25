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
            dvgclient.Rows.Clear(); // vider datagrid view
            foreach(var S in db.Clients)
            {
                // ajouter les lignes dans datagrid 
                dvgclient.Rows.Add(false , S.ID_Client, S.Prenom_Client, S.Telephonne_Client, S.Adresse_Client, S.Email_Client, S.Pays_Client,S.Ville_Client );
            }
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
            //dvgclient.Rows.Add();
            //dvgclient.Rows[0].Cells[1].Value = "tom";
            //dvgclient.Rows[0].Cells[2].Value = "xxx";
            //dvgclient.Rows[0].Cells[3].Value = "xx";

            //dvgclient.Rows[0].Cells[4].Value = "2222222";
            //dvgclient.Rows[0].Cells[5].Value = "info@mail.com";
            //dvgclient.Rows[0].Cells[6].Value = "tunisa ";
            //dvgclient.Rows[0].Cells[6].Value = "sfax";
        }

        private void btnmodifier_Click(object sender, EventArgs e)
        {
            PL.FRM_Ajouter_Modifier_Client frmclient = new FRM_Ajouter_Modifier_Client(this);
            frmclient.lblTitle.Text = "Modifier Client";
            frmclient.btnactualiser.Visible = false;

            frmclient.ShowDialog();
        }
    }
}
