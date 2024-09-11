using System.Security.Cryptography.X509Certificates;

namespace OOP;

class Program
{
    static void Main(string[] args)
    {
        //Araştırma Ödevi: Nesne Yönelimli Programlama (OOP) Kavramları
        #region 1 Nesne Yönelimli Programlama (OOP) nedir?
            
            /* 
            * Bilgisayar Sistemlerinin daha iyi modellenmesi için bir düşünce biçimidir.
            * Bu konsept sadece yazılım ile ilgili değil, bütün bilgisayar sistemleri için geçerli.
            * Amaç; bütün bilgisayar sistemlerinin, birbirlerini etkilemeden modüler bir şekilde haberleşebilmesi.
            * API teknolojisi: farklı dillerde iki program birbirleriyle haberleşebiliyor.
            * Ana amaç mesajlaşmaktır. “Alan Key”
            * Mesajlaşmak: Bir kod parçasının, başka bir kod parçasına soru sorup cevap almasıdır.
            * Farklı görevleri olan birçok nesneyi bir arada, uyum içerisinde çalıştırmak istiyorsak, onları mesajlaştırabiliyor olmamız gerekir.

            * Nasıl: Fonksiyon. Kodumuza fonksiyonelini katmalıyız. Çünkü bir girdi alıp sonuç üreten en küçük mesajlaşma birimi fonksiyondur. Biz kodlarımızı bu fonksiyon içerisine ekleyerek başka kodların bizim kodlarımızı kullanmasına olanak sağlıyoruz. Bu sayede kodlarımız, istenilen yerden istenilen adette çağrılabilir.

            Nesne Yönelimli Programlama Kullanan Diller 
            Python, C++, Objective-C, Delphi, Smalltalk, Java, Swift, C#, Perl, Ruby, PHP
             */



        #endregion
        #region 2 Sınıf (Class) ve Nesne (Object) nedir?
            /* 
                Sınıf, daha soyut bir kavramdır. Nesne ise belirli bir türden nesnelerin ortak özelliklerini belirten bir kavramdır.
                *Örnek olarak İnsan sınıfı (class) oluşturdum. İnsan sınıfının altında ise iki farklı nesne (object) oluşturdum: insan1 ve insan2.
             */

            //Insan insan1 = new Insan();
            
            //insan1.cinsiyet = "Kadın";
            //insan1.yas = 30;
            //insan1.boy = 160;
            //insan1.kilo = 50;

            //Insan insan2 = new insan1();

            //insan2.cinsiyet = "Erkek";
            //insan2.yas = 32;
            //insan2.boy = 180;
            //insan2.kilo = 70;

            /* 
                *Her iki nesne de Insan sınıfının altında yer alır ve bunu kullanır.
             */
        #endregion
        #region 3 Encapsulation (Kapsülleme) nedir?
            
            /* 
                * Encapsulation bir nesnenin belirli özellik ve metotlarının erişiminin kısıtlanması ve saklanmasıdır. Bu kısıtlamalar kötü amaçlı kullanım ve istenmeyen veri girişlerini engeller. Elimizdeki değişkenlera, metodlara
                belirli kısıtlamalar koymak, belirli mekanizmalarla da bunlara erişim sağlamak.

                * Bazı durumlarda kullanıcı erişmesin, developer erişsin istenebilir.
                * Metodlar ile yapılır.

                -Public -Private -Protected -Internal
                -geter seter
             */

            /* private int telefonNo;
            private int tcKimlikNo;

            public void SetTelefonNo(int yeniTelefonNo)
            {
                telefonNo = yeniTelefonNo;
            }

            public int GetTelefonNo()
            {
                return telefonNo;
            } */

            // telefonNo ve tcKimlikNo Private olarak tanımlanmıştır. Dışarıdan erişim yapılamaz. Get ve Set metodlar aracılığı ile kontrollü erişim yapılabilir.

             

        #endregion
        #region 4 Inheritance (Kalıtım) nedir?

            /*
                * Bir class'ın başka bir class'tan özelliklerini ve metotlarını alması demektir.
                * Ortak özellikler ve davranışlar üst sınıfta tanımlanıp alt sınıfa miras olarak gidebilir.
                * Faydaları:
                * Inheritance kodun yeniden kullanılabilirliğini artırır ve sınıflar arasında hiyerarşik ilişkiler kurmayı sağlar.

                * Örneğin, Hayvan adında bir class’ımızın olduğunu düşünelim. Kedi de bir hayvan dolduğundan dolayı hayvanın temel özellikleri kedide de olacaktır. Fakat bu özellikler diğer hayvanlara göre farklılık gösterebilir. Örneğin, İnsan ve Kedi iki farklı hayvan türüdür, aynı temel özellikleri taşısada farklı özelliklere ve davranışlara sahip olabilir.


            */
            
            /* public class Araba
            {
                public string otomobil {get;set;}
                public void ilerle() //Ana sınıfın metodu
                {
                    Console.WriteLine("Araba ilerledi.");
                } 

            }

            public class Mercedes : Araba
            {
                public void hizliIlerle()
                {
                    Console.WriteLine($"{otomobil} hızlı ilerledi.");
                }
            } */

            
            
        #endregion
        #region 5 Polymorphism (Çok Biçimlilik) nedir?

            /* 
                * Static && Dynamic

                Static Polymorphism; birden fazla aynı isimde bir methodun farklı parametrelerle birden fazla method oluşturma anlamına gelir.

                Dynamic Polymorphism; türetilmiş classtaki özelliklerin ve methodun aynısına sahip olmasıdır.
             */
             //Method Overloading
            /*  public class Calculator 
             { public int Add(int a, int b) 
             { 
                return a + b; 
             } 
             public int Add(int a, int b, int c) 
             { 
                return a + b + c; 
             }

             public class Animal
            {
                public virtual void MakeSound()
                {
                    Console.WriteLine("The animal makes a sound");
                }
            } */
            
            //Method Overriding
            /* public class Cat : Animal
            {
                public override void MakeSound()
                {
                    Console.WriteLine("The dog barks");
                }
            }
            
            public class Human : Animal
            {
                public override void MakeSound()
                {
                    Console.WriteLine("The human says Hi!");
                } */
            
        #endregion
        #region 6 Abstraction (Soyutlama) nedir?

        /* 
            Abstraction (Soyutlama) detayları saklama ve sadece gösterilmesi istenen bilgileri kullanıcıya göstermek amacıyla kullanılır. Abstraction(Soyutlama) hem Abstract class(soyutlama sınıfları) ile hem de interfaces (arayüzler) ile yapılır.

            Abstract Class : Abstract class’lardan instance object (örnek nesne) oluşturulamaz. Abstract class’a ulaşmak için başka bir sınıftan kalıtım alınması gerekir.

            Abstract Method : Sadece abstract class içerisinde kullanılır. Metot içerisine herhangi birşey yazılmaz. Bir abstract class hem abstract metotlara hem de normal metotlara sahip olabilir.

            Farkları ise soyutlama, sistemin gereksiz detaylarını gizleyerek kullanıcıya basit bir arayüz sunarken, kapsülleme verilerin güvenliğini ve gizliliğini sağlamak için verilerin dışarıdan erişimini sınırlar.
         */
            
        #endregion
        #region 7 Constructor (Yapıcı Metot) nedir ve nasıl kullanılır?

        /* 
            Nesne yönelimli programlamada sınıf yapılarının nesne şeklinde tanımlanması için gerekli alt yapıyı hazırlayan metottur. Yapıcı metotlar, sınıflardan nesne oluşturulduğu sırada oluşan ve geriye dönüş tipi olmayan metotlardır.
         */
        
        /* 
            public class Araba
            {
                public Araba() // constructor metot
                {
                    Console.Writeline("Constructor metot.");
                }
            }

            Araba nesne = new Araba(); // "Constructor metot" yazılacaktır.
         */
         //this keyword'ü önemli. bir tane constructor tetiklenirken arkada zincir gibi birden fazla constructor tetiklensin isteniyorsa "this" keyword ü kullanılır. 
         //public Araba():this("Mercedes")
        #endregion
        #region 8 Interface ve Abstract Class nedir?
            /* 
                Interface (Arayüz) ve Abstract Class (Soyut Sınıf), C# dilinde soyutlama (abstraction) sağlamak için kullanılan iki önemli yapıdır. Her ikisi de sınıfların ortak bir arayüz sağlamasına yardımcı olur. Önemli farkları vardır.

             */

             /* 
                // Soyut sınıf tanımı
                public abstract class Hayvan
                {
                    public string Ad { get; set; }

                    // Soyut metot, alt sınıflarda geçersiz kılınmak zorunda
                    public abstract void SesCikar();

                    // Somut metot, alt sınıflarda kullanılır
                    public void Yuru()
                    {
                        Console.WriteLine("Hayvan yürüyor.");
                    }
                }

                // Soyut sınıfı genişleten sınıf
                public class Kedi : Hayvan
                {
                    public override void SesCikar()
                    {
                        Console.WriteLine("Kedi miyavladı.");
                    }
                }

                // Ana Program
                class Program
                {
                    static void Main(string[] args)
                    {
                        Hayvan kedi = new Kedi();
                        kedi.SesCikar();  // Çıktı: "Kedi miyavladı."
                        kedi.Yuru();      // Çıktı: "Hayvan yürüyor."
                    }
                

              */
        #endregion
    }
}
