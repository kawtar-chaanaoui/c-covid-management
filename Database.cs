using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Covid
{
    class DataBase
    {
         
        string chaine;
        SqlConnection con;


        public bool OpenConnection()
        {
            chaine = @"Data Source=DESKTOP-SC1DR6N;Initial Catalog=Mycovid;Integrated Security=True";
            con = new SqlConnection(chaine);
            try
            {
                con.Open();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return false;
            }
        }

        public void CloseConnection()
        {
            try
            {
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        public void insertCitoyen(Citoyen citoyen)
        {
            if (OpenConnection())
            {
                String sql = "INSERT INTO Citoyen(cin,nom,prenom,age,adresse,etat,maladie_grave) VALUES('" + citoyen.getcin() + "','" + citoyen.getNom() + "','" +
                    citoyen.getPrenom() + "'," + citoyen.getAge() + ",'" + citoyen.getAdresse() + "'," + citoyen.getEtat() + ",'" + citoyen.getMaladie_grave() + "')";
                try
                {
                    SqlCommand command = new SqlCommand(sql, con);
                    command.ExecuteNonQuery();
                    CloseConnection();
                    MessageBox.Show("DONE");
 
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }
        public void supCitoyen(string cin)
        {
            if (OpenConnection())
            {
                String sql = "DELETE FROM Citoyen WHERE cin = '" + cin + "'";
                try
                {
                    SqlCommand command = new SqlCommand(sql, con);
                    command.ExecuteNonQuery();
                    CloseConnection();
                    MessageBox.Show("done");

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }

        }
        public DataTable Affinfo(string cin)

        {
            DataTable data = new DataTable();
            if (OpenConnection())
            {
                String sql = "SELECT * FROM Citoyen WHERE cin = '" + cin + "'"; 
                try
                {
                    SqlCommand command = new SqlCommand(sql, con);

                    
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    adapter.Fill(data);
                    return data;
                    

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
            return data;
        }
        public DataTable Affinf(string cin)

        {
            DataTable data1= new DataTable();
            if (OpenConnection())
            {
                String sql = "SELECT * FROM CPR WHERE cin = '" + cin + "'";
                try
                {
                    SqlCommand command = new SqlCommand(sql, con);


                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    adapter.Fill(data1);
                    return data1;


                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
            return data1;
        }
        public DataTable Aff(string cin)

        {
            DataTable data2 = new DataTable();
            if (OpenConnection())
            {
                String sql = "SELECT * FROM Quarantined WHERE cin = '" + cin + "'";
                try
                {
                    SqlCommand command = new SqlCommand(sql, con);


                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    adapter.Fill(data2);
                    return data2;


                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
            return data2;
        }

    }
}

