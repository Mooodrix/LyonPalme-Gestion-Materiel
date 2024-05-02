using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LyonPalme.Model
{
    public class ListPretModel
    {
        
        public string EMP_Id
        {
            get; set;
        }
        public DateTime EMP_Date
        {
            get; set;
        }
        public DateTime EMP_DateRetour
        {
            get; set;
        }

        public int ADH_Id
        {
            get; set;
        }

        public string MAT_Id
        {
            get; set;
        }
        public void setempId(string empId)
        {
            EMP_Id = empId;
        }

        public void setempDate(DateTime empDate)
        {
            EMP_Date = empDate;
        }

        public void setdateRetour(DateTime dateRetour)
        {
            EMP_DateRetour = dateRetour;
        }

        public void setadhId(int adhId)
        {
            ADH_Id = adhId;
        }

        public void setmatId(string matId)
        {
            MAT_Id = matId;
        }

    }
}
