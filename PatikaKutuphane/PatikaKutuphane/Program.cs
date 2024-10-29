using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatikaKutuphane
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Kütüphanemizde bulunan kitaplar.\n");
 
 
            Kütüphane kitap = new Kütüphane("Aziz","Nesin","Zübük",180,"Epsilon");//Kütüphane classın dan kitap objesi olusturarak kütüphane clasında ki verilere new anahtarı ile erişeceğiz. 
            kitap.bilgi();//Kitap objesine bilgi metodunu çağırtarak kitabın bilgilerini ekrana yazdırıyoruz.
            Console.WriteLine();

            Kütüphane Kitap2 = new Kütüphane("Ayşe","Kulin","Adı aylin", 255, "Remzi Kitabevi");
            Kitap2.bilgi();

            Console.WriteLine();

        
            Kütüphane Kitap3=new Kütüphane("Elif","Şafak","İskender",530,"Doğan kitap");
            Kitap3.bilgi(); 

           

            Console.ReadLine();


        }
    }
}
