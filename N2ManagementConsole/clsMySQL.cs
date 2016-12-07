using System;
using System.Collections.Generic;
using System.Linq;
using MySql.Data.MySqlClient;

namespace N2ManagementConsole
{
    class clsMySQL
    {
        public MySqlConnection mySqlCn = null;

        public  bool OpenConnection()
        {
            const string connectionStr = "server=192.168.1.230;user id=vs;password=n2gs;persistsecurityinfo=True;database=n2wizard";
            try
            {
                mySqlCn = new MySqlConnection(connectionStr);
                mySqlCn.Open();
            }
            catch (Exception ex)
            {
                Console.Write(ex.Message);
                return false;
            }
            return true;
        }

        public bool closeConnection()
        {
            try
            {
                mySqlCn.Close();
            }
            catch (Exception ex)
            {
                Console.Write(ex.Message);
                return false;
            }
            return true;
        }
        
    }
}
