namespace _24_25_prog_e2_gy3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //   █████▀▀▀▀▀█████▀▀▀▀▀▀█████▀▀▀▀▀▀▀█████▀▀▀▀▀▀█████▀▀▀▀▀█████
            //    |O|___|:°°_°°_°°_°°_°°_°°:|______|O|______|:°°_°°:|___|O|
            //    | |°°°|:                 :|°°/\°°| |\°°°°/|   |   |°°°| | 
            //    | |°°°|:  03. GYAKORLAT  :|-[▓▓▓▓▓▓░░░░░░░░░░░░░░░░░░]| | 
            //    | |°°°|:                 :|/°°°°\| |°°\/°°|   |   |°°°| | 
            //    |O|___|:°°_°°_°°_°°_°°_°°:|______|O|______|:°°_°°:|___|O|
            //    ██ ██-----------------------------------------------██ ██
            //    |██ | A gyakorlat témája                            | ██|
            //    ██ ██-----------------------------------------------███ █
            //    | ██|                                               | ██|
            //    ███ █ 1) Adatsorozat beolvasása                     ███ █
            //    |███| 2) Tömbökkel végzett egyszerű feladatok       | ██|
            //    ██  █                                               ██ ██
            //    | ██|-----------------------------------------------| ██|
            //    |O|___|:°°_°°_°°_°°_°°_°°:|______|O|______|:°°_°°:|___|O|
            //    | |°°°|:                 :|/°°°°\| |°°\/°°|   |   |°°°| | 
            //    |O|___|:°°_°°_°°_°°_°°_°°:|______|O|______|:°°_°°:|___|O|
            //   █████▄▄▄▄▄█████▄▄▄▄▄▄█████▄▄▄▄▄▄▄█████▄▄▄▄▄▄█████▄▄▄▄▄█████





            //    |▀|____|~'''''''''''''''''''|________________|'''''''|___|▀| 
            //    |█|  ██|:   01. FELADAT    :|  ██  ██  ██  ██|   |   |HHH|█| 
            //    |▄|██__||'''''''''''''''''''|██__██__██__██__|'''''''|___|▄|   
            //        |
            //        |  Olvass be egy számot, majd hozz létre egy, a számnak megfelelő hosszúságú Integer tömböt.
            //        |  Töltsd fel a tömböt számokkal, a standard inputról olvasva.
            //        └

            int n = int.Parse(Console.ReadLine());
            int[] tomb = new int[n];

            for (int i = 0; i < n; i++)
            {
                tomb[i] = int.Parse(Console.ReadLine());
            }





            //    |▀|____|~'''''''''''''''''''|________________|'''''''|___|▀|
            //    |█|  ██|:   02. FELADAT    :|  ██  ██  ██  ██|   |   |HHH|█|
            //    |▄|██__||'''''''''''''''''''|██__██__██__██__|'''''''|___|▄|
            //        |
            //        |  Írasd ki az előbbi tömb elemeit.
            //        └
            
            for (int i = 0; i < n; i++)
            {
                Console.Write(tomb[i] + " ");
            }

            Console.WriteLine();





            //    |▀|____|~'''''''''''''''''''|________________|'''''''|___|▀|
            //    |█|  ██|:   03. FELADAT    :|  ██  ██  ██  ██|   |   |HHH|█|
            //    |▄|██__||'''''''''''''''''''|██__██__██__██__|'''''''|___|▄|
            //        |
            //        |  Írassuk ki a tömb elemeit addig, amíg egy 41-nél nagyobb számot
            //        |  nem találunk. Ekkor fejezzük be a kiírást.
            //        └

            int h = 0;
            while (h < n && tomb[h] <= 41)
            {
                Console.WriteLine(tomb[h]);
                h++;
            }





            //    |▀|____|~'''''''''''''''''''|________________|'''''''|___|▀|
            //    |█|  ██|:   04. FELADAT    :|  ██  ██  ██  ██|   |   |HHH|█|
            //    |▄|██__||'''''''''''''''''''|██__██__██__██__|'''''''|___|▄|
            //        |
            //        |  Írassuk ki a tömb héttel osztható elemeit.
            //        └

             for (int i = 0; i < n; i++)
             {
                 if (tomb[i] % 7 == 0)
                 {
                     Console.WriteLine(tomb[i]);
                 }
             }





            //    |▀|____|~'''''''''''''''''''|________________|'''''''|___|▀|
            //    |█|  ██|:   05. FELADAT    :|  ██  ██  ██  ██|   |   |HHH|█|
            //    |▄|██__||'''''''''''''''''''|██__██__██__██__|'''''''|___|▄|
            //        |
            //        |  Írjuk ki a tömb elemeinek összegét.
            //        └

            int szum = 0;

            for (int i = 0; i < n; i++)
            {
                szum += tomb[i];
            }

            Console.WriteLine(szum);





            //    |▀|____|~'''''''''''''''''''|________________|'''''''|___|▀|
            //    |█|  ██|:   06. FELADAT    :|  ██  ██  ██  ██|   |   |HHH|█|
            //    |▄|██__||'''''''''''''''''''|██__██__██__██__|'''''''|___|▄|
            //        |
            //        |  Írjuk ki a tömb elemeinek átlagát.
            //        └

            // egész átlag:
            int avg = szum / n;

            // tört típusú átlag
            double avgFloat = (double)szum / (double)n;

            Console.WriteLine(avg);





            //    |▀|____|~'''''''''''''''''''|________________|'''''''|___|▀|
            //    |█|  ██|:   07. FELADAT    :|  ██  ██  ██  ██|   |   |HHH|█|
            //    |▄|██__||'''''''''''''''''''|██__██__██__██__|'''''''|___|▄|
            //        |
            //        |  Írjuk ki a tömb helyenkénti részösszegeit.
            //        └

            int[] reszOsszeg = new int[n];

            for (int i = 0; i < n; i++)
            {

                for (int j = 0; j <= i; j++)
                {
                    reszOsszeg[i] += tomb[j];
                }

            }

            for (int i = 0; i < n; i++)
            {
                Console.Write(reszOsszeg[i] + " ");
            }

            Console.WriteLine();





            //    |▀|____|~'''''''''''''''''''|________________|'''''''|___|▀|
            //    |█|  ██|:   08. FELADAT    :|  ██  ██  ██  ██|   |   |HHH|█|
            //    |▄|██__||'''''''''''''''''''|██__██__██__██__|'''''''|___|▄|
            //        |
            //        |  Valósítsuk meg a buborékrendezést a tömbön.
            //        └

            for (int i = n - 1; i > 0; i--)
            {
                for (int j = 0; j < i; j++)
                {
                    if (tomb[j] > tomb[j + 1])
                    {
                        int c = tomb[j];
                        tomb[j] = tomb[j + 1];
                        tomb[j + 1] = c;
                    }
                }
            }

            for (int i = 0; i < n; i++)
            {
                Console.Write(tomb[i] + " ");
            }

            Console.WriteLine();





        }
    }
}