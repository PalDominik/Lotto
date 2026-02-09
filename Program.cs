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


		static void Main(string[] args)
        {
            int [] nyeroszamok = LottoSzamokGeneralasMetodus();
		}
    }
}
