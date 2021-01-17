using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Covid
{
    class Citoyen
    {
        private String cin;
        private String nom;
        private String prenom;
        private int age;
        private String adresse;
        private int etat;
        private String maladie_grave;

        public Citoyen()
        {

        }

        public Citoyen(string cin, string nom, string prenom, int age, string adresse, int etat, string maladie_grave)
        {
            this.cin = cin;
            this.nom = nom;
            this.prenom = prenom;
            this.age = age;
            this.adresse = adresse;
            this.etat = etat;
            this.maladie_grave = maladie_grave;

        }
        public void setcin(String cin)
        {
            this.cin = cin;
        }
        public String getcin()
        {
            return cin;
        }
        public void setNom(String nom)
        {
            this.nom = nom;
        }
        public String getNom()
        {
            return nom;
        }
        public void setPrenom(String prenom)
        {
            this.prenom = prenom;
        }
        public String getPrenom()
        {
            return prenom;
        }
        public void setAge(int age)
        {
            this.age = age;
        }
        public int getAge()
        {
            return age;
        }
        public void setAdresse(String adresse)
        {
            this.adresse = adresse;
        }
        public String getAdresse()
        {
            return adresse;
        }
        public void setEtat(int etat)
        {
            this.etat = etat;
        }
        public int getEtat()
        {
            return etat;
        }
        public void setMaladie_grave(String maladie_grave)
        {
            this.maladie_grave = maladie_grave;
        }
        public String getMaladie_grave()
        {
            return maladie_grave;
        }

    }
}

