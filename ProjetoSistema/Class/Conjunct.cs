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

        public static string TrocarVirgulaPorPonto(this string value)
        {
            return value.Replace(",", ".");
        }

        public static string ObservadorParaMaiusculo(this string value, TextBox textBox)
        {
            textBox.Text = value.ToUpper();
            textBox.Select(textBox.Text.Length, 0);
            return value.ToUpper();
        }
        public static void SoNumero(this string value,TextBox textBox, KeyPressEventArgs e)
        {
            try
            {
                if ((!char.IsDigit(e.KeyChar) && e.KeyChar != ',' && !char.IsControl(e.KeyChar)) ||
            (e.KeyChar == ',' && textBox.Text.Contains(",")))
                {
                    e.Handled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Digite somente numeros{ex.Message}"); 
            }
        }

        public static void SoNumeroComPontoEVirgula(this string value, TextBox textBox, KeyPressEventArgs e)
        {
            try
            {
                if ((!char.IsDigit(e.KeyChar) && e.KeyChar != ',' && e.KeyChar != '.' && !char.IsControl(e.KeyChar)))
                {
                    e.Handled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Digite somente numeros{ex.Message}");
            }
        }

        public static void SoNumeroComPontoEVirgula(this string value, MaskedTextBox textBox, KeyPressEventArgs e)
        {
            try
            {
                if ((!char.IsDigit(e.KeyChar) && e.KeyChar != ',' && e.KeyChar != '.' && !char.IsControl(e.KeyChar)))
                {
                    e.Handled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Digite somente numeros{ex.Message}");
            }
        }

        public static void SoNumero(this string value, MaskedTextBox textBox, KeyPressEventArgs e)
        {
            try
            {
                if ((!char.IsDigit(e.KeyChar) && e.KeyChar != ',' && !char.IsControl(e.KeyChar)) ||
            (e.KeyChar == ',' && textBox.Text.Contains(",")))
                {
                    e.Handled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Digite somente numeros{ex.Message}");
            }
        }

        public static decimal ToValidDecimal(this string valor)
        {
            valor = valor.Replace("R$", "").Replace("%", "").Replace("''", "");

            if (decimal.TryParse(valor, NumberStyles.Any, CultureInfo.GetCultureInfo("pt-BR"), out var result))
            {
                return result;
            }

            return 0M;
        }

    }
    public static class AttCadastros
    {

        public static void ExcluirEntidade(string NomeCampo, TextBox CampoIdentificador)
        {
            try
            {
                if (CampoIdentificador.Text.Length >= 1)
                {
                    var Excluir = $@"UPDATE {NomeCampo} SET ATIVO = '0' WHERE ID = {CampoIdentificador.Text}";
                    using (SqlConnection cn = new SqlConnection(Conn.StrCon))
                    {
                        cn.Open();
                        SqlCommand Execute = new SqlCommand(Excluir, cn);

                        int EntidadeApagadas = Execute.ExecuteNonQuery();
                        if (EntidadeApagadas > 0) { MessageBox.Show("Entidade excluida com sucesso"); }
                        else { MessageBox.Show("Nenhuma entidade encontrada com o ID especificado"); }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao excluir a entidade {ex.Message}");
            }

        }
        public static void RestaurarEntidade(string NomeCampo, TextBox CampoIdentificador)
        {
            try
            {
                if (CampoIdentificador.Text.Length >= 1)
                {
                    var Excluir = $@"UPDATE {NomeCampo} SET ATIVO = '1' WHERE ID = {CampoIdentificador.Text}";
                    using (SqlConnection cn = new SqlConnection(Conn.StrCon))
                    {
                        cn.Open();
                        SqlCommand Execute = new SqlCommand(Excluir, cn);

                        int EntidadeApagadas = Execute.ExecuteNonQuery();
                        if (EntidadeApagadas > 0) { MessageBox.Show("Entidade restaurada com sucesso"); }
                        else { MessageBox.Show("Nenhuma entidade encontrada com o ID especificado"); }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao restaurar a entidade {ex.Message}");
            }

        }

        public static void UpdateCadastro(string TableName,string ColumnName,string NewValue,string ColumnWhere,string ValorChecagem)
        {
            
            try
            {
                var Update = $@"UPDATE {TableName} set {ColumnName} = '{NewValue}' where {ColumnWhere} = '{ValorChecagem}'";
                using (SqlConnection cn = new SqlConnection(Conn.StrCon))
                {
                    cn.Open();
                    SqlCommand Execute = new SqlCommand(Update, cn);
                    Execute.ExecuteNonQuery();

                }
            }
            catch(Exception ex)
            {
                MessageBox.Show($"Erro ao atualizar a entidade{ex.Message}");
            }

        }

       
    }
}
