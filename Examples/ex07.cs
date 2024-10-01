using System;


namespace Examples {
    internal class ex07 {
        static void Main() {
            //반복문 while
            //패턴
            //초기화
            //while(조건식){
            // 수행문
            // 증감문
            //}
            //int i = 0;
            //while (i < 5) {
            //    Console.WriteLine(i);
            //    i++;
            //}
            ////무한루프
            //i = 0;
            //while (true) {
            //    Console.WriteLine(i);
            //    if (i > 10) {
            //        break;
            //    }
            //    i++;
            //}

            //연습문제 6
            // 1. 철수와 영희가 주사위게임을 한다.
            //    주사위를 한번씩 던져서, 2나 4이면 1칸 전진, 홀수(1,3,5)이면 그 자리에,
            //    6이면 뒤로 한칸이다.
            //    앞으로 10칸을 먼저 전진하는 사람이 승리한다.
            //    이때의 게임결과를 출력하시오.
            //    출력예) 철수: 1 그자리
            //            영희: 2 1칸전진!
            //            ...
            //            영희: 4 1칸전진!
            //            영희 승
            Random rand = new Random();
            int sum_CS = 0, sum_YH = 0;
            while (true) {
                int CS = rand.Next(1, 6);
                Console.Write($"철수 : {CS} ");
                if (CS == 2 || CS == 4) {
                    Console.Write("한 칸 전진!, ");
                    sum_CS++;
                } else if (CS == 6) {
                    Console.Write("한 칸 후진!, ");
                    sum_CS--;
                } else { Console.Write("그자리!.     "); }
                if (sum_CS >= 10) {
                    Console.WriteLine("철수 승!");
                    break;
                }
                int YH = rand.Next(1, 6);
                Console.Write($"영희 : {YH} ");
                if (YH == 2 || YH == 4) {
                    Console.Write("한 칸 전진!  ");
                    sum_YH++;
                    Console.WriteLine($"철수 위치 : {sum_CS}, 영희 위치 : {sum_YH}");
                } else if (YH == 6) {
                    Console.Write("한 칸 후진!  ");
                    sum_CS--;
                    Console.WriteLine($"철수 위치 : {sum_CS}, 영희 위치 : {sum_YH}");
                } else { 
                    Console.Write("그자리!.     "); 
                    Console.WriteLine($"철수 위치 : {sum_CS}, 영희 위치 : {sum_YH}"); }
                if (sum_YH >= 10) {
                    Console.WriteLine("영희 승!");
                    break;
                }
            }
            Console.WriteLine();
            // 2. 패널티킥 게임
            //    손흥민이 공을 차고, 조현우가 골키퍼를 한다.
            //    공의 방향은 왼쪽(0), 중앙(1), 오른쪽(2)이 있다.
            //    랜덤하게 공을차는데, 방향 별 확률이 왼쪽 : 30%, 중앙 : 20%, 오른쪽 : 50%이다.
            //    조현우도 수비방향이 왼쪽(0), 중앙(1), 오른쪽(2) 이다.
            //    수비 확률은 왼쪽 40%, 중앙 30%, 오른쪽 30%이다.
            //    손흥민이 골을 넣을 확률은?
            int HM = rand.Next(1, 10);
            int HM_status;
            if (HM == 1 || HM == 2 || HM == 3) {
                HM_status = 0;
                Console.Write("손흥민의 왼쪽 공격!!   ");
            } else if (HM == 4 || HM == 5) {
                HM_status = 1;
                Console.Write("손흥민의 중앙 공격!!   ");
            } else {
                HM_status = 2;
                Console.Write("손흥민의 오른쪽 공격!!   ");
            }
            int HY = rand.Next(1, 10);
            int HY_status;
            if (HY == 1 || HY == 2 || HY == 3 || HY == 4) {
                HY_status = 0;
                Console.Write("조현우의 왼쪽 방어!!   ");
            } else if (HY == 5 || HY == 6 || HY == 7) {
                HY_status = 1;
                Console.Write("조현우의 중앙 방어!!   ");
            } else {
                HY_status = 2;
                Console.Write("조현우의 오른쪽 방어!!   ");
            }
            if (HM_status == HY_status) {
                Console.Write("No Goal !!!");
            } else if (HM_status != HY_status) {
                Console.Write("Goal !!!");
            }
            Console.WriteLine();
        }
    }
}