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
        private String cne;
        public Quarantined()
        {

        }
        public Quarantined(string idQuarantine, DateTime dateI, DateTime dateF, string cne)
        {
            this.idQuarantine = idQuarantine;
            this.dateI = dateI;
            this.dateF = dateF;
            this.cne = cne;
        }

    }
}
