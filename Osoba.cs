public class Osoba

{
    private string imięNazwisko;

    public string ImięNazwisko
    {
        get { return imięNazwisko; }
        set
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentException("Imię nie może być puste.");
            }

            imięNazwisko = value;
            AktualizujImięINazwisko(value);
        }
    }

    public Osoba(string imięNazwisko)
    {
        ImięNazwisko = imięNazwisko;
    }

    private string? imię;
    public string Imię
    {
        get => imię;
        set
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentException("Imię nie może być puste.");
            }
            imię = value;
        }
    }

    private string? nazwisko;
    public string Nazwisko
    {
        get => nazwisko;
        set { nazwisko = value; }
    }

    public DateTime? DataUrodzenia { get; set; }
    public DateTime? DataŚmierci { get; set; }

    public TimeSpan? Wiek
    {
        get
        {
            if (DataUrodzenia == null)
            {
                return null;
            }

            DateTime śmierc_czyZyjeDoDzisiaj = DataŚmierci ?? DateTime.Now.Date;
            return śmierc_czyZyjeDoDzisiaj - DataUrodzenia.Value;
        }
    }

    private void AktualizujImięINazwisko(string value)
    {
        if (string.IsNullOrEmpty(value))
        {
            imię = null;
            nazwisko = null;
        }
        else
        {
            string[] split = value.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            if (split.Length > 0)
            {
                imię = split[0];
                if (split.Length > 1)
                {
                    nazwisko = split[split.Length - 1];
                }
                else
                {
                    nazwisko = string.Empty;
                }
            }
        }
    }
}