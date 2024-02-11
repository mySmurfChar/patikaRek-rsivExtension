namespace rekürsivVeExtension
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sayiTabani = 3;
            int sayiUssu = 5;
            int anaSayi = 3;

            for (int i = 0; i < sayiUssu; i++)
            {
                anaSayi = anaSayi * sayiTabani;
                
                Console.WriteLine(anaSayi);
            }
            Console.WriteLine(anaSayi + " " + sayiTabani);
            Metotus metot=new Metotus();
            Console.WriteLine(metot.usAlma(8,5));
            Console.WriteLine(metot.faktoriyelAl(-9));

            int[] dizi=new int[] { 3, 65, 7, 8, 9 };
            int indis = dizi.Length-1;


            metot.Fibonacci(8, 26);
            Console.WriteLine(metot.diziToplam(dizi,indis));

            string ifade = "Muhammet Can Gökçe";
            bool sonuc = ifade.Checkspaces();
            Console.WriteLine(sonuc);
            if(sonuc)
            {
                Console.WriteLine(ifade.DeleteSpaces());

            }

            int a = 4;
            Console.WriteLine(
                "Sayı çift mi? "+ a.IsEvenNumber()
                );
            Console.WriteLine(ifade.GetFirstCharacter());
        }
        
    }
    public class Metotus
    {
        public int usAlma(int taban, int us)
        {
            if (us<2)
            {
                return taban;
            }
            else
            {
                return taban * usAlma(taban, us - 1);
            }
        }
        public int faktoriyelAl(int sayi)
        {
            if (sayi < 0)
            {
                sayi = sayi * -1;
                return faktoriyelAl(sayi);
            }
            else if(sayi ==0)
            {
                return 1;
            }
            else if (sayi ==1)
            {
                return 1;
            }
            else
            {
                return sayi * faktoriyelAl(sayi - 1);

            }
        }
        public void Fibonacci(int basSayi,int kacDefa)
        {
            Console.WriteLine(basSayi);
            if(kacDefa>0)
            {
                basSayi += basSayi;
                kacDefa--;
                Fibonacci(basSayi,kacDefa);

            }
        }
        public int diziToplam(int[] dizi,int indis)
        {
            if(indis>=0)
            {
                Console.WriteLine("Toplanıyor" + dizi[indis]);
                return dizi[indis] + diziToplam(dizi, indis - 1);
            }
            else
            {
                return 0;
            }
        }


    }

    public static class Extension
    {

        public static bool Checkspaces(this string param)
        {
            return param.Contains(" ");
        }

        public static string DeleteSpaces(this string param)
        {
            string[] dizi = param.Split(" ");
            return string.Join("", dizi);

        }

        public static string MakeUpperCase(this string param)
        {
            return param.ToUpper();
        }

        public static string MakeLowerCase(this string param)
        {
            return param.ToLower();
        }

        public static int[] SortArray(this int[] param)
        {
            Array.Sort(param);
            return param;


        }

        public static void EkranaYazdir(this int[] param)
        {
            foreach (var item in param)
            {
                Console.WriteLine(item);
            }
        }

        public static bool IsEvenNumber(this int param)//çift mi
        {
            return param % 2 == 0;

        }

        public static string GetFirstCharacter(this string param)
        {
            return param.Substring(0,1);

        }

    }


}
