
internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Lütfen dairenin yarıçaını giriniz:");
        int yaricap = Convert.ToInt32(Console.ReadLine());
        if(yaricap>0)
        {
            DaireCiz(yaricap);
        }
        
        else
            Console.WriteLine("Hatalı değer girdiniz");
    }

    static void DaireCiz(int r)
    {
        int j=1;
        for (int i = 0; i < r; i++)
        {
            if(i==0)
            {
                System.Console.Write(new string(' ',r*2));
                System.Console.WriteLine("****");
                continue;
            }
            
                System.Console.Write(new string(' ',2*(r-i))+"**");
                System.Console.WriteLine(new string(' ',2*(i+j))+"**");
            
           
            j++;
        }
        j=r-1;
        for (int i = 0; i < r; i++)
        {
           
            
                System.Console.Write(new string(' ',2*(i+1))+"**");
                System.Console.WriteLine(new string(' ',4*j)+"**");
            
            
            j--;
            
        }
    }

}

