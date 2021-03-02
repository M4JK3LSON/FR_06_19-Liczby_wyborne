using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FR_06_19___Liczby_wyborne
{
    class Program
    {
        public static bool wybornosc(int n)
        {
           
            int[] liczba;//tablica intow
            char[] help1 = n.ToString().ToCharArray();//tablica charow utworzona z liczby 
            liczba = new int[help1.Length];//tablica intow dlugosci tablicy charow
          

            for (int j = 0; j < help1.Length; j++)//przepisywanie charow na inty
            {

                liczba[help1.Length-j-1] = n % 10;//wyciaganie ostatniej cyfry
                n /= 10;//zmiejszanie liczby
                
          //      Console.WriteLine(liczba[j]);
            }

            for (int m = 1; m <= liczba.Length; m++)//tworzenie stringa z tablicy intow co jedna cyfre
            {
                string ciag="";
                for (int k = 0; k < m; k++)
                {
                    ciag += liczba[k].ToString();//dopisywanie cyfry do stringa
                }
           
                int tes2 = int.Parse(ciag);//tworzenie inta ze stringa
                if (tes2 % m != 0)//sprawdzanie czy obecny string zostanie podzielony bez reszty przez obecna ilosc cyfr z jakich jest zbudowany
                {
                    return false;//jezeli reszta z dzielenia jest inna niz 0 dyskfalifikuje liczbe z mozliwosci zostania liczba wyborna
                }
                
            }
            return true;//liczba wyborna
           


        }

        static void Main(string[] args)
        {
            int d = int.Parse(Console.ReadLine());
            for(int i = 0; i < d; i++)
            {
                int n = int.Parse(Console.ReadLine());//odczytanie liczby n
                bool wynik = false;
                bool wynik_w = false;
                bool wynik_n = false;
                int wynik_koncowy = 0;
                for (int j = 0; wynik != true; j++)
                {
                    int b = n + j;//liczba o j wieksza od n
                    int c = n - j;//liczba o j mniejsza od n
                    wynik_w = wybornosc(b);// sprawdzanie wybornosci liczby b
                    wynik_n = wybornosc(c);// sprawdzanie wybornosci liczby c

                    if(wynik_w==true && wynik_n == true)//rozstrzygniecie ze jesli obydwie liczby oddalone od liczby n o tę sama wartosc to wezmie liczbe mniejsza 
                    {
                        wynik_koncowy = n - j;// liczba wyborna mniejsza
                        break;
                    }
                    else//jezeli nie obydwie sa wyborne
                    {
                        if (wynik_w == true)//jezeli wieksza od n jest liczba wyborna to ja zwroci 
                        {
                            wynik_koncowy = n + j;
                            break;
                        }
                        else
                        {//jezeli obydwie nie sa wyborne i wieksza rowniez nie jest wyborna
                            if (wynik_n == true)//jezeli mniejsza jest wyborna to ja zwroci
                            {
                                wynik_koncowy = n - j;
                                break;
                            }
                            
                        }
                    }



                   
                }
                
               
                Console.WriteLine(wynik_koncowy);//wypisywanie wybornej
            }

            Console.ReadKey();
        }
    }
}
