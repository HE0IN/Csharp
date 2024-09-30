using System;
namespace Examples
{
    internal class ex03
    {
        static void Main()
        {
            //콘솔로부터 입력받기
            //Console.WriteLine("안녕하세요 : ");
            //string input = Console.ReadLine();
            //Console.WriteLine(input);
            //int myInt = int.Parse(input);
            //Console.WriteLine(myInt * 2);

            //연습문제2

            //1. 콘솔로부터 정수 1개를 입력받고,
            //   그 수에 10을 곱한 수를 출력하시오.
            //   입력 예) 10
            //   출력 에) 100
            Console.WriteLine("10을 곱할 숫자를 입력하세요.");
            string? input = Console.ReadLine();
            int myunt = int.Parse(input);
            Console.WriteLine(myunt * 10);


            //2. 콘솔로부터 정수 1개를 입력받고 (1 ~ 100까지 중 하나)
            //   그 수가 짝수이면 "짝수", 홀수이면 "홀수" 라고 출력하시오.
            //   힌트 : %연산자 이용
            Console.WriteLine("홀, 짝을 구분할 숫자를 입력하세요.");
            int myint = Convert.ToInt32(Console.ReadLine());
            if (myint % 2 == 1)
            {
                Console.WriteLine("홀수");
            }
            else
            {
                Console.WriteLine("짝수");
            }
            
            //3. 콘솔로부터 문자열 2개를 입력받고, 합쳐서 출력하시오.
            //   문자열 연결연산자 +
            //   입력 예) 대한
            //            민국
            //   출력 예) 대한민국
            Console.WriteLine("첫 번째 문자열을 입력하세요.");
            string? inputstring1 = Console.ReadLine();
            Console.WriteLine("두 번째 문자열을 입력하세요.");
            string? inputstring2 = Console.ReadLine();
            Console.WriteLine($"두 문자열을 합치면 {inputstring1}{inputstring2}입니다.");
            string? inputstring3 = inputstring1 + inputstring2;
            Console.WriteLine($"두 문자열을 합치면 {inputstring3}입니다.");

        }
    }
}
