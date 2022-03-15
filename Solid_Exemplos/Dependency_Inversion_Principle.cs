using System.Data.SqlClient;

namespace Solid_Exemplos
{
    //The wrong way
    public class PasswordReminder_wrong
    {
        private SqlConnection dbConnection;
    
        public PasswordReminder_wrong()
        {
            dbConnection = new SqlConnection();
        }

        // Faz alguma coisa
    }


    //The right way
    public class PasswordReminder
    {
        private SqlConnection _dbConnection;

        public PasswordReminder(SqlConnection dbConnection)
        {
            dbConnection = _dbConnection;
        }

        // Faz alguma coisa
    }



}
