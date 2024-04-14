
using System;

public class UpperLower
{
    public static void Main()
    {
        String s;                                   //입력 문자열을 저장할 변수인 s 선언

        Console.Clear();                            //콘솔 화면을 지움
        s = Console.ReadLine();                     //사용자가 s에 입력한 값을 받음

        for(int i = 0; i<s.Length; i++)             //입력받은 문자열의 각 문자를 확인하고, 대문자->소문자/소문자->대문자로 변경하여 출력
        {
            if (char.IsLower(s[i]))                 //현재 문자가 소문자인지 확인
            {
                Console.Write(char.ToUpper(s[i]));  //소문자를 대문자로 변경하여 출력
            }
            else
            {
                Console.Write(char.ToLower(s[i]));  //대문자를 소문자로 변경하여 출력
            }
        }
    }
}
