using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.ExceptionServices;

namespace Examples {
    internal class example100 {
        static void Main() {
            //https://blog.naver.com/nissisoft21/222520498886
            //https://blog.naver.com/nissisoft21/222520537431

            // 문제 1. Hello 출력
            //Console.WriteLine("Hello");

            // 문제 2. Hello world 출력
            //Console.WriteLine("Hello Wrold");

            // 문제 3. 두 줄에 걸쳐서 Hello world 출력
            //Console.WriteLine("Hello \nworld");

            // 문제 4. 작은 단 따옴표를 문장에 넣어 출력
            // 예) 'Hello'
            //Console.WriteLine("'Hello'");

            // 문제 5. 큰 따옴표를 문장에 넣어 출력
            // 예) "Hello World"
            //Console.WriteLine("\"Hello\"");

            // 문제 6. 여러가지 문자들이 포함된 문장 출력
            // 예) "C:\Download\hello.java"
            //Console.WriteLine("C:\\Download\\hello.java");

            // 문제 7. 키보드로 입력한 정수값을 그대로 출력
            //int input7 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine(input7);

            // 문제 8. 키보드로 입력한 문자를 그대로 출력
            //string? input8 = Console.ReadLine();
            //Console.WriteLine(input8);

            // 문제 9. 키보드로 입력한 실수를 그대로 출력
            //double input9 = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine(input9);

            // 문제 10. 정수 두 개를 입력받아 그대로 출력
            //int input10_1, input10_2;
            //Console.Write("첫 번째 정수를 입력하세요: "); input10_1 = Convert.ToInt32(Console.ReadLine());
            //Console.Write("두 번째 정수를 입력하세요: "); input10_2 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine($"첫 번째 정수 : {input10_1}, 두 번째 정수 : {input10_2}");

            // 문제 11. 두 개의 문자를 입력받은 후 순서를 바꿔 출력
            //Console.Write("첫 번째 문자를 입력하세요: "); string? string11_1 = Console.ReadLine();
            //Console.Write("두 번째 문자를 입력하세요: "); string? string11_2 = Console.ReadLine();
            //Console.WriteLine($"두 번째 문자 : {string11_2}, 첫 번째 문자 : {string11_1}");

            // 문제 12. 하나의 단어를 입력받아 그대로 출력
            //Console.Write("단어를 입력하세요 : "); string? string12 = Console.ReadLine();
            //Console.Write($"입력 된 단어 : {string12}");

            // 문제 13. 실수 한 개를 입력받아 소수점 이하 3째 자리에서 반올림하여 2째 자리까지 출력
            //Console.Write("실수를 입력하세요 : "); double input13 = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine($"입력된 실수 : {input13}"); double input13_1 = Math.Round(input13, 2);
            //Console.WriteLine($"반올림한 실수 : {input13_1}");

            // 문제 14. 시간이 특정 형식에 맞추어 입력될 때 그대로 출력
            //Console.Write("시를 입력하세요 : "); int input14_1 = Convert.ToInt32(Console.ReadLine());
            //Console.Write("분을 입력하세요 : "); int input14_2 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine($"{input14_1} : {input14_2}");

            // 문제 15. 년, 월, 일을 입력받아 형식에 맞게 출력
            //Console.Write("년을 입력하세요 : "); int input15_1 = Convert.ToInt32(Console.ReadLine());
            //Console.Write("월을 입력하세요 : "); int input15_2 = Convert.ToInt32(Console.ReadLine());
            //Console.Write("일을 입력하세요 : "); int input15_3 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine($"{input15_1}.{input15_2.ToString("00")}.{input15_3.ToString("00")}");

            // 문제 16. 10진수를 입력받아 8진수로 출력
            //Console.Write("10진수를 입력하세요 : "); int input16_1 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine($"입력된 값의 8진수 값 : {Convert.ToString(input16_1, 8)} ");

            // 문제 17. 10진수를 입력받아 16진수로 출력
            //Console.Write("10진수를 입력하세요 : "); int input17 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine($"입력된 값의 16진수 값 : {Convert.ToString(input17, 16)} ");

            // 문제 18. 영문자 한 개를 입력받아 아스키코드 10진수 값으로 출력
            //Console.Write("아스키코드로 바꿀 영문자 : "); char? input18 = Console.ReadKey().KeyChar;
            //Console.WriteLine($"\n아스키 코드 값 : {(int)input18}");

            // 문제 19. 10진수 정수 한개를 입력받아 아스키 문자로 출력
            //Console.Write("문자로 바꿀 정수 : "); int input19 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine($"\n아스키 코드 값 : {(char)input19}");

            // 문제 20. 정수 세 개를 입력받아 합과 평균을 출력
            //Console.Write("첫 번째 숫자를 입력하세요 : "); int input20_1 = Convert.ToInt32(Console.ReadLine());
            //Console.Write("두 번째 숫자를 입력하세요 : "); int input20_2 = Convert.ToInt32(Console.ReadLine());
            //Console.Write("세 번째 숫자를 입력하세요 : "); int input20_3 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine($"세 숫자의 합 : {input20_1 + input20_2 + input20_3}");
            //Console.WriteLine($"세 숫자의 평균 : {(input20_1 + input20_2 + input20_3)/3}");

            // 문제 21. 두 정수(a, b)를 입력받아 a의 b 승을 출력
            //Console.Write("첫 번째 숫자를 입력하세요 : "); int input21_1 = Convert.ToInt32(Console.ReadLine());
            //Console.Write("두 번째 숫자를 입력하세요 : "); int input21_2 = Convert.ToInt32(Console.ReadLine());
            //Console.Write($"{input21_1}의 {input21_2}제곱은 : {Math.Pow(input21_1, input21_2)}");

            // 문제 22. 두 정수(a, b)를 입력받아 a가 b보다 크면 1, a가 b와 같거나 b가 a보다 크다면 0출력 (if문 사용)
            //Console.Write("첫 번째 숫자를 입력하세요 : "); int input22_1 = Convert.ToInt32(Console.ReadLine());
            //Console.Write("두 번째 숫자를 입력하세요 : "); int input22_2 = Convert.ToInt32(Console.ReadLine());
            //if (input22_1 > input22_2) {Console.WriteLine("1");} else { Console.WriteLine("0"); }

            // 문제 23. 두 정수(a, b)를 입력받아 a와 b가 같으면 1, a와 b가 같지 않으면 0을 출력
            //Console.Write("첫 번째 숫자를 입력하세요 : "); int input23_1 = Convert.ToInt32(Console.ReadLine());
            //Console.Write("두 번째 숫자를 입력하세요 : "); int input23_2 = Convert.ToInt32(Console.ReadLine());


            // 문제 24. 두 정수(a, b)를 입력받아 b가 a보다 크거나 같으면 1, b가 a보다 작으면 0을 출력
            //Console.Write("첫 번째 숫자를 입력하세요 : "); int input24_1 = Convert.ToInt32(Console.ReadLine());
            //Console.Write("두 번째 숫자를 입력하세요 : "); int input24_2 = Convert.ToInt32(Console.ReadLine());
            //if (input24_1 <= input24_2) { Console.WriteLine("1"); } else { Console.WriteLine("0"); }

            // 문제 25. 두 정수(a, b)를 입력받아 a와 b가 서로 다르면 1, a와 b가 같으면 0을 출력
            //Console.Write("첫 번째 숫자를 입력하세요 : "); int input25_1 = Convert.ToInt32(Console.ReadLine());
            //Console.Write("두 번째 숫자를 입력하세요 : "); int input25_2 = Convert.ToInt32(Console.ReadLine());
            //if (input25_1 != input25_2) { Console.WriteLine("1"); } else { Console.WriteLine("0"); }

            // 문제 26. 참 또는 거짓이 입력되었을 때, 반대로 출력 (scan.nextBoolean)
            //Console.Write("참(true) 또는 거짓(false)을 입력하세요 : "); string? input = Console.ReadLine();
            //bool boolvalue;
            //if (bool.TryParse(input, out boolvalue)) { Console.WriteLine($"입력된 값 : {boolvalue}"); }
            //Console.WriteLine($"반대 값 : {!boolvalue}");

            // 문제 27. 입력된 두 정수 중 큰 값을 출력하는 프로그램 작성 (삼한연산자 사용)
            //Console.Write("첫 번째 숫자를 입력하세요 : "); int input27_1 = Convert.ToInt32(Console.ReadLine());
            //Console.Write("두 번째 숫자를 입력하세요 : "); int input27_2 = Convert.ToInt32(Console.ReadLine());
            //Console.Write($"입력된 두 정수 중 큰 값은 : {(input27_1 > input27_2 ? input27_1 : input27_2)}");

            // 문제 28. 세 정수 a, b, c가 입력되었을 때, 짝수만 출력
            //Console.Write("첫 번째 숫자를 입력하세요 : "); int input28_1 = Convert.ToInt32(Console.ReadLine());
            //Console.Write("두 번째 숫자를 입력하세요 : "); int input28_2 = Convert.ToInt32(Console.ReadLine());
            //Console.Write("세 번째 숫자를 입력하세요 : "); int input28_3 = Convert.ToInt32(Console.ReadLine());
            //if (input28_1 % 2 == 0) { Console.WriteLine(input28_1); }
            //if (input28_2 % 2 == 0) { Console.WriteLine(input28_2); }
            //if (input28_3 % 2 == 0) { Console.WriteLine(input28_3); }

            // 문제 29. 세 정수 a, b, c가 입력되었을 때 순서대로 홀/짝 판별
            //List<int> nums29 = new List<int>();
            //Console.Write("첫 번째 숫자를 입력하세요 : "); int input29_1 = Convert.ToInt32(Console.ReadLine()); nums29.Add(input29_1);
            //Console.Write("두 번째 숫자를 입력하세요 : "); int input29_2 = Convert.ToInt32(Console.ReadLine()); nums29.Add(input29_2);
            //Console.Write("세 번째 숫자를 입력하세요 : "); int input29_3 = Convert.ToInt32(Console.ReadLine()); nums29.Add(input29_3);
            //foreach (int i in nums29) {
            //    if (i % 2 == 0) {
            //        Console.WriteLine($"{i}는 짝수입니다.");
            //    } else { Console.WriteLine($"{i}는 홀수입니다."); }
            //}

            // 문제 30. 정수 한 개가 입력되었을 때 첫째줄에 음, 양 다음줄에 홀, 짝 출력
            //Console.Write("숫자를 입력하세요 : "); int input30 = Convert.ToInt32(Console.ReadLine());
            //if (input30 > 0) { Console.WriteLine($"{input30}은 양수 입니다."); 
            //} else if (input30 < 0) { Console.WriteLine($"{input30}은 음수입니다.");
            //} else { Console.WriteLine($"{input30}은 0입니다."); }
            //if (input30 % 2 == 0) { Console.WriteLine($"{input30}은 짝수입니다."); 
            //} else { Console.WriteLine($"{input30}은 홀수입니다."); }


            // 문제 31. 정수를 입력받아 평가를 출력
            //Console.Write("점수를 입력하세요 : "); int input31 = Convert.ToInt32(Console.ReadLine());
            //if (input31 > 90) {
            //    Console.WriteLine($"{input31}은 A입니다.");
            //} else if (input31 > 70) {
            //    Console.WriteLine($"{input31}은 B입니다,");
            //} else if (input31 > 40) {
            //    Console.WriteLine($"{input31}은 C입니다,");
            //} else { Console.WriteLine($"{input31}은 D입니다."); }

            // 문제 32. 평가를 문자로 입력받아 내용을 다르게 출력해보기
            //Console.Write("등급을 입력하세요 : "); string? input32 = Console.ReadLine();
            //switch (input32) {
            //    case "A":
            //        Console.WriteLine("Very Very Good~~~!!!");
            //        break;
            //    case "B":
            //        Console.WriteLine("Very Good~~~!!!");
            //        break;
            //    case "C":
            //        Console.WriteLine("Good~~~!!!");
            //        break;
            //    case "D":
            //        Console.WriteLine("bad~~~!!!");
            //        break;
            //    default:
            //        Console.WriteLine("What?!?!");
            //        break;
            //}

            // 문제 33. 월을 나타내는 정수(1 ~ 12)가 입력될 때 계절이 출력
            //Console.Write("달을 입력하세요 : "); int input33 = Convert.ToInt32(Console.ReadLine());
            //switch (input33) {
            //    case 3 or 4 or 5 :
            //        Console.WriteLine("봄 입니다.");
            //        break;
            //    case 6 or 7 or 8 :
            //        Console.WriteLine("여름 입니다.");
            //        break;
            //    case 9 or 10 or 11 :
            //        Console.WriteLine("가을 입니다.");
            //        break;
            //    case 12 or 1 or 2 :
            //        Console.WriteLine("겨울 입니다.");
            //        break;
            //}

            // 문제 34. 정수가 순서대로 입력, 정수를 줄을 바꿔 하나씩 출력
            //while (true) {
            //    Console.Write("숫자를 입력하세요 : "); int input34 = Convert.ToInt32(Console.ReadLine());
            //    if (input34 == 0) {
            //        break;
            //    }
            //}

            // 문제 35. 정수 한 개를 입력받아 1 부터 그 수까지의 짝수의 합을 구하기
            //Console.Write("숫자를 입력하세요 : "); int input35 = Convert.ToInt32(Console.ReadLine());
            //int sum = 0;
            //for (int i = 0; i < input35 + 1; i++) {
            //    if (i % 2 == 0) {
            //        sum += i;
            //    }
            //}
            //Console.Write($"1부터 {input35}까지의 짝수의 합은 {sum}입니다.");

            // 문제 36. 1부터 n까지, 1부터 m까지 숫자가 적힌 색이 서로 다른 주사위 2개를 던졌을 때, 나올 수 있는 모든 경우의 수 출력
            //Random rand = new Random();
            //int num36_1 = rand.Next(1, 10);
            //int num36_2 = rand.Next(1, 10);
            //Console.WriteLine($"첫 번째 주사위 면의 개수 : {num36_1}, 두 번째 주사위 면의 개수 : {num36_2}");
            //for (int i = 1; i < num36_1 + 1; i++) {
            //    for (int j = 1; j < num36_2 + 1; j++) {
            //        Console.WriteLine($"{i}, {j}");
            //    }
            //}

            //문제 37. 길이 n이 입력되면 길이가 n인 사각형을 출력
            //Console.Write("정사각형의 길이를 입력하세요 : "); int input37 = Convert.ToInt32(Console.ReadLine());
            //for (int i = 0; i < input37; i++) {
            //    for (int j = 0; j < input37; j++) {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            // 문제 38. 삼각형의 넓이 출력
            //Console.Write("삼각형의 밑변의 길이를 입력하세요 : "); double input38_width = Convert.ToDouble(Console.ReadLine());
            //Console.Write("삼각형의 높이를 입력하세요 : "); double input38_height = Convert.ToDouble(Console.ReadLine());
            //double square_38 = input38_height * input38_width / 2;
            //Console.Write($"밑변이 {input38_width}, 높이가 {input38_height}인 삼각형의 넓이는 {square_38}입니다.");

            // 문제 39. 세 정수가 주어지면 그 중 가장 작은 수 출력
            //Random rand = new Random();
            //int num39_1 = rand.Next(1, 100), num39_2 = rand.Next(1, 100), num39_3 = rand.Next(1, 100);
            //Console.WriteLine($"첫 번째 정수 : {num39_1}, 두 번째 정수 : {num39_2}, 세 번째 정수 : {num39_3}");
            //if (num39_1 < num39_2 && num39_1 < num39_3) {
            //    Console.WriteLine($"가장 작은 정수는 {num39_1}");
            //} else if (num39_2 < num39_1 && num39_2 < num39_3) {
            //    Console.WriteLine($"가장 작은 정수는 {num39_2}");
            //} else if (num39_1 < num39_2 && num39_2 <= num39_3) {
            //    Console.WriteLine($"가장 작은 정수는 {num39_3}");
            //} else { Console.WriteLine("세 정수가 모두 같습니다."); }

            // 문제 40. 공던지기 아이스크림 내기 1
            //Console.Write("공을 던질 거리를 입력하세요(50 ~ 60사이 숫자면 승리, 실수가능) : "); 
            //double input40 = Convert.ToDouble(Console.ReadLine());
            //if (input40 > 50 && input40 < 60) {
            //    Console.WriteLine("승리했습니다!");
            //}else { Console.WriteLine("패배했습니다!"); }

            // 문제 41. 공던지기 아이스크림 내기 2
            //Console.Write("공을 던질 거리를 입력하세요(50 ~ 60사이 숫자면 승리, 실수가능) : ");
            //double input41 = Convert.ToDouble(Console.ReadLine());
            //if (input41 > 30 && input41 < 40 || input41 > 60 && input41 < 70) {
            //    Console.WriteLine("승리했습니다!");
            //} else { Console.WriteLine("패배했습니다!"); }

            // 문제 42. 공던지기 아이스크림 내기 3 
            //Console.Write("공을 던질 거리를 입력하세요(50 ~ 60사이 숫자면 승리, 실수가능) : ");
            //double input40 = Convert.ToDouble(Console.ReadLine());
            //if (input40 > 50 && input40 < 70 || input40 % 6 == 0) {
            //    Console.WriteLine("승리했습니다!");
            //} else { Console.WriteLine("패배했습니다!"); }

            // 문제 43. 숫자를 한글로 바꾸기
            // 숫자를 입력받음
            //Console.Write("숫자를 입력하세요: ");
            //string? input43 = Console.ReadLine();
            //// 각 숫자에 대응하는 한글 숫자 배열
            //string[] koreanNumbers = { "공", "일", "이", "삼", "사", "오", "육", "칠", "팔", "구" };
            //// 자릿수에 대응하는 한글 단위
            //string[] units = { "", "십", "백", "천", "만", "십만", "백만", "천만", "억", "십억", "백억", "천억" };
            //string result = "";
            //int length = input43?.Length ?? 0;  // input43이 null일 경우 길이를 0으로 처리

            //// 소수점 여부 확인
            //bool hasDecimal = input43?.Contains(".") ?? false;

            //string[] parts = hasDecimal ? (input43?.Split('.') ?? new string[0]) : new[] { input43 ?? "" };

            //// 정수부 처리
            //string integerPart = parts[0];
            //for (int i = 0; i < integerPart.Length; i++) {
            //    int digit = integerPart[i] - '0';  // 각 자리 숫자
            //    int position = integerPart.Length - i - 1;  // 자릿수

            //    if (digit != 0)  // 0은 건너뜀
            //    {
            //        if (digit != 1 || position % 4 != 0)  // '일'이 일의 자리인 경우 생략
            //        {
            //            result += koreanNumbers[digit];
            //        }
            //        result += units[position];
            //    }
            //}
            //Console.WriteLine($"입력한 숫자의 한글 변환: {result}");

            // 문제 44. 주원이는 월, 수, 금, 일 아르바이트를 간다. 요일의 번호가 입력으로 주어지고,
            //          그날이 아르바이트 가는날이면 "oh my god"을, 가는날이 아니면 "enjoy"를 출력
            //Console.Write("요일에 대한 숫자를 입력하시오 : ");  int input44 = Convert.ToInt32(Console.ReadLine());
            //switch (input44) {
            //    case 1 or 3 or 5 or 7:
            //        Console.WriteLine("oh my god");
            //        break;
            //    case 2 or 4 or 6: Console.WriteLine("한 잔해"); break;
            //}

            // 문제 45. 이차방정식의 해
            //          2차방정식 ax2 + bx + c = 0의 해를 구하시오 (근의 공식 이용)
            //Console.Write("2차항의 계수를 입력하시오 : "); double input45_1 = Convert.ToDouble(Console.ReadLine());
            //Console.Write("1차항의 계수를 입력하시오 : "); double input45_2 = Convert.ToDouble(Console.ReadLine());
            //Console.Write("상수항을 입력하시오 : "); double input45_3 = Convert.ToDouble(Console.ReadLine());
            //double x_45_1 = (-input45_2 + Math.Sqrt(Math.Pow(input45_2, 2) - 4 * input45_1 * input45_3)) / (2 * input45_1);
            //double x_45_2 = (-input45_2 - Math.Sqrt(Math.Pow(input45_2, 2) - 4 * input45_1 * input45_3)) / (2 * input45_1);
            //if (Math.Pow(input45_2, 2) - 4 * input45_1 * input45_3 > 0) {
            //    Console.WriteLine(($"x는 서로 다른 실근입니다. {x_45_1}, {x_45_2}"));
            //} else if (Math.Pow(input45_2, 2) - 4 * input45_1 * input45_3 < 0) {
            //    Console.WriteLine(($"x는 서로 다른 허근입니다. {x_45_1}, {x_45_2}"));
            //} else {
            //    Console.WriteLine(($"x는 중근입니다. {x_45_1}"));
            //}

            // 문제 46. 어떤 차의 높이가 170cm이다 이 차는 3개의 터널을 차례대로 지나게 될 것이다.
            //          터널의 높이가 차의 높이보다 같거나 낮다면 차는 터널과 충돌하여 사고가 날 것이다.
            //          터널의 높이가 차례대로 3개 주어지면 터널을 무사히 잘 통과하면 PASS를 출력하고,
            //          사고가 난다면 CRASH를 출력하시오
            //Random rand = new Random();
            //int random_46_1 = rand.Next(160, 200), random_46_2 = rand.Next(160, 200), random_46_3 = rand.Next(160, 200);
            //if (random_46_1 > 170) {
            //    Console.WriteLine($"첫 번째 터널의 높이 : {random_46_1} -> PASS!!");
            //    if (random_46_2 > 170) {
            //        Console.WriteLine($"두 번째 터널의 높이 : {random_46_2} -> PASS!!");
            //        if (random_46_3 > 170) {
            //            Console.WriteLine($"세 번째 터널의 높이 : {random_46_3} -> PASS!!");
            //        } else {
            //            Console.WriteLine($"세 번째 터널의 높이 : {random_46_3} -> CRASH!!");
            //        }
            //    } else {
            //        Console.WriteLine($"두 번째 터널의 높이 :  {random_46_2} -> CRASH!!");
            //    }
            //} else {
            //    Console.WriteLine($"첫 번째 터널의 높이 : {random_46_1} -> CRASH!!");
            //}

            // 문제 47. 윤년판별
            //          2월이 29일까지 있는 해를 윤년이라고 함.
            //          어떤 해가 입력되면 그 해가 윤년인지 아닌지 판별하시오.
            //          (윤년 : 해가 4의 배수이면서 100의 배수가 아니면 윤년, 400의 배수이면 윤년 두 조건중 하나라도 맞으면 윤년)
            //Console.Write("년도를 입력하세요 : "); int input47_1 = Convert.ToInt32(Console.ReadLine());
            //if (input47_1 % 4 == 0 && input47_1 % 100 != 0 || input47_1 % 400 == 0) {
            //    Console.WriteLine($"{input47_1}은 윤년입니다.");
            //} else {
            //    Console.WriteLine($"{input47_1}은 윤년이 아닙니다.");
            //}

            // 문제 48. 나이 계산
            //          주민등록번호는 생년월일과 성별정보, 지역정보로 이루어져있다.
            //          여기서 생년월일과 성별정보만 입력으로 받겠다.
            //          성별 정보는 1이면 1900년대 출생 남자, 2이면 1900년대 출생 여자, 3이면 2000년대 출생 남자, 4이면 2000년대 출생 여자이다.
            //          기준년도는 2018년도이다.  현재 나이를 출력하시오
            //Console.Write("성별 정보를 입력하세요 : "); int input48_1 = Convert.ToInt32(Console.ReadLine());
            //Console.Write("생년월일을 입력하세요 : "); string? input48_2 = Console.ReadLine();
            //int age_48 = 0;
            //if (input48_2 != null) {
            //    age_48 = Int32.Parse(input48_2.Substring(0, 2));
            //} else { Console.WriteLine("생년월일을 입력하세요 : "); }

            //if (input48_1 == 1 || input48_1 == 2) {
            //    int age_48_1 = 100 - age_48 + 18;
            //    Console.WriteLine($"성별 정보가 {input48_1}이므로, {1900 + age_48}년생, {age_48_1}살이다.");
            //} else if (input48_1 == 3 || input48_1 == 4) {
            //    int age_48_1 = 18 - age_48;
            //    Console.WriteLine($"성별 정보가 {input48_1}이므로, {2000 + age_48}년생, {age_48_1}살이다.");
            //} else {
            //    Console.WriteLine("정확히 입력하세요");
            //}

            // 문제 49. 30분 전 시간 계산
            //          수호는 30분 전으로 돌아가고 싶고, 차례대로 시간과 분이 주어진다.
            //          그러면 이 시간을 기준으로 30분 전의 시간을 출력하시오. 예) 12 35 => 12 5, 12 0 => 11 30
            //Console.Write("시 정보를 입력하세요 : "); int input49_1 = Convert.ToInt32(Console.ReadLine());
            //Console.Write("분 정보를 입력하세요 : "); int input49_2 = Convert.ToInt32(Console.ReadLine());
            //int input49_3 = 0, input49_4 = 0;
            //if (input49_2 < 30) {
            //    input49_3 = input49_1 - 1;
            //    input49_4 = input49_2 - 30;
            //    if (input49_4 < 0) {
            //        input49_4 = 60 + input49_4;
            //    }
            //} else {
            //    input49_3 = input49_1;
            //    input49_4 = input49_2 - 30;
            //}
            //Console.WriteLine($"수호는 시간을 30분 돌려서 {input49_1}시 {input49_2}분에서 {input49_3}시 {input49_4}분이 됐습니다. ");

            // 문제 50. 비만을 판단하기 위해서 BMI 수치가 필요하다.
            //          BMI 수치가 입력되면 비만을 판단하시오. (BMI 지수 : 몸무게 / (신장 / 100 * 신장 / 100)
            //Console.Write("키 정보를 입력하세요(cm) : "); double height50 = Convert.ToDouble(Console.ReadLine());
            //Console.Write("몸무게 정보를 입력하세요(Kg) : "); double weight50 = Convert.ToDouble(Console.ReadLine());
            //double BMI_info = weight50 / (height50 / 100 * height50 / 100);
            //Console.WriteLine($"BMI_info : {BMI_info}");
            //if (BMI_info < 18.5) {
            //    Console.WriteLine("당신은 저체중 입니다.");
            //} else if (BMI_info >= 18.5 && BMI_info <= 23) {
            //    Console.WriteLine("당신은 정상체중 입니다.");
            //} else if (BMI_info > 23) {
            //    Console.WriteLine("당신은 과체중 입니다.");
            //} else {
            //    Console.WriteLine("당신은 사람이 아닙니다.");
            //}

            // 문제 51. 쓰레기통 알고리즘 문제
            //Console.Write("압축기준량을 입력해주세요(100미만) : "); int input51 = Convert.ToInt32(Console.ReadLine());
            //int input51_1 = input51 / 10;
            //int input51_2 = input51 % 10;
            //int input51_3 = (input51_2 * 10 + input51_1) * 2;
            //if (input51_3 > 100) {
            //    input51_3 = input51_3 - 100;
            //}
            //Console.Write($"{input51_3}이므로..... {(input51_3 < 50 ? "Good!!!" : "Oh my God")}");


            // 문제 52. 영어 서수 문제
            //Console.Write("숫자를 입력하시면 서수가 붙습니다. : "); int input52 = Convert.ToInt32(Console.ReadLine());
            //int input52_1 = input52 % 10;
            //int input52_2 = input52 / 10;
            //if (input52_2 == 1) {
            //    Console.WriteLine($"{input52}는 {input52}th입니다.");
            //} else {
            //    if (input52_1 == 1) {
            //        Console.WriteLine($"{input52}는 {input52}st입니다.");
            //    } else if (input52_1 == 2) {
            //        Console.WriteLine($"{input52}는 {input52}nd입니다.");
            //    } else if (input52_1 == 3) {
            //        Console.WriteLine($"{input52}는 {input52}rd입니다.");
            //    } else {
            //        Console.WriteLine($"{input52}는 {input52}th입니다.");
            //    }
            //}


            // 문제 53. 두 실수 a, b가 입력되면 그 두수를 더하거나 빼거나 곱하거나 나누거나 제곱을 해서 가장 큰 수를 출력
            //Console.Write("실수 a를 입력하세요. : "); double input53_1 = Convert.ToDouble(Console.ReadLine());
            //Console.Write("실수 b를 입력하세요. : "); double input53_2 = Convert.ToDouble(Console.ReadLine());
            //double max = 0;
            //if (input53_1 + input53_2 > max) { max = input53_1 + input53_2; }
            //Console.WriteLine($"{input53_2} + {input53_1} = {input53_2 + input53_1}");
            //if (input53_2 - input53_1 > max) { max = input53_2 - input53_1; }
            //Console.WriteLine($"{input53_2} - {input53_1} = {input53_2 - input53_1}");
            //if (input53_2 * input53_1 > max) { max = input53_2 * input53_1; }
            //Console.WriteLine($"{input53_2} * {input53_1} = {input53_2 * input53_1}");
            //if (input53_2 / input53_1 > max) { max = input53_2 / input53_1; }
            //Console.WriteLine($"{input53_2} / {input53_1} = {input53_2 / input53_1}");
            //if (input53_1 + input53_2 > max) { max = input53_1 + input53_2; }
            //Console.WriteLine($"{input53_2} + {input53_1} = {input53_2 + input53_1}");
            //if (input53_1 - input53_2 > max) { max = input53_1 - input53_2; }
            //Console.WriteLine($"{input53_2} - {input53_1} = {input53_2 - input53_1}");
            //if (input53_1 * input53_2 > max) { max = input53_1 * input53_2; }
            //Console.WriteLine($"{input53_2} * {input53_1} = {input53_2 * input53_1}");
            //if (input53_1 / input53_2 > max) { max = input53_1 / input53_2; }
            //Console.WriteLine($"{input53_2} / {input53_1} = {input53_2 / input53_1}");
            //Console.WriteLine($"가장 큰 경우의 수는 {max}입니다.");

            // 문제 54. 두 자연수 a, b가 주어진다. b가 a의 배수이면 "a*x=b"를 출력하고,
            //          a가 b의 배수이면 "b*x=a"를 출력하고, 배수관계가 아니면 "none"을 출력
            //Console.Write("정수 a를 입력하세요. : "); int input54_1 = Convert.ToInt32(Console.ReadLine());
            //Console.Write("정수 b를 입력하세요. : "); int input54_2 = Convert.ToInt32(Console.ReadLine());
            //if (input54_1 % input54_2 == 0) {
            //    Console.WriteLine($"{input54_1}는(은) {input54_2}의 배수입니다. {input54_2} * {input54_1 / input54_2} = {input54_1}");
            //} else if (input54_2 % input54_1 == 0) {
            //    Console.WriteLine($"{input54_2}는(은) {input54_1}의 배수입니다. {input54_1} * {input54_2 / input54_1} = {input54_2}");
            //} else { Console.WriteLine("none"); }

            // 문제 55. 재호는 이번 시험에 받은 성적이 궁금했다. 점수가 입력되면 등급을 출력
            //Console.Write("시험 성적을 입력하시오. : "); int input55 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine($"{(input55 >= 90 ? "A" : input55 >= 80 ? "B" : input55 >= 70 ? "C" : input55 >= 60 ? "D" : "F")}");

            // 문제 56. 윷놀이 문제
            //Random rand = new Random();
            //int sum56 = 0;
            //int[] num56 = new int[4];
            //for (int i = 0; i < num56.Length; i++) {
            //    num56[i] = rand.Next(0, 2);
            //    Console.WriteLine(num56[i]);
            //    sum56 += num56[i];
            //}
            //Console.WriteLine($"뒤집어진 개수는 {sum56}으로 {(sum56 == 4 ? "윷" : (sum56 == 3 ? "걸" : (sum56 == 2 ? "개" : (sum56 == 1 ? "도" : "모"))))}");

            // 문제 57. 놋데리아 문제
            //Console.Write("메뉴 두개를 선택하세요. 칼로리가 500을 초과하면 엄마가 화내십니다."); int input57_1 = Convert.ToInt32(Console.ReadLine());
            //Console.Write("메뉴 두개를 선택하세요. 칼로리가 500을 초과하면 엄마가 화내십니다."); int input57_2 = Convert.ToInt32(Console.ReadLine());
            //int food_1 = 0, food_2 = 0;
            //if (input57_1 == 1) { Console.WriteLine("치즈버거를 선택했습니다."); food_1 = 400; } else if (input57_1 == 2) { Console.WriteLine("야채버거를 선택했습니다."); food_1 = 340; } else if (input57_1 == 3) { Console.WriteLine("우유를 선택했습니다."); food_1 = 1700; } else if (input57_1 == 4) { Console.WriteLine("계란말이를 선택했습니다."); food_1 = 100; } else if (input57_1 == 5) { Console.WriteLine("샐러드를 선택했습니다."); food_1 = 70; }
            //if (input57_2 == 1) { Console.WriteLine("치즈버거를 선택했습니다."); food_2 = 400; } else if (input57_2 == 2) { Console.WriteLine("야채버거를 선택했습니다."); food_2 = 340; } else if (input57_2 == 3) { Console.WriteLine("우유를 선택했습니다."); food_2 = 1700; } else if (input57_2 == 4) { Console.WriteLine("계란말이를 선택했습니다."); food_2 = 100; } else if (input57_2 == 5) { Console.WriteLine("샐러드를 선택했습니다."); food_2 = 70; }
            //int sumfood57 = food_1 + food_2;
            //if (sumfood57 > 500)
            //    Console.WriteLine("어머니 : angry!!");
            //else
            //    Console.WriteLine("어머니 : no angry...");

            // 문제 58. 세 개의 직선이 있다. 숫자의 의미는 직선의 길이를 말한다.
            //          이 직선으로 삼각형을 만들 수 있는지 판단하는 프로그램을 작성
            //Console.Write("첫 번째 변의 길이를 입력하세요. "); int input58_1 = Convert.ToInt32(Console.ReadLine());
            //Console.Write("두 번째 변의 길이를 입력하세요. "); int input58_2 = Convert.ToInt32(Console.ReadLine());
            //Console.Write("세 번째 변의 길이를 입력하세요. "); int input58_3 = Convert.ToInt32(Console.ReadLine());
            //if (input58_1 > input58_2 && input58_1 > input58_3) {
            //    Console.Write($"가장 큰 변의 길이는 {input58_1}이고, 나머지 변의 길이의 합은 {input58_2 + input58_3} 이므로 ");
            //    Console.Write($"{(input58_1 < input58_2 + input58_3 ? "삼각형이 가능합니다." : "삼각형이 불가능합니다.")}");
            //} else if (input58_2 > input58_1 && input58_2 > input58_3) {
            //    Console.Write($"가장 큰 변의 길이는 {input58_2}이고, 나머지 변의 길이의 합은 {input58_1 + input58_3} 이므로 ");
            //    Console.Write($"{(input58_2 < input58_1 + input58_3 ? "삼각형이 가능합니다." : "삼각형이 불가능합니다.")}");
            //} else if (input58_3 > input58_1 && input58_3 > input58_2) {
            //    Console.Write($"가장 큰 변의 길이는 {input58_3}이고, 나머지 변의 길이의 합은 {input58_1 + input58_2} 이므로 ");
            //    Console.Write($"{(input58_3 < input58_1 + input58_2 ? "삼각형이 가능합니다." : "삼각형이 불가능합니다.")}");
            //}

            // 문제 59. 로또 문제
            // 로또 번호 입력
            //Console.WriteLine("로또 번호 7개를 입력하세요 (마지막 번호는 보너스 번호입니다)");
            //int[] input59 = new int[7];
            //while (true) {
            //    Console.Write("입력 번호 : ");
            //    string? input59_str = Console.ReadLine();
            //    if (input59_str != null) {
            //        string[] inputArray = input59_str.Split(new char[] { ',', ' ', ';', '\t' }, StringSplitOptions.RemoveEmptyEntries);
            //        if (inputArray.Length != 7) {
            //            Console.WriteLine("정확히 7개의 번호를 입력하세요.");
            //            continue;
            //        }
            //        try {
            //            input59 = Array.ConvertAll(inputArray, int.Parse);
            //        } catch {
            //            Console.WriteLine("유효한 숫자를 입력하세요.");
            //            continue;
            //        }
            //        if (input59.Distinct().Count() != input59.Length) {
            //            Console.WriteLine("중복된 번호가 있습니다. 중복 없이 입력하세요.");
            //            continue;
            //        }
            //        if (input59.Any(x => x < 1 || x > 45)) {
            //            Console.WriteLine("로또 번호는 1부터 45 사이의 숫자여야 합니다.");
            //            continue;
            //        }
            //        break;
            //    }
            //}
            //Random rand = new Random();
            //List<int> nums59 = new List<int>();
            //for (int i = 1; i < 46; i++) {
            //    nums59.Add(i);
            //}
            //List<int> lotto59 = new List<int>();
            //for (int i = 0; i < 7; i++) {
            //    int random59 = rand.Next(0, nums59.Count);
            //    lotto59.Add(nums59[random59]);
            //    nums59.RemoveAt(random59);
            //}
            //Console.Write("로또 번호 : ");
            //Console.WriteLine(string.Join(", ", lotto59));
            //int compare59 = 0, bonus59 = 0;
            //for (int i = 0; i < 6; i++) {
            //    for (int j = 0; j < 6; j++) {
            //        if (lotto59[i] == input59[j]) {
            //            compare59++;
            //        }
            //    }
            //}
            //if (lotto59[6] == input59[6]) {
            //    bonus59++;
            //}
            //if (compare59 == 6) {
            //    Console.WriteLine("당첨번호 일치가 6개 이므로, 1등 입니다.");
            //} else if (compare59 == 5 && bonus59 == 1) {
            //    Console.WriteLine("당첨번호 일치가 5개, 보너스번호 일치로 2등 입니다.");
            //} else if (compare59 == 5) {
            //    Console.WriteLine("당첨번호 일치가 5개 이므로, 3등 입니다.");
            //} else if (compare59 == 4) {
            //    Console.WriteLine("당첨번호 일치가 4개 이므로, 4등 입니다.");
            //} else if (compare59 == 3) {
            //    Console.WriteLine("당첨번호 일치가 3개 이므로, 5등 입니다.");
            //} else {
            //    Console.WriteLine($"당첨번호 일치가 {compare59}개 이므로 꽝 입니다.");
            //}

            // 문제 60. 46번이랑 같은 터널 문제
            //Random rand = new Random();
            //int random_46_1 = rand.Next(160, 200), random_46_2 = rand.Next(160, 200), random_46_3 = rand.Next(160, 200);
            //if (random_46_1 > 170) {
            //    Console.WriteLine($"첫 번째 터널의 높이 : {random_46_1} -> PASS!!");
            //    if (random_46_2 > 170) {
            //        Console.WriteLine($"두 번째 터널의 높이 : {random_46_2} -> PASS!!");
            //        if (random_46_3 > 170) {
            //            Console.WriteLine($"세 번째 터널의 높이 : {random_46_3} -> PASS!!");
            //        } else {
            //            Console.WriteLine($"세 번째 터널의 높이 : {random_46_3} -> CRASH!!");
            //        }
            //    } else {
            //        Console.WriteLine($"두 번째 터널의 높이 :  {random_46_2} -> CRASH!!");
            //    }
            //} else {
            //    Console.WriteLine($"첫 번째 터널의 높이 : {random_46_1} -> CRASH!!");
            //}

            // 문제 61. 계산기 프로그램
            //Console.WriteLine("계산기 프로그램");
            //Console.Write("계산식을 입력하세요. : "); string? input61 = Console.ReadLine();
            //if (input61 != null) {
            //    string[] Array61 = input61.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);
            //    if (Array61[1] == "+") {
            //        double sum = double.Parse(Array61[0]) + double.Parse(Array61[2]);
            //        Console.WriteLine($"{Array61[0]} + {Array61[2]} = {sum}입니다.");
            //    } else if (Array61[1] == "-") {
            //        double sum = double.Parse(Array61[0]) - double.Parse(Array61[2]);
            //        Console.WriteLine($"{Array61[0]} - {Array61[2]} = {sum}입니다.");
            //    } else if (Array61[1] == "*") {
            //        double sum = double.Parse(Array61[0]) * double.Parse(Array61[2]);
            //        Console.WriteLine($"{Array61[0]} * {Array61[2]} = {sum}입니다.");
            //    } else if (Array61[1] == "/") {
            //        double sum = double.Parse(Array61[0]) / double.Parse(Array61[2]);
            //        Console.WriteLine($"{Array61[0]} / {Array61[2]} = {sum:F2}입니다.");
            //    }
            //}

            // 문제 62. 학번을 입력 받아 다음 형식으로 출력하시오. 학번은 학년, 반, 번호로 입력된다.
            //          이번에는 학년은 한자리, 반은 두자리, 번호는 세자리로 출력한다
            //int input62_1, input62_2, input62_3;
            //do {
            //    Console.Write("학년을 입력하세요(3학년 이하) : "); input62_1 = Convert.ToInt32(Console.ReadLine());
            //} while (input62_1 > 4 || input62_1 < 0);
            //do {
            //    Console.Write("반을 입력하세요(20반 이하) : "); input62_2 = Convert.ToInt32(Console.ReadLine());
            //} while (input62_2 > 20 || input62_2 < 0);
            //do {
            //    Console.Write("번호를 입력하세요(999번 이하) : "); input62_3 = Convert.ToInt32(Console.ReadLine());
            //} while (input62_3 > 999 || input62_2 < 0);

            //Console.WriteLine($"학번 : {input62_1}{input62_2.ToString("00")}{input62_3.ToString("000")}");


            // 문제 63. 하루는 24시간이다. 일(day)이 입력으로 주어지면 시간으로 변환하시오. 입력일(day)이 입력된다.
            //          출력시간으로 변환해서 출력한다. (입력 예 : 2 , 출력 예 : 48)
            //Console.Write("일 수를 입력하세요 : "); int input63 = Convert.ToInt32(Console.ReadLine());
            //Console.Write($"시간으로 환산하면 {input63 * 24}시간 입니다.");


            // 문제 64. 정수 계산에서 나머지를 구하시오. 예를 들어 7 / 5 의 나머지는 2입니다. 입력 : 두 정수 a, b를 입력받는다.
            //          a는 피제수, b는 제수를 나타낸다. 예) 7 5 가 입력되었다면  ====> 7 / 5 를 뜻함, 출력 : 나머지를 출력한다.
            //Console.Write("계산식을 입력하세요. : "); string? input64 = Console.ReadLine();
            //if (input64 != null) {
            //    string[] Array64 = input64.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);
            //    Console.Write($"{Array64[0]} / {Array64[1]} 의 몫은 {int.Parse(Array64[0]) / int.Parse(Array64[1])} 이고, 나머지는 {double.Parse(Array64[0]) % double.Parse(Array64[1])}입니다.");
            //}

            // 문제 65. 3 6 9 게임
            //Console.WriteLine("3 6 9 게임");
            //Console.Write("숫자를 입력하세요. : "); int input65 = Convert.ToInt32(Console.ReadLine());
            //if (input65 < 10) {
            //    if (input65 % 3 == 0) {
            //        Console.WriteLine("X");
            //    }
            //} else if (input65 >= 9) {
            //    int input65_1 = input65 / 10;
            //    int input65_2 = input65 % 10;
            //    if (input65_1 % 3 == 0) {
            //        Console.Write("X");
            //    }
            //    if (input65_2 % 3 == 0 && input65_2 != 0) {
            //        Console.Write("X");
            //    }
            //}

            // 문제 66. 1, 2, 3 ... 을 계속 더해나갈때, 그 합이 입력한 정수보다 같거나 작을 때까지,
            //          (0 ~1000) 계속 합하는 프로그램을 작성
            //Console.Write("숫자를 입력해 주세요 : ");
            //string? input = Console.ReadLine();

            //if (input != null && int.TryParse(input, out int a)) {
            //    int sum = 0;
            //    int i = 1;
            //    for (; i <= a; i++)
            //    {
            //        sum += i;
            //        if (sum >= a) {
            //            break;
            //        }
            //        Console.Write(i + "+");
            //    }
            //    Console.Write(i); 
            //    Console.WriteLine();
            //    Console.WriteLine(sum + " 입력한 수보다 크거나 같으므로 종료 합니다.");
            //} else {
            //    Console.WriteLine("유효한 숫자를 입력해 주세요.");
            //}

            // 문제 67. 정수 한 개가 입력되었을 때 카운트다운을 출력
            //Console.Write("카운트 다운 시작할 숫자를 입력하세요>");
            //string? input = Console.ReadLine();

            //if (input != null && int.TryParse(input, out int a)) {
            //    for (int i = a; i > 0; i--) {
            //        try {
            //            Thread.Sleep(500);
            //        } catch (ThreadInterruptedException e) {
            //            Console.WriteLine(e.Message);
            //        }
            //        Console.WriteLine(i);
            //    }
            //    Console.WriteLine("종료합니다.");
            //} else {
            //    Console.WriteLine("유효한 숫자를 입력해 주세요.");
            //}


            // 문제 68. 정수 한 개를 입력받아 0부터 그 수까지 순서대로 출력해보자. (0 ~100)
            //          입력 : 정수 한 개가 입력된다. (0 ~100), 출력 : 0부터 그 수까지 줄을 바꿔 한 줄씩 출력
            //Console.Write("(역)카운트 다운 시작할 숫자를 입력하세요>");
            //string? input = Console.ReadLine();

            //if (input != null && int.TryParse(input, out int a)) {
            //    for (int i = 1; i <= a; i++) {
            //        try {
            //            Thread.Sleep(500);
            //        } catch (ThreadInterruptedException e) {
            //            Console.WriteLine(e.Message);
            //        }
            //        Console.WriteLine(i);
            //    }
            //    Console.WriteLine("종료합니다.");
            //} else {
            //    Console.WriteLine("유효한 숫자를 입력해 주세요.");
            //}


            // 문제 69. 시작 값(a), 등차의 값(d), 몇 번째 인지를 나타내는 정수(n)가 입력될 때 n번째 수를 출력하는 프로그램 작성
            //Console.Write("시작값을 입력해주세요>");
            //string? inputA = Console.ReadLine();
            //Console.Write("등차 값을 입력해주세요>");
            //string? inputB = Console.ReadLine();
            //Console.Write("몇 번째 자리까지 출력을 할지 입력해주세요>");
            //string? inputN = Console.ReadLine();

            //if (inputA != null && inputB != null && inputN != null &&
            //    int.TryParse(inputA, out int a) && int.TryParse(inputB, out int b) && int.TryParse(inputN, out int n)) {
            //    for (int i = a; i <= (b * n); i += b) {
            //        Console.WriteLine(i);
            //    }
            //} else {
            //    Console.WriteLine("유효한 숫자를 입력해 주세요.");
            //}


            // 문제 70. 시작 값(a), 등비의 값(r), 몇 번째 인지를 나타내는 정수(n)가 입력될 때 n번째 수를 출력하는 프로그램 작성
            //Console.Write("시작 값을 입력하세요: ");
            //string? input1 = Console.ReadLine();
            //Console.Write("등비 값을 입력하세요: ");
            //string? input2 = Console.ReadLine();
            //Console.Write("몇 번째 수를 출력할지 입력하세요: ");
            //string? input3 = Console.ReadLine();

            //if (input1 != null && input2 != null && input3 != null &&
            //    int.TryParse(input1, out int a) && int.TryParse(input2, out int r) && int.TryParse(input3, out int n)) {
            //    int multiSum = a;
            //    for (int i = 1; i <= n; i++) {
            //        Console.WriteLine(multiSum);
            //        multiSum *= r;
            //    }
            //} else {
            //    Console.WriteLine("유효한 숫자를 입력해 주세요.");
            //}


            // 문제 71. 무작위로 n개의 정수가 입력된다.(n은 2~10의 랜덤수임) n개의 수의 합을 출력
            //int sum = 0;
            //Console.WriteLine("계산기 n개의 숫자를 입력해 더합니다. 0을 입력하면 종료합니다.");
            //Console.WriteLine("==============================================");

            //while (true) {
            //    Console.Write("더할 숫자를 입력하세요> ");
            //    string? input = Console.ReadLine();

            //    if (int.TryParse(input, out int num)) {
            //        sum += num;
            //        Console.WriteLine("====================");
            //        Console.WriteLine("지금까지 숫자의 합은? " + sum);

            //        if (num == 0) {
            //            Console.WriteLine("시스템을 종료합니다.");
            //            break;
            //        }
            //    } else {
            //        Console.WriteLine("유효한 숫자를 입력해 주세요.");
            //    }
            //}

            // 문제 72. 입력의 개수 n이 입력되고 n개의  데이터가 입력된다. 이 n개의 데이터 중 최대값을 출력
            //List<int> arr = new List<int>();
            //int max = 0;

            //while (true) {
            //    Console.WriteLine();
            //    Console.Write("숫자를 입력하세요> ");
            //    string? input = Console.ReadLine();

            //    if (int.TryParse(input, out int num)) {
            //        arr.Add(num);
            //        for (int i = 0; i < arr.Count; i++) {
            //            if (max < arr[i]) {
            //                max = arr[i];
            //            }
            //            Console.Write(arr[i] + (i < arr.Count - 1 ? ", " : ""));
            //        }
            //        Console.WriteLine();
            //        Console.WriteLine("입력받은 숫자의 최대값은? " + max);
            //    } else {
            //        Console.WriteLine("유효한 숫자를 입력해 주세요.");
            //    }
            //}

            // 문제 73. 기부 문제
            //int[] rule = { 1, 10, 2, 20, 3, 30, 4, 40, 5,
            //    50, 6, 60, 7, 70, 8, 80, 9, 90,
            //    10, 100, 11, 110, 12, 120 };

            //Console.Write("존의 번호를 입력하세요: ");
            //string? input1 = Console.ReadLine();
            //Console.Write("밥의 번호를 입력하세요: ");
            //string? input2 = Console.ReadLine();

            //if (int.TryParse(input1, out int num1) && int.TryParse(input2, out int num2)) {
            //    if (num1 >= 1 && num1 <= rule.Length && num2 >= 1 && num2 <= rule.Length) {
            //        int money = rule[num1 - 1] + rule[num2 - 1];
            //        Console.WriteLine("기부금은 " + money);
            //    } else {
            //        Console.WriteLine("입력값이 유효하지 않습니다. 1에서 " + rule.Length + " 사이의 값을 입력해주세요.");
            //    }
            //} else {
            //    Console.WriteLine("유효한 숫자를 입력해 주세요.");
            //}

            // 문제 74. 자연수 N이 주어지면 N의 약수를 오름차순으로 모두 출력
            //Console.Write("약수를 구할 숫자를 입력하세요> ");
            //string? input = Console.ReadLine();

            //if (int.TryParse(input, out int num)) {
            //    Console.Write("약수: ");
            //    for (int i = 1; i <= 30; i++) {
            //        if (num % i == 0) {
            //            Console.Write(i + (i < 30 ? ", " : ""));
            //        }
            //    }
            //    Console.WriteLine();
            //} else {
            //    Console.WriteLine("유효한 숫자를 입력해 주세요.");
            //}

            // 문제 75. 소수란, 약수가 1과 자기 자신 두 개 뿐인 수를 말한다. 어떤 수가 입력되면 그 수가 소수인지 판단
            //Console.Write("소수 판별을 할 숫자를 입력하세요: ");
            //string? input = Console.ReadLine();

            //if (int.TryParse(input, out int n)) {
            //    int count = 0; // 약수 카운트

            //    for (int i = 1; i <= n; i++) {
            //        if (n % i == 0) // 나누어 떨어짐
            //        {
            //            count++;
            //        }
            //    }

            //    if (count == 2) {
            //        Console.WriteLine("소수임");
            //        Console.WriteLine("약수 갯수: " + count);
            //    } else {
            //        Console.WriteLine("소수가 아님");
            //        Console.WriteLine("약수 갯수: " + count);
            //    }
            //} else {
            //    Console.WriteLine("유효한 숫자를 입력해 주세요.");
            //}

            // 문제 76. 어떤 수 n과 k가 있다. n과 k의 관계는 다음과 같다. nk는 n을 k번 곱한 것을 말한다.
            //          입력으로 n과 k가 주어지면 결과를 출력
            //Console.Write("지수를 입력하세요> ");
            //string? inputN = Console.ReadLine();
            //Console.Write("가수를 입력하세요> ");
            //string? inputK = Console.ReadLine();

            //if (int.TryParse(inputN, out int n) && int.TryParse(inputK, out int k)) {
            //    int num = (int)Math.Pow(n, k);
            //    Console.WriteLine(num);
            //} else {
            //    Console.WriteLine("유효한 숫자를 입력해 주세요.");
            //}

            // 문제 77. 팩토리얼 문제 n이 입력되면 n!의 값을 출력
            //Console.Write("n의 값을 입력하세요> ");
            //if (int.TryParse(Console.ReadLine(), out int n)) {
            //    long factorial = 1;

            //    for (int i = 1; i <= n; i++) {
            //        factorial *= i;
            //        Console.Write($"{i}, ");
            //    }
            //    Console.WriteLine();
            //    Console.WriteLine($"{n}! = {factorial}");
            //} else {
            //    Console.WriteLine("유효한 숫자를 입력해 주세요.");
            //}

            // 문제 78. 계산기 1에서 두 피연산자에 대한 연산만 다루었다.
            //          이번에는 식을 입력하면 차례대로 계산하여 출력하는 계산기를 만들어보자.
            //          단, 우선순위는 따지지 않고 왼쪽에서 부터 차례대로 계산하고, 모든 계산은 정수형 계산으로 처리한다
            //int num1;
            //int num2;
            //char op;

            //Console.WriteLine("입력하세요.");
            //string? input1 = Console.ReadLine();

            //// Null 체크 및 int.TryParse로 변환
            //if (input1 != null && int.TryParse(input1, out num1)) {
            //    int result = num1;

            //    while (true) {
            //        string? inputOp = Console.ReadLine();
            //        if (inputOp != null && inputOp.Length > 0) {
            //            op = inputOp[0];

            //            if (op == '=') {
            //                Console.WriteLine(result);
            //                break;
            //            }

            //            string? input2 = Console.ReadLine();
            //            if (input2 != null && int.TryParse(input2, out num2)) {
            //                if (op == '+') {
            //                    result += num2;
            //                } else if (op == '-') {
            //                    result -= num2;
            //                } else if (op == '*') {
            //                    result *= num2;
            //                } else if (op == '/') {
            //                    result /= num2;
            //                }
            //            } else {
            //                Console.WriteLine("유효한 숫자를 입력해 주세요.");
            //            }
            //        } else {
            //            Console.WriteLine("유효한 연산자를 입력해 주세요.");
            //        }
            //    }
            //} else {
            //    Console.WriteLine("유효한 숫자를 입력해 주세요.");
            //}


            // 문제 79. 주어지는 문장의 대문자를 소문자로, 소문자를 대문자로 변경하는 프로그램을 작성
            //Console.WriteLine("입력하세요:");
            //string? str = Console.ReadLine();

            //for (int i = 0; i < str.Length; i++) {
            //    char c = str[i];

            //    if (c >= 'a' && c <= 'z') // 영소문자
            //    {
            //        Console.Write((char)(c - 32));
            //    } else if (c >= 'A' && c <= 'Z') // 영대문자
            //      {
            //        Console.Write((char)(c + 32));
            //    } else // 숫자나 특수문자
            //      {
            //        Console.Write(c);
            //    }
            //}

            // 문제 80. 암호문 문제
            //string password = "qhyhu wuxvw euxwxv";

            //for (int i = 0; i < password.Length; i++) {
            //    char c = password[i];

            //    if (c >= 'd' && c <= 'z') // 'd'부터 'z'까지는 3칸 앞으로
            //    {
            //        Console.Write((char)(c - 3));
            //    } else if (c >= 'a' && c <= 'c') // 'a', 'b', 'c'는 'x', 'y', 'z'로 변환
            //      {
            //        Console.Write((char)(c + 23));
            //    } else // 공백인 경우
            //      {
            //        Console.Write(c);
            //    }
            //}

            // 문제 81. 5개의 정수들의 최댓값과 최솟값을 구하는 프로그램을 작성
            //int[] nums = new int[5];
            //Console.WriteLine("5개의 정수를 입력하세요:");

            //for (int i = 0; i < 5; i++) {
            //    string? input = Console.ReadLine();  // 입력을 받음

            //    if (input != null && int.TryParse(input, out int number))  // null 체크와 숫자 변환
            //    {
            //        nums[i] = number;
            //    } else {
            //        Console.WriteLine("유효한 숫자를 입력해 주세요.");
            //        i--; // 유효하지 않은 입력이 있으면 다시 입력받도록
            //    }
            //}

            //// 최대값 찾기
            //int max = nums[0];
            //for (int i = 1; i < 5; i++) {
            //    if (max < nums[i])
            //        max = nums[i];
            //}

            //// 최소값 찾기
            //int min = nums[0];
            //for (int i = 1; i < 5; i++) {
            //    if (min > nums[i])
            //        min = nums[i];
            //}

            //Console.WriteLine("최대값: " + max);
            //Console.WriteLine("최소값: " + min);

            // 문제 82. 시작단과 마지막 단을 입력하면 그 구간의 구구단을 출력하는 프로그램을 작성
            //Console.Write("시작할 구구단의 단수를 입력하세요> ");
            //string? inputStart = Console.ReadLine();
            //Console.Write("마지막 구구단의 단수를 입력하세요> ");
            //string? inputLast = Console.ReadLine();

            //if (int.TryParse(inputStart, out int start) && int.TryParse(inputLast, out int last)) {
            //    for (int i = start; i <= last; i++) {
            //        for (int j = 1; j < 10; j++) {
            //            Console.WriteLine($"{i} * {j} = {i * j}");
            //        }
            //    }
            //} else {
            //    Console.WriteLine("유효한 숫자를 입력해 주세요.");
            //}

            // 문제 83. n이 입력되면 다음과 같은 삼각형을 출력, 예) n 이 5 이면
            //          *
            //          **
            //          ***
            //          ****
            //          *****
            //Console.Write("삼각형의 길이를 입력하세요> ");
            //string? input = Console.ReadLine();

            //if (int.TryParse(input, out int size)) {
            //    for (int i = 1; i <= size; i++) {
            //        for (int j = 1; j <= i; j++) {
            //            Console.Write("*");
            //        }
            //        Console.WriteLine();
            //    }
            //} else {
            //    Console.WriteLine("유효한 숫자를 입력해 주세요.");
            //}

            // 문제 84. 길이 n이 입력되면 역삼각형을 출력 예) n이 5이면
            //          *****
            //          ****
            //          ***
            //          **
            //          *
            //Console.Write("역삼각형의 길이를 입력하세요> ");
            //string? input = Console.ReadLine();

            //if (int.TryParse(input, out int n)) {
            //    for (int i = 0; i < n; i++) {
            //        for (int j = 0; j < n - i; j++) {
            //            Console.Write("*");
            //        }
            //        Console.WriteLine();
            //    }
            //} else {
            //    Console.WriteLine("유효한 숫자를 입력해 주세요.");
            //}

            // 문제 85. 길이 n이 입력되면 다음과 같은 역삼각형을 출력한다. 예) n이 5이면
            //          *****
            //           ****
            //            ***
            //             **
            //              *
            //Console.WriteLine("n?: ");
            //string? input = Console.ReadLine();

            //if (int.TryParse(input, out int n)) {
            //    for (int i = 0; i < n; i++) {
            //        for (int j = 0; j < i; j++) {
            //            Console.Write(" ");
            //        }
            //        for (int k = 0; k < n - i; k++) {
            //            Console.Write("*");
            //        }
            //        Console.WriteLine();
            //    }
            //} else {
            //    Console.WriteLine("유효한 숫자를 입력해 주세요.");
            //}

            // 문제 86. 어떤 수 n을 입력받으면 다음과 같은 삼각형을 출력한다. 여기서 입력되는 n은 반드시 홀수이다.
            //          입력예) 3부터 99 까지의 홀수 중 하나가 입력
            //            *
            //           ***
            //          *****       
            //Console.Write("3부터 99까지의 홀수 중 하나를 입력하세요: ");
            //string? input = Console.ReadLine();

            //if (int.TryParse(input, out int n) && n >= 3 && n <= 99 && n % 2 != 0) 
            //{
            //    int midIndex = (n / 2) + 1;

            //    for (int i = 1; i <= midIndex; i++) {
            //        for (int k = i; k < midIndex; k++) {
            //            Console.Write(" ");
            //        }

            //        for (int j = 1; j < i * 2; j++) {
            //            Console.Write("*");
            //        }

            //        Console.WriteLine();
            //    }
            //} else {
            //    Console.WriteLine("유효한 홀수를 입력해 주세요. (3부터 99까지의 홀수)");
            //}

            // 문제 87. 길이 n이 입력되면 다음과 같은 사각형을 출력한다. 예) n이 5일때
            //          *****
            //          *   *
            //          *   *
            //          *   *
            //          *****
            //Console.WriteLine("n값:");
            //string? input = Console.ReadLine();

            //if (int.TryParse(input, out int n)) {
            //    for (int i = 0; i < n; i++) {
            //        for (int j = 0; j < n; j++) {
            //            if (i == 0 || i == n - 1) // 첫 줄과 마지막 줄
            //                Console.Write("*");
            //            else {
            //                if (j == 0 || j == n - 1) // 첫 열과 마지막 열
            //                    Console.Write("*");
            //                else
            //                    Console.Write(" ");
            //            }
            //        }
            //        Console.WriteLine();
            //    }
            //} else {
            //    Console.WriteLine("유효한 숫자를 입력해 주세요.");
            //}

            // 문제 88. 동렬이는 수학 문제를 풀다 다음과 같은 수열을 보았다.
            //          Sn = (1) + (1 + 2) + (1 + 2 + 3) + (1 + 2 + 3 + 4) + ...+(1 + ...+ n)Sn
            //          = (1) + (1 + 2) + (1 + 2 + 3) + (1 + 2 + 3 + 4) + ...+(1 + ...+ n)
            //          임의의 정수 n이 주어질 때 이 수열의 합 Sn을 구하는 프로그램을 작성
            //Console.Write("n값은: ");
            //string? input = Console.ReadLine();

            //if (int.TryParse(input, out int n)) {
            //    int sum = 0;

            //    for (int i = 1; i <= n; i++) {
            //        for (int j = 1; j <= i; j++) {
            //            sum = sum + j;
            //        }
            //    }

            //    Console.WriteLine("수열의 합: " + sum);
            //} else {
            //    Console.WriteLine("유효한 숫자를 입력해 주세요.");
            //}

            // 문제 89. 주사위 경우의 수 문제
            //Console.Write("두 주사위의 합 k를 입력하세요: ");
            //string? input = Console.ReadLine();

            //if (int.TryParse(input, out int k) && k >= 2 && k <= 12) {
            //    bool found = false;

            //    for (int i = 1; i <= 6; i++) {
            //        for (int j = i; j <= 6; j++) // 첫 번째 주사위 값이 더 작거나 같도록 설정
            //        {
            //            if (i + j == k) {
            //                Console.WriteLine(i + " " + j);
            //                found = true;
            //            }
            //        }
            //    }

            //    if (!found) {
            //        Console.WriteLine("합이 " + k + "가 되는 경우가 없습니다.");
            //    }
            //} else {
            //    Console.WriteLine("2에서 12 사이의 유효한 값을 입력해 주세요.");
            //}

            // 문제 90. 출석 문제
            //int[] numbers = new int[10];

            //Console.WriteLine("10번의 출석 번호를 입력하세요 (1~23 사이의 숫자):");

            //for (int i = 0; i < 10; i++) {
            //    string? input = Console.ReadLine();

            //    if (int.TryParse(input, out int k) && k >= 1 && k <= 23) {
            //        numbers[i] = k;
            //    } else {
            //        Console.WriteLine("유효한 번호를 입력하세요 (1~23 사이의 숫자).");
            //        i--;
            //    }
            //}

            //Console.WriteLine("출석 번호를 거꾸로 출력합니다:");

            //for (int i = 9; i >= 0; i--) 
            //{
            //    Console.Write(numbers[i] + " ");
            //}

            // 문제 91. n개의 숫자가 입력되면, n개의 숫자를 왼쪽으로 하나씩 돌려서 출력하시오.
            //          예) 1 2 3 4 5가 입력된 경우,
            //          1 2 3 4 5
            //          2 3 4 5 1
            //          3 4 5 1 2
            //          4 5 1 2 3
            //          5 1 2 3 4
            //Console.WriteLine("n개의 수를 입력하세요:");
            //string? inputN = Console.ReadLine();

            //if (inputN != null && int.TryParse(inputN, out int n)) {
            //    int[] nums = new int[1000];

            //    Console.WriteLine($"{n}개의 수를 입력하세요:");
            //    for (int i = 0; i < n; i++) {
            //        string? inputNum = Console.ReadLine();

            //        if (inputNum != null && int.TryParse(inputNum, out int number)) {
            //            nums[i] = number;
            //        } else {
            //            Console.WriteLine("유효한 숫자를 입력해 주세요.");
            //            i--; 
            //        }
            //    }

            //    for (int i = 0; i < n; i++) {
            //        for (int j = i; j < n; j++) {
            //            Console.Write(nums[j] + " ");
            //        }
            //        for (int k = 0; k < i; k++) {
            //            Console.Write(nums[k] + " ");
            //        }
            //        Console.WriteLine();
            //    }
            //} else {
            //    Console.WriteLine("유효한 숫자를 입력해 주세요.");
            //}

            // 문제 92. 기억력 문제 1
            //int[] motherNum = { 18, 29, 48, 39, 24, 23, 11, 77, 99, 55 };
            //foreach (int m in motherNum) {
            //    Console.Write(m + " ");
            //}
            //Console.WriteLine();

            //try {
            //    Thread.Sleep(5000); // 5초 대기
            //} catch (Exception e) {
            //    Console.WriteLine(e.Message);
            //}

            //for (int i = 0; i < 50; i++) {
            //    Console.WriteLine("...");
            //}

            //Console.WriteLine("3번째 숫자는?");
            //string? input = Console.ReadLine();
            //if (int.TryParse(input, out int num)) {
            //    bool isExist = false;

            //    if (num == motherNum[2]) // 3번째 숫자는 배열의 인덱스 2
            //    {
            //        isExist = true;
            //    }

            //    if (isExist) {
            //        Console.WriteLine("정답!");
            //    } else {
            //        Console.WriteLine("오답!");
            //    }
            //} else {
            //    Console.WriteLine("유효한 숫자를 입력해 주세요.");
            //}

            // 문제 93. 기억력 문제 2
            //Console.WriteLine("7개의 단어를 차례대로 입력하세요 (단어를 띄어쓰기로 구분):");
            //string? input = Console.ReadLine();

            //string[] words = input?.Split(' ') ?? new string[0];

            //if (words.Length != 7) {
            //    Console.WriteLine("7개의 단어를 입력해야 합니다.");
            //    return;
            //}

            //Console.WriteLine("다음 단어들을 기억하세요:");
            //foreach (string word in words) {
            //    Console.Write(word + " ");
            //}
            //Console.WriteLine();

            //try {
            //    Thread.Sleep(5000); // 5초 대기
            //} catch (Exception e) {
            //    Console.WriteLine(e.Message);
            //}

            //for (int i = 0; i < 50; i++) {
            //    Console.WriteLine(".");
            //}

            //Console.WriteLine("k번째 숫자는 뭘까요?");
            //string? kInput = Console.ReadLine();

            //if (int.TryParse(kInput, out int k) && k >= 1 && k <= 7) {
            //    // k번째 단어 출력
            //    Console.WriteLine($"{k}번째 단어는: {words[k - 1]}");
            //} else {
            //    Console.WriteLine("1에서 7 사이의 유효한 숫자를 입력해 주세요.");
            //}

            // 문제 94. 괄호 문제
            //Console.WriteLine("괄호로 이루어진 문자열을 입력하세요:");
            //string? input = Console.ReadLine();

            //if (input != null) {
            //    int openCount = 0;
            //    int closeCount = 0;

            //    foreach (char c in input) {
            //        if (c == '(') {
            //            openCount++;
            //        } else if (c == ')') {
            //            closeCount++;
            //        }
            //    }

            //    Console.WriteLine($"{openCount} {closeCount}");
            //} else {
            //    Console.WriteLine("유효한 문자열을 입력해 주세요.");
            //}

            // 문제 95. 어떤 영어 문장이 주어지면 각 알파벳이 몇 번 나왔는지 출력
            //int[] counts = new int[26];

            //Console.WriteLine("영어 문장을 입력하세요:");
            //string? str = Console.ReadLine();

            //if (str != null) {
            //    foreach (char c in str) {
            //        if (c >= 'a' && c <= 'z') {
            //            int index = c - 'a';
            //            counts[index]++;
            //        }
            //    }

            //    for (int i = 0; i < counts.Length; i++) {
            //        if (counts[i] > 0) {
            //            Console.WriteLine((char)('a' + i) + ":" + counts[i]);
            //        }
            //    }
            //} else {
            //    Console.WriteLine("유효한 입력이 아닙니다.");
            //}

            // 문제 96. 친구 성적 문제
            //Console.WriteLine("학생 수를 입력하세요 (3 <= n <= 50):");
            //string? input = Console.ReadLine();

            //if (input != null && int.TryParse(input, out int n) && n >= 3 && n <= 50) {
            //    string[,] students = new string[n, 2];

            //    for (int i = 0; i < n; i++) {
            //        Console.WriteLine("학생 이름을 입력하세요:");
            //        string? nameInput = Console.ReadLine();

            //        if (string.IsNullOrEmpty(nameInput)) {
            //            Console.WriteLine("유효한 이름을 입력해 주세요.");
            //            i--;
            //            continue;
            //        }
            //        students[i, 0] = nameInput;

            //        Console.WriteLine("학생 성적을 입력하세요:");
            //        string? scoreInput = Console.ReadLine();

            //        if (string.IsNullOrEmpty(scoreInput) || !int.TryParse(scoreInput, out int score)) {
            //            Console.WriteLine("유효한 성적을 입력해 주세요.");
            //            i--;
            //            continue;
            //        }
            //        students[i, 1] = score.ToString();
            //    }

            //    for (int i = 0; i < n; i++) {
            //        for (int j = i + 1; j < n; j++) {
            //            int score1 = int.Parse(students[i, 1]);
            //            int score2 = int.Parse(students[j, 1]);

            //            if (score2 > score1) {
            //                string tempName = students[i, 0];
            //                string tempScore = students[i, 1];
            //                students[i, 0] = students[j, 0];
            //                students[i, 1] = students[j, 1];
            //                students[j, 0] = tempName;
            //                students[j, 1] = tempScore;
            //            }
            //        }
            //    }

            //    Console.WriteLine("성적이 세 번째로 높은 학생:");
            //    Console.WriteLine(students[2, 0]);
            //} else {
            //    Console.WriteLine("유효한 학생 수를 입력해 주세요 (3 이상 50 이하).");
            //}

            // 문제 97. 담임 자리배치 문제
            //Console.WriteLine("학생 수와 한 줄에 앉을 자리 수를 입력하세요:");
            //string? input = Console.ReadLine();

            //if (input != null && input.Split().Length == 2) {
            //    string[] inputs = input.Split();

            //    if (int.TryParse(inputs[0], out int studentCount) && int.TryParse(inputs[1], out int placeCount)) {
            //        if (studentCount < 1 || studentCount > 99 || placeCount < 1 || placeCount > 10) {
            //            Console.WriteLine("학생 수는 1~99명, 자리 수는 1~10명 사이여야 합니다.");
            //            return;
            //        }

            //        int[] heights = new int[studentCount];
            //        Console.WriteLine("학생들의 키를 입력하세요:");
            //        for (int i = 0; i < studentCount; i++) {
            //            string? heightInput = Console.ReadLine();

            //            if (heightInput == null || !int.TryParse(heightInput, out heights[i])) {
            //                Console.WriteLine("유효한 숫자를 입력해 주세요.");
            //                i--;
            //            }
            //        }

            //        Array.Sort(heights);

            //        for (int i = 0; i < studentCount; i++) {
            //            Console.Write(heights[i] + " ");

            //            if ((i + 1) % placeCount == 0) {
            //                Console.WriteLine();
            //            }
            //        }
            //    } else {
            //        Console.WriteLine("유효한 학생 수와 자리 수를 입력해 주세요.");
            //    }
            //} else {
            //    Console.WriteLine("입력 형식이 잘못되었습니다.");
            //}

            // 문제 98. 오목문제
            //int[,] board = new int[10, 10];
            //for (int i = 0; i < 10; i++) {
            //    for (int j = 0; j < 10; j++) {
            //        board[i, j] = 0;
            //    }
            //}

            //Console.Write("흰돌의 개수를 입력하세요 (1~10): ");
            //string? inputN = Console.ReadLine();

            //if (inputN != null && int.TryParse(inputN, out int n) && n >= 1 && n <= 10) {
            //    for (int i = 0; i < n; i++) {
            //        Console.Write("X: ");
            //        string? inputX = Console.ReadLine();
            //        Console.Write("Y: ");
            //        string? inputY = Console.ReadLine();

            //        if (inputX != null && int.TryParse(inputX, out int x) &&
            //            inputY != null && int.TryParse(inputY, out int y) &&
            //            x >= 1 && x <= 10 && y >= 1 && y <= 10) {
            //            board[x - 1, y - 1] = 1;
            //        } else {
            //            Console.WriteLine("유효한 좌표를 입력해 주세요.");
            //            i--;
            //        }
            //    }

            //    for (int i = 0; i < 10; i++) {
            //        for (int j = 0; j < 10; j++) {
            //            Console.Write(board[i, j] + " ");
            //        }
            //        Console.WriteLine();
            //    }
            //} else {
            //    Console.WriteLine("유효한 흰돌의 개수를 입력해 주세요 (1~10).");
            //}

            // 문제 99. 학점 문제
            //Console.WriteLine("점수를 입력하세요:");
            //string? input = Console.ReadLine();

            //if (input != null && int.TryParse(input, out int score)) {
            //    CalculateGrade(score);
            //} else {
            //    Console.WriteLine("유효한 정수를 입력해 주세요.");
            //}

            // 문제 100. 컴퓨터 랜덤숫자 문제
            //Random rand = new Random();
            //int answer = rand.Next(1, 101);
            //bool isCorrect = false;

            //Console.WriteLine("숫자 맞추기 게임을 시작합니다!");

            //while (!isCorrect) {
            //    Console.WriteLine("1에서 100 사이의 숫자를 입력하세요.");
            //    string? input = Console.ReadLine();

            //    if (input != null && int.TryParse(input, out int userAnswer)) {
            //        if (userAnswer < answer) {
            //            Console.WriteLine("입력한 숫자가 정답보다 작습니다.");
            //        } else if (userAnswer > answer) {
            //            Console.WriteLine("입력한 숫자가 정답보다 큽니다.");
            //        } else {
            //            Console.WriteLine("정답입니다!");
            //            isCorrect = true;
            //        }
            //    } else {
            //        Console.WriteLine("유효한 숫자를 입력해 주세요.");
            //    }
            //}

            //static void CalculateGrade(int score) {
            //    if (score >= 90) {
            //        Console.WriteLine("A학점");
            //    } else if (score >= 80) {
            //        Console.WriteLine("B학점");
            //    } else if (score >= 70) {
            //        Console.WriteLine("C학점");
            //    } else if (score >= 60) {
            //        Console.WriteLine("D학점");
            //    } else {
            //        Console.WriteLine("E학점");
            //    }
        }
    }
}
