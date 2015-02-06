using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Mae
    {
        string amamentar = "sim";
        public Mae(string amam)
        {
            amamentar = amam;
        }
        public Mae()
            : this("")
        {

        }

        public string Amamentar { get { return amamentar; } }

        protected void Bater()
        {
        }
        protected string Valor;

        void Bater(string x)
        {


        }

        public void Bater2()
        {
        }



    }
}
