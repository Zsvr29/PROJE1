using System;

namespace PROJEM1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("STAJ PROGRAMI UYGULAMASINA HOSGELDINIZ");
            string ad, soyad,okulad, bolum,kategori;
            string TC;
           
            Console.WriteLine(" Adınızı Gırınız:");
            ad = Console.ReadLine();
            
            Console.WriteLine(" Soyadınızı Gırınız:");
            soyad = Console.ReadLine();

            Console.WriteLine(" TC nızı Gırınız:");
            TC = Console.ReadLine();

            Console.WriteLine(" Okulunuzun Ismını  Gırınız:");
            okulad = Console.ReadLine();

            Console.WriteLine("Bolumunuzu Gırınız:");
            bolum = Console.ReadLine();

            if (bolum=="Bilgisayar Mühendisliği")
            {
                Console.BackgroundColor = ConsoleColor.DarkBlue;
                Console.Clear();
                Console.WriteLine("Bilgisayar Muhendıslıgı Staj Programına Hosgeldınız:");
                Console.WriteLine("Lutfen Asagıdakılerden sıze uygun olan kategoriyi secınız:");
                Console.WriteLine();
                Console.WriteLine("KATEGORİ: A-Bilgi İşlem B-Web Tasarım C- E-Ticaret D-Oyun Konsolu");
                kategori = Console.ReadLine();
                if  (kategori == "A")
                {
                    Console.WriteLine("Bilgi İşlem Kategorısını Sectınız.");
                    Console.WriteLine(" Adınızı Gırınız:");
                    ad = Console.ReadLine();

                    Console.WriteLine(" Soyadınızı Gırınız:");
                    soyad = Console.ReadLine();

                    Console.WriteLine(" TC nızı Gırınız:");
                    TC = Console.ReadLine();
                    Console.WriteLine("Tebrikler Kaydınız Basarılı Bır Sekılde Alınmıstır.");

                }
                
                 else  if (kategori=="B")
                {
                    Console.WriteLine("Web Tasarım Kategorisini sectınız.");
                    Console.WriteLine(" Adınızı Gırınız:");
                    ad = Console.ReadLine();

                    Console.WriteLine(" Soyadınızı Gırınız:");
                    soyad = Console.ReadLine();

                    Console.WriteLine(" TC nızı Gırınız:");
                    TC = Console.ReadLine();
                    Console.WriteLine("Tebrikler Kaydınız Basarılı Bır Sekılde Alınmıstır.");

                }
                else if (kategori == "C")
                {
                    Console.WriteLine("E-Ticaret Kategorisini sectınız.");
                    Console.WriteLine(" Adınızı Gırınız:");
                    ad = Console.ReadLine();

                    Console.WriteLine(" Soyadınızı Gırınız:");
                    soyad = Console.ReadLine();

                    Console.WriteLine(" TC nızı Gırınız:");
                    TC = Console.ReadLine();
                    Console.WriteLine("Tebrikler Kaydınız Basarılı Bır Sekılde Alınmıstır.");

                }
                else if (kategori == "D")
                {
                    Console.WriteLine("Oyun Konsolu Kategorisini sectınız.");
                    Console.WriteLine(" Adınızı Gırınız:");
                    ad = Console.ReadLine();

                    Console.WriteLine(" Soyadınızı Gırınız:");
                    soyad = Console.ReadLine();

                    Console.WriteLine(" TC nızı Gırınız:");
                    TC = Console.ReadLine();
                    Console.WriteLine("Tebrikler Kaydınız Basarılı Bır Sekılde Alınmıstır.");


                }

            }
             else  if (bolum=="Matematik Öğretmenliği")
            {
                Console.BackgroundColor = ConsoleColor.DarkGreen;
                Console.Clear();
                Console.Write("Matematik Ögretmenliği Staj Programına Hosgeldınız:");
                Console.WriteLine("Lutfen Asagıdakılerden sıze uygun olan kategorıyı  secınız:");
                Console.WriteLine();
                Console.WriteLine("KATEGORİ: A-İlkögretim Matematik B-Lise Matematik C-Orta Ogretım Matematık D-İleri Düzey Matematık");
                kategori = Console.ReadLine();

                 if (kategori=="A")
                {
                    Console.WriteLine("İlkögretim Matematik Kategorisini sectınız.");
                    Console.WriteLine(" Adınızı Gırınız:");
                    ad = Console.ReadLine();

                    Console.WriteLine(" Soyadınızı Gırınız:");
                    soyad = Console.ReadLine();

                    Console.WriteLine(" TC nızı Gırınız:");
                    TC = Console.ReadLine();
                    Console.WriteLine("Tebrikler Kaydınız Basarılı Bır Sekılde Alınmıstır.");


                }
                else if (kategori=="B")
                {
                    Console.WriteLine("Lise Matematik Kategorisini sectınız.");
                    Console.WriteLine(" Adınızı Gırınız:");
                    ad = Console.ReadLine();

                    Console.WriteLine(" Soyadınızı Gırınız:");
                    soyad = Console.ReadLine();

                    Console.WriteLine(" TC nızı Gırınız:");
                    TC = Console.ReadLine();
                    Console.WriteLine("Tebrikler Kaydınız Basarılı Bır Sekılde Alınmıstır.");


                }
                else if (kategori=="C")
                {
                    Console.WriteLine("-Orta Ogretım Matematık Kategorisini sectınız.");
                    Console.WriteLine(" Adınızı Gırınız:");
                    ad = Console.ReadLine();

                    Console.WriteLine(" Soyadınızı Gırınız:");
                    soyad = Console.ReadLine();

                    Console.WriteLine(" TC nızı Gırınız:");
                    TC = Console.ReadLine();
                    Console.WriteLine("Tebrikler Kaydınız Basarılı Bır Sekılde Alınmıstır.");


                }
                else if (kategori=="D")
                {
                    Console.WriteLine("-İleri Düzey Matematık Kategorisini sectınız.");
                    Console.WriteLine(" Adınızı Gırınız:");
                    ad = Console.ReadLine();

                    Console.WriteLine(" Soyadınızı Gırınız:");
                    soyad = Console.ReadLine();

                    Console.WriteLine(" TC nızı Gırınız:");
                    TC = Console.ReadLine();
                    Console.WriteLine("Tebrikler Kaydınız Basarılı Bır Sekılde Alınmıstır.");

                }
            }

            else if (bolum=="Elektrik Elektronik Mühendisliği")
            {
                Console.BackgroundColor = ConsoleColor.DarkMagenta;
                Console.Clear();
                Console.WriteLine("Elektrik Elektronik Mühendisliği  Staj Programına Hosgeldınız:");
                Console.WriteLine("Lutfen Asagıdakılerden sıze uygun olan kategorıyı secınız:");
                Console.WriteLine();
              Console.WriteLine("KATEGORİ: A-Enerji Dağıtımı B-Endüstriyel Elektronik  C-Sayısal Elektronik D-Nümerik Analiz");
               kategori = Console.ReadLine();
                if (kategori=="A")
                {
                        Console.WriteLine("Enerji Dagıtımı Kategorisini sectınız.");
                    Console.WriteLine(" Adınızı Gırınız:");
                    ad = Console.ReadLine();

                    Console.WriteLine(" Soyadınızı Gırınız:");
                    soyad = Console.ReadLine();

                    Console.WriteLine(" TC nızı Gırınız:");
                    TC = Console.ReadLine();
                    Console.WriteLine("Tebrikler Kaydınız Basarılı Bır Sekılde Alınmıstır.");


                }
                else if (kategori == "B")
                {
                    Console.WriteLine("Endüstriyel Elektronik  Kategorisini sectınız.");
                    Console.WriteLine(" Adınızı Gırınız:");
                    ad = Console.ReadLine();

                    Console.WriteLine(" Soyadınızı Gırınız:");
                    soyad = Console.ReadLine();

                    Console.WriteLine(" TC nızı Gırınız:");
                    TC = Console.ReadLine();
                    Console.WriteLine("Tebrikler Kaydınız Basarılı Bır Sekılde Alınmıstır.");


                }
                else  if (kategori == "C")
                {
                    Console.WriteLine("Sayısal Elektronik Kategorisini sectınız.");
                    Console.WriteLine(" Adınızı Gırınız:");
                    ad = Console.ReadLine();

                    Console.WriteLine(" Soyadınızı Gırınız:");
                    soyad = Console.ReadLine();

                    Console.WriteLine(" TC nızı Gırınız:");
                    TC = Console.ReadLine();
                    Console.WriteLine("Tebrikler Kaydınız Basarılı Bır Sekılde Alınmıstır.");


                }
                else  if (kategori == "D")
                {
                    Console.WriteLine("Nümerik Analiz Kategorisini sectınız.");
                    Console.WriteLine(" Adınızı Gırınız:");
                    ad = Console.ReadLine();

                    Console.WriteLine(" Soyadınızı Gırınız:");
                    soyad = Console.ReadLine();

                    Console.WriteLine(" TC nızı Gırınız:");
                    TC = Console.ReadLine();
                    Console.WriteLine("Tebrikler Kaydınız Basarılı Bır Sekılde Alınmıstır.");

                }

            }
            else if (bolum=="Makina Mühendisliği")
            {
                Console.BackgroundColor = ConsoleColor.DarkYellow;
                Console.Clear();
                Console.WriteLine("Makine Mühendisliği  Staj Programına Hosgeldınız:");
                Console.WriteLine("Lutfen Asagıdakılerden sıze uygun olan kategorıyı  secınız:");
                Console.WriteLine();
                Console.WriteLine("KATEGORİ: A-Bilgisayar Destekli Çizim B-Termodinamik C-İmal Usulleri D-Mekanizmalar");
                kategori = Console.ReadLine();
                if (kategori == "A")
                {
                    Console.WriteLine("Bilgisayar DestekLİ Çizim Kategorısını sectınız.");
                    Console.WriteLine(" Adınızı Gırınız:");
                    ad = Console.ReadLine();


                    Console.WriteLine(" Soyadınızı Gırınız:");
                    soyad = Console.ReadLine();

                    Console.WriteLine(" TC nızı Gırınız:");
                    TC = Console.ReadLine();
                    Console.WriteLine("Tebrikler Kaydınız Basarılı Bır Sekılde Alınmıstır.");

                }

                else if (kategori == "B")
                {
                    Console.WriteLine("Termodinamik  Kategorisini sectınız.");
                    Console.WriteLine(" Adınızı Gırınız:");
                    ad = Console.ReadLine();

                    Console.WriteLine(" Soyadınızı Gırınız:");
                    soyad = Console.ReadLine();

                    Console.WriteLine(" TC nızı Gırınız:");
                    TC = Console.ReadLine();
                    Console.WriteLine("Tebrikler Kaydınız Basarılı Bır Sekılde Alınmıstır.");


                }
                else if (kategori == "C")
                {
                    Console.WriteLine("İmal Usulleri Kategorisini sectınız.");
                    Console.WriteLine(" Adınızı Gırınız:");
                    ad = Console.ReadLine();

                    Console.WriteLine(" Soyadınızı Gırınız:");
                    soyad = Console.ReadLine();

                    Console.WriteLine(" TC nızı Gırınız:");
                    TC = Console.ReadLine();
                    Console.WriteLine("Tebrikler Kaydınız Basarılı Bır Sekılde Alınmıstır.");


                }
                else if (kategori == "D")
                {
                    Console.WriteLine("Mekanizmzlar Kategorisini sectınız.");
                    Console.WriteLine(" Adınızı Gırınız:");
                    ad = Console.ReadLine();

                    Console.WriteLine(" Soyadınızı Gırınız:");
                    soyad = Console.ReadLine();

                    Console.WriteLine(" TC nızı Gırınız:");
                    TC = Console.ReadLine();
                    Console.WriteLine("Tebrikler Kaydınız Basarılı Bır Sekılde Alınmıstır.");

                }
            }
            else
            {
                Console.BackgroundColor = ConsoleColor.DarkRed;
                Console.Clear();
                Console.WriteLine(" Girdiniz Bolum Hakkında Staj Programı Bulunmamaktadır.");
            }
            Console.ReadLine();
        }
    }
}
