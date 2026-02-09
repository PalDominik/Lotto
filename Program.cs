namespace Lotto
{
    internal class Program
    {

        static int [] LottoSzamokGeneralasMetodus()
        {
            Random random = new Random();
            int[] lottoSzamok = new int[5];
            for (int i = 0; i < lottoSzamok.Length; i++)
            {
                lottoSzamok[i] = random.Next(1, 91);
            }
            return lottoSzamok;
		}

        static int[] Bekerszamok(int[] lotto)
        {
            int[] beker = new int[lotto.Length];
            int i = 0;

            while (i < lotto.Length)
            {
                Console.Write("Kérek egy számot: ");
                int tipp = Convert.ToInt32(Console.ReadLine());
                bool vanE = false;
                for (int j = 0; j < i; j++)
                {
                    if (beker[j] == tipp)
                    {
                        vanE = true;
                    }
                }
                if (!vanE)
                {
                    beker[i] = tipp;
                    i++;
                }
                else
                {
                    Console.WriteLine("Ilyen van már.");
                }
            }
            return beker;
            //         for(int i = 0; i < lotto.Length; i++)
            //         {
            //             Console.Write($"Kérem adja meg a {i + 1}. számot: ");
            //             beker[i] = int.Parse(Console.ReadLine());
            //             for (int j = 0; j < i; j++)
            //             {
            //                 if (beker[i] == beker[j])
            //                 {
            //                     Console.WriteLine("Ez a szám már szerepel, kérem adjon meg egy másikat.");
            //                     i--;
            //                 }
            //	}
        //  }
		}
        static void kiir(int[] tomb)
        {
            for (int i = 0; i < tomb.Length; i++)
            {
                Console.Write(tomb[i] + " ");
            }
            Console.WriteLine();
        }

        static void TalalatokSzama(int[] lotto, int[]nyero)
        {
            int darab = 0;
            for(int i = 0;i < nyero.Length;i++)
            {
                for (int j = 0; j < lotto.Length; j++)
                {
                    if (nyero[i] == lotto[j])
                    {
                        darab++;
                    }
                }
            }
			Console.WriteLine($"Találatok száma: {darab}");

        }

		static void Main(string[] args)
        {
            int [] nyeroszamok = LottoSzamokGeneralasMetodus();
            kiir(nyeroszamok);
            int [] enszamaim = Bekerszamok(nyeroszamok);
            kiir(enszamaim);

            TalalatokSzama(nyeroszamok, enszamaim);


		}   
    }
}
