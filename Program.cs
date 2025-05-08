internal class Program
{
    private static void Main(string[] args)
    {
        List<int> fibonacci=new List<int>();
        fibonacci.Add(0);
        fibonacci.Add(1);
        fibonacci.Add(1);
        int diziUzunlugu=3;
       Console.WriteLine("Ortalamasını hesaplamak istediğiniz fibonacci dizisinin uzunluğunu giriniz");
       try
       {
        diziUzunlugu=Convert.ToInt32(Console.ReadLine());
       }
       catch (System.Exception)
       {
        Console.WriteLine("Hatalı bir değer girdiniz");
        throw;
       }
       for (int i = 2; i < diziUzunlugu-1; i++)
       {
        int eklenecekSayi=fibonacci[i]+fibonacci[i-1];
        fibonacci.Add(eklenecekSayi);
       }
       ortalamaHesapla(fibonacci);
    }
    public static void ortalamaHesapla(List<int> list)
    {
        double ortalama=0;
        double toplam=0;
       for (int i = 0; i < list.Count; i++)
         toplam+=list[i];
       
       ortalama=toplam/list.Count;
       Console.WriteLine($"Ortalama:{ortalama}");
    }

    
}

