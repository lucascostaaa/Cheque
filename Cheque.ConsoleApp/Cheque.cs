using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cheque.ConsoleApp
{
    public class ChequeValorExtenso
    {

        List<string> Unidade = new List<string> { "um", "dois", "tres", "quatro", "cinco", "seis", "sete", "oito", "nove" };
        List<string> DezeUnidade  = new List<string> { "onze", "doze", "treze", "quatorze", "quinze", "dezesseis", "dezessete", "dezoito", "dezenove" };
        List<string> Dezena = new List<string> { "dez", "vinte", "trinta", "quarenta", "sessenta", "setenta", "oitenta", "noventa" };
       
  

        private string[] RetornaArraySplitCentavos(string valor)
        {
            return valor.Split(',');
        }

        public string verificaCentavos(string valor)
        {
            string nomenclaturaCentavos = " centavos de real";

            string aposVirgula = valor.Split(',')[1];

            string[] recebeSplit = RetornaArraySplitCentavos(valor);

            string recebeValorUnidade = "";

            string recebeValorDezena = "";

            if (recebeSplit[1].Length > 1)
            {
                if (aposVirgula != null)
                {
                    char[] separaAposVirgula = aposVirgula.ToCharArray();

                    int indice = separaAposVirgula.Length - 1;

                    recebeValorUnidade = retornaListaUnidades(separaAposVirgula, indice);
                    recebeValorDezena = retornaListaDezenas(separaAposVirgula);
                }
                return (recebeValorDezena) + " " + (recebeValorUnidade) + nomenclaturaCentavos;


            }
            else
            {
                char[] separa = valor.ToCharArray();
                int indice = separa.Length - 1;
                string recebeValor = retornaListaUnidades(separa, indice);

                if (recebeValor == "um")
                {
                    return recebeValor + "centavo de real";
                }

                return CultureInfo.CurrentCulture.TextInfo.ToTitleCase(recebeValor) + nomenclaturaCentavos;

            }
        }
        public string retornaListaUnidades(char[] unidade, int indice)
        {
            for (int i = 0; i < Dezena.Count; i++)
            {
                if (unidade[indice] == '1') { return Unidade[0]; }
                if (unidade[indice] == '2') { return Unidade[1]; }
                if (unidade[indice] == '3') { return Unidade[2]; }
                if (unidade[indice] == '4') { return Unidade[3]; }
                if (unidade[indice] == '5') { return Unidade[4]; }
                if (unidade[indice] == '6') { return Unidade[5]; }
                if (unidade[indice] == '7') { return Unidade[6]; }
                if (unidade[indice] == '8') { return Unidade[7]; }
                if (unidade[indice] == '9') { return Unidade[8]; }


            }
            return "unidades";
        }
        private string retornaListaDezenas(char[] dezena)
        {
            for (int i = 0; i < Dezena.Count; i++)
            {


                if (dezena[0] == '1') { return Dezena[0]; }
                if (dezena[0] == '2') { return Dezena[1]; }
                if (dezena[0] == '3') { return Dezena[2]; }
                if (dezena[0] == '4') { return Dezena[3]; }
                if (dezena[0] == '5') { return Dezena[4]; }
                if (dezena[0] == '6') { return Dezena[5]; }
                if (dezena[0] == '7') { return Dezena[6]; }
                if (dezena[0] == '8') { return Dezena[7]; }
                if (dezena[0] == '9') { return Dezena[8]; }


            }
            return "dezenas";
        }
        public Validar (decimal valor)
        {
            string[]recebeSplit = controlador.RecebeArray
        }

    }
}



