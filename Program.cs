Console.Write("lütfen bir cümle giriniz:");
string cumle = Console.ReadLine();

KarakterDegistirme(cumle);

void KarakterDegistirme(string cumle)
{
    string[] dizi = cumle.Split(' ');
    string ilk;
    string son;
    // for (int i = 0; i < dizi.Length; i++)
    // {
    //     Console.Write(dizi[i] + " ");
    // }
    for (int i = 0; i < dizi.Length; i++)
    {
        ilk = Convert.ToString(dizi[i][0]);
        son = Convert.ToString(dizi[i][dizi[i].Length - 1]);
        if (dizi[i].Length == 1)
        {
            dizi[i] = dizi[i].Remove(dizi[i].Length - 1, 1);
            dizi[i]= dizi[i].Insert(0, son);
        }   
        else
        {
            dizi[i] = dizi[i].Remove(dizi[i].Length - 1, 1);
            dizi[i] = dizi[i].Remove(0, 1);
            dizi[i] = dizi[i].Insert(0, son);
            dizi[i] = dizi[i].Insert(dizi[i].Length, ilk);
        }
       
     
    }
    for (int i = 0; i < dizi.Length; i++)
    {
        Console.Write(dizi[i] + " ");
    }
}
