using System;
using System.Text;
using System.Data;
using System.Data.SQLite;

namespace EmpSearch_v2.Controllers
{
    
    public class db_query
    {
        private SQLiteConnection sQLite;

        public void DataClass(){
            sQLite = new SQLiteConnection("Data Source = emps.db");
        }
        public string db_search(string searchterm){
            
            // Inserts search term into query
            // NOTE: This is vulnerable to SQL Injection: I'm aware of this issue, not sure how to prevent it. I don't think there's a way
            // to detect if a string is code in a certain language.
            string query = "SELECT * FROM emps WHERE name LIKE '%"+searchterm+"%'";
            
            
                sQLite.Open();
                

                using(sQLite){
                    SQLiteCommand command = new SQLiteCommand(query, sQLite);
                    SQLiteDataReader reader = command.ExecuteReader();

                    // I will format DB results into HTML, stuff it in a string, and return to the JS, to
                    // then be inserted into the display
                    string results = "";

                    // This while loop with the DataReader function is super convenient. 
                    while(reader.Read()){
                        // console.log as test.
                        Console.WriteLine("ID: "+reader["id"]+" || "+reader["name"]);
                    }
                }

            return query;
        }
    }
}