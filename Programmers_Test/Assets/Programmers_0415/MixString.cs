using System;

public class Solution
{
    public string solution(string str1, string str2)                //두 개의 문자열을 번갈아가며 결합하는 함수
    {
        string answer = "";
        for (int i = 0; i < str1.Length; i++)
            answer += str1[i].ToString() + str2[i].ToString();      //첫 번째 문자열(str1)과 두 번째 문자열(str2)의 각 문자를 번갈아가며 결합
        return answer;
    }
}