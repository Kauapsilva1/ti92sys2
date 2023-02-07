using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace ti92class
{
    public static class Banco
    {
        public static MySqlCommand Abrir()
        {   
            MySqlCommand cmd = new MySqlCommand();
            try // Tenta abrir
            {
                string strCon = @"server=127.0.0.1;database=ti92sysdb;user id=root;password=";
                MySqlConnection cn = new MySqlConnection(strCon);
                cn.Open();
                cmd.Connection = cn;
            }
            catch (Exception)
            {
                throw;
            }
            
            

            return cmd;
        }
    }
    
}
