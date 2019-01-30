#region Ressources extérieures
using System;
using System.Collections.Generic;
using System.Text;
using Projet_BD_EXEMPLE.Classes;
using Projet_BD_EXEMPLE.Acces;
#endregion

namespace Projet_BD_EXEMPLE.Gestion
{
 /// <summary>
 /// Couche intermédiaire de gestion (Business Layer)
 /// </summary>
 public class G_Personne : G_Base
 {
  #region Constructeurs
  public G_Personne()
   : base()
  { }
  public G_Personne(string sChaineConnexion)
   : base(sChaineConnexion)
  { }
  #endregion
  public int Ajouter(string NOM, string PRE, DateTime? NAI)
  { return new A_Personne(ChaineConnexion).Ajouter(NOM, PRE, NAI); }
  public int Modifier(int ID, string NOM, string PRE, DateTime? NAI)
  { return new A_Personne(ChaineConnexion).Modifier(ID, NOM, PRE, NAI); }
  public List<C_Personne> Lire(string Index)
  { return new A_Personne(ChaineConnexion).Lire(Index); }
  public C_Personne Lire_ID(int ID)
  { return new A_Personne(ChaineConnexion).Lire_ID(ID); }
  public int Supprimer(int ID)
  { return new A_Personne(ChaineConnexion).Supprimer(ID); }
 }
}
