using System;
namespace ToanTuSoHoc
{
    class ToanTu
    {
        static void Main(string[] args)
        {
            Console.Write("nhap vao so thu nhat : ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("nhap vao so thu hai : ");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Ket qua hieu cua hai so la " + (a - b));
            if (a < b){
                Console.WriteLine("Ket qua chia lay nguyen la : " + a + "/" + b);
            }if (a > b){
                Console.WriteLine("Ket qua chia lay nguyen la : " + (a / b));
            }
            Console.WriteLine("Ket qua chia lay du la : " + (a % b));
            
        }
    }
}