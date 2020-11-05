using System;

namespace binarysearch
{
    class Search
    {
        private int[] vector;
        public void Load()
        {
            Console.WriteLine("Porfavor Introduce 10 Elementos Numericos");
            string line;
            vector = new int[10];
            for (int f = 0; f < vector.Length; f++)
            {
                Console.Write("Porfavor ingrese el elemento " + (f + 1) + ": ");
                line = Console.ReadLine();
                vector[f] = int.Parse(line);
            }
        }
        public void search(int num)
        {
            int l = 0, h = 9;
            int m = 0;
            bool found = false;
            while (l <= h && found == false)
            {
                m = (l + h) / 2;
                if (vector[m] == num)
                    found = true;
                if (vector[m] > num)
                    h = m - 1;
                else
                    l = m + 1;
            }
            if (found == false)
            { Console.Write("\nEl elemento {0} no se encuentra en el arreglo", num); }
            else
            { Console.Write("\nEl elemento {0} esta ubicado en: {1}", num, m + 1); }
        }
        public void Imprimir()
        {
            for (int f = 0; f < vector.Length; f++)
            {
                Console.Write(vector[f] + "  ");
            }
        }
        static void Main(string[] args)
        {
            Search pv = new Search();
            pv.Load();
            pv.Imprimir();
            Console.Write("\n\nElemento que se esta buscando: ");
            int num = int.Parse(Console.ReadLine());
            pv.search(num);
            Console.ReadKey();

        }
    }
}