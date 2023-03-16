using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai_1._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("bai tat c# dau tien");
            // khai bao bien thong thuong
            /*
            int a = 10;
            int b = 15;
            int c = a + b;
            Console.WriteLine("Tong cua a + b = " + c);*/

            //khai bao bien hang bang ham const
            /*
            const double Pi = 3.1416;
            float r = 3;
            double dtHtron = r * r * Pi;
            Console.WriteLine("dien tich hinh tron la : " + dtHtron);*/

            //--------------+++++++++++-----------+++++++++++++++++--------------++++++++++++--------//

            // khai bao bien ngam dinh bang var
            // kiem tra kieu cua bien ngam dinh dung cu phap <ten_bien> + ham GetType()
            /*
             var L = "long dep trai";
             var x = 100;
             var y = 37.1;
             var t = new DateTime(2023, 2, 18);



             Console.WriteLine("kieu gia tri cua bien L la : " + L.GetType() + "\n" +
                               "kieu gia tri cua bien x la : " + x.GetType() + "\n" +
                               "kieu gia tri cua bien y la : " + y.GetType() + "\n" +
                               "kieu gia tri cua bien t la : " + t.GetType() + "\n"
                               ); */

            // nhap du lieu tu ban phim : + nhap thang ta dung ham Parse()

            // Console.Write("moi nhap gia tri cho bien a : ");

            //int a = int.Parse(Console.ReadLine());
            // nhap gia tri gian tiep
            /*
            string stra = Console.ReadLine();
            int a = Convert.ToInt32(stra);
            Console.WriteLine("kieu gia tri a la : "+a.GetType());
            */

            //--------------+++++++++++-----------+++++++++++++++++--------------++++++++++++--------//

            // bai toan kiem tra so nguyen duong voi cau truc if - else
            /*
            Console.Write("moi ban nhan gia tri n : ");
            int n = Convert.ToInt32(Console.ReadLine());

            if (n != 0)
            {
                if(n > 0)
                {
                    Console.Write("so ban nhap la so duong");
                }
                else if(n < 0)
                {
                    Console.Write("so ban nhap la so am");
                }
                
            }
            else
            
                Console.Write("so nhap vao la so 0");
            
               */

            // cấu trúc lụa chon swich - case
            /*
            Console.Write("nhap gia tri cho n de biet thu trong tuan: ");

            int n = Convert.ToInt32(Console.ReadLine());

            switch (n)
            {
                case 2 :
                    Console.WriteLine("thu 2");
                    break;
                case 3 :
                    Console.WriteLine("thu 3");
                    break ;
                case 4 :
                    Console.WriteLine("thu 4");
                    break;
                case 5:
                    Console.WriteLine("thu 5");
                    break;
                case 6:
                    Console.WriteLine("thu 6");
                    break;
                case 7:
                    Console.WriteLine("thu 7");
                    break;
                    default:
                    Console.WriteLine("chu nhat");
                    break;
            }
                */
            int[,] matrix = new int[3, 3]; // khởi tạo ma trận 3x3

            // nhập giá trị cho ma trận
            Console.WriteLine("Nhập giá trị cho ma trận: ");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write($"[{i}, {j}] = ");
                    matrix[i, j] = int.Parse(Console.ReadLine());
                }
            }

            // tính tổng các phần tử trong ma trận
            int sum = 0;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    sum += matrix[i, j];
                }
            }

            // hiển thị ma trận và tổng các phần tử trong ma trận
            Console.WriteLine("Ma trận vừa nhập là:");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write($"{matrix[i, j]} ");
                }
                Console.WriteLine();
            }
            Console.WriteLine($"Tổng các phần tử trong ma trận là: {sum}");


            Console.ReadLine();
        }
    }
}
