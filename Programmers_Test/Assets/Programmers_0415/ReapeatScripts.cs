using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;


public class ReapeatScripts : MonoBehaviour
{
    public static void Main()
    {
        string[] input;                             //�Է��� ���� ���ڿ� �迭�� ����
        Console.Clear();                            //�ܼ��� ����
        input = Console.ReadLine().Split(' ');      //�ֿܼ��� �Է��� �ް�, ������ �������� �и��Ͽ� Input �迭�� ����

        string s1 = input[0];                       //�Է� �迭�� ù ��° ��Ҹ� ���ڿ� ���� s1�� ����
        int a = Int32.Parse(input[1]);              //�Է� �迭�� �� ��° ��Ҹ� ������ ���� a�� ����

        for(int i = 0; i<a; i++)                    //a�� �ݺ��Ͽ� s1�� ����� ���ڿ��� �ݺ���
        {
            Console.Write(s1);                  //Console.Write�� s1 ���ڿ��� ����ְ�, �̸� for�� �ȿ� ��������鼭 �ش� ���ڿ��� �ݺ��ϰ� ��
        }                                       //Console.WriteLine�� ()���� ������ ��� ��, ���� �ٲ�

        //for (���� ��; ����; ����/����)                    
        //{
            //�ݺ� ����                  
        //}
    }


    
}
