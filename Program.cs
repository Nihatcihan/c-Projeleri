Console.Write("Lütfen girmek istediğiniz integer ikili sayısını giriniz:");
int sayi=Convert.ToInt32(Console.ReadLine());
integerİkilisi(sayi);

void integerİkilisi(int deger)
{
    List<int> liste =new List<int>();
    Console.Write("Lütfen integer ikililerini giriniz:");
    for (int i = 0; i < deger*2; i++)
    {
        liste.Add(Convert.ToInt32(Console.ReadLine()));
    }
    ikiliToplamlari(liste);
}

void ikiliToplamlari(List<int> ikiliDizisi)
{
    List<int> sonuc=new List<int>();
    for (int i = 0; i < ikiliDizisi.Count; i++)
    {
        if(ikiliDizisi[i]==ikiliDizisi[i+1])
            sonuc.Add(ikiliDizisi[i]*ikiliDizisi[i+1]);
        else
            sonuc.Add(ikiliDizisi[i]+ikiliDizisi[i+1]);

        i++;
    }
    for (int i = 0; i < sonuc.Count; i++)
    {   
        if(i==sonuc.Count-1)
            Console.Write(sonuc[i]);
        else
            Console.Write($"{sonuc[i]} ");
    }
}