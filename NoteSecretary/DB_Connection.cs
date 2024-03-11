using System.Data.SqlClient;

namespace NoteSecretary
{
    public static class DB_Connection
    {
        public static SqlConnection connection = new SqlConnection();
        public static SecretaryDBEntities secretaryDBEntities = new SecretaryDBEntities();
        
    }
}