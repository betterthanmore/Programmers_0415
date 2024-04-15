using System;

public class Example
{
    public static void Main()
    {
        string s = "!@#$%^&*(" + "\\" + "\'" + "\"" + "<>?:;";          //+기호는 제외해도 무방함, 특수문자들을 string s 에 집어넣어 Console.WriteLine(s)로 출력
        Console.WriteLine(s);
    }
}