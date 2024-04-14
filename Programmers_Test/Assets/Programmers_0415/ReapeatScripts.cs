using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;


public class ReapeatScripts : MonoBehaviour
{
    public static void Main()
    {
        string[] input;                             //입력을 받을 문자열 배열을 선언
        Console.Clear();                            //콘솔을 지움
        input = Console.ReadLine().Split(' ');      //콘솔에서 입력을 받고, 공백을 기준으로 분리하여 Input 배열에 저장

        string s1 = input[0];                       //입력 배열의 첫 번째 요소를 문자열 변수 s1에 저장
        int a = Int32.Parse(input[1]);              //입력 배열의 두 번째 요소를 정수형 변수 a에 저장

        for(int i = 0; i<a; i++)                    //a번 반복하여 s1에 저장된 문자열을 반복함
        {
            Console.Write(s1);                  //Console.Write에 s1 문자열을 집어넣고, 이를 for문 안에 집어넣으면서 해당 문자열을 반복하게 함
        }                                       //Console.WriteLine은 ()안의 내용을 출력 후, 줄을 바꿈

        //for (시작 값; 조건; 증가/감소)                    
        //{
            //반복 동작                  
        //}
    }


    
}
