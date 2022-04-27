using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionDeStock.BL
{
    class CLS_Client
    {
        private dbStockContext db = new dbStockContext();
        private Client C; // table client

        // fonction pour ajouter client dans la bsae de donnée
        public bool Ajouter_Client(string Nom, string prenom, string Adresse, string Telephone, string Email, string pays, string Ville)
        {
            C = new Client();
            C.Nom_Client = Nom;
            C.Prenom_Client = prenom;
            C.Adresse_Client = Adresse;
            C.Telephonne_Client = Telephone;
            C.Email_Client = Email;
            C.Pays_Client = pays;
            C.Ville_Client = Ville;
            // verifier si le nom et le prenom existe dej dans la base de données
            if(db.Clients.SingleOrDefault(s => s.Nom_Client == Nom && C.Prenom_Client== prenom)==null) // si n'existe pas
            {
                db.Clients.Add(C);// ajouter dans la table de client
                db.SaveChanges(); // enregistrer dans la base de données
                return true;
            }
            else // si existe
            {
                return false;
            }
        }
        public void Modifier_client(int id, string Nom, string prenom, string Adresse, string Telephone, string Email, string pays, string Ville)
        {
            C = new Client();
            C = db.Clients.SingleOrDefault(s => s.ID_Client == id); // verifier si id d client et existe
            if(C!=null) //existe
            {
                C.Nom_Client = Nom;
                C.Prenom_Client = prenom;
                C.Adresse_Client = Adresse;
                C.Telephonne_Client = Telephone;
                C.Email_Client = Email;
                C.Pays_Client = pays;
                C.Ville_Client = Ville;
                db.SaveChanges();
            }
        }
    }
}
