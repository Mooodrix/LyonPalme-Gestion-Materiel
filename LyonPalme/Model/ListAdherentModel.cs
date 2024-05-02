using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LyonPalme.Model
{
    public class ListAdherentModel
    {
        
        public int ADH_Id
        {
            get; set;
        }
        public string ADH_Nom
        {
            get; set;
        }
        public string ADH_Prenom
        {
            get; set;
        }

        public string ADH_Mobile
        {
            get; set;
        }

        public string ADH_AdresseMail
        {
            get; set;
        }
        public void setadhId(int adhId)
        {
            ADH_Id = adhId;
        }

        public void setadhNom(string adhNom)
        {
            ADH_Nom = adhNom;
        }

        public void setadhPrenom(string adhPrenom)
        {
            ADH_Prenom = adhPrenom;
        }

        public void setadhMobile(string adhMobile)
        {
            ADH_Mobile = adhMobile;
        }

        public void setadhMail(string adhMail)
        {
            ADH_AdresseMail = adhMail;
        }

    }
}
