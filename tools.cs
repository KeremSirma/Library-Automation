using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.IO;


namespace Library
{

   public static class tools
    {


       public static SqlConnection Con = new SqlConnection("Data Source=.;Initial Catalog=master;Integrated Security=True;MultipleActiveResultSets=True");
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Security", "CA2100:Review SQL queries for security vulnerabilities")]
        public static DataTable list(string sql) {

            
            SqlDataAdapter Da = new SqlDataAdapter(sql, Con);
            DataSet Ds = new DataSet();
            Da.Fill(Ds);
            return Ds.Tables[0];

 }

    }
    public static class forms{
    public static User user=new User();
    public static Login login=new Login();
    }

}

