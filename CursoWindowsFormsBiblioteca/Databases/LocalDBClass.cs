using System.Data.SqlClient;

namespace CursoWindowsFormsBiblioteca.Databases
{
    public class LocalDBClass
    {
        public string stringConn { get; set; }
        public SqlConnection connDB { get; set; }

        public LocalDBClass()
        {
            stringConn = ""; 
            connDB = new SqlConnection(stringConn); 
            connDB.Open();
        }

    }
}
