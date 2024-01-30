using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoSistema.Class
{
    internal class Conn
    {
        private static string Server = @"MIGRACAO\OBJETIVA";
        private static string DataBase = "Ambar";
        private static string User = @"OBJETIVA\migracao";
        private static string Password = "";


        public static string StrCon
        {
            get { return "Data Source=" + Server + "; Integrated Security = true;Initial Catalog =" + DataBase + "; User Id =" + User + "; Password=" + Password; }

            //mudar o Integrated security pra False quando tiver alguma senha
        }
    }
}
