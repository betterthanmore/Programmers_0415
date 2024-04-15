using System;

public class StringOverlap  
{
    public string solution(string my_string, string overwrite_string, int s)        //두 개의 문자열을 받아서 지정된 위치에서 첫 번째 문자열을 두 번째 문자열로 덮어쓴 결과를 반환
    {
        string answer = "";                                                         //반환할 결과를 저장할 변수를 선언
        answer = my_string.Remove(s, overwrite_string.Length);                      //덮어쓸 문자열을 제거한 후, 새로운 문자열을 삽입하여 결과를 얻음
        answer = answer.Insert(s, overwrite_string);                                
        return answer;                                                              //결괏값을 반환
    }
}