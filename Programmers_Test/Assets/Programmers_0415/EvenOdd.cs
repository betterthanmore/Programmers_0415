using System;

public class EvenOdd
{
    public static void Main()
    {
        String[] s;                                     //�Էµ� ���ڿ��� ������ ���ڿ� �迭�� ����

        Console.Clear();                                //�ܼ� �ʱ�ȭ
        s = Console.ReadLine().Split(' ');              //�ֿܼ��� �Է��� �ް� ������ �������� ���ڿ��� ������, ���ڿ� �迭�� ����

        int a = Int32.Parse(s[0]);                      //���ڿ� �迭�� ù ��° ��Ҹ� ���������� ��ȯ
        if (a % 2 == 0)                                 //a�� 2�� ���������� �������� 0���� �Ǵ�, ¦������ Ȧ������ �˻� �� ����� ���(if, else�� ���)
            Console.WriteLine($"{a} is even", a);
        else
            Console.WriteLine($"{a} is odd", a);
    }
}