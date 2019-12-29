using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication46
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("SALDIRMAK İÇİN ==> SALDIR");
            Console.WriteLine("MİLİTAN TOPLAMAK İÇİN ==> KIŞLA");
            Console.WriteLine("MARKET'E GİTMEK İÇİN ==> MARKET");
            Console.WriteLine("BÖLGENİ GÖRMEK İÇİN ==> BÖLGEM ");
            Console.WriteLine("BİNA KURMAK İÇİN ==> İNŞAET");
            Console.WriteLine("YARDIM İÇİN ==> YARDIM");
            Console.WriteLine("ENVANTERİ GÖRMEK İÇİN ==> ENVANTER");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("OYUNCU ADINIZI GİRİNİZ");
            string OYUNCU = Console.ReadLine();
            Console.Clear();
            string MARKET = "MARKET";
            string ELBAB = "ELBAB", HALEP = "HALEP", ŞAM = "ŞAM", HAMAS = "HAMAS", KÖYLER = "KÖYLER", KIŞLA = "KIŞLA", SALDIR = "SALDIR";
            int GÜN = 1, PARA = 10000, MİLİTAN = 10, AK47 = 10, MAGNUM = 0, TABANCA = 0, M4 = 0;
            int AK47GÜÇ = 2, TABANCAGÜÇ = 1, M4GÜÇ = 3, MAGNUMGÜÇ = 5;
            int ELBABBOT = 30000, HALEPBOT = 60000, ŞAMBOT = 20000, HAMASBOT = 40000;
            string ELBABSAHİP = "YPG", HALEPSAHİP = "ESAD", ŞAMSAHİP = "Ö.S.O", HAMASSAHİP = "ESAD";
            int AKFİYAT = 100, TABANCAFİYAT = 50, M4FİYAT = 200, MAGNUMFİYAT = 500;
            int GÜÇ = 7, ÖAŞ, ÖAEB, ÖAH, ÖAHL, ÖAK, ATŞ, ATEB, ATH, ATHL, EB, H, HL, S;
            int KAMP = 0, FABRİKA = 0;
            GÜÇ = MİLİTAN + AK47 * AK47GÜÇ + MAGNUM * MAGNUMGÜÇ + TABANCA * TABANCAGÜÇ + M4 * M4GÜÇ;
            Random r = new Random();
            while (MİLİTAN > 0 && PARA > 0)
            {
                S = r.Next(6000, 20000);
                EB = r.Next(200000, 500000);
                H = r.Next(100000, 175000);
                HL = r.Next(1000000, 2500000);
                ATH = r.Next(4, 12);
                ATHL = r.Next(3, 7);
                ATEB = r.Next(3, 10);
                ATŞ = r.Next(2, 7);
                ÖAŞ = r.Next(20, 50);
                ÖAK = r.Next(1, 7);
                ÖAEB = r.Next(300, 500);
                ÖAH = r.Next(500, 2000);
                ÖAHL = r.Next(2000, 4000);
                Console.Clear();
                GÜÇ = MİLİTAN + MAGNUM * MAGNUMGÜÇ + TABANCA * TABANCAGÜÇ + M4 * M4GÜÇ + AK47 * AK47GÜÇ;
                Console.WriteLine("*==================== IŞİD İMPARATORLUĞU ===================*");
                Console.WriteLine("*                                                           *");
                if (GÜÇ > ELBABBOT)
                {
                    Console.WriteLine("* EL-BAB ====>  {0}                                        *", ELBABSAHİP = OYUNCU, MİLİTAN = MİLİTAN + 25, PARA = PARA + 3000, ELBABBOT = 0, GÜÇ = GÜÇ + MİLİTAN);
                }
                else if (GÜÇ < ELBABBOT)
                {
                    Console.WriteLine("* EL-BAB ====>  {0}                                         *", ELBABSAHİP);
                }
                if (GÜÇ > HALEPBOT)
                {
                    Console.WriteLine("* HALEP  ====>  {0}                                        *", HALEPSAHİP = OYUNCU, MİLİTAN = MİLİTAN + 100, PARA = PARA + 5000, HALEPBOT = 0, GÜÇ = GÜÇ + MİLİTAN);
                }
                else if (GÜÇ < HALEPBOT)
                {
                    Console.WriteLine("* HALEP  ====>  {0}                                        *", HALEPSAHİP);
                }
                if (GÜÇ > ŞAMBOT)
                {
                    Console.WriteLine("* ŞAM    ====>  {0}                                        *", ŞAMSAHİP = OYUNCU, MİLİTAN = MİLİTAN + 10, PARA = PARA + 2000, ŞAMBOT = 0, GÜÇ = GÜÇ + MİLİTAN);
                }
                else if (GÜÇ < ŞAMBOT)
                {
                    Console.WriteLine("* ŞAM    ====>  {0}                                       *", ŞAMSAHİP);
                }
                if (GÜÇ > HAMASBOT)
                {
                    Console.WriteLine("* HAMAS  ====>  {0}                                        *", HAMASSAHİP = OYUNCU, MİLİTAN = MİLİTAN + 50, PARA = PARA + 4000, HAMASBOT = 0, GÜÇ = GÜÇ + MİLİTAN);
                }
                else if (GÜÇ < HAMASBOT)
                {
                    Console.WriteLine("* HAMAS  ====>  {0}                                        *", HAMASSAHİP);
                }
                Console.WriteLine("* KÖYLER ====>                                              *");
                Console.WriteLine("* ({0}.GÜN)  (PARA={1}$)  (MİLİTAN={2})  (GÜÇ={3})             *", GÜN, PARA, MİLİTAN, GÜÇ);
                Console.WriteLine("*************************************************************");
                string işlem1 = Console.ReadLine();
                if (işlem1 == KIŞLA)
                {
                    Console.WriteLine("* NEREYE ?                                                  *");
                    string işlem2 = Console.ReadLine();
                    if (işlem2 == ELBAB)
                    {
                        Console.Clear();
                        Console.WriteLine("MİLİTAN SAYINIZ ==> {0}'A YÜKSELDİ VE PARANIZ {1}'A DÜŞTÜ", MİLİTAN = MİLİTAN + ATEB, PARA = PARA - MİLİTAN * 2, GÜÇ = GÜÇ + MİLİTAN);
                        Console.WriteLine("{0}.GÜN BİTTİ", GÜN = GÜN + 1, MİLİTAN = MİLİTAN + KAMP * 2, AK47 = AK47 + FABRİKA * 3, PARA = PARA - MİLİTAN * 2);
                    }
                    else if (işlem2 == HALEP)
                    {
                        Console.Clear();
                        Console.WriteLine("MİLİTAN SAYINIZ ==> {0}'A YÜKSELDİ VE PARANIZ {1}'A DÜŞTÜ", MİLİTAN = MİLİTAN + ATHL, PARA = PARA - MİLİTAN * 2, GÜÇ = GÜÇ + MİLİTAN);
                        Console.WriteLine("{0}.GÜN BİTTİ", GÜN = GÜN + 1, MİLİTAN = MİLİTAN + KAMP * 2, AK47 = AK47 + FABRİKA * 3, PARA = PARA - MİLİTAN * 2);
                    }
                    else if (işlem2 == ŞAM)
                    {
                        Console.Clear();
                        Console.WriteLine("MİLİTAN SAYINIZ ==> {0}'A YÜKSELDİ VE PARANIZ {1}'A DÜŞTÜ", MİLİTAN = MİLİTAN + ATŞ, PARA = PARA - MİLİTAN * 2, GÜÇ = GÜÇ + MİLİTAN);
                        Console.WriteLine("{0}.GÜN BİTTİ", GÜN = GÜN + 1, MİLİTAN = MİLİTAN + KAMP * 2, AK47 = AK47 + FABRİKA * 3, PARA = PARA - MİLİTAN * 2);
                    }
                    else if (işlem2 == HAMAS)
                    {
                        Console.Clear();
                        Console.WriteLine("MİLİTAN SAYINIZ ==> {0}'A YÜKSELDİ VE PARANIZ {1}'A DÜŞTÜ", MİLİTAN = MİLİTAN + ATH, PARA = PARA - MİLİTAN * 2, GÜÇ = GÜÇ + MİLİTAN);
                        Console.WriteLine("{0}.GÜN BİTTİ", GÜN = GÜN + 1, MİLİTAN = MİLİTAN + KAMP * 2, AK47 = AK47 + FABRİKA * 3, PARA = PARA - MİLİTAN * 2);
                    }
                    else if (işlem2 == KÖYLER)
                    {
                        Console.Clear();
                        Console.WriteLine("KÖYLERDEN MİLİTAN TOPLAYAMASSINIZ", MİLİTAN = MİLİTAN + KAMP * 2, AK47 = AK47 + FABRİKA * 3);
                        Console.WriteLine("{0}.GÜN BİTTİ", GÜN = GÜN + 1, MİLİTAN = MİLİTAN + KAMP * 2, AK47 = AK47 + FABRİKA * 3, PARA = PARA - MİLİTAN * 2);
                    }
                    else
                    {
                        Console.WriteLine("BU BÖLGE ÇOK UZAKTA OLDUĞUNDAN ORDAN MİLİTAN ÇIKMAZ");
                    }
                }
                if (işlem1 == SALDIR)
                {
                    Console.WriteLine("* NEREYE ?                                                  *");
                    string işlem3 = Console.ReadLine();
                    if (işlem3 == ELBAB)
                    {
                        Console.Clear();
                        Console.WriteLine("{0} MİLİTAN HAKKIN RAHMETİNE KAVUŞTU VE PARANIZ {1}'E YÜKSELDİ", ÖAEB, PARA = PARA + EB, MİLİTAN = MİLİTAN - ÖAEB, PARA = PARA - MİLİTAN * 2);
                        Console.WriteLine("{0}.GÜN BİTTİ", GÜN = GÜN + 3, MİLİTAN = MİLİTAN + KAMP * 6, AK47 = AK47 + FABRİKA * 9);
                    }
                    else if (işlem3 == HALEP)
                    {
                        Console.Clear();
                        Console.WriteLine("{0} MİLİTAN HAKKIN RAHMETİNE KAVUŞTU VE PARANIZ {1}'E YÜKSELDİ", ÖAH, PARA = PARA + HL, MİLİTAN = MİLİTAN - ÖAHL, PARA = PARA - MİLİTAN * 2);
                        Console.WriteLine("{0}.GÜN BİTTİ", GÜN = GÜN + 17, MİLİTAN = MİLİTAN + KAMP * 34, AK47 = AK47 + FABRİKA * 51);
                    }
                    else if (işlem3 == ŞAM)
                    {
                        Console.Clear();
                        Console.WriteLine("{0} MİLİTAN HAKKIN RAHMETİNE KAVUŞTU VE PARANIZ {1}'E YÜKSELDİ", ÖAŞ, PARA = PARA + S, MİLİTAN = MİLİTAN - ÖAŞ, PARA = PARA - MİLİTAN * 2);
                        Console.WriteLine("{0}.GÜN BİTTİ", GÜN = GÜN + 2, MİLİTAN = MİLİTAN + KAMP * 4, AK47 = AK47 + FABRİKA * 6);
                    }
                    else if (işlem3 == HAMAS)
                    {
                        Console.Clear();
                        Console.WriteLine("{0} MİLİTAN HAKKIN RAHMETİNE KAVUŞTU VE PARANIZ {1}'E YÜKSELDİ", ÖAH, PARA = PARA + H, MİLİTAN = MİLİTAN - ÖAH, PARA = PARA - MİLİTAN * 2);
                        Console.WriteLine("{0}.GÜN BİTTİ", GÜN = GÜN + 5, MİLİTAN = MİLİTAN + KAMP * 10, AK47 = AK47 + FABRİKA * 15);
                    }
                    else if (işlem3 == KÖYLER)
                    {
                        Console.Clear();
                        Console.WriteLine("{0} MİLİTAN HAKKIN RAHMETİNE KAVUŞTU VE PARANIZ {1}'E YÜKSELDİ", ÖAK, PARA = PARA + 3000, MİLİTAN = MİLİTAN - ÖAK, PARA = PARA - MİLİTAN * 2);
                        Console.WriteLine("{0}.GÜN BİTTİ", GÜN = GÜN + 1, MİLİTAN = MİLİTAN + KAMP * 2, AK47 = AK47 + FABRİKA * 3);
                    }
                    else
                    {
                        Console.WriteLine("MİLİTANLAR YOLUNU KAYBETTİ VE GERİ DÖNMEK ZORUNDA KALDILAR"); ;
                    }

                }
                if (işlem1 == MARKET)
                {
                    Console.Clear();
                    Console.WriteLine("****************** MARKET *********************");
                    Console.WriteLine("*                                             *");
                    Console.WriteLine("*                                             *");
                    Console.WriteLine("* AK47 ====> 100$ || GÜÇ ====> 2              *");
                    Console.WriteLine("*-------------------------------------------- *");
                    Console.WriteLine("* DEAGLE ====>50$ || GÜÇ ====> 1              *");
                    Console.WriteLine("*-------------------------------------------- *");
                    Console.WriteLine("* M4-61 ====> 200$ || GÜÇ ====> 4             *");
                    Console.WriteLine("*-------------------------------------------- *");
                    Console.WriteLine("* MAGNUM SNİPER ====> 500$ || GÜÇ ====> 10    *");
                    Console.WriteLine("***********************************************");
                    string SATINAL = Console.ReadLine();
                    Console.WriteLine("* HANGİSİ                                     *");
                    int ADET = Int32.Parse(Console.ReadLine());
                    if (SATINAL == "AK47")
                    {
                        Console.Clear();
                        Console.WriteLine("{0} ADET AK47 ALINDI VE GÜCÜNÜZ {1} ARTTI", ADET, ADET * AK47GÜÇ, AK47 = AK47 + ADET, PARA = PARA - ADET * AKFİYAT, GÜÇ = GÜÇ + ADET * AK47GÜÇ);
                    }
                    else if (SATINAL == "DEAGLE")
                    {
                        Console.Clear();
                        Console.WriteLine("{0} ADET DEAGLE ALINDI VE GÜCÜNÜZ {1} ARTTI", ADET, ADET * TABANCAGÜÇ, TABANCA = TABANCA + ADET, PARA = PARA - ADET * TABANCAFİYAT, GÜÇ = GÜÇ + ADET * TABANCAGÜÇ);
                    }
                    else if (SATINAL == "M4")
                    {
                        Console.Clear();
                        Console.WriteLine("{0} ADET M4 ALINDI VE GÜCÜNÜZ {1} ARTTI", ADET, ADET * M4GÜÇ, M4 = M4 + ADET, PARA = PARA - ADET * M4FİYAT, GÜÇ = GÜÇ + ADET * M4GÜÇ);
                    }
                    else if (SATINAL == "MAGNUM")
                    {
                        Console.Clear();
                        Console.WriteLine("{0} ADET MAGNUM ALINDI VE GÜCÜNÜZ {1} ARTTI ", ADET, ADET * MAGNUMGÜÇ, MAGNUM = MAGNUM + ADET, PARA = PARA - ADET * MAGNUMFİYAT, GÜÇ = GÜÇ + ADET * MAGNUMGÜÇ);
                    }
                }
                if (işlem1 == "İNŞAET")
                {
                    Console.Clear();
                    Console.WriteLine("KAMP ==> GÜNLÜK 2 ASKER ÇIKIŞI");
                    Console.WriteLine("FABRİKA ==> GÜNLÜK 3 AK47 ÇIKIŞI");
                    Console.WriteLine("HANGİSİ ?                       ");
                    string işlem4 = Console.ReadLine();
                    Console.Clear();
                    if (işlem4 == "KAMP")
                    {
                        Console.WriteLine("{0}.GÜN VE KAMP İNŞAEDİLDİ", GÜN = GÜN + 7, KAMP = KAMP + 1, PARA = PARA - 6000, PARA = PARA - MİLİTAN * 14, MİLİTAN = MİLİTAN + KAMP * 14);
                    }
                    if (işlem4 == "FABRİKA")
                    {
                        Console.WriteLine("{0}.GÜN VE FABRİKA İNŞAEDİLDİ", GÜN = GÜN + 15, FABRİKA = FABRİKA + 1, PARA = PARA - 13000, PARA = PARA - MİLİTAN * 30, MİLİTAN = MİLİTAN + KAMP * 60);
                    }
                }
                if (işlem1 == "ENVANTER")
                {
                    Console.Clear();
                    Console.WriteLine("****************** ENVANTER *********************");
                    Console.WriteLine("*                                             *");
                    Console.WriteLine("*                                             *");
                    Console.WriteLine("* AK-47 ====> {0} || GÜÇ ====> {1}               *", AK47, AK47 * AK47GÜÇ);
                    Console.WriteLine("*-------------------------------------------- *");
                    Console.WriteLine("* DEAGLE ====>{0} || GÜÇ ====> {1}                *", TABANCA, TABANCA * TABANCAGÜÇ);
                    Console.WriteLine("*-------------------------------------------- *");
                    Console.WriteLine("* M4-61 ====> {0} || GÜÇ ====> {1}                *", M4, M4 * M4GÜÇ);
                    Console.WriteLine("*-------------------------------------------- *");
                    Console.WriteLine("* MAGNUM SNİPER ====> {0} || GÜÇ ====> {1}        *", MAGNUM, MAGNUM * MAGNUMGÜÇ);
                    Console.WriteLine("***********************************************");
                }
                if (işlem1 == "BÖLGEM")
                {
                    Console.Clear();
                    Console.WriteLine("****************** BÖLGEM *********************");
                    Console.WriteLine("*                                             *");
                    Console.WriteLine("*                                             *");
                    Console.WriteLine("* {0} TANE KAMP GÜNLÜK ASKER ÇIKIŞI ==> {1}       *", KAMP, KAMP * 2);
                    Console.WriteLine("*-------------------------------------------- *");
                    Console.WriteLine("* {0} TANE FABRİKAT GÜNLÜK SİLAH ÇIKIŞI ==> {1}   *", FABRİKA, FABRİKA * 3);
                    Console.WriteLine("***********************************************");
                }
                if (işlem1 == "YARDIM")
                {
                    Console.Clear();
                    Console.WriteLine("SALDIRMAK İÇİN ==> SALDIR");
                    Console.WriteLine("MİLİTAN TOPLAMAK İÇİN ==> KIŞLA");
                    Console.WriteLine("MARKET'E GİTMEK İÇİN ==> MARKET");
                    Console.WriteLine("BÖLGENİ GÖRMEK İÇİN ==> BÖLGEM ");
                    Console.WriteLine("BİNA KURMAK İÇİN ==> İNŞAET");
                    Console.WriteLine("ENVANTERİ GÖRMEK İÇİN ==> ENVANTER", GÜN = GÜN - 1, MİLİTAN = MİLİTAN - KAMP * 2, AK47 = AK47 - FABRİKA * 3, PARA = PARA + MİLİTAN * 2);
                }
                Console.ReadKey();
                Console.WriteLine("{0}.GÜN BİTTİ", GÜN = GÜN + 1, MİLİTAN = MİLİTAN + KAMP * 2, AK47 = AK47 + FABRİKA * 3, PARA = PARA - MİLİTAN * 2);
                S = r.Next(3000, 10000);
                EB = r.Next(5000, 13000);
                H = r.Next(80000, 150000);
                HL = r.Next(500000, 1500000);
                ATH = r.Next(4, 12);
                ATHL = r.Next(3, 7);
                ATEB = r.Next(3, 10);
                ATŞ = r.Next(2, 7);
                ÖAŞ = r.Next(20, 50);
                ÖAK = r.Next(1, 7);
                ÖAEB = r.Next(300, 1000);
                ÖAH = r.Next(500, 2000);
                ÖAHL = r.Next(2000, 4000);
            }
            if (MİLİTAN < 0)
            {
                Console.Clear();
                Console.WriteLine("SENDE HAKKIN RAHMETİNE KAVUŞTUN");
            }
            if (PARA < 0)
            {
                Console.Clear();
                Console.WriteLine("{0} BORCUNUZU ÖDEMEDİĞİNİZ İÇİN HACİZ GELDİ \n KALAŞNİKOFLARI TOPLADILAR", PARA);
            }
            Console.WriteLine("KAYBETTİNİZ");
            Console.WriteLine();
            Console.WriteLine("_______#########________________         §§§§§§§§_§§___§§_§§§§§§§_§§__§§");
            Console.WriteLine("_____############_______________         ___§§____§§___§§_§§___§§_§§_§§");
            Console.WriteLine("____##############______________         ___§§____§§___§§_§§§§§§§_§§§§");
            Console.WriteLine("___#######______###_____#________        ___§§____§§___§§_§§__§§__§§_§§");
            Console.WriteLine("___######________##_____##_______        ___§§____§§§§§§§_§§___§§_§§__§§");
            Console.WriteLine("___######_______________###______");
            Console.WriteLine("___#####_____________########____");
            Console.WriteLine("___#####___________#########_____");
            Console.WriteLine("___#####_______________######____");
            Console.WriteLine("___#####_______________#######____");
            Console.WriteLine("___######______________###___##__");
            Console.WriteLine("____######_______#_____##_________");
            Console.WriteLine("____#######____###________________");
            Console.WriteLine("_____############_______________");
            Console.WriteLine("______##########_________________");
            Console.WriteLine("________######____________________");
            Console.ReadKey();


        }
    }
}
