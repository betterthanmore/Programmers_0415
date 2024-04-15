using System;

public class PlusAddition
{
    public static void Main()
    {
        String[] s;                                 //입력된 문자열을 저장할 문자열 배열을 선언

        Console.Clear();                            //콘솔 초기화
        s = Console.ReadLine().Split(' ');          //콘솔에서 입력을 받고 공백을 기준으로 문자열을 나눔, 그리고 문자열 배열에 저장

        int a = Int32.Parse(s[0]);                  //문자열 배열의 첫 번째 요소를 정수로 변환하여 변수에 저장
        int b = Int32.Parse(s[1]);                  //문자열 배열의 두 번째 요소를 정수로 변환하여 변수에 저장
                                                    //s[0]은 사용자가 입력한 문자열 배열의 첫 번째 요소를 가리킴, 사용자가 입력한 숫자를 정수형으로 변환 후 변수 a, b에 저장

        Console.WriteLine(a + " + " + b + " = " + "{0}", a + b);            //두 정수의 합을 출력
    }
}