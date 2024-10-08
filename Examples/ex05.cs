﻿using System;

namespace Examples {
    internal class ex05 {
        static void Main() {
            ////조건문 if문 swith문
            ////1.단일 if문
            ////패턴 
            ////if( 조건식 ) { //비교,논리연산자로 이루어진 식
            ////  true일때만 수행되는 수행문
            ////}
            //if (true) {
            //    Console.WriteLine("조건식이 true임");
            //}
            //if (10 == 20) { //조건식이 false이므로 실행되지 않음.
            //    Console.WriteLine("10과 20은 같음");
            //}

            ////2.if else문
            ////패턴
            ////if( 조건식 ) {
            ////   true일 때 수행
            ////}else{
            ////   false일 때 수행
            ////}
            //if (10 == 20) {
            //    Console.WriteLine("true임");
            //} else {
            //    Console.WriteLine("false임");
            //}

            ////3.if else if문
            //int num = 30;
            //if (num == 10) {
            //    Console.WriteLine("10입니다.");
            //} else if (num == 20) {
            //    Console.WriteLine("20입니다.");
            //} else if (num == 30) {
            //    Console.WriteLine("30입니다.");
            //} else {
            //    Console.WriteLine("그외의 수입니다.");
            //}

            ////4.중첩 if문 - if문 안에 if문
            //if (true) {
            //    if (true) {

            //    } else {

            //    }
            //}

            //랜덤한 정수 생성하기
            //Random 클래스 : 랜덤한 수를 생성해주는 클래스
            //rand : 클래스로부터 생성된 객체
            //new : 객체를 생성하는 예약어
            //Random() : 클래스이름과 동일한 생성자함수
            //클래스 안에는 변수와 메소드가 있다!
            //Random rand = new Random();
            //int randNum = rand.Next(1, 100); //1부터 100사이의 랜덤한 정수 발생!
            //Console.WriteLine(randNum);

            //연습문제4
            // 1. 철수와 영희가 각각 주사위를 2번씩 던져서,
            //    주사위의 수의 합이 더 큰 사람이 승리하게 된다.
            //    누가 승리하는지 출력하시오.
            //    입력예) 주사위값 4개
            //    출력예) 영희 승! or 철수 승!
            Random rand = new Random();
            int CS1 = rand.Next(1, 6), CS2 = rand.Next(1, 6), YH1 = rand.Next(1, 6), YH2 = rand.Next(1, 6);
            int CS = CS1 + CS2, YH = YH1 + YH2;
            Console.WriteLine($"\n1번 문제\n철수 주사위 {CS}, 영희 주사위 {YH}");
            if (CS > YH) {
                Console.WriteLine("철수 승!!");
            } else if (CS < YH) {
                Console.WriteLine("영희 승!!");
            } else { Console.WriteLine("무승부!!"); }
            // 2. 랜덤한 정수 (0부터 9사이)를 2개 뽑아서
            //    첫번째 정수는 십의 자리로, 두번째 정수는 일의 자리로 생성하여
            //    출력하시오.
            //    입력예) 랜덤한 정수 2개 1과 3
            //    출력계) 13
            int num21 = rand.Next(0, 9), num22 = rand.Next(0, 9);
            int num2 = num21 * 10 + num22;
            Console.WriteLine($"\n2번 문제\n첫 번째 숫자: {num21}, 두 번째 숫자: {num22}, 숫자의 합 : {num2}");
            // 3. 1부터 100사이의 랜덤한 정수를 하나 발생시키고
            //    90점 이상이면 "A"
            //    80점 이상이면 "B"
            //    70점 이상이면 "C"
            //    60점 이상이면 "D"
            //    그 외의 수이면 "E"라고 출력하시오.
            int num3 = rand.Next(1, 100);
            Console.Write($"\n3번 문제\n랜덤 값 : {num3}, 점수 : ");
            if (num3 > 90) { Console.WriteLine("A"); } else if (num3 > 80) { Console.WriteLine("B"); } else if (num3 > 70) 
                { Console.WriteLine("C"); } else if (num3 > 60) { Console.WriteLine("D"); } else { Console.WriteLine("E"); }

            // 4. 철수와 영희가 교대로 주사위를 계속 던져 (무한루프)
            //    같은 주사위의 값이 먼저 나온 사람이 승리하게 된다.
            //    누가 먼저 승리하는지 출력하시오.
            //    출력 예) ... 철수4, 영희5, 철수4 => 철수 승!
            bool a = false;
            int num411 = 0, num422 = 0;
            Console.WriteLine("\n4번 문제");
            while (a == false) {
                int num41 = rand.Next(1, 6);
                Console.WriteLine($"철수 주사위 {num41}");
                if (num41 == num411) {
                    Console.WriteLine("철수 승!");
                    break;
                }
                int num42 = rand.Next(1, 6);
                Console.WriteLine($"영희 주사위 {num42}");
                if (num42 == num422) {
                    Console.WriteLine("영희 승!");
                    break;
                }
                num411 = num41; num422 = num42;
            }
            // 5. 0부터 9사이의 정수값을 차례로 3개 발생시키고
            //    그 값을 반대로 출력하시오. (ArrayList나 배열 사용)
            //    배열 : int[] student = new int[6];
            //    리스트 : ArrayList<int> list = new ArrayList(); list.Add(3);
            //    입력예) 3 6 8, 출력예) 8 6 3
            Console.WriteLine("\n5번 문제");
            int[] nums = new int[3];
            for (int i = 0; i < 3; i++) {
                int num = rand.Next(0, 9);
                Console.Write($"랜덤 값 {num}\n");
                nums[i] = num;
            }
            for (int i = nums.Length - 1 ; i >= 0; i--) {
                Console.Write(nums[i]);
            }

            //Generic(제네릭) : 클래스안에 데이터 타입을 다양하게 넣는 것
            //배열 Array(논-제네릭)
            int[] arrayNum = new int[3];
            for (int i = 0; i < 3; i++) {
                arrayNum[i] = rand.Next(0, 9);
                Console.WriteLine(arrayNum[i]); //배열의 인덱스는 0부터이다.
            }
            for (int i = 2; i > -1; i--) {
                Console.WriteLine(arrayNum[i]);
            }

            //배열 : 같은 타입의 데이터를 순차적으로 나열한 자료구조
            //리스트 - 제네릭 (List) : 배열 + 삽입,삭제,추가 기능 지원
            //리스트 - 논제네릭 (ArrayList) : 배열 + 삽입,삭제,추가 기능 지원

            //리스트 List(제네릭)
            List<int> list = new List<int>();
            for (int i = 0; i < 3; i++) {
                list.Add(rand.Next(0, 9));
            }
            Console.WriteLine(string.Join(' ', list));
            list.Reverse();
            Console.WriteLine(string.Join(' ', list));

            for (int i = 0; i < 3; i++) {
                Console.WriteLine(list[i]);
            }
            foreach (int num2 in list) {
                Console.WriteLine(num2);
            }

            //리스트 ArrayList(논-제네릭)
            ArrayList list2 = new ArrayList();
            for (int i = 0; i < 3; i++) {
                list2.Add(rand.Next(0, 9));
            }
            Console.WriteLine(string.Join(" ", list2.ToArray()));
            list2.Reverse();
            Console.WriteLine(string.Join(" ", list2.ToArray()));


        }
    }
}