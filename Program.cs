Console.Write("Üçgen yüksekliğini girin: ");
        int yukseklik;

        if (int.TryParse(Console.ReadLine(), out yukseklik) && yukseklik > 1)
        {
            for (int i = 0; i < yukseklik - 1; i++)
            {
                // Sol boşluk
                for (int j = 0; j < yukseklik - i - 1; j++)
                {
                    Console.Write(" ");
                }

                Console.Write("/");

                // İç boşluk
                for (int k = 0; k < i * 2; k++)
                {
                    Console.Write(" ");
                }

                Console.WriteLine("\\"); 
            }

            // Taban çizgisi
            Console.Write("/");
            for (int i = 0; i < (yukseklik - 1) * 2; i++)
            {
                Console.Write("_");
            }
            Console.WriteLine("\\");
        }