using System;

public class Solution
{
    public string solution(string str1, string str2)                //�� ���� ���ڿ��� �����ư��� �����ϴ� �Լ�
    {
        string answer = "";
        for (int i = 0; i < str1.Length; i++)
            answer += str1[i].ToString() + str2[i].ToString();      //ù ��° ���ڿ�(str1)�� �� ��° ���ڿ�(str2)�� �� ���ڸ� �����ư��� ����
        return answer;
    }
}