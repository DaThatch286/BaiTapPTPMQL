using System;
namespace ToanTu
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap vao so thu nhat : ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Nhap vao so thu hai : ");
            int b = int.Parse(Console.ReadLine());   
            if(a < b ){
                Console.Write(a + " nho hon " + b);
            }if(a > b){
                Console.Write(a + " lon hon " + b);
            }
        }
    }
}
