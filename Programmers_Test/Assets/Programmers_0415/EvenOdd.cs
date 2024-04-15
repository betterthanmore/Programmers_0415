using System;

public class EvenOdd
{
    public static void Main()
    {
        String[] s;                                     //입력된 문자열을 저장할 문자열 배열을 선언

        Console.Clear();                                //콘솔 초기화
        s = Console.ReadLine().Split(' ');              //콘솔에서 입력을 받고 공백을 기준으로 문자열을 나누며, 문자열 배열에 저장

        int a = Int32.Parse(s[0]);                      //문자열 배열의 첫 번째 요소를 정수형으로 변환
        if (a % 2 == 0)                                 //a를 2로 나누었을때 나머지가 0인지 판단, 짝수인지 홀수인지 검사 후 결과를 출력(if, else문 사용)
            Console.WriteLine($"{a} is even", a);
        else
            Console.WriteLine($"{a} is odd", a);
    }
}