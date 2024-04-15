using System;

public class ReturnString
{
    public static void Main()
    {
        String s;                       //입력될 문자열을 저장할 문자열 변수 저장

        Console.Clear();                //콘솔 초기화
        s = Console.ReadLine();         //콘솔에서 한 줄을 입력받아 문자열 변수에 저장

        foreach (char c in s)           //문자열을 순회하면서 각 문자를 한 줄씩 출력
            Console.WriteLine(c);       //출력

    }
}