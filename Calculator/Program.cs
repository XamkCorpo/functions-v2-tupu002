namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //valitaan laskutoimitus
            int valinta = ValitseLaskuToimitus();

            //kysytään luvut
            double eka = KysyLuku("Syötä ensimmäinen luku:\n");
            double toka = KysyLuku("Syötä toinen luku:\n");

            //tulostetaan tulos
            TulostaTulos(valinta, eka, toka);
        }

        //suoritetaan laskutoimitus

        /// <summary>
        /// lasketaan yhteenlasku
        /// </summary>
        /// <param name="eka"></param>
        /// <param name="toka"></param>
        /// <returns></returns>
        static double LaskeSumma(double eka, double toka) => eka + toka;


        /// <summary>
        /// lasketaan vähennyslasku
        /// </summary>
        /// <param name="eka"></param>
        /// <param name="toka"></param>
        /// <returns></returns>
        static double LaskeErotus(double eka, double toka) => eka - toka;


        /// <summary>
        /// lasketaan kertolasku
        /// </summary>
        /// <param name="eka"></param>
        /// <param name="toka"></param>
        /// <returns></returns>
        static double LaskeKerto(double eka, double toka) => eka * toka;


        /// <summary>
        /// lasketaan jakolasku
        /// </summary>
        /// <param name="eka"></param>
        /// <param name="toka"></param>
        /// <returns></returns>
        static double LaskeOsamaara(double eka, double toka)
        {
            if (toka == 0)
            {
                Console.WriteLine("Nollalla ei voi jakaa.");
                return 0;
            }
            return eka / toka;
        }



        /// <summary>
        /// tulostetaan laskutoimituksen tulos
        /// </summary>
        /// <param name="valinta"></param>
        /// <param name="eka"></param>
        /// <param name="toka"></param>
        static void TulostaTulos(int valinta, double eka, double toka)
        {
            double tulos = 0;
            switch (valinta)
            {
                case 1:
                    tulos = LaskeSumma(eka, toka);
                    Console.WriteLine($"Tulos: {eka} + {toka} = {tulos}");
                    break;
                case 2:
                    tulos = LaskeErotus(eka, toka);
                    Console.WriteLine($"Tulos: {eka} - {toka} = {tulos}");
                    break;
                case 3:
                    tulos = LaskeKerto(eka, toka);
                    Console.WriteLine($"Tulos: {eka} * {toka} = {tulos}");
                    break;
                case 4:
                    tulos = LaskeOsamaara(eka, toka);
                    if (toka != 0)
                        Console.WriteLine($"Tulos: {eka} / {toka} = {tulos}");
                    break;
                default:
                    Console.WriteLine("Virheellinen valinta.");
                    break;
            }
        }

        /// <summary>
        /// kysytään käyttäjältä luku ja tarkistetaan että se on validi
        /// </summary>
        /// <param name="kysymys"></param>
        /// <returns></returns>
        static double KysyLuku(string kysymys)
        {
            while (true)
            {
                Console.Write(kysymys);

                string syote = Console.ReadLine();

                if (double.TryParse(syote, out double arvo))
                {
                    return arvo;
                }
                else
                {
                    Console.WriteLine("Yritä uudelleen.");
                }
            }
        }

        /// <summary>
        /// kysytään käyttäjältä haluttu laskutoimitus
        /// </summary>
        /// <returns></returns>
        private static int ValitseLaskuToimitus()
        {
            while (true)
            {
                Console.WriteLine($"Valitse laskutoimitus \n1: Yhteenlasku  \n2: Vähennyslasku \n3: Kertolasku \n4: Jakolasku");

                string syote = Console.ReadLine();
                if (int.TryParse(syote, out int valinta) && valinta >= 1 && valinta <= 4)
                {
                    return valinta;
                }
                else
                {
                    Console.WriteLine($"Yritä uudelleen.");
                }
            }
        }
    }
}
