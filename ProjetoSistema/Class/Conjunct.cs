using ProjetoSistema.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoSistema.Class
{
    internal class Conjunct
    {
        //aqui vou estar criando os metodos gerais do sistema
    }

    public static class ConversoresdeString
    {
        public static string TrocarPontoPorVirgula(this string value)
        {
            return value.Replace(".", ",");
        }

        public static string ObservadorParaMaiusculo(this string value,TextBox textBox)
        {
            textBox.Text = value.ToUpper();
            textBox.Select(textBox.Text.Length,0);
            return value.ToUpper();
           
        }
    }
}
