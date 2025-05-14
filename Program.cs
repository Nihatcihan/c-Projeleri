internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Islem yapmak istediğiniz geometrik sekiller için\nucgen icin {1}'e\nkare icin {2}'ye\ndikdortgen icin {3}'e basınız: ");
        int deger = Convert.ToInt32(Console.ReadLine());

        switch (deger)
        {
            case 1:
                ucgen();
                break;
            case 2:
                kare();
                break;
            case 3:
                dikdortgen();
                break;
            default:
                Console.WriteLine("hatalı bir değer girdiniz");
                break;

        }
    }
    static void ucgen()
    {
        Console.Write("lütfen ücgenin kenar uzunluğunu giriniz:");
        int kenar=Convert.ToInt32(Console.ReadLine());
        string cisim="ucgen";
        Console.Write("Alan hesaplamak için {1}'e\nçevresini hesaplamak için {2}'ye basınız:");
        int kontrol=Convert.ToInt32(Console.ReadLine());

        switch (kontrol)
        {
            case 1:
                Alan(kenar,cisim);
            break;
            case 2:
                Cevre(kenar,cisim);
            break;
            default:
            Console.WriteLine("yanlış bir değer girdiniz");
            break;
        }
    }
    static void kare()
    {
        Console.Write("lütfen karenin kenar uzunluğunu giriniz:");
        int kenar=Convert.ToInt32(Console.ReadLine());
        string cisim="kare";
        Console.Write("Alan hesaplamak için {1}'e\nçevresini hesaplamak için {2}'ye basınız:");
        int kontrol=Convert.ToInt32(Console.ReadLine());

        switch (kontrol)
        {
            case 1:
                Alan(kenar,cisim);
            break;
            case 2:
                Cevre(kenar,cisim);
            break;
            default:
            Console.WriteLine("yanlış bir değer girdiniz");
            break;
        }
    }
    static void dikdortgen()
    {
        Console.Write("lütfen dikdortgenin uzun kenar uzunluğunu giriniz:");
        int kenar1=Convert.ToInt32(Console.ReadLine());
        Console.Write("lütfen dikdortgenin kısa kenar uzunluğunu giriniz:");
        int kenar2=Convert.ToInt32(Console.ReadLine());
        Console.Write("Alan hesaplamak için {1}'e\n çevresini hesaplamak için {2}'ye basınız:");
        int kontrol=Convert.ToInt32(Console.ReadLine());

        switch (kontrol)
        {
            case 1:
                Alan(kenar1,kenar2);
            break;
            case 2:
                Cevre(kenar1,kenar2);
            break;
            default:
            Console.WriteLine("yanlış bir değer girdiniz");
            break;
        }
    }
    static void Alan(int kenarUzunluğu ,string sekilİsmi)
    {
        if(sekilİsmi=="ucgen")
        {
            Console.WriteLine($"Üçgenin alanı:{(double)kenarUzunluğu*kenarUzunluğu/2}");
        }
        else
        {
            Console.WriteLine($"Karenin alanı:{kenarUzunluğu*kenarUzunluğu}");
        }
    }
    static void Alan(int kenarUzunluğu1,int kenarUzunluğu2)
    {
            Console.WriteLine($"Dikdörtgenin alanı:{kenarUzunluğu1*kenarUzunluğu2}");
    }
    static void Cevre(int kenarUzunluğu ,string sekilİsmi)
    {
        if(sekilİsmi=="ucgen")
        {
            Console.WriteLine($"Üçgenin çevresi:{kenarUzunluğu*3}");
        }
        else
        {
            Console.WriteLine($"Karenin çevresi:{kenarUzunluğu*4}");
        }
    }
    static void Cevre(int kenarUzunluğu1,int kenarUzunluğu2)
    {
            Console.WriteLine($"Dikdörtgenin çevresi:{(kenarUzunluğu1+kenarUzunluğu2)*2}");
    }
}