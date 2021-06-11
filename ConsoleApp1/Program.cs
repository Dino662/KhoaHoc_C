using System;

namespace Buoi6_C
{
    class Buoi_6
    {
        //
        static int[,] m_mang_int;
        static int[] m_int = new int[5] { 4, 1, 6, 2, 8 };
        static void Main()
        {
            //Lý thuyết
            //Phan6_3();
            //Phan6_1();
            //Phan6_2();
            //Phan6_4();
            Phan6_5();
        }
        static void Phan6_1()
        {
            string[] _mang_str = new string[3] { "Phan tu1", "Phan tu2", "Phan tu3" };
            Console.Write(_mang_str[1]);
            Console.ReadLine();
        }
        static void Phan6_2()
        {
            int[,] _mang_int = new int[3, 4] { { 0, 1, 2, 3 }, { 4, 5, 6, 7 }, { 8, 9, 10, 11 } };
            /*Console.Write(_mang_int[1, 2]);
            Console.ReadLine();*/
        }
        static void Phan6_3()
        {
            Phan6_2();
            //Gọi Phan 6.2 Để Khởi tạo mảng hai chiều 
            //For
            for (int i = 0; i < 4; i++)
            {
                Console.Write("{0}\t", m_mang_int[0, i]);
            }
            Console.ReadLine();
        }
        static void Phan6_4()
        {
            //for each
            foreach (int _int_tam in m_int)
            {
                Console.Write("{0}\t", _int_tam);
            }
            Console.ReadLine();
        }
        static void Phan6_5()
        {
            //mảng 2 chiểu ko cố định
            int[][] _mang2_int =
            {
                new int[] {1,2,6,2,1,0},
                new int[] {9,3,5,8,3,8},
                new int[] {2,3,7,5,6,7},
            };
            //In ra màn hình mảng 2 chiều
            //Sử dụng 2 vòng for
            foreach (int[] _mang_int_tam in _mang2_int)
            {
                foreach (int _int_tam in _mang_int_tam)
                {
                    Console.Write("{0}\t", _int_tam);
                }
                Console.WriteLine("");
            }
            Console.ReadLine();
        }
    }
}
