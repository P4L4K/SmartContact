using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace SmartContact.SmartContactClasses
{
    internal class ContactClass
    {
        //Getter setter properties
        //acts as a data carrier 
        public int ContactID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string ContactNo { get; set; }
        public string Gender { get; set; }
        public string Image { get; set; }

        static string mysqlcon = "server=localhost; user=root ; database=smartcart; password=root";
        
        public DataTable SelectData()
        {
            MySqlConnection mySqlConnection = new MySqlConnection(mysqlcon);
            DataTable dt = new DataTable();
            try
            {
                string sql = "SELECT * FROM details";
                //CREATING cmd using sql and mySqlConnection
                MySqlCommand cmd = new MySqlCommand(sql, mySqlConnection);
                
                //creating sql dataAdapter using cmd 
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                mySqlConnection.Open();
               
                adapter.Fill(dt);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                mySqlConnection.Close();
            }
            return dt;
        }
   
        //inserting data into database
        public bool Insert(ContactClass c)
        {
            //creating a default return type and setting its value to false
            bool isSuccess = false;

            //step 1: connect database
            MySqlConnection mySqlConnection = new MySqlConnection(mysqlcon);
            try
            {
                //step 2: create a sq; query to insert data
                string sql;
                if (c.Image == "")
                {
                    sql = "INSERT INTO details(FirstName, LastName, Gender, ContactNo)  Values(@FirstName, @LastName, @Gender, @ContactNo)";
                }
                else
                {
                    sql = "INSERT INTO details(FirstName, LastName, Gender, ContactNo, Image)  Values(@FirstName, @LastName, @Gender, @ContactNo, @Image)";
                }
               //CREATING cmd using sql and mySqlConnection
                MySqlCommand cmd = new MySqlCommand(sql, mySqlConnection);
                //creating parameters to add data
                cmd.Parameters.AddWithValue("@FirstName", c.FirstName);
                cmd.Parameters.AddWithValue("@LastName", c.LastName);
                cmd.Parameters.AddWithValue("@ContactNo", c.ContactNo);
                cmd.Parameters.AddWithValue("@Gender", c.Gender);
                cmd.Parameters.AddWithValue("@Image", c.Image);

                mySqlConnection.Open();
            
                int rows = cmd.ExecuteNonQuery();
                //If the query runs successfully then the value of rows will be greater than zero else it will be 0
                if (rows > 0)
                {
                    isSuccess = true;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                mySqlConnection.Close();
            }
            return isSuccess;
        }
        //search the data
        public DataTable search(ContactClass c)
        {
            MySqlConnection mySqlConnection = new MySqlConnection(mysqlcon);
            DataTable dt = new DataTable();
            try
            {
                string sql = "SELECT * FROM details WHERE CONCAT(FirstName,' ',LastName) LIKE CONCAT('%', @FirstName, '%')";
                //CREATING cmd using sql and mySqlConnection
                MySqlCommand cmd = new MySqlCommand(sql, mySqlConnection);
                //creating parameters to add data
                cmd.Parameters.AddWithValue("@FirstName", c.FirstName);
                //creating sql dataAdapter using cmd 
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                mySqlConnection.Open();
                adapter.Fill(dt);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                mySqlConnection.Close();
            }
            return dt;

        }
        //update the data
        public bool update(ContactClass c)
        {
            //creating a default return type and setting its value to false
            bool isSuccess = false;
            //connect to database
            MySqlConnection mySqlConnection = new MySqlConnection(mysqlcon);
            try
            {
                String sql = "UPDATE details SET ContactNo = @ContactNO, Image=@Image, FirstName=@FirstName, LastName=@LastName, Gender=@Gender where ContactID = @ContactID";
                //CREATING cmd using sql and mySqlConnection
                MySqlCommand cmd = new MySqlCommand(sql, mySqlConnection);
                //creating parameters to add data
                cmd.Parameters.AddWithValue("@ContactID", c.ContactID);
                cmd.Parameters.AddWithValue("@FirstName", c.FirstName);
                cmd.Parameters.AddWithValue("@LastName", c.LastName);
                cmd.Parameters.AddWithValue("@ContactNo", c.ContactNo);
                cmd.Parameters.AddWithValue("@Gender", c.Gender);
                cmd.Parameters.AddWithValue("@Image", c.Image);

                mySqlConnection.Open();
                int rows = cmd.ExecuteNonQuery();
                //If the query runs successfully then the value of rows will be greater than zero else it will be 0
                if (rows > 0)
                {
                    isSuccess = true;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                mySqlConnection.Close();
            }
            return isSuccess;

        }
        //delete the data
        public bool Delete(ContactClass c)
        {
            //creating a default return type and setting its value to false
            bool isSuccess = false;
            //connect to database
            MySqlConnection mySqlConnection = new MySqlConnection(mysqlcon);
            try
            {
                String sql = "DELETE FROM details where ContactID = @ContactID";
                //CREATING cmd using sql and mySqlConnection
                MySqlCommand cmd = new MySqlCommand(sql, mySqlConnection);
                //creating parameters to add data
                cmd.Parameters.AddWithValue("@ContactID", c.ContactID);
               
                mySqlConnection.Open();
             
                int rows = cmd.ExecuteNonQuery();
                //If the query runs successfully then the value of rows will be greater than zero else it will be 0
                if (rows > 0)
                {
                    isSuccess = true;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                mySqlConnection.Close();
            }
            return isSuccess;

        }
    }
}
// manuall collection : serve , text mining , web search.
