using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GatoyRaton
{
    class Gato
    {
        public bool TieneHambre;
        public string Duenio;
        public void cazar(Raton r)
        {
            if (r.Vivo && TieneHambre )
            {
                r.Vivo = false;
                TieneHambre = false;
            }
        }
        public string VerEstado()
        {
            string resultado = "Gato -->  ";
            resultado += "Dueño: "+Duenio;

            if (TieneHambre)
            {
                resultado += " -- Tiene Hambre : Si -- ";
            }
            else
            {
                resultado += " -- Tiene Hambre : No -- ";
            }
            return resultado;
        }

    }
    class Raton
    {
        public bool Vivo;
        public bool TieneHambre;
        public void Comer (ref int queso)
        {
            if (Vivo == true)
            {
                if (queso >= 2)
                {
                    TieneHambre = false;
                    queso -= 2;
                }
                else if (queso == 1)
                {
                    queso -= 1;
                }
            }
        }
        public string VerEstado()
        {
            string resultado = "Raton --> ";
            if (Vivo)
            {
                resultado += " -- Vivo : Si -- ";
            }
            else
            {
                resultado += " -- Vivo : No -- ";
            }
            if (TieneHambre)
            {
                resultado += " -- Tiene Hambre : Si -- ";
            }
            else
            {
                resultado += " -- Tiene Hambre : No -- ";
            }
            return resultado;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int queso = 10;

            Gato tom = new Gato();
            tom.Duenio = "Ana";
            tom.TieneHambre = true;
            Console.WriteLine(tom.VerEstado());

            Raton jerry = new Raton();
            jerry.Vivo = true;
            jerry.TieneHambre = true;
            Console.WriteLine(jerry.VerEstado());

            jerry.Comer(ref queso);
            Console.WriteLine("Cantidad de queso: {0}", queso);
            tom.cazar(jerry);

            Console.ReadKey();
        }
    }
}
