using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LyonPalme.classe
{
    public class Monopalme : Materiel
    {
        #region atribut
        public string _pointure { get; set; }

        public void SetCode(string code)
        {
            if (code != null)
                _code = code;
        }

        public void SetPointure(string pointure)
        {
            if (pointure != null)
                _pointure = pointure;
        }
        /*
        private string _code;
        private string _pointure;

        #endregion

        #region constructeur

        public Monopalme(string code, string pointure, string marque, string libelle, string etat) : base(code, marque, libelle, etat)
        {
            _code = code;
            _pointure = pointure;
        }

        #endregion

        #region accesseur

        public string getCode()
        {
            return _code;
        }

        public string getPointure()
        {
            return _pointure;
        }

        public void setCode(string code)
        {
            _code = code;
        }

        public void setPointure(string pointure)
        {
            _pointure = pointure;
        }*/
        #endregion

    }
}
