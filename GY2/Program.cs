namespace _24_25_prog_e2_gy2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //   █████▀▀▀▀▀█████▀▀▀▀▀▀█████▀▀▀▀▀▀▀█████▀▀▀▀▀▀█████▀▀▀▀▀█████
            //    |O|___|:°°_°°_°°_°°_°°_°°:|______|O|______|:°°_°°:|___|O|
            //    | |°°°|:                 :|°°/\°°| |\°°°°/|   |   |°°°| | 
            //    | |°°°|:  02. GYAKORLAT  :|-[▓▓▓▓░░░░░░░░░░░░░░░░░░░░]| | 
            //    | |°°°|:                 :|/°°°°\| |°°\/°°|   |   |°°°| | 
            //    |O|___|:°°_°°_°°_°°_°°_°°:|______|O|______|:°°_°°:|___|O|
            //    ██ ██-----------------------------------------------██ ██
            //    |██ | A gyakorlat témája                            | ██|
            //    ██ ██-----------------------------------------------███ █
            //    | ██|                                               | ██|
            //    ███ █ 1) Ellenőrzött beolvasás                      ███ █
            //    |███| 2) Vegyes feladatok                           | ██|
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
            //        |  Valósíts meg ellenőrzött beolvasást TryParse használatával.
            //        |  Addig kérj bemenetet, amíg nem sikerül valid számot beolvasni.
            //        └

            // Console.ReadLine() - beolvas egy sort szöveges formában.

            int beolvasott;

            while (!int.TryParse(Console.ReadLine(), out beolvasott))
            {
                Console.WriteLine("Valami nem jó :(");
            }

            Console.WriteLine("Siker!");





            //    |▀|____|~'''''''''''''''''''|________________|'''''''|___|▀| 
            //    |█|  ██|:   02. FELADAT    :|  ██  ██  ██  ██|   |   |HHH|█| 
            //    |▄|██__||'''''''''''''''''''|██__██__██__██__|'''''''|___|▄|   
            //        |
            //        |  Döntsd el egy számról, hogy páros vagy páratlan-e.
            //        └

            int szam1 = int.Parse(Console.ReadLine());
            bool paros = (szam1 % 2 == 0);

            Console.WriteLine(paros);





            //    |▀|____|~'''''''''''''''''''|________________|'''''''|___|▀| 
            //    |█|  ██|:   03. FELADAT    :|  ██  ██  ██  ██|   |   |HHH|█| 
            //    |▄|██__||'''''''''''''''''''|██__██__██__██__|'''''''|___|▄|   
            //        |
            //        |  Döntsd el egy számról, hogy prím-e.
            //        └

            int szam2;
            szam2 = int.Parse(Console.ReadLine());

            bool prim;

            prim = true;

            int i = 2;
            while (prim && i < szam2/2)
            {
                prim = (szam2 % i != 0);
                i++;
            }

            Console.WriteLine(prim);





            //    |▀|____|~'''''''''''''''''''|________________|'''''''|___|▀| 
            //    |█|  ██|:   04. FELADAT    :|  ██  ██  ██  ██|   |   |HHH|█| 
            //    |▄|██__||'''''''''''''''''''|██__██__██__██__|'''''''|___|▄|   
            //        |
            //        |  Döntsd el egy koordinátáról, hogy egy Descartes-féle
            //        |  derékszögű koordináta-rendszer melyik síknegyedébe tartozik.
            //        |
            //        |   2 | 1
            //        |   -----
            //        |   3 | 4
            //        └

            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());

            int sik;

            if (x == 0 || y == 0)
            {
                sik = 0;
            } else if (x > 0 && y > 0)
            {
                sik = 1;
            } else if (x < 0 && y > 0)
            {
                sik = 2;
            } else if (x < 0 && y < 0)
            {
                sik = 3;
            } else
            {
                sik = 4;
            }

            if (sik == 0)
            {
                Console.WriteLine("Valamelyik koordináta komponens tengelyen helyezkedik el.");
            } else
            {
                Console.WriteLine(sik);
            }
            




        }
    }
}