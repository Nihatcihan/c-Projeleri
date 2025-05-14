
Console.Write("Lütfen bir cümle giriniz:");
string cumle=Console.ReadLine();
karakterTersYazdirma(cumle);

void karakterTersYazdirma(string cumle)
{
    string[] dizi=cumle.Split(' ');
    string[] reverse=new string[dizi.Length];

    for (int i = 0; i < dizi.Length; i++)
    {
        for (int j = dizi[i].Length-1; j >-1; j--)
        {
            reverse[i]+=dizi[i][j];
        }
    }
    for (int i = 0; i < reverse.Length; i++)
    {
        Console.Write(reverse[i]+" ");
    }
}