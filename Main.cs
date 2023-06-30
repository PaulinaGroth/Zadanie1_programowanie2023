namespace Zadanie1_programowanie2023
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Osoba osoba = new Osoba("Antonina Kowal");
            Osoba osoba2 = new Osoba("Eleonora Byk");
            osoba.DataUrodzenia = new DateTime(1998, 02, 11);
            osoba.DataŚmierci = new DateTime(2010, 07, 20);


            Console.WriteLine(osoba.Imię);
            Console.WriteLine(osoba.Nazwisko);
            Console.WriteLine(osoba.DataUrodzenia?.ToString("yyyy-MM-dd"));
            Console.WriteLine(osoba.DataŚmierci?.ToString("yyyy-MM-dd"));
            Console.WriteLine(osoba.Wiek?.TotalDays);
            Console.WriteLine(osoba.ImięNazwisko);
        }
    }

}
