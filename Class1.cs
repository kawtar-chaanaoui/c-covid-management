using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Covid
{
    class CPR
    {
        private String pcrCode;
        private DateTime date;
        private Boolean result;
        private string cin;

        public CPR()
        {

        }
        public CPR(string pcrCode, DateTime date, bool result,String cin)
        {
            this.pcrCode = pcrCode;
            this.date = date;
            this.result = result;
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
        public void setcode(String pcrcode)
        {
            this.pcrCode = pcrcode;
        }
        public String getcode()
        {
            return pcrCode;
        }
        public void setdate(DateTime date)
        {
            this.date = date;
        }
        public DateTime getdate()
        {
            return date;
        }
        public void setresult(bool result)
        {
            this.result = result;
        }
        public bool getresult()
        {
            return result;
        }


    }
}
