using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LyonPalme.Model
{
    public class ListMaterielModel
    {
        public string MAT_Id
        {
            get;set;
        }
        public string MAT_Marque
        {
            get; set;
        }
        public string MAT_Libelle
        {
            get; set;
        }
        public string MAT_Etat
        {
            get; set;
        }
        public int MAT_Pointure
        {
            get; set;
        }
        public string MAT_Taille
        {
            get; set;
        }
        public void setmaterielId(string materielId)
        {
            MAT_Id = materielId; 
        }

        public void setmaterielMarque(string materielMarque)
        {
            MAT_Marque = materielMarque;
        }

        public void setmaterielLibelle(string materielLibelle)
        {
            MAT_Libelle = materielLibelle;
        }

        public void setmaterielEtat(string materielEtat)
        {
            MAT_Etat =  materielEtat;
        }

        public void setmaterielPointure(int materielPointure)
        {
            MAT_Pointure = materielPointure;
        }

        public void setmaterielTaille(string materielTaille)
        {
            MAT_Taille = materielTaille;
        }
    }
}
