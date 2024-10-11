using System;
using System.Collections.Generic;

namespace Examples {
    internal class ex15 {
        static void Main() {
            //재귀함수 : 자기를 자기를 호출하는 함수
            //recursive(5);

            //Console.WriteLine( factorial(5) );
            //Console.WriteLine( fibonacci(6) ); //8
            //int[] arr = [1,2,3,4,5];
            //Console.WriteLine(SumArray(arr, arr.Length));
            //Console.WriteLine(ReverseString("hello"));

            TowerOfHanoi(3, 'A', 'C', 'B');
        }
        //하노이탑 문제
        static void TowerOfHanoi(int n, char from, char to, char aux) {
            if (n == 1) {
                Console.WriteLine($"Move disk 1 from {from} to {to}");
                return;
            }
            TowerOfHanoi(n - 1, from, aux, to);
            Console.WriteLine($"Move disk {n}, from {from} to {to}");
            TowerOfHanoi(n - 1, aux, to, from);
        }

        //문자열 뒤집기
        static string ReverseString(string str) {
            if (str.Length <= 1) return str;
            //Substring(int index) : 인덱스이후의 문자열만 가져옴.
            //Console.WriteLine("hello".Substring(1)); "ello"
            return ReverseString(str.Substring(1)) + str[0];
        }

        //배열 합 구하기
        static int SumArray(int[] arr, int n) {
            if (n <= 0) return 0;
            return arr[n - 1] + SumArray(arr, n - 1);
        }

        //피보나치 수열
        static int fibonacci(int n) {
            if (n <= 1) return n;
            return fibonacci(n - 1) + fibonacci(n - 2);
        }

        //팩토리얼 : 5! = 5*4*3*2*1 
        static int factorial(int n) {
            if (n == 0) return 1;
            return n * factorial(n - 1);
            //return 2*1
            //return 3 *(2*1)
            //return 4 * (3 *(2*1))
            //return 5 * (4 * (3 *(2*1));
        }


        static void recursive(int n) {
            if (n == 0) {
                return;
            }
            Console.WriteLine(n);
            recursive(n - 1);
            return;
        }

    }
}