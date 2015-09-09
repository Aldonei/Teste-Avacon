using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WcfServiceCliente.Utils
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Reflection;
    using System.ComponentModel;
    using System.Data.SqlClient;
    using System.Data;
    using System.Text.RegularExpressions;
    using System.Runtime.Serialization.Json;
    using System.Runtime.InteropServices;
    using System.Web;
    using System.IO;
    
    public static class Utils
    {
        /// summary
        /// Enum com os tipos de Validacoes
        /// summary
        public enum TipoValidacao { CPF, CNPJ, CEP, CEPSemHifen, Telefone };

        /// summary
        /// Expressão regular com as regras do CPF
        /// summary
        private static Regex _cpf = new Regex(@"^\d{3}\.?\d{3}\.?\d{3}\-?\d{2}$", RegexOptions.Compiled);

        // Máscara para exibição de CPF
        private static Regex _cpfFormatado = new Regex(@"(\d\d\d)(\d\d\d)(\d\d\d)(\d\d)");

        /// <summary>
        /// Expressão regular com as regras de cnpj
        /// </summary>
        private static Regex _cnpj = new Regex(@"(^(\d{2}.\d{3}.\d{3}/\d{4}-\d{2})|(\d{14})$)");

        // Máscara para exibição de CNPJ
        private static Regex _cnpjFormatado = new Regex(@"(\d\d)(\d\d\d)(\d\d\d)(\d\d\d\d)(\d\d)");

        // Máscara para exibição de Telefone
        private static Regex _telefoneFormatado = new Regex(@"(\d\d\d\d)(\d\d\d\d)");
        private static Regex _telefoneFormatado_nono = new Regex(@"(\d\d\d\d)(\d\d\d\d\d)");
            
        /// <summary>
        /// Expressão regular com as regras de cep Ex: 87094-132
        /// </summary>
        private static Regex _cep = new Regex(@"^[0-9]{5}-[0-9]{3}$");

        /// <summary>
        /// Expressão regular com as regras de cep Ex: 87094132
        /// </summary>
        private static Regex _cepSemHifen = new Regex(@"^[0-9]{5}[0-9]{3}$");

        // Máscara para exibição de CEP
        private static Regex _cepFormatado = new Regex(@"(\d\d\d\d\d)(\d\d\d)");

        /// <summary>
        /// Expressão regular com as regras de telefone Ex: (44)3344-4332
        /// </summary>
        private static Regex _telefone = new Regex(@"^\(\d{2}\)\d{4}-\d{4}$");
                        
        /// <summary>
        /// Método de validação
        /// </summary>
        /// <param name="value">Valor string a ser validado</param>
        /// <param name="type">Tipo enum da validação</param>
        /// <returns>False se estiver inválido</returns>
        public static bool ValidateField(string value, TipoValidacao type)
        {
            bool validate = false;

            switch (type)
            {
                case TipoValidacao.CPF: validate = _cpf.IsMatch(value) ? true : false;
                    break;
                case TipoValidacao.CNPJ: validate = _cnpj.IsMatch(value) ? true : false;
                    break;
                case TipoValidacao.CEP: validate = _cep.IsMatch(value) ? true : false;
                    break;
                case TipoValidacao.Telefone: validate = _telefone.IsMatch(value) ? true : false;
                    break;
                case TipoValidacao.CEPSemHifen: validate = _cepSemHifen.IsMatch(value) ? true : false;
                    break;
                default: validate = false;
                    break;
            }
            return validate;
        }

        /// <summary>
        /// Informar o valor a ser formatado e tipo de formatação que será empregado ao valor. O Retorno será o valor
        /// formatado conforme máscara definida pelo programador.
        /// Ex.: string valorFormatado = FormatarString("7190182053", TipoValidacao.CPF);
        /// O valorFormatado será 719.018.20-53.
        /// </summary>
        /// <param name="valor"></param>
        /// <param name="type"></param>
        /// <returns></returns>
        public static string FormataString(string valor, TipoValidacao type)
        {
            string novoValorFormatado = string.Empty;

            switch (type)
            {
                case TipoValidacao.CPF: novoValorFormatado = _cpfFormatado.Replace(valor, "$1.$2.$3-$4");
                    break;

                case TipoValidacao.CNPJ: novoValorFormatado = _cnpjFormatado.Replace(valor, "$1.$2.$3/$4-$5");
                    break;

                case TipoValidacao.CEP: novoValorFormatado = _cepFormatado.Replace(valor, "$1-$2");
                    break;

                case TipoValidacao.Telefone:

                    if (!string.IsNullOrEmpty(valor))
                        novoValorFormatado = (valor.Length > 8 ? _telefoneFormatado_nono.Replace(valor, "$1-$2") : _telefoneFormatado.Replace(valor, "$1-$2"));
                    else
                        novoValorFormatado = string.Empty;

                    break;
            }
            return novoValorFormatado;
        }

        public static bool ValidaCnpj(string cnpj)
        {
            int[] multiplicador1 = new int[12] { 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] multiplicador2 = new int[13] { 6, 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };
            int soma;
            int resto;
            string digito;
            string tempCnpj;
            cnpj = cnpj.Trim();
            cnpj = cnpj.Replace(".", string.Empty).Replace("-", string.Empty).Replace("/", string.Empty);
            if (cnpj.Length != 14)
                return false;
            tempCnpj = cnpj.Substring(0, 12);
            soma = 0;
            for (int i = 0; i < 12; i++)
                soma += int.Parse(tempCnpj[i].ToString()) * multiplicador1[i];
            resto = (soma % 11);
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;
            digito = resto.ToString();
            tempCnpj = tempCnpj + digito;
            soma = 0;
            for (int i = 0; i < 13; i++)
                soma += int.Parse(tempCnpj[i].ToString()) * multiplicador2[i];
            resto = (soma % 11);
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;
            digito = digito + resto.ToString();
            return cnpj.EndsWith(digito);
        }

        /// <summary>
        /// Formatar o telefone de acordo com o tamanho do número.
        /// </summary>
        /// <param name="mascara"></param>
        /// <param name="valor"></param>
        /// <returns></returns>
        public static string FormataNumero(string numero)
        {
            string result = string.Empty;

            if (!string.IsNullOrEmpty(numero))
            {
                numero = numero.Trim();
                if (numero.Contains("-"))
                    numero = numero.Replace("-", string.Empty);

                string numeroFormatado = string.Empty;

                if (numero.Length == 8)
                    numeroFormatado = numero.Substring(0, 4) + "-" + numero.Substring(4, numero.Length - 4);
                else if (numero.Length == 9)
                    numeroFormatado = numero.Substring(0, 5) + "-" + numero.Substring(5, numero.Length - 5);

                result = numeroFormatado;
            }
            return result;
        }

        public static bool ValidaCpf(string cpf)
        {
            // Cpfs com números iguais são considerados cpfs válidos segundo a Receita Federal, porém cancelados.
            // estou colocando para retornar falso para eles embora sejam válidos para a Receita.
            switch (cpf)
            {
                case "00000000000":
                    return false;
                case "11111111111":
                    return false;
                case "2222222222":
                    return false;
                case "33333333333":
                    return false;
                case "44444444444":
                    return false;
                case "55555555555":
                    return false;
                case "66666666666":
                    return false;
                case "77777777777":
                    return false;
                case "88888888888":
                    return false;
                case "99999999999":
                    return false;
            }

            int[] multiplicador1 = new int[9] { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] multiplicador2 = new int[10] { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            string tempCpf;
            string digito;
            int soma;
            int resto;
            cpf = cpf.Trim();
            cpf = cpf.Replace(".", string.Empty).Replace("-", string.Empty);
            if (cpf.Length != 11)
                return false;
            tempCpf = cpf.Substring(0, 9);
            soma = 0;

            for (int i = 0; i < 9; i++)
                soma += int.Parse(tempCpf[i].ToString()) * multiplicador1[i];
            resto = soma % 11;
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;
            digito = resto.ToString();
            tempCpf = tempCpf + digito;
            soma = 0;
            for (int i = 0; i < 10; i++)
                soma += int.Parse(tempCpf[i].ToString()) * multiplicador2[i];
            resto = soma % 11;
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;
            digito = digito + resto.ToString();
            return cpf.EndsWith(digito);
        }
    }
}
