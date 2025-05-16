string sessiz = "QWRTYPSDFGHJKLZXCVBNMqwrtypsdfghjklzxcvbnm";

Console.Write("Lütfen bir cümle giriniz:");
string kontrol = Console.ReadLine();

SessizHarf(kontrol, sessiz);

void SessizHarf(string cumle,string sessizler)
{
    string[] dizi = cumle.Split(' ');
    int x = 0;
    for (int i = 0; i < dizi.Length; i++)
    {
        for (int j = 0; j < dizi[i].Length - 1; j++)
        {
            if (sessizler.Contains(dizi[i][j]) && sessizler.Contains(dizi[i][j + 1]))
            {
                Console.Write("True ");
                x++;
            }
        }
        if (x == 0)
            Console.Write("False ");
        else
            x = 0;
    }
}