

/* 1: Değişken,  metot, sınıf isimleri verirken anlaşılır isimler verin.
 ÖRNEK: int x yerine int girilenSayi gbi..
   2: Değişken,  metot, sınıf isimlendirmesi yaparken camelCaseing/PascalCasing notasyonuna dikkat edelim. değişkenler camelCasing, sınıf metot propertyler PascalCaseing
   
   3:Düzen biçimlendirilmesine dikkat edelim. ctrl+k+d
   4: Eğer bir değişkene başlangıç değeri vereceksek tanımladığımız yerde yapalım. Aynı tipteki değikenleri yan yana, virgüllerle ayıraral yazabliriz.
 Örnek: int sayi=0,sayac=1; 
    5: Gerekli yerlere abartılı olmayack şekilde yorum satırı ekleyebilirm.Bu yorum satırları metotlarda summary satırı olabilir. ///
    6: Kodlarınızı yeniden kullanılabilir olarak yazınız. Metotlar sınıflar..
    7:Karar yapılarında veya metotlarda kullanılacak olan değeerler sabit ise, bu değerleri ilgili yapının tanımlandığı yerde yazınız.
örnek: if(kullanicininYetkisi=="Müdür") yerine
string mudurYetkisi="Müdür";
if(kullaniciYetkisi==mudurYetkisi) şeklinde yazılır.
    8: Metot zincirlemeyi kullanın
örnek: Gelen metni küçük harf turkçe olmadan boşluksuz olarak ele alalım
    9: Kullanılabilen yerlerde karar yapısı olarak Ternary If kullanabiliriz.
   10: Uzun kod bloklarında region ifadesi kullanın. ctrl + k+s
   11: Hata yakalamak için Try Catch kullanabilir ve istisnaları özellesştirebiliriz.






 */


int sayi, sayac = 0, maksimumSayi = 0, ciftMaksimumSayi = 0;

bool sayiMi = KullanicidanSayiAi(out sayi);
if(sayiMi&& sayi>=0 && sayi!=1)
{
    DegerleriBul(out ciftMaksimumSayi, out maksimumSayi, out sayac);
    DegerleriEkranaYaz(maksimumSayi, ciftMaksimumSayi, sayac);
}

void DegerleriEkranaYaz(int maksimumSayi, int ciftMaksimumSayi, int sayac)
{
    Console.WriteLine("Bu işlem sırasında ulaşılan maksimum sayı: {0}", maksimumSayi);
    Console.WriteLine("Bu işlem sırasında sürekli çift olarak 1'e ulaşılan sayı{0}", ciftMaksimumSayi);
    Console.WriteLine("İşlem bitene kadarki adım sayısı{0}", sayac);
}


void DegerleriBul(out int ciftMaksimumSayi, out int maksimumSayi, out int sayac)
{
    ciftMaksimumSayi = maksimumSayi = sayac = 0;
    while (sayi >= 2)
    {
        sayac++;
        if(sayi%2==1)
        {
            sayi = sayi * 3 + 1;
            sayac++;
            ciftMaksimumSayi = 0;
        }
        ciftMaksimumSayi = ciftMaksimumSayi < sayi ? sayi : ciftMaksimumSayi;
        maksimumSayi=maksimumSayi<sayi ? sayi : maksimumSayi;
        sayi /= 2;
    }
}

/// <summary>
/// Kullanıcıdan değer alıp, değeri int değerine dönüştürmeyi dener
/// <summary>
/// <param name="sayi">int türünde bir sayı girin</param>

static bool  KullanicidanSayiAi(out int sayi)
{

    Console.WriteLine("Lütfen pozitif bir tam sayı girin");
    return int.TryParse(Console.ReadLine(), out sayi);

}
