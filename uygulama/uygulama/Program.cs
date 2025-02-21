using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uygulama
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int devam = 0;
            do
            {
                 

            Console.WriteLine(" [1] Sayının Pozitif, Negatif veya Sıfır Olduğunu Belirleme");
            Console.WriteLine(" [2] Gün İsmi Belirleme");
            Console.WriteLine(" [3] Basit Hesap Makinesi");
            Console.WriteLine(" [4] Üç Sayının En Büyüğünü Bulma");
            Console.WriteLine(" [5] Şifre Güçlülüğünü Kontrol Etme");

            Console.WriteLine("Yapmak İstediğiniz İşlemi Giriniz \n");
            int islem;
            islem = Int32.Parse(Console.ReadLine())-1;
            switch (islem) { 
            
                case 0:
                    Console.WriteLine("Karşılaştırmak istediğiniz sayıyı giriniz : ");
                    int sayi=int.Parse(Console.ReadLine());
                    if (sayi==0)
                    {
                        Console.WriteLine("Sayı 0'a eşittir \n");
                    }
                    else if(sayi>=0)
                    {
                        Console.WriteLine("Sayı pozitiftir \n");
                    }
                    else
                    {
                        Console.WriteLine("Sayı negatiftir");
                    }
                        Console.WriteLine("Başka işlem yapmak istiyor musunuz? (1 = Evet, Başka tuş = Hayır)");
                        devam = int.Parse(Console.ReadLine());
                break;

                case 1:
                    Console.WriteLine("Öğrenmek istediğiniz gün sayısını giriniz : (% alınmıştır)");
                    int gunSayisi=(int.Parse(Console.ReadLine())-1)%7;
                    switch (gunSayisi)
                    {
                        case 0:
                            Console.WriteLine("Pazartesi");
                        break;
                        case 1:
                            Console.WriteLine("Salı");
                        break;

                        case 2:
                            Console.WriteLine("Çarşamba");
                            break;
                        case 3:
                            Console.WriteLine("Perşembe");
                            break;
                        case 4:
                            Console.WriteLine("Cuma");
                            break;
                        case 5:
                            Console.WriteLine("Cumartesi");
                            break;
                        case 6:
                            Console.WriteLine("Pazar");
                            break;            
                        default:
                            Console.WriteLine("Hatalı Giriş");
                            break;
                    }
                        Console.WriteLine("Başka işlem yapmak istiyor musunuz? (1 = Evet, Başka tuş = Hayır)");
                        devam = int.Parse(Console.ReadLine());
                        break;

                case 2:
                    Console.WriteLine(" [1] Toplama");
                    Console.WriteLine(" [2] Çıkarma");
                    Console.WriteLine(" [3] Çarpma");
                    Console.WriteLine(" [4] Bölme");
                    Console.WriteLine(" [5] Mod Alma");
                    Console.WriteLine(" Yapmak istediğiniz işlemi giriniz");

                    int islem2 = int.Parse(Console.ReadLine()) - 1;

                    switch (islem2)
                    {
                        case 0:
                            Console.WriteLine("Toplanacak Sayıları giriniz");
                            Console.Write("1. sayı : ");
                            int sayi1 = int.Parse(Console.ReadLine());
                            Console.Write("2. sayı : ");
                            int sayi2 = int.Parse(Console.ReadLine());
                            int sonuc1 = sayi1 + sayi2;
                            Console.WriteLine($"Toplama İşleminin Sonucu: {sonuc1}");
                            break;

                        case 1:
                            Console.WriteLine("Çıkarılacak Sayıları giriniz");
                            Console.Write("1. sayı : ");
                            int sayi3 = int.Parse(Console.ReadLine());
                            Console.Write("2. sayı : ");
                            int sayi4 = int.Parse(Console.ReadLine());
                            int sonuc2 = sayi3 - sayi4;
                            Console.WriteLine($"Çıkarma İşleminin Sonucu: {sonuc2}");
                            break;

                        case 2:
                            Console.WriteLine("Çarpılacak Sayıları giriniz");
                            Console.Write("1. sayı : ");
                            int sayi5 = int.Parse(Console.ReadLine());
                            Console.Write("2. sayı : ");
                            int sayi6 = int.Parse(Console.ReadLine());
                            int sonuc3 = sayi5 * sayi6;
                            Console.WriteLine($"Çarpma İşleminin Sonucu: {sonuc3}");
                            break;

                        case 3:
                            Console.WriteLine("Bölünecek Sayıları giriniz");
                            Console.Write("1. sayı : ");
                            int sayi7 = int.Parse(Console.ReadLine());
                            Console.Write("2. sayı : ");
                            int sayi8 = int.Parse(Console.ReadLine());

                            if (sayi8 == 0)
                                Console.WriteLine("Hata: Bir sayı sıfıra bölünemez!");
                            else
                            {
                                int sonuc4 = sayi7 / sayi8;
                                Console.WriteLine($"Bölme İşleminin Sonucu: {sonuc4}");
                            }
                            break;

                        case 4:
                            Console.WriteLine("Mod Alınacak Sayıları giriniz");
                            Console.Write("1. sayı : ");
                            int sayi9 = int.Parse(Console.ReadLine());
                            Console.Write("2. sayı : ");
                            int sayi10 = int.Parse(Console.ReadLine());

                            if (sayi10 == 0)
                                Console.WriteLine("Hata: Mod işlemi için bölen sıfır olamaz!");
                            else
                            {
                                int sonuc5 = sayi9 % sayi10;
                                Console.WriteLine($"Mod Alma İşleminin Sonucu: {sonuc5}");
                            }
                            break;

                        default:
                            Console.WriteLine("Geçersiz işlem seçildi.");
                            break;
                    }
                        Console.WriteLine("Başka işlem yapmak istiyor musunuz? (1 = Evet, Başka tuş = Hayır)");
                        devam = int.Parse(Console.ReadLine());
                        break;
                
                case 3:
                        Console.Write("1. sayı : ");
                        int sayi11 = int.Parse(Console.ReadLine());
                        Console.Write("2. sayı : ");
                        int sayi12 = int.Parse(Console.ReadLine());
                        Console.Write("3. sayı : ");
                        int sayi13 = int.Parse(Console.ReadLine());

                        if (sayi11 > sayi12 && sayi11 > sayi13)
                        {
                            Console.WriteLine("1. sayı en büyüktür");
                        }
                        else if (sayi12 > sayi11 && sayi12 > sayi13) 
                        {
                            Console.WriteLine("2. sayı en büyüktür");
                        }
                        else if (sayi13 > sayi11 && sayi13 > sayi12)
                        {
                            Console.WriteLine("3. sayı en büyüktür");
                        }
                        else
                        {
                            Console.WriteLine("Bazı sayılar eşit.");
                        }

                        Console.WriteLine("Başka işlem yapmak istiyor musunuz? (1 = Evet, Başka tuş = Hayır)");
                        devam = int.Parse(Console.ReadLine());
                        break;

                    case 4:
                    Console.Write("Şifrenizi girin: ");
                    string sifre = Console.ReadLine();

                    if (sifre.Length < 8)
                    {
                        Console.WriteLine("Şifre zayıf: En az 8 karakter olmalı!");
                    }
                    else if (!BuyukHarfVarMi(sifre))
                    {
                        Console.WriteLine("Şifre orta seviye: En az bir büyük harf içermeli!");
                    }
                    else if (!OzelKarakterVarMi(sifre))
                    {
                        Console.WriteLine("Şifre güçlü değil: En az bir özel karakter (@, #, $, %) içermeli!");
                    }
                    else
                    {
                        Console.WriteLine("Şifre güçlü!");
                    }
                        Console.WriteLine("Başka işlem yapmak istiyor musunuz? (1 = Evet, Başka tuş = Hayır)");
                        devam = int.Parse(Console.ReadLine());
                        break;
                default:
                    Console.WriteLine("Geçersiz İşlem Yapıldı");
                break;
            }
            bool BuyukHarfVarMi(string metin)
            {
                foreach (char karakter in metin)
                {
                    if (char.IsUpper(karakter))
                        return true;
                }
                return false;
            }

            bool OzelKarakterVarMi(string metin)
            {
                string ozelKarakterler = "@#$%";
                foreach (char karakter in metin)
                {
                    if (ozelKarakterler.Contains(karakter))
                        return true;
                }
                return false;
            }

            } while (devam==1);
        }
    }
}
