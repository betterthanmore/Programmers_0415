using System;

public class ReturnString
{
    public static void Main()
    {
        String s;                       //�Էµ� ���ڿ��� ������ ���ڿ� ���� ����

        Console.Clear();                //�ܼ� �ʱ�ȭ
        s = Console.ReadLine();         //�ֿܼ��� �� ���� �Է¹޾� ���ڿ� ������ ����

        foreach (char c in s)           //���ڿ��� ��ȸ�ϸ鼭 �� ���ڸ� �� �پ� ���
            Console.WriteLine(c);       //���

    }
}