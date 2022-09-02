using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ProjetoAndreia
{
    public static class Utils
    {
        private const int DECIMAIS_QUANTIDADE = 3;
        private const int DECIMAIS_VALOR = 2;
        private const int EMPRESA_BALCAO = 1;

        public static string PrimeiroCaracterMaiusculo(this string input)
        {
            switch (input)
            {
                case null: throw new ArgumentNullException(nameof(input));
                case "": throw new ArgumentException($"{nameof(input)} cannot be empty", nameof(input));
                default: return input.First().ToString().ToUpper() + input.Substring(1);
            }
        }

        public static string FormatarCpfCnpj(string strCpfCnpj, bool isCnpj = false, bool isCpf = false)
        {
            if (string.IsNullOrEmpty(strCpfCnpj))
                return null;

            strCpfCnpj = strCpfCnpj.Replace(".", "").Replace("-", "").Replace("/", "");
            try
            {
                if (strCpfCnpj.Length == 11 || isCpf)
                {
                    MaskedTextProvider mtpCpf = new MaskedTextProvider(@"000\.000\.000-00");
                    mtpCpf.Set(strCpfCnpj);
                    return mtpCpf.ToString();
                }
                else if (strCpfCnpj.Length == 14 || isCnpj)
                {
                    MaskedTextProvider mtpCnpj = new MaskedTextProvider(@"00\.000\.000/0000-00");
                    mtpCnpj.Set(strCpfCnpj);
                    return mtpCnpj.ToString();
                }
                return strCpfCnpj;
            }
            catch
            {
                return strCpfCnpj;
            }
        }

        public static string RemoveCifrao(String valor)
        {
            String Novovalor = valor;
            try
            {
                if (valor.StartsWith("R$"))
                    Novovalor = valor.Remove(0, 2);
                return Novovalor;
            }
            catch (Exception ex)
            {
                return String.Empty;
            }
        }

        public static string RemoverAccentos(this string text)
        {
            StringBuilder sbReturn = new StringBuilder();
            var arrayText = text.Normalize(NormalizationForm.FormD).ToCharArray();
            foreach (char letter in arrayText)
            {
                if (CharUnicodeInfo.GetUnicodeCategory(letter) != UnicodeCategory.NonSpacingMark)
                    sbReturn.Append(letter);
            }
            return sbReturn.ToString();
        }

        public static string RemocePontucaoCpfCnpj(string cpfCnpj)
        {
            if (string.IsNullOrEmpty(cpfCnpj))
                return null;

            return Regex.Replace(cpfCnpj, "[^0-9]", "");
        }

        public static string ZerosEsquerda(string strString, int intTamanho)
        {
            try
            {
                if (string.IsNullOrEmpty(strString))
                    return null;

                string strResult = "";
                for (int intCont = 1; intCont <= (intTamanho - strString.Length); intCont++)
                {
                    strResult += "0";
                }
                return strResult + strString;
            }
            catch
            {
                return strString;
            }
        }

        public static string FormatarInscricaoEstadual(string ie)
        {
            try
            {
                ie = ZerosEsquerda(ie, 12);
                return Convert.ToUInt64(ie).ToString(@"000\.000\.000\.000");
            }
            catch
            {
                return ie;
            }
        }

        public static string FormatarSubClasseCnae(string subclasse)
        {
            return Convert.ToUInt64(subclasse).ToString(@"0000-0/00");
        }

        /// <summary>
        /// Formato de retorno: 00.000-000
        /// </summary>
        /// <param name="cep"></param>
        /// <returns></returns>
        public static string FormatarCEP(string cep)
        {
            try
            {
                return Convert.ToUInt64(cep).ToString(@"00\.000\-000");
            }
            catch
            {
                return cep;
            }
        }

        /// <summary>
        /// Formato de retorno: (00) 0 0000-0000
        /// </summary>
        /// <param name="celular"></param>
        /// <returns></returns>
        public static string FormatarCelular(string celular)
        {
            try
            {
                return Convert.ToUInt64(celular).ToString(@"(00) 0 0000\-0000");
            }
            catch
            {
                return celular;
            }
        }

        public static string RemoveCaracteresCelular(string celular)
        {
            if (celular == null)
                return null;

            return celular.Replace(" ", "").Replace("(", "").Replace(")", "").Replace("-", "");
        }

        public static string FormatarTelefone(string telefone)
        {
            try
            {
                return Convert.ToUInt64(telefone).ToString(@"(00) 0000\-0000");
            }
            catch
            {
                return telefone;
            }
        }

        public static decimal TruncaValor(decimal Value, int Casas)
        {
            /*
            string sValor;
            int nPos;

            // Transforma o valor em string
            sValor = Value.ToString();

            // Verifica se possui ponto decimal
            nPos = sValor.IndexOf(",");
            if (nPos > 0)
            {
                sValor = sValor.Substring(0, nPos + Casas + 1);
            }

            return Convert.ToDecimal(sValor);
             * */
            return Value;
        }

        public static decimal TruncaValor(decimal? Value, int Casas)
        {
            string sValor;
            int nPos;

            // Transforma o valor em string
            sValor = Value.ToString();

            // Verifica se possui ponto decimal
            nPos = sValor.IndexOf(",");
            if (nPos > 0)
            {
                sValor = sValor.Substring(0, nPos + Casas);
            }

            return Convert.ToDecimal(sValor);
        }

        public static string FormataFloat(string Tipo, decimal Valor)
        {
            int i;
            string Mascara;

            Mascara = "0.";

            if (Tipo == "Q")
            {
                for (i = 1; i <= DECIMAIS_QUANTIDADE; i++)
                    Mascara = Mascara + "0";
            }
            else if (Tipo == "V")
            {
                for (i = 1; i <= DECIMAIS_VALOR; i++)
                    Mascara = Mascara + "0";
            }

            return Convert.ToDecimal(Valor).ToString(Mascara);
        }

        public static string FormataFloat(string Tipo, decimal? Valor)
        {
            int i;
            string Mascara;

            Mascara = "0.";

            if (Tipo == "Q")
            {
                for (i = 1; i <= DECIMAIS_QUANTIDADE; i++)
                    Mascara = Mascara + "0";
            }
            else if (Tipo == "V")
            {
                for (i = 1; i <= DECIMAIS_VALOR; i++)
                    Mascara = Mascara + "0";
            }

            return Convert.ToDecimal(Valor).ToString(Mascara);
        }

        public static string DevolveConteudoDelimitado(string Delimidador, string Linha)
        {
            int PosBarra;
            string Result;

            PosBarra = Linha.IndexOf(Delimidador);
            Result = (Linha.Substring(PosBarra - 1, 1)).Replace("[#]", "|");
            Linha = Linha.Remove(0, PosBarra);
            return Result;
        }

        /// <summary>
        /// Get substring of specified number of characters on the right.
        /// </summary>
        public static string Right(this string value, int length)
        {
            if (String.IsNullOrEmpty(value)) return string.Empty;

            return value.Length <= length ? value : value.Substring(value.Length - length);
        }

        public static string TiraPontos(string Str)
        {
            int i;
            string xStr;
            string Result;

            xStr = "";
            for (i = 1; i <= Str.Trim().Length; i++)
                if (("/-.)(,".IndexOf(Str.Substring(1, i)) == 0)) xStr = xStr + Str[i];

            xStr = xStr.Replace(" ", "");

            Result = xStr;
            return Result;
        }

        public static DateTime TextoParaData(string pData)
        {
            int Dia, Mes, Ano;
            System.DateTime Result;

            if ((pData != "") && (pData != "0000-00-00"))
            {
                Dia = Convert.ToInt32(pData.Substring(2, 9));
                Mes = Convert.ToInt32(pData.Substring(2, 6));
                Ano = Convert.ToInt32(pData.Substring(4, 1));
                Result = new DateTime(Ano, Mes, Dia);
            }
            else
            {
                Result = new DateTime();
            }
            return Result;
        }

        public static string DataParaTexto(DateTime pData)
        {
            return pData.ToString("YYYY-MM-DD");
        }
    }
}
