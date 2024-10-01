using System;
using System.Collections.Generic;

namespace Examples {
    internal class ex06 {
        static void Main() {
            //반복문 for문 while문
            //패턴
            //for( 초기화; 조건식; 증감문 ){
            //   수행문;
            //}
            //for (int i = 0; i < 5; i++) {
            //    Console.WriteLine(i);
            //}
            //연습문제 5
            //1. 반복변수 i를 1부터 100까지 출력하시오.
            Console.WriteLine("첫 번째 문제 : 반복변수 i를 1부터 100까지 출력");
            for (int i = 1; i < 101; i++) {
                Console.Write($"{i},");
            }
            //2. 반복변수 i를 1부터 100사이의 짝수만 출력하시오.
            Console.WriteLine("\n\n두 번째 문제 : 반복변수 i를 1부터 100사이의 짝수만 출력 ");
            for (int i = 0; i < 101; i+=2) {
                Console.Write($"{i},");
            }
            //3. 10부터 -10까지 출력하시오.
            Console.WriteLine("\n\n세 번째 문제 : 10부터 -10까지 출력 ");
            for (int i = 10; i > -11; i--) {
                Console.Write($"{i},");
            }
            //4. 1부터 100사이의 수 중에서 3이나 6이나 9가 포함된 수만 출력하시오.
            // 출력예) 3, 6, 9, ... 3, 33 ... 99
            Console.WriteLine("\n\n네 번째 문제 : 1부터 100사이의 수 중에서 3이나 6이나 9가 포함된 수만 출력");
            for (int i = 1; i < 101; i++) {
                int i4_1 = i / 10;
                int i4_2 = i % 10;
                if (i4_1 == 3 || i4_1 == 6 || i4_1 == 9 || i4_2 == 3 || i4_2 == 6 || i4_2 == 9) {
                    Console.Write($"{i},");
                }
            }
            //5. 1부터 100사이의 2의 배수이거나 3의 배수인 수의 갯수를 출력하시오.
            Console.WriteLine("\n\n다섯 번째 문제 : 1부터 100사이의 2의 배수이거나 3의 배수인 수의 갯수를 출력");
            for (int i = 1; i < 101; i++) {
                if (i % 2 == 0 || i % 3 == 0) {
                    Console.Write($"{i},");
                }
            }
            //6. 10의 약수의 갯수와 그 약수를 출력하시오.
            // 약수란 나누어 떨어지는 수
            // 출력예) 10의 약수는 1 2 5 10 
            Console.Write("\n\n여섯 번째 문제 : 10의 약수의 갯수와 그 약수를 출력\n약수 : ");
            int j = 0, k = 10;
            for (int i = 1; i < k; i++) {
                if (k % i == 0) {
                    Console.Write($"{i},");
                    j++;
                }
            }
            Console.Write($"\n약수의 총 개수 : {j}");
            //7. 2부터 100사이의 랜덤한 정수를 발생시키고,
            // 그 수가 소수인지 아닌지 판별하시오.
            // 소수는 약수의 갯수가 2개인 정수이다.
            // 출력예) 7은 소수입니다.
            //        10은 소수가 아닙니다.
            Console.WriteLine("\n\n일곱 번째 문제 : 2부터 100사이의 랜덤한 정수를 발생시키고, 그 수가 소수인지 아닌지 판별");
            Random rand = new Random();
            int num7 = rand.Next(2, 100), m = 0;
            Console.Write($"랜덤한 정수 : {num7}");
            for (int i = 2; i < num7; i++) {
                if (num7 % i == 0) {
                    m++;                
                }
            }
            if (m == 0) {
                Console.Write("\n소수 입니다.");
            } else { Console.Write("\n소수가 아닙니다."); }

            //중괄호 생략하는 경우 - 수행문이 한줄일때만
            //for (int i = 0; i < 5; i++)
            //    Console.WriteLine(i);

            //if (10 < 20)
            //    Console.WriteLine("10<20");

            Console.WriteLine("\n");
        }
    }
}