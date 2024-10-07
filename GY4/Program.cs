using System.Diagnostics;

namespace _24_25_prog_n11_gy4
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //   █████▀▀▀▀▀█████▀▀▀▀▀▀█████▀▀▀▀▀▀▀█████▀▀▀▀▀▀█████▀▀▀▀▀█████
            //    |O|___|:°°_°°_°°_°°_°°_°°:|______|O|______|:°°_°°:|___|O|
            //    | |°°°|:                 :|°°/\°°| |\°°°°/|   |   |°°°| | 
            //    | |°°°|:  04. GYAKORLAT  :|-[▓▓▓▓▓▓▓▓░░░░░░░░░░░░░░░░]| | 
            //    | |°°°|:                 :|/°°°°\| |°°\/°°|   |   |°°°| | 
            //    |O|___|:°°_°°_°°_°°_°°_°°:|______|O|______|:°°_°°:|___|O|
            //    ██ ██-----------------------------------------------██ ██
            //    |██ | A gyakorlat témája                            | ██|
            //    ██ ██-----------------------------------------------███ █
            //    | ██|                                               | ██|
            //    ███ █ 1) Összegzés, feltételes összegzés            ███ █
            //    |███|    megszámlálás, maximum kiválasztás,         | ██|
            //    ██  █    sablonjai.                                 ██ ██
            //    |███| 2) Gyakorló feladatok                         | ██|
            //    ██  █                                               ██ ██
            //    | ██|-----------------------------------------------| ██|
            //    |O|___|:°°_°°_°°_°°_°°_°°:|______|O|______|:°°_°°:|___|O|
            //    | |°°°|:                 :|/°°°°\| |°°\/°°|   |   |°°°| | 
            //    |O|___|:°°_°°_°°_°°_°°_°°:|______|O|______|:°°_°°:|___|O|
            //   █████▄▄▄▄▄█████▄▄▄▄▄▄█████▄▄▄▄▄▄▄█████▄▄▄▄▄▄█████▄▄▄▄▄█████





            //    |▀|____|~'''''''''''''''''''|________________|'''''''|___|▀| 
            //    |█|  ██|:    BEOLVASÁS     :|  ██  ██  ██  ██|   |   |HHH|█| 
            //    |▄|██__||'''''''''''''''''''|██__██__██__██__|'''''''|___|▄|   
            //        |
            //        |  Egy király bekéri az országában lakó N darab ember
            //        |  havi keresetét - valószínűleg nem kifejezetten tiszta
            //        |  szándékkal. Ismerjük továbbá az ország törvényi
            //        |  minimálbérét.
            //        └

            int N = int.Parse(Console.ReadLine());
            double minimalBer = double.Parse(Console.ReadLine());

            double[] berLista = new double[N];
            for (int i = 0; i < N; i++)
            {
                berLista[i] = double.Parse(Console.ReadLine()); 
            }





            //    |▀|____|~'''''''''''''''''''|________________|'''''''|___|▀| 
            //    |█|  ██|:   01. FELADAT    :|  ██  ██  ██  ██|   |   |HHH|█| 
            //    |▄|██__||'''''''''''''''''''|██__██__██__██__|'''''''|___|▄|   
            //        |
            //        |  (korábban beolvasott adatokkal)
            //        |
            //        |  A király kíváncsi az országának összkeresetére, így
            //        |  számolásba kezd.
            //        └

            double mindenBerOsszege = 0;

            for (int i = 0; i < N; i++)
            {
                mindenBerOsszege += berLista[i];
            }

            Console.WriteLine(mindenBerOsszege);





            //    |▀|____|~'''''''''''''''''''|________________|'''''''|___|▀| 
            //    |█|  ██|:   02. FELADAT    :|  ██  ██  ██  ██|   |   |HHH|█| 
            //    |▄|██__||'''''''''''''''''''|██__██__██__██__|'''''''|___|▄|   
            //        |
            //        |  (korábban beolvasott adatokkal)
            //        |  
            //        |  A király túlzottan empatizál a gazdagokkal ahhoz, hogy
            //        |  megadóztassa őket, ámde a szegények... az más kérdés.
            //        |  A király először is megszámolja azon polgárainak számát,
            //        |  akiknek keresete nem haladja meg a minimálbér 120%-át.
            //        └

            int kizsakmanyolhatokSzama = 0;
            
            for (int i = 0; i < N; i++)
            {
                if (berLista[i] <= minimalBer*1.2)
                {
                    kizsakmanyolhatokSzama++;
                }
            }

            Console.WriteLine(kizsakmanyolhatokSzama);





            //    |▀|____|~'''''''''''''''''''|________________|'''''''|___|▀| 
            //    |█|  ██|:   03. FELADAT    :|  ██  ██  ██  ██|   |   |HHH|█| 
            //    |▄|██__||'''''''''''''''''''|██__██__██__██__|'''''''|___|▄|   
            //        |
            //        |  (korábban beolvasott adatokkal)
            //        |  
            //        |  A király egy csekély 70%-os adót vet ki a minimálbér
            //        |  legfeljebb 120%-át megkereső lakosok havi bérére.
            //        |  Mennyi pénzre tesz így szert?
            //        └

            double osszAdo = 0;

            for (int i = 0; i < N; i++)
            {
                if (berLista[i] <= minimalBer * 1.2)
                {
                    osszAdo += berLista[i] * 0.7;
                }
            }

            Console.WriteLine(osszAdo);





            //    |▀|____|~'''''''''''''''''''|________________|'''''''|___|▀| 
            //    |█|  ██|:   04. FELADAT    :|  ██  ██  ██  ██|   |   |HHH|█| 
            //    |▄|██__||'''''''''''''''''''|██__██__██__██__|'''''''|___|▄|   
            //        |
            //        |  (korábban beolvasott adatokkal)
            //        | 
            //        |  A királyt váratlan "baleset" éri, így a nép új uralkodót
            //        |  választ magának. Kényelmi okokból a legmagasabb keresetűt
            //        |  szeretnék megválasztani. Hányadik lakos ez a listában, és
            //        |  mennyit keres?
            //        └

            int ujKiralyIndex = 0;
            double ujKiralyKeresete = berLista[0];

            for (int i = 1; i < N; i++)
            {
                if (berLista[i] > ujKiralyKeresete)
                {
                    ujKiralyIndex = i;
                    ujKiralyKeresete = berLista[i];
                }
            }

            Console.WriteLine(ujKiralyIndex + " " + ujKiralyKeresete);


        }
    }
}