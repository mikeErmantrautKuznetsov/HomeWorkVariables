using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript2 : MonoBehaviour
{
    static void Main(string[] args)
    {
        //��� ������ ������ �� ������ ��������� ���� � ��� �� ��� ��������� ���.
        //�������� ���������� ���������, ������� ������� ���������(�������������)
        //������������� ��������� �������� ���������� ���.
        //���������� �������� ����� ������ ������ ������������.

        Console.WriteLine("������ ���������: ");
        string messageRepeat = Console.ReadLine();
        Console.WriteLine("������� ����� ���������? ");
        int repeatMany = Convert.ToInt32(Console.ReadLine());
        int startPosition = 0;

        //���� �������

        //for (int i = 0; i < repeatMany; i++)
        //{
        //    Console.WriteLine(messageRepeat);
        //}

        //������ ������� 

        while (startPosition < repeatMany)
        {
            Console.WriteLine(messageRepeat);
            startPosition++;
            if (startPosition == repeatMany)
                break;
        }

        foreach (var item in messageRepeat)
        {
            if (startPosition == repeatMany)
                Console.WriteLine($"��������� �������� " + repeatMany);
            break;
        }
    }
}
