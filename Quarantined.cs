using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Covid
{
    class Quarantined
    {
        private String idQuarantine;
        private DateTime dateI;
        private DateTime dateF;
        private String cin;
        public Quarantined()
        {

        }

        public Quarantined(string idQuarantine, DateTime dateI, DateTime dateF, string cin)
        {
            this.idQuarantine = idQuarantine;
            this.dateI = dateI;
            this.dateF = dateF;
            this.cin = cin;
        }

        public void setcin(String cin)
        {
            this.cin = cin;
        }
        public String getcin()
        {
            return cin;
        }
        public void setIDq(String idQuarantine)
        {
            this.idQuarantine = idQuarantine;
        }
        public String getIDq()
        {
            return idQuarantine;
        }
        public void setdateI(DateTime dateI)
        {
            this.dateI= dateI;
        }
        public DateTime getDateI()
        {
            return dateI;
        }
        public void setdateF(DateTime dateF)
        {
            this.dateF = dateF;
        }
        public DateTime getdateF()
        {
            return dateF;
        }


    }
}
