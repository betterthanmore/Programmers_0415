using System;

public class TextPrinting
{
    public static void Main()
    {
        String[] input;                                 //�Էµ� ���ڿ��� ������ ���ڿ� �迭�� ����

        Console.Clear();                                //�ܼ� �ʱ�ȭ
        input = Console.ReadLine().Split(' ');          //�ֿܼ��� �Է��� �ް� ������ �������� ���ڿ��� ���� �� ���ڿ� �迭�� ����

        String s1 = input[0];                           //���ڿ� �迭�� ù/�� ��° ��Ҹ� ���� ������ ����
        String s2 = input[1];
        String output = s1 + s2.Replace(" ", "");       //s2���� ������ ������ ��, s1�� �̾�ٿ� output�� ����

        Console.WriteLine(output);                      //����� ���

    }
}