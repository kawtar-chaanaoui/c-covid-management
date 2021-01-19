using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Covid
{
    class Metier
    {
        DataBase dataBase;
        public void insertCit(Citoyen citoyen)
        {
            Citoyen c1 = new Citoyen();
            dataBase = new DataBase();
            dataBase.insertCitoyen(c1);
        }
        public void supCit(string cin)
        {
            dataBase = new DataBase();
            dataBase.supCitoyen(cin);
        }
        public DataTable Affinfo(string cin)
        {
            DataTable data = new DataTable();
            dataBase = new DataBase();
            data=dataBase.Affinfo(cin);

            return data;
        }
        public DataTable Affinf (string cin)
        {
            DataTable data1 = new DataTable();
            dataBase = new DataBase();
            data1 = dataBase.Affinf(cin);

            return data1;
        }

    }

}

