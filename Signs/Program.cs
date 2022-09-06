using System;

namespace Signs
{
    class Horoscope
    {
        static void Main(string[] args)
        { 
            //Metodo que es copado
            Initiation();

            //Metodo que obtiene información
            int day, year, month;
            ObteinInformation(out day, out year, out month);

            Space();

            //Metodo que calcula edad
            int age = 0;
            CalculateAge(year, day, month);
            Console.WriteLine("Su edad es de = " + age + " años");

            Space();

            //Metodo que me den el signo
            Console.WriteLine("Su signo en el horoscopo zodiacal es : ");
            Zodiac(day, month);

            Space();

            //Metodo que me den el animal
            Console.WriteLine("Su animal en el horoscopo chino es : ");
            Animal(year);

            Space();

            //Metodo que me den el solar
        }

        private static void Initiation()
        {
            Console.BackgroundColor = ConsoleColor.Cyan;
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.Clear();

            Console.WriteLine("Dame tu nombre:");
            string name = Console.ReadLine();
            Console.Clear();
            Console.SetCursorPosition(30, 2);
            Console.WriteLine("Bienvienido " + name);
            Console.SetCursorPosition(18, 3);
            Console.WriteLine("Vamos a calcular tu edad y signo Zodiacal.\n");
        }

        private static void ObteinInformation(out int day, out int year, out int month)
        {
            Console.WriteLine("Ingrese su día de nacimiento (dd): ");
            day = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese su año de nacimiento (aaaa): ");
            year = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese su mes de nacimiento (mm): ");
            month = Int32.Parse(Console.ReadLine());
        }

        public static DateTime CalculateAge(int year, int day, int month)
        {
            DateTime bornDate = default;
            bornDate = bornDate.AddDays(day - 1).AddMonths(month - 1).AddYears(year - 1);

            DateTime current = DateTime.Now;
            DateTime age = current /*- bornDate*/;
            return age;
        }

        public static void Zodiac(int day, int month)
        {
            if ((day >= 21 && month == 3) || (day <= 20 && month == 4))
                Console.WriteLine("Aries");
            if ((day >= 24 && month == 9) || (day <= 23 && month == 10))
                Console.WriteLine("Libra");
            if ((day >= 21 && month == 4) || (day <= 21 && month == 5))
                Console.WriteLine("Tauro");
            if ((day >= 24 && month == 10) || (day <= 22 && month == 11))
                Console.WriteLine("Escorpio");
            if ((day >= 22 && month == 5) || (day <= 21 && month == 6))
                Console.WriteLine("Geminis");
            if ((day >= 23 && month == 11) || (day <= 21 && month == 12))
                Console.WriteLine("Sagitario");
            if ((day >= 21 && month == 6) || (day <= 23 && month == 7))
                Console.WriteLine("Cancer");
            if ((day >= 22 && month == 12) || (day <= 20 && month == 1))
                Console.WriteLine("Capricornio");
            if ((day >= 24 && month == 7) || (day <= 23 && month == 8))
                Console.WriteLine("Leo");
            if ((day >= 21 && month == 1) || (day <= 19 && month == 2))
                Console.WriteLine("Acuario");
            if ((day >= 24 && month == 8) || (day <= 23 && month == 9))
                Console.WriteLine("Virgo");
            if ((day >= 20 && month == 2) || (day <= 20 && month == 3))
                Console.WriteLine("Piscis");
        }

        public static void Animal(int year)
        {
            int yearSign = year - 1900;
            int number = yearSign % 12;

            if (number == 0)
                Console.WriteLine("Rata");
            if (number == 1)
                Console.WriteLine("Buey");
            if (number == 2)
                Console.WriteLine("Tigre");
            if (number == 3)
                Console.WriteLine("Conejo");
            if (number == 4)
                Console.WriteLine("Dragon");
            if (number == 5)
                Console.WriteLine("Serpiente");
            if (number == 6)
                Console.WriteLine("Caballo");
            if (number == 7)
                Console.WriteLine("Cabra");
            if (number == 8)
                Console.WriteLine("Mono");
            if (number == 9)
                Console.WriteLine("Gallo");
            if (number == 10)
                Console.WriteLine("Perro");
            if (number == 11)
                Console.WriteLine("Cerdo");
        }
        public static void Space()
        {
            Console.WriteLine("\n");
        }

    }
}

