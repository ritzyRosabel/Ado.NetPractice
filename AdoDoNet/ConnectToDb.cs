using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoDoNet
{
  public  class ConnectToDb
    {
        public static int GetNumOfTestRows()
        {
            int noOfRowAffected = 0; 
            var query = "Select COUNT(*) from Test";
            var con = ConfigurationManager.ConnectionStrings["Model1"].ConnectionString;
            using (SqlConnection connection = new SqlConnection(con))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();
                    noOfRowAffected =(int)command.ExecuteScalar();
                }
            }
            return noOfRowAffected;
        }
            
    }
}
