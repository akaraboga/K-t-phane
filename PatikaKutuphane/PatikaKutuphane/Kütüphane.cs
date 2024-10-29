using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatikaKutuphane
{
    internal class Kütüphane
    {
        public string Ad  { get; set; } //Propertylerimizi giriyioruz

        public string Soyad { get; set; }
        public string Kitapadı { get; set; }
        public int Sayfasayisi { get; set; }

        public string Yayınevi { get; set; }

        public DateTime Tarih { get; set; }

        public Kütüphane()//Parametre almayan Constructora Tarih Propertymizi   atıyoruz.
        {
            Tarih = DateTime.Now;
        }

        public Kütüphane(string _Ad,string _Soyad,string _Kitapadı,int _Sayfasayisi,string _Yayınevi)//Burdada parametre alan Constructor var.içine Propertylerimizin değişken turunde değişken giriyoruz
        {
            Ad= _Ad; //Değişkenlere gelecek olan değerleri propertylerimize atıyoruz.
            Soyad= _Soyad;
            Sayfasayisi= _Sayfasayisi;
            Yayınevi = _Yayınevi;
            Tarih = DateTime.Now;
            Kitapadı=_Kitapadı;

        }

        public void bilgi()//Kitapların bilgisini tutan metod.
        {
            Console.WriteLine($" yazar Ad Soyad : {Ad} {Soyad} \n Kitabın adı : {Kitapadı}\n Kitabın Sayfa sayisi :{Sayfasayisi} \n Kitabın yayınevi : {Yayınevi} \n Kayıt tarihi : {Tarih}  " );
        }

        //Class nedir? :classlar nesne tabanlı programlamada verileri daha düzenli hale getirip kod okunurluğunu artırmak için kullanılan nesnelerdir.

        //Property :Propertyler public ve private gibi erişim belirleyicileri alan değişkenlerdir.bunlarla degeri get(değer dondurmek),set(değer atama) işlemlerini yapabiliriz. 

        //new : new anahtar sozcuğu ile classlardan veri alabiliriz.orn; Kütüphane kitap = new kütüphane de kitap objesine kütüphanedeki ozelliklere erişim yapmamızı sağlayabiliriz. 

        // Constructor : constructor class ın içinde classla aynı adı taşıyan yapıcı metodlardır.class ın propertylerine değer atamamızı sağlar.

    }
}
