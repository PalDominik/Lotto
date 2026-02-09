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
            Console.WriteLine("A generált lottószámok: " + string.Join(", ", lottoSzamok));
            return lottoSzamok;
		}

        static int [] Bekerszamok(int[] lotto)
        {
            int[] beker = new int[lotto.Length];
            for(int i = 0; i < lotto.Length; i++)
            {
                Console.Write($"Kérem adja meg a {i + 1}. számot: ");
                beker[i] = int.Parse(Console.ReadLine());
                for (int j = 0; j < i; j++)
                {
                    if (beker[i] == beker[j])
                    {
                        Console.WriteLine("Ez a szám már szerepel, kérem adjon meg egy másikat.");
                        i--;
                        break;
                    }
				}
			}

			return beker;
		}


		static void Main(string[] args)
        {
            int [] nyeroszamok = LottoSzamokGeneralasMetodus();
		}
    }
}
