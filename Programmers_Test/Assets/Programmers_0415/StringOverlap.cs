using System;

public class StringOverlap  
{
    public string solution(string my_string, string overwrite_string, int s)        //�� ���� ���ڿ��� �޾Ƽ� ������ ��ġ���� ù ��° ���ڿ��� �� ��° ���ڿ��� ��� ����� ��ȯ
    {
        string answer = "";                                                         //��ȯ�� ����� ������ ������ ����
        answer = my_string.Remove(s, overwrite_string.Length);                      //��� ���ڿ��� ������ ��, ���ο� ���ڿ��� �����Ͽ� ����� ����
        answer = answer.Insert(s, overwrite_string);                                
        return answer;                                                              //�ᱣ���� ��ȯ
    }
}