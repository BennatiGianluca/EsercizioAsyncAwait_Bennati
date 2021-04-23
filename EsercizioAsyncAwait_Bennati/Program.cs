using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsercizioAsyncAwait_Benna
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Quanti partecipanti ci sono? ");
            int p = int.Parse(Console.ReadLine());

            List<string> partecipanti = new List<string>();

            for (int i = 1; i <= p; i++)
            {
                Console.WriteLine($"Il nome del partecipante{i}: ");
                string nome = Console.ReadLine();
                partecipanti.Add(nome);
            }

            foreach (string s in partecipanti)
            {
                Corri(s);
            }

            Console.ReadLine();
        }

        private static async Task Corri(string name)
        {
            await Task.Run(() =>
            {
                for (int i = 1; i < 100; i++)
                {
                    Console.WriteLine($"Il partecipante {name} è al km {i}.");
                }
                Console.WriteLine($"Il partecipante {name} è arrivato al km 100 e ha terminato la corsa.");
            });
        }
    }
}
