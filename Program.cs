Console.Write("Lütfen girilecek sayı adetini giriniz:");
int sayi=Convert.ToInt32(Console.ReadLine());

MutlakKareAl(sayi);


void MutlakKareAl(int diziUzunlugu)
{
    List<int> liste =new List<int>();
    int kucuk=0;
    int buyuk=0;

    for (int i = 0; i < diziUzunlugu; i++)
    {
        int deger=Convert.ToInt32(Console.ReadLine());
        if(deger<67)
            kucuk+=67-deger;
        else
            buyuk+=(deger-67)*(deger-67);
    }
    Console.Write($"{kucuk} {buyuk}");
}