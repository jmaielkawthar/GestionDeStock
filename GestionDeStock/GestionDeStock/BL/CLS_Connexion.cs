using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionDeStock.BL
{
    class CLS_Connexion
    {
		public bool ConnexionValide(dbStockContext db, string Nom, string Mot_De_Passe)
		{
			Utilisateur U = new Utilisateur(); // table utilisateur
			U.NomUser = Nom;
			U.Mot_De_Passe = Mot_De_Passe;
			if (db.Utilisateurs.SingleOrDefault(s => s.NomUser == Nom && s.Mot_De_Passe == Mot_De_Passe) != null) // si le nom d'user et le mot de passe existe dan la base de donnée
			{
				return true;
			}
			else // si n'existe pas
			{
				return false;
			}
		}
	}
}
