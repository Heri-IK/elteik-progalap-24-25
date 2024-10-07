namespace _24_25_prog_n11_gy1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //   █████▀▀▀▀▀█████▀▀▀▀▀▀█████▀▀▀▀▀▀▀█████▀▀▀▀▀▀█████▀▀▀▀▀█████
            //    |O|___|:°°_°°_°°_°°_°°_°°:|______|O|______|:°°_°°:|___|O|
            //    | |°°°|:                 :|°°/\°°| |\°°°°/|   |   |°°°| | 
            //    | |°°°|:  01. GYAKORLAT  :|-[▓▓░░░░░░░░░░░░░░░░░░░░░░]| | 
            //    | |°°°|:                 :|/°°°°\| |°°\/°°|   |   |°°°| | 
            //    |O|___|:°°_°°_°°_°°_°°_°°:|______|O|______|:°°_°°:|___|O|
            //    ██ ██-----------------------------------------------██ ██
            //    |██ | A gyakorlat témája                            | ██|
            //    ██ ██-----------------------------------------------███ █
            //    | ██|                                               | ██|
            //    ███ █ - Gyorstalpaló:                               ███ █
            //    |███| 1) Kiírás                                     | ██|
            //    ██  █ 2) Változók, konverziók                       ██ ██
            //    |███| 3) Tömbök                                     | ██|
            //    ██  █ 4) Elágazások                                 ██ ██
            //    |███| 5) Ciklusok                                   | ██|
            //    ██  █                                               ██ ██
            //    | ██|-----------------------------------------------| ██|
            //    |O|___|:°°_°°_°°_°°_°°_°°:|______|O|______|:°°_°°:|___|O|
            //    | |°°°|:                 :|/°°°°\| |°°\/°°|   |   |°°°| | 
            //    |O|___|:°°_°°_°°_°°_°°_°°:|______|O|______|:°°_°°:|___|O|
            //   █████▄▄▄▄▄█████▄▄▄▄▄▄█████▄▄▄▄▄▄▄█████▄▄▄▄▄▄█████▄▄▄▄▄█████



            // Ez egy komment - a fordító ignorálja ezt a szöveget,
            // magunknak (és másoknak) dokumentálhatunk így.

            /*
             * ez
             * egy
             * több
             * soros
             * komment
             */



            //    /▀\________________/█▀██▀▀▀▀███▀▀███▀▀▀▀██▀█\________________/▀\
            //    |▀|////////////////█:                      :█\\\\\\\\\\\\\\\\|▀| 
            //    |█|  ██  ██  ██  ██|:        Kiírás        :|██  ██  ██  ██  |█| 
            //    |▄|██__██__██__██__█:                      :█  ██  ██  ██  ██|▄|   
            //    \▄/                \█▄██▄▄▄▄███▄▄███▄▄▄▄██▄█/                \▄/
            //     █ 
            //     █  Szöveg kiírása a parancssoros felületre:
            //     █ 
            //     █     Console.WriteLine();
            //     █     Console.Write();
            //     █ 
            //     █  A fönti utasítások a 'Console' osztály 'WriteLine' vagy 'Write'
            //     █  metódusait hívják meg. Ezekkel a fogalmakkal egyelőre mélyebben
            //     █  nem foglalkozunk!
            //     █ 
            //     █  A zárójelek közé a metódus ún. paraméterei kerülnek, egy metódushoz
            //     █  többféle paraméterezés is tartozhat. A paraméter valamilyen bemenő
            //     █  adat, amellyel a metódus dolgozik.
            //     █ 
            //     █  Kísérletezzünk:
            //     █     1) írjuk ki, hogy "Hello World".
            //     █     2) Írjuk ki, hogy ""Hello World"", tehát ezúttal a szöveg
            //     █        idézőjelek között jelenjen meg.
            //     █     3) Írjuk ki, hogy "ELTE INFORMATIKAI KAR", ám minden szó
            //     █        kerüljön új sorba. Egy utasítást használjunk.
            //     █     4) Mi van akkor, ha több szöveg adatot szeretnénk egy
            //     █        utasítással kiírni? (ez később lesz hasznos)
            //     █ 
            //    \▄/  

            Console.WriteLine("Hello, world");
            Console.WriteLine("\"Hello, world\"");
            Console.WriteLine("ELTE\nINFORMATIKAI\nKAR");
            Console.WriteLine("ELTE " + "INFORMATIKA " + "KAR");





            //    /▀\________________/█▀██▀▀▀▀███▀▀███▀▀▀▀██▀█\________________/▀\
            //    |▀|////////////////█:                      :█\\\\\\\\\\\\\\\\|▀| 
            //    |█|  ██  ██  ██  ██|:       Változók       :|██  ██  ██  ██  |█| 
            //    |▄|██__██__██__██__█:                      :█  ██  ██  ██  ██|▄|   
            //    \▄/                \█▄██▄▄▄▄███▄▄███▄▄▄▄██▄█/                \▄/
            //     █
            //     █  Általátunk használt primitív változótípusok:
            //     █ 
            //     █     egész szám: int
            //     █     egész szám 64 biten: long
            //     █     lebegőpontos szám: float
            //     █     lebegőpontos szám 64 biten: double
            //     █     karakter: char
            //     █     szöveg: string
            //     █     logikai: bool
            //     █ 
            //     █  Deklaráció:
            //     █     típus azonosító;
            //     █  Pl.:
            //     █     int age;
            //     █ 
            //     █  Inicializációval:
            //     █     típus azonosító = érték;
            //     █   Pl.:
            //     █     int age = 33;
            //     █ 
            //     █  Néhány konverzió:
            //     █ 
            //     █  Convert osztály metódusai (kísérlezett), pl.:
            //     █     Convert.ToInt32();
            //     █     Convert.ToString();
            //     █  stb.
            //     █ 
            //     █  Szöveg parsing:
            //     █     int.Parse();
            //     █     double.Parse();
            //     █  stb.
            //     █ 
            //    \▄/

            int almakSzama;
            almakSzama = 5;

            double valami = 4.5;
            string valami2 = "Nem tudom";
            char valami3 = '4';
            bool valami4 = true;

            almakSzama = 7;





            //    /▀\________________/█▀██▀▀▀▀███▀▀███▀▀▀▀██▀█\________________/▀\
            //    |▀|////////////////█:                      :█\\\\\\\\\\\\\\\\|▀| 
            //    |█|  ██  ██  ██  ██|:        Tömbök        :|██  ██  ██  ██  |█| 
            //    |▄|██__██__██__██__█:                      :█  ██  ██  ██  ██|▄|   
            //    \▄/                \█▄██▄▄▄▄███▄▄███▄▄▄▄██▄█/                \▄/
            //     █
            //     █  Tömbök
            //     █  
            //     █  Valamilyen típusú tömb:
            //     █     típus[]
            //     █  Pl.:
            //     █     int[]
            //     █  
            //     █  Deklaráció és default inicializáció:
            //     █     típus[] azonosító = new típus[hossz];
            //     █  Pl.:
            //     █     int[] numbers = new int[5];
            //     █  
            //     █  Létrehozható tömb kezdeti értékekkel, így:
            //     █     int[] numbers = {4,3,5,6,2};
            //     █  
            //     █  Tömb elemének elérése (indexeléssel):
            //     █     azonosító[sorszám]
            //     █  Pl.:
            //     █     numbers[2]
            //     █  
            //     █  Mindig 0-tól indexelünk, így az első elemet a 0. indexen érjük el.
            //     █  
            //     █  Tömbhossz:
            //     █     azonosító.Length;
            //     █  
            //    \▄/

            int[] tomb1 = {2,5,3,1,80};
            int[] tomb2 = new int[30];

            Console.WriteLine(tomb1[0]);
            Console.WriteLine(tomb1.Length);





            //    /▀\________________/█▀██▀▀▀▀███▀▀███▀▀▀▀██▀█\________________/▀\
            //    |▀|////////////////█:                      :█\\\\\\\\\\\\\\\\|▀| 
            //    |█|  ██  ██  ██  ██|:      Elágazások      :|██  ██  ██  ██  |█| 
            //    |▄|██__██__██__██__█:                      :█  ██  ██  ██  ██|▄|   
            //    \▄/                \█▄██▄▄▄▄███▄▄███▄▄▄▄██▄█/                \▄/
            //     █
            //     █  if (feltétel)
            //     █     {
            //     █         ha igaz
            //     █     {
            //     █
            //     █
            //     █  if (feltétel)
            //     █     {
            //     █         ha igaz
            //     █     {
            //     █  else
            //     █     {
            //     █         ha nem igaz
            //     █     }
            //     █
            //     █
            //     █  switch(adat)
            //     █     {
            //     █         case érték:
            //     █             valami
            //     █             break;
            //     █
            //     █         case érték:
            //     █             valami
            //     █             break;
            //     █
            //     █         deault:
            //     █             valami;
            //     █             break;
            //     █     }
            //     █
            //    \▄/

            int kor = int.Parse(Console.ReadLine());

            if (kor >= 18)
            {
                Console.WriteLine("Kor elfogadva.");
            } else if (kor >= 2)
            {
                Console.WriteLine("Túl fiatal vagy.");
            } else
            {
                Console.WriteLine("Te hogyan használsz egyáltalán számítógépet?");
            }

            int eset = 3;

            switch (eset)
            {
                case 0:
                    // valami
                    break;
                case 1:
                    // valami
                    break;
                default:
                    // valami
                    break;
            }





            //    /▀\________________/█▀██▀▀▀▀███▀▀███▀▀▀▀██▀█\________________/▀\
            //    |▀|////////////////█:                      :█\\\\\\\\\\\\\\\\|▀| 
            //    |█|  ██  ██  ██  ██|:       Ciklusok       :|██  ██  ██  ██  |█| 
            //    |▄|██__██__██__██__█:                      :█  ██  ██  ██  ██|▄|   
            //    \▄/                \█▄██▄▄▄▄███▄▄███▄▄▄▄██▄█/                \▄/
            //     █             
            //     █   for (indexváltozó = érték; futási_feltétel; indexáltozó manipulációja)
            //     █      {
            //     █          valami
            //     █      }
            //     █ 
            //     █ 
            //     █   while (futási_feltétel)
            //     █      {
            //     █          valami
            //     █      }
            //     █ 
            //     █ 
            //     █   foreach (valami in adatszerkezet)
            //     █      {
            //     █          valami
            //     █      }
            //     █
            //    \▄/

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }

            int a = 700;

            while (a >= 100)
            {
                a = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Na végre, egy száznál kisebb szám!");

            int[] arr = { 3, 5, 1 };

            foreach (int r in arr)
            {
                Console.WriteLine(r);
            }





        }
    }
}