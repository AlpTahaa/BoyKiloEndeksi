using System.ComponentModel.Design;

internal class Program
{

    
    public static void Main(string[] args)
    {

        Console.WriteLine("Vücut Kitle Endeksine Hoş Geldiniz");
        Console.WriteLine("Kilonuzu Giriniz?");
        int kilo = Convert.ToInt32(Console.ReadLine());
       
        Console.WriteLine("Boyunuzu Giriniz(metre cinsinden)?");
        double boy = Convert.ToDouble(Console.ReadLine());
       
        double kilo_boy =( kilo / (boy * boy) );
        Console.WriteLine("Vücut Kitle Endeksiniz: " + kilo_boy);
         

        if (kilo_boy < 18.49 )
        {
            Console.WriteLine("İdeal Kilonun altında");
        }
        else if (kilo_boy > 18.5 && kilo_boy < 24.99 )
        {
            Console.WriteLine("İdeal Kilo");
        }
        else if (kilo_boy > 25 && kilo_boy < 29.99)
        {
            Console.WriteLine("İdeal Kilonun üzeri");
        }
        else {
            Console.WriteLine("İdeal Kilonun Çok Üzeri");
        }












        Console.ReadLine();

































    }

    private static string ConsoleReadline() => Console.ReadLine();
}  