using System.Xml.Linq;

namespace ConsoleApp7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pult pult = new Pult();
            pult.Narxi = 1234;
            pult.IshlabChiqaruvchi = "uzb";
            pult.IshlashQuvvati = 220;
            pult.Yoqish();
            pult.KalanAlmashtirish();
            pult.OvozUzgartirish(-21);
            pult.Uchirildi();
            Console.WriteLine();

            Ishchi ishchi = new Ishchi();
            ishchi.IshlashVaqti(12);
            ishchi.OylikMaosh(12_000_000);
            ishchi.fuqoroligi = "Uz";
            ishchi.UchaOlishi = true;
            ishchi.Name = "Jeck";
            ishchi.DisplayInfo();
            //display infoga hamma malumotni kiritmadim
            //ucha olishi yoki yuqligi kiritildi

        }
    }
    abstract class Mahsulot
    {
        public decimal Narxi;
        public string IshlabChiqaruvchi;
    }
    abstract class Elektronika : Mahsulot
    {
        public string Modeli;
        public double IshlashQuvvati;

    }
    interface Textnika
    {
        public void Yoqish();

        public void Uchirildi();

        public void Remond();
        
        
    }
    class Pult : Elektronika, Textnika
    {
        public void KalanAlmashtirish()
        {
            Console.WriteLine("Kanal almashtirildi....");
        }
        public void OvozUzgartirish(int num)
        {
            if (num > 0)
            {
                Console.WriteLine("Ovoz kutarildi...");
            }
            else if(num < 0)
            {
                Console.WriteLine("Ovoz pasaytirildi...");
            }
            else
            {
                Console.WriteLine("Ovoz uzgarmasdan qoldi...");
            }
        }
        public void Yoqish()
        {
            Console.WriteLine("Yoqildi....");
        }
        public void Uchirildi()
        {
            Console.WriteLine("Uchirildi ...");
        }
        public void Remond()
        {
            Console.WriteLine("Remond xolatida...");
        }
    }
    ////////////////////////////////////////////
    abstract class Jonzod
    {
        public string Name { get; set; }
        public bool UchaOlishi { get; set; }
        public void DisplayInfo()
        {
            Console.WriteLine($"{Name} ucha olishi {UchaOlishi} ");
        }
    }

    class Ishchi : Odam
    {

        public decimal Oylik = 0;
        public int IshlashVaqti(int vaqt)
        {
            return vaqt;
        }
        public decimal OylikMaosh(decimal oylik)
        {
            if(oylik > 0)
            {
                Oylik += oylik;
                return Oylik;
            }
            else
            {
                return Oylik;
            }
        } 
    }
    abstract class Odam:Jonzod
    {
        
        public string lastName;
        public string fuqoroligi;
        public bool UchaOlishi { get; set; }
    }
    class Animal:Jonzod
    {
        public bool UchaOlishi { get; set; }

        public void Ovqatlanmoq()
        {
            Console.WriteLine($"{Name} Ovqatlanmoqda..");
        }
        public void Uxlamoqda()
        {
            Console.WriteLine($"{Name} Uxlamoqda..");
        }
        public void Sayrqilmoqda()
        {
            Console.WriteLine($"{Name} Sayrqilmoqda..");
        }
    }
    
}