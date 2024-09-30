using System;

namespace Examples {
    internal class ex04_1 {
        static void Main() {
            //연습문제3
            //1. 정수형 변수 하나를 선언하고 123으로 초기화한다.
            //  백의 자릿수와 십의 자릿수, 일의 자릿수를 구하여 출력하시오.
            // 출력예) 백의 자릿수: 1
            //        십의 자릿수: 2
            //        일의 자릿수: 3
            int num1 = 567;
            int num11 = num1 / 100;
            int num12 = (num1 / 10) % 10;
            int num13 = num1 % 10;
            Console.WriteLine($"{num1}의 백의 자리 수는 {num11}, 십의 자리 수는 {num12}, 일의 자리 수는 {num13} 입니다.");

            //2. 콘솔로부터 정수 2개를 입력받고
            // 더 큰 수를 출력하시오.
            // 입력예) 10
            //        20
            // 출력예) 20
            Console.WriteLine("첫 번째 숫자를 입력하세요 : ");
            int input1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("두 번째 숫자를 입력하세요 : ");
            int input2 = Convert.ToInt32(Console.ReadLine());
            if (input1 > input2) {
                Console.WriteLine(input1);
            } else if (input1 < input2) {
                Console.WriteLine(input2);
            } else { Console.WriteLine("두 숫자가 같습니다."); }

            //3. 콘솔로부터 10자미만의 문자열을 입력받고,
            // null이 아니라면(null 조건부 연산자 사용), 그 문자열의 길이를 출력하시오.
            // string str; str.Length 문자열의 길이
            Console.WriteLine("10자 미만의 문자열을 입력하세요.");
            string? input3 = Console.ReadLine();
            if (input3 != null) {
                int length = input3.Length;
                Console.WriteLine($"문자열의 길이는 {length}");
            }else { Console.WriteLine("입력된 문자가 없습니다."); }

            //4. string input = null 로 선언하고
            // input이 null이라면 기본값 "null값입니다."를 출력하는 코드를 작성하시오.
            // null 병합 연산자 사용
            string? input = null;
            Console.WriteLine($"{input ?? "null 값입니다."}");

        }
    }
}
