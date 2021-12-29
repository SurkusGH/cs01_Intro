using System;

namespace cs01_paskaita
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("cs01_paskaita");
            Console.WriteLine($"4 + 5 = {4 + 5}");

            //int age = 15;
            //string myName = "Vilmantas";
            Console.WriteLine("Stringas: Koks Jūsų vardas: ");
            string myName = Console.ReadLine();

            Console.WriteLine("Integeris: Koks Jūsų amžius: ");
            int age = int.Parse(Console.ReadLine());

            //Console.ForegroundColor = ConsoleColor.DarkRed; // <-- paspalvoju consolės tekstą

            Console.WriteLine($"Mano vardas yra {myName} ir man yra {age} metų");

            //Assignment1();
            //Assignment2();
            //Assignment3();
            Assignment4();
        }

        public static void Assignment1()           // <-- į šitą vietą kolkas nekreipkite dėmesio, 
        {                                          //     čia aš tiesiog izoliuoju kodą, sekančias eilutes tiesiog apsirašykite main metode
            // Parašyti programą, kuri klausia vartotojo jo mėgstamos spalvos.
            // Programa visada turi atsakyti: mano irgi

            // Tai iš esmės užduotyje mus reikės vartotojo įvedamo 1 stringo, tai nuo to ir pradedame:
            string color; // <-- inicijuojame kintamąjį
            // tuomet sakome konsole skaityk įvestį
            color = Console.ReadLine(); // <-- čia konsolė prie anksčiau inicijuoto kintamojo priskiria reikšmę, kurią įvesite konsolėje
            //tuomet nurodome, kad kompiuteris imtų mūsų stringo reikšmę ir spausdintų ją tarp kitų žodžių:
            Console.WriteLine($"Mano irgi {color}"); // <-- riestiniuose sklaisutuose esantis kintamasis keičiasi priklausomai nuo įvesties
                                                     //     plačiau apie tai, tiesiog google "string interpolation".
        }

        public static void Assignment2()
        {
            //Parašyti programą, kuris išveda dviejų skaičių 17 ir 23 sumą

            int number1 = 17; // <-- elementariai inicijuojame sau kintamąjį
            int number2 = 23;
            //tuomet sakome konsolei spausdink sumą – čia paprasta kaip skaičiuotuve:
            Console.WriteLine($"Bus sudedami du skaičiai: {number1} + {number2}"); // <-- atkreipkite dėmesį, kad jeigu "+" yra ne riestiniuose skliaustuose, kaip
            Console.WriteLine($"Skaičių suma yra {number1 + number2}");            //     ankstesnėje eilutėje, jis neatlieka jokio veiksmo
        }                                                                          //     tik riestiniuose sklaustuose esantys operatoriai atlieka veiksmą.

        public static void Assignment3()
        {
            // Parašyti programą, kuris padalina 24 iš 5

            // Iš esmės tai yra tas pats kaip ir ankstesnėje užduotyje, tik operatorių iš "+" pakeičiame į "/"
            // Todėl, kad neperrašinėti, padarysiu kitu būdu tą patį ir kad vartotojas skaičius įvestų
            Console.WriteLine("Vartotojau įvesk 2 skaičius: "); // <-- consolė parašo vartotojui tekstą
            // Čia mes sukuriame du kintamuosius, kurių vertes įves vartotojas:
            int number3 = int.Parse(Console.ReadLine()); // <-- čia mes naudojame parse funckciją. Ką tai reiškia?
            int number4 = int.Parse(Console.ReadLine()); //     by default consolė priima stringą, parse funckija čia tiesiog pasako, kad čia yra įvedamas skaičius
            // Tuomet konsolė, kaip ir ankstesnėje užduotyje spausdina, ką jei nurodome; šį kartą optimalesniu būdu
            // Vienoje eilutėje nurodoma ir kokie skaičiai sudedami ir jų suma:
            Console.WriteLine($"Vartotojas dalybai įvedė skaičius {number3} ir {number4}, padalinus juos gauname: {number3 / number4}");
        }
        public static void Assignment4()
        {
            // Parašyti programą, kuri išveda rezultatą
            // -6+3*5
            // (13-2) * 7
            // (5+-2) + (20/10)

            // Užduotis yra analogiška ankstesnėms savo logika, todėl sprendimą aprašau trumpai:
            Console.WriteLine($"Lygtis: {-6} + {3} * {5} = {-6 + 3 * 5}");
            Console.WriteLine($"Lygtis: ({13} - {2}) * {7} = {(13 - 2) * 7}");
            Console.WriteLine($"Lygtis: ({5} + {-2}) + ({20} / {10}) = {(5 + -2) + (20 / 10)}");
            // Šita sprendimą galima buvo aprašyti ir paprasčiau, kad spausdintų tik atsakymus:
            Console.WriteLine($"{ -6 + 3 * 5}");
            Console.WriteLine($"{(13 - 2) * 7}");
            Console.WriteLine($"{(5 + -2) + (20 / 10)}");
            // Iš esmės pirma dalis yra tik dėl grožio, kad matytųsi veiksmai, ne tik atsakymas konsolėje.
            // Čia pavyzdžiui galime, nors užduotis ir neprašo pabandyti įsivesti patys sau skaičius apibrėžtai lygčiai, pavyzdžiui:
            Console.WriteLine("Įveskite skaičius X, Y, Z, kurie bus skaičiuojami pagal lygti X + Y * Z");
            // Čia inicijuojame vienu metu tris kintamuosius
            int X, Y, Z;
            //Tuomet konsolėje rašome vartotojui – įvesk X kintamąjį:
            Console.WriteLine("Įveskite X");
            X = int.Parse(Console.ReadLine());

            Console.WriteLine("Įveskite Y");
            Y = int.Parse(Console.ReadLine());

            Console.WriteLine("Įveskite Z");
            Z = int.Parse(Console.ReadLine());

            // Tuomet konsolėje dėl grožio pakartojame, kokia yra vartotojo įvestis:
            Console.WriteLine($"Vartotojo įvestis yra X = {X}, Y = {Y}, Z = {Z}, ");
            // Tuomet dėl grožio parašome kaip atrodys lygtis su kintamaisiais"
            Console.WriteLine($"Lygtis su kintamaisiais yra {X} + {Y} * {Z}");
            // Ir tuomet kaip ankstesnėse užduotyse aprašome paduodame atsakymą:
            Console.WriteLine($"Atsakymas yra {X + Y * Z}");
        }
    }
}

