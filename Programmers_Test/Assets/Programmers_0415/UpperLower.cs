
using System;

public class UpperLower
{
    public static void Main()
    {
        String s;                                   //�Է� ���ڿ��� ������ ������ s ����

        Console.Clear();                            //�ܼ� ȭ���� ����
        s = Console.ReadLine();                     //����ڰ� s�� �Է��� ���� ����

        for(int i = 0; i<s.Length; i++)             //�Է¹��� ���ڿ��� �� ���ڸ� Ȯ���ϰ�, �빮��->�ҹ���/�ҹ���->�빮�ڷ� �����Ͽ� ���
        {
            if (char.IsLower(s[i]))                 //���� ���ڰ� �ҹ������� Ȯ��
            {
                Console.Write(char.ToUpper(s[i]));  //�ҹ��ڸ� �빮�ڷ� �����Ͽ� ���
            }
            else
            {
                Console.Write(char.ToLower(s[i]));  //�빮�ڸ� �ҹ��ڷ� �����Ͽ� ���
            }
        }
    }
}
