using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace LyonPalme.classe
{

    public class Combinaison : Materiel
    {
        #region atribut
        public string _taille { get; set; }

        public void SetCode(string code)
        {
            if (code != null)
                _code = code;
        }

        public void SetTaille(string taille)
        {
            if (taille != null)
                _taille = taille;
        }
        /*

        private string _code;
        private string _taille;

        #endregion

        #region constructeur

        public Combinaison(string code, string taille, string marque, string libelle, string etat) : base (code, marque, libelle, etat)
        {
            _code = code;
            _taille = taille;
        }

        #endregion

        #region accesseur

        public string getCode()
        {
            return _code;
        }

        public string getTaille()
        {
            return _taille;
        }

        public void setCode(string code)
        {
            _code = code;
        }

        public void setTaille(string taille)
        {
            _taille = taille;
        }*/
        #endregion
    }
}
