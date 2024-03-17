
namespace Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Task1
            //2 string array-i içerisindeki ortaq elementleri tapib ekrana yazdiran metod;

            //string[] arr1 = { "zam", "fd", "Siri", };
            //string[] arr2 = { "Ri", "zam", "Siri", "Ef", "Nici" };


            //FindSameStrings(arr1, arr2);

            #endregion

            #region Task2
            /*2 eyni uzunluqlu array içerisindeki elementlerin indexlerine uygun hasilini tapib ekrana yazdiran metod
            (example : { 5 , 10 ,15}. ve {2 , 4 , 5}. ==>  { 10 , 40 ,75 })*/

            //int[] arr1 = { 5,10,15 };
            //int[] arr2 = { 2,4,5 };


            //FindResult(arr1, arr2);

            #endregion

            #region Task3
            /*
             3.Array -in içerisinde verilmiş herf ile başlayan elementleri ekrana yazdıran method
            (example : axtarırıq A hərfi  {"Anar" , "Eli" , "Yusif" , "Arif" }   ==> Anar , Arif)
            */

            //string[] arr = { "Anar", "Eli", "Yusif", "Arif" };

            //Console.Write("Axtardiginiz herfi daxil edin: ");
            //char a = Convert.ToChar(Console.ReadLine().ToLower());

            //FindChar(arr, a);
            #endregion

            #region Task4
            /*
             4.Area deyə Method(lar) yaradın
            a. Çevrənin sahəsi - S = p*r² (p=3)
            b. Düzbucaqlının sahəsi - S = a*b
            c. Düzbucaqlı paralelpipedin tam səthinin sahəsi - S=2(a*b+a*c+b*c)
            d. Üçbucaqlının daxilinə çəkilmiş çevrənin sahəsi - S=p*r; p=(a+b+c)/2
             */

            //Area(6);
            //Area(4, 5);
            //Area(4, 5, 6);
            //Area(4, 5, 6, 3);


            #endregion



        }

        static void FindSameStrings(string[] arr1, string[] arr2)
        {
            for (int i = 0; i < arr1.Length; i++)
            {
                for (int j = 0; j < arr2.Length; j++)
                {
                    if (arr1[i] == arr2[j])
                    {
                        Console.WriteLine(arr1[i]);
                    }
                }
            }
        }

        static void FindResult(int[] arr1, int[] arr2)
        {
            int[] newArr = new int[arr1.Length];

            for (int i = 0; i < arr1.Length; i++)
            {
                newArr[i] = arr1[i] * arr2[i];

            }
            for (int i = 0; i < newArr.Length; i++)
                Console.Write($"{newArr[i]} ");
        }
        static void FindChar(string[] arr, char herf)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = arr[i].ToLower();
                if (herf == arr[i][0])
                {
                    Console.WriteLine($"{herf} Herfi ile başlayan söz {arr[i]}");
                }
            }
        }
        static void Area(double r)
        {
            double p = 3;
            //double S =p*Math.Pow(r ,2);//qisa yol
            double S = p * (r * r);

            Console.WriteLine($"Çevrənin sahəsi: {S}");

        }
        static void Area(int a, int b)
        {
            int S = a * b;

            Console.WriteLine($"Düzbucaqlının sahəsi: {S}");
        }
        static void Area(int a, int b, int c)
        {
            double S = 2 * (a * b + a * c + b * c);

            Console.WriteLine($"Düzbucaqlı paralelpipedin tam səthinin sahəsi: {S}");

        }
        static void Area(int a, int b, int c, int r)
        {
            int p = (a + b + c) / 2;
            double S = p * r;


            Console.WriteLine($"Üçbucaqlının daxilinə çəkilmiş çevrənin sahəsi : {S}");

        }



    }
}

