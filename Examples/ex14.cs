using System;
using System.Collections.Generic;

namespace Examples {
    internal class ex14 {
        static void Main() {
            //�ڷ�(������)���� 
            //�˰��� : ������ Ǯ��� ������ ���

            //�ִ밪/�ּҰ� ���ϱ�
            int[] nums = [10, 30, 20, 50, 40];
            //1. max ������ �ּҰ� �����Ѵ�.
            //   min ������ �ִ밪 �����Ѵ�.
            int max = 10;
            int min = 50;
            //2. ��ü��Ҹ� ��ȸ�ϸ鼭 max�������� �� ū ��Ҹ� �߰��ϸ�
            //  max�� �� ���� �ִ´�.
            for (int i = 0; i < nums.Length; i++) {
                if (max < nums[i]) {
                    max = nums[i];
                }
                if (min > nums[i]) {
                    min = nums[i];
                }
            }
            //3. ��ȸ ���� �Ŀ��� max�� �ִ밪�� �ȴ�.
            Console.WriteLine(max);
            Console.WriteLine(min);

            //����(Sort) �˰���
            // 1. ���� ����
            // 2. ���� ����
            // 3. ���� ����

            //Swap ġȯ
            int a = 10;
            int b = 20;
            //a�� b����, b�� a���� �ְ� �ʹ�.
            //a = b;//20 = 20
            //b = a;//20 = 20
            //ġȯ�� �ӽú����� ����Ѵ�.
            int temp = 0;
            temp = a;
            a = b;
            b = temp;

            //1.�������� : ������������
            nums = [10, 30, 20, 50, 40];
            for (int i = 0; i < 5; i++) {
                for (int j = i + 1; j < 5; j++) {
                    if (nums[i] > nums[j]) {
                        //ġȯ!
                        int tmp = nums[i];
                        nums[i] = nums[j];
                        nums[j] = tmp;
                    }
                }
            }
            foreach (int num in nums) {
                Console.WriteLine(num);
            }

        }
    }
}