(string x,int y)deger;
Console.Write("Lütfen bir kelime giriniz:");
deger.x=Console.ReadLine();
Console.Write("Lütfen silinmesini istediğiniz index numarasını giriniz:");
deger.y=Convert.ToInt32(Console.ReadLine());
harfSil(deger.x,deger.y);

void harfSil(string kelime, int sayi)
{
    List<char> chars=new List<char>();
    if(sayi<=kelime.Length)
    {
        for (int i = 0; i < kelime.Length; i++)
        {
            
            if(i==sayi)
                continue;
            chars.Add(kelime[i]);
        }
        for (int i = 0; i < chars.Count; i++)
            Console.Write(chars[i]);
    }
    else
        Console.WriteLine(kelime);

}