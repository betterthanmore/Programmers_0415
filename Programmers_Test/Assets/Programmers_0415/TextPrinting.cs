using System;

public class TextPrinting
{
    public static void Main()
    {
        String[] input;                                 //입력된 문자열을 저장할 문자열 배열을 선언

        Console.Clear();                                //콘솔 초기화
        input = Console.ReadLine().Split(' ');          //콘솔에서 입력을 받고 공백을 기준으로 문자열을 나눈 뒤 문자열 배열에 저장

        String s1 = input[0];                           //문자열 배열의 첫/두 번째 요소를 각각 변수에 저장
        String s2 = input[1];
        String output = s1 + s2.Replace(" ", "");       //s2에서 공백을 제거한 후, s1과 이어붙여 output에 저장

        Console.WriteLine(output);                      //결과를 출력

    }
}