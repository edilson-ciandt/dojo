using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PacoteNegocio
{
    public class Negocio
    {
        public Boolean VerificaPalindrome(String palavra)
        {
            palavra = palavra.Replace(" ","");
            int final = palavra.Length - 1;
            for (int i = 0; i < palavra.Length; i++)
            {
                if (!palavra[i].Equals(palavra[final - i]))
                    return false;

            }
            return true;
        }
    }
}
