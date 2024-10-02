using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq.Expressions;
using System.Xml.Linq;

namespace Examples {
    internal class ex09 {
        static void Main() {
            Console.WriteLine("1. 원의 둘레 구하는 함수");
            Console.Write("반지름을 입력하세요 : "); int input1 = Convert.ToInt32(Console.ReadLine());
            double Pi_1 = CalculatePi(input1);
            Console.WriteLine($"반지름이 {input1}인 원의 원주는 {Pi_1}입니다.");
            Console.WriteLine();

            Console.WriteLine("2. 가장 큰 수를 반환하는 함수");
            Console.Write("첫 번째 정수를 입력하세요 : "); int input2_1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("두 번째 정수를 입력하세요 : "); int input2_2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("세 번째 정수를 입력하세요 : "); int input2_3 = Convert.ToInt32(Console.ReadLine());
            int max = GetMaxValue(input2_1, input2_2, input2_3);
            Console.WriteLine();

            Console.WriteLine("3. 문자열을 압축해서 반환하는 함수");
            Console.WriteLine("문자열을 입력하세요(영문)"); string? input3 = Console.ReadLine();
            if (input3 != null) {
                Console.WriteLine($"압축된 문자열: {CompressString(input3)}");
            } else {
                Console.WriteLine("문자열이 입력되지 않았습니다.");
            }
            Console.WriteLine();
            Console.WriteLine("4. 배열을 매개변수로 받는 FindMin(int[] array) 함수");
            Console.Write("배열의 요소를 띄어쓰기로 구분하여 입력하세요:");
            string? input4 = Console.ReadLine();
            if (input4 != null) {
                string[] inputArray = input4.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                int[] numbers = Array.ConvertAll(inputArray, int.Parse);
                int minValue = FindMin(numbers);
                Console.WriteLine($"배열의 가장 작은 값은: {minValue}");
            }
            Console.WriteLine();
            Console.WriteLine("5. 두개의 배열을 병합하고, 오름차순으로 정렬된 배열을 반환하는 함수");
            Console.Write("첫 번째 배열의 요소를 띄어쓰기로 구분하여 입력하세요:"); string? input5_1 = Console.ReadLine();
            Console.Write("두 번째 배열의 요소를 띄어쓰기로 구분하여 입력하세요:"); string? input5_2 = Console.ReadLine();
            if (input5_1 != null && input5_2 != null) {
                string[] inputArray1 = input5_1.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                string[] inputArray2 = input5_2.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                int[] numbers1 = Array.ConvertAll(inputArray1, int.Parse);
                int[] numbers2 = Array.ConvertAll(inputArray2, int.Parse);
                int[] newarray = MergeAndsSort(numbers1, numbers2);
                foreach (int num in newarray) {
                    Console.Write(num + " ");
                }
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("6. 간단한 암호해독기 함수");
            Console.Write("암호문을 입력하세요:"); string? input6 = Console.ReadLine();
            if (input6 != null) {
                Console.WriteLine(DecryptCaesarcipher(input6));
            }


        }
        //연습문제 7
        // 1. 원의 둘레 구하는 함수를 선언하고,
        //    매개변수로 반지름을 입력하면 원주율을 반환하여 출력하시오.
        static double CalculatePi(double x) {
            double xPi = 2 * x * 3.14;
            return xPi;
        }
        // 2. 정수 3개를 매개변수를 입력받고, 그중 가장 큰 수를 반환하는 함수
        static int GetMaxValue(int x, int y, int z) {
            Console.Write($"{x}, {y}, {z} ");
            if (x > y && x > z) {
                Console.WriteLine($"중에 가장 큰 수는 {x}입니다.");
                return x;
            } else if (y > z && y > x) {
                Console.WriteLine($"중에 가장 큰 수는 {y}입니다.");
                return y;
            } else {
                Console.WriteLine($"중에 가장 큰 수는 {z}입니다.");
                return z;
            }
        }
        // 3. 문자열 압축 함수
        //    주어진 문자열에서 연속된 문자를 압축하는 CompressString(string input) 함수
        //    예를 들어, 입력이 "aaabbcccc"일 경우 "a3b2c4"를 반환하도록 하세요.
        static string CompressString(string input3) {
            List<char> newstring = new List<char>();
            List<int> numbers = new List<int>();
            char currentChar = input3[0];
            int count = 1;
            for (int i = 1; i < input3.Length; i++) {
                if (input3[i] == currentChar) {
                    count++;
                } else {
                    newstring.Add(currentChar);
                    numbers.Add(count);

                    currentChar = input3[i];
                    count = 1;
                }
            }
            newstring.Add(currentChar);
            numbers.Add(count);
            string result = "";
            for (int i = 0; i < newstring.Count; i++) {
                result += newstring[i];
                result += numbers[i].ToString();
            }
            return result;
        }
        // 4. 배열의 요소 중 최소값을 찾는 함수
        static int FindMin(int[] array) {
            int min = array[0];
            for (int i = 1; i < array.Length; i++) {
                if (array[i] < min) {
                    min = array[i];
                }
            }
            return min;  // 가장 작은 값을 반환
        }

        // 5. 두개의 배열을 병합하고, 오름차순으로 정렬된 배열을 반환하는 함수를 선언하시오.
        static int[] MergeAndsSort(int[] array1, int[] array2) {
            int[] mergedArray = array1.Concat(array2).ToArray();
            Array.Sort(mergedArray);
            return mergedArray;
        }

        // 6. 간단한 암호해독기 함수를 작성하시오.
        //    시저 암호(Caesar Cipher)는 알파벳을 3칸 이동하여 작성된 암호이다.
        //    암호화된 문자열: "Khoor Zruog!" (3칸 오른쪽 이동)
        //    복호화된 문자열: "Hello World!" (3칸 왼쪽 이동)
        static string DecryptCaesarcipher(string input) {
            char[] input6Array = input.ToCharArray();
            char[] newarray = new char[input.Length];
            for (int i = 0; i < input6Array.Length; i++) {
                if (input6Array[i] >= 97 && input6Array[i] <= 122 || input6Array[i] >= 65 && input6Array[i] <= 90) {
                    newarray[i] = (char)(input6Array[i] - 3);
                } else {
                    newarray[i] = input6Array[i];
                }
            }
            return new string(newarray);
        }
    }
}