using System;
using System.Collections;
using System.Collections.Generic;

namespace AtliKarinca
{
    class Program
    {
        static void Main(string[] args)
        {

            //K her seferinde Atlı Karıncaya binen kişi sayısı
            //R bir günde atlı karıncanın çalışma sayısı
            //N kadar Atlı Karıncaya binmek isteyen grup
            //kişi başı 1 TL kazanç
            int R, K, N;
            int toplamPara = 0;
            int temp;
            int grupSayisi = 0;
            int sira = 1;
            string binenGrupDegerleri = "";
            List<string> repo = new List<string>();
            Console.WriteLine("Aşağıda verilen sıralamaya göre arada boşluk bırakarak '4 6 4' şeklinde değerleri giriniz...");
            Console.WriteLine();
            Console.WriteLine("     R - Atlı Karınca günde kaç defa çalışıyor? \n" +
                              "     K - Her seferinde kaç kişi binebiliyor?\n" +
                              "     N - Bİnmek isteyen kaç adet grup var?");
            Console.WriteLine();
            string rknDeger = Console.ReadLine();
            string[] rknSplit = rknDeger.Split(' ');
            R = Convert.ToInt32(rknSplit[0]);
            K = Convert.ToInt32(rknSplit[1]);
            N = Convert.ToInt32(rknSplit[2]);
            Console.WriteLine("R değeri: " + R);
            Console.WriteLine("K değeri: " + K);
            Console.WriteLine("N değeri: " + N);
            Console.WriteLine();

            Console.WriteLine(N + " gruptaki kişi sayılarını arada boşluk bırakarak '1 4 2 1' yazınız.");
            string grupDeger = Console.ReadLine();
            string[] grupSplit = grupDeger.Split(' ');
            int[] intGrup = new int[N];
            for (int i = 0; i < intGrup.Length; i++)
            {
                intGrup[i] = Convert.ToInt32(grupSplit[i]);
            }
            Console.WriteLine();
            for (int tur = 0; tur < R; tur++)
            {
                grupSayisi = 0;
                int binenKisiSayisi = 0;
                binenGrupDegerleri = "";
                Console.Write(sira + ". Güncel Sıralama: ");
                for (int i = 0; i < N; i++)
                {
                    Console.Write("{0} ", intGrup[i]);
                }
                for (int i = 0; i < N; i++)
                {
                    if (binenKisiSayisi + intGrup[i] <= K)
                    {
                        binenKisiSayisi = binenKisiSayisi + intGrup[i];
                        toplamPara = toplamPara + intGrup[i];
                        grupSayisi++;
                    }
                    else
                    {
                        break;
                    }
                    binenGrupDegerleri += intGrup[i];
                    binenGrupDegerleri += " ";
                }
                for (int j = 0; j < grupSayisi; j++)
                {
                    for (int x = 0; x < N - 1; x++)
                    {
                        temp = intGrup[x];
                        intGrup[x] = intGrup[x + 1];
                        intGrup[x + 1] = temp;
                    }
                }
                repo.Add(binenKisiSayisi.ToString() + "-" + binenGrupDegerleri.ToString());

                Console.WriteLine("\nAtlı Karıncaya Binen Gruplar: " + binenGrupDegerleri);
                Console.WriteLine("Binen Kişi Sayisi: " + binenKisiSayisi);
                Console.WriteLine("Binen Grup Sayisi: " + grupSayisi);
                sira++;
                Console.WriteLine("\n-----------------------------------");
            }
            Console.Write("Son Sıralama: ");
            for (int i = 0; i < N; i++)
            {
                Console.Write("{0} ", intGrup[i]);
            }
            Console.WriteLine("\nToplam Kazanilan Para: " + toplamPara);
            
            Console.ReadLine();
        }
    }
}
