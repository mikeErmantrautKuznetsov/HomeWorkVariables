using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    static void Main(string[] args)
    {
        // �������� ���������, ������� ����� ����������� �� ��� ���, ���� �� ����� ������� ����� exit.
        //�������, � ����� ������ ���� �������, ������� �������� �� ��, ����� ���� ������ �����������.
        //��� �����, ����� ����� ����������� �������� �� ��� ���, ����� ������ ������� ������ �����.
        int cicleContinion = 0;
        string codWordStart = "Start";
        Console.WriteLine("��� ������ ������ ���������, �������� Start");
        string endProgram = Console.ReadLine();
        string codWordEnd = "Exit";
        Console.WriteLine("������ �����! ��� ������ �������� Exit.");

        switch (endProgram)
        {
            case "Start":
                cicleForever(codWordStart, cicleContinion, codWordEnd);
                break;
        }

    }

    static void cicleForever(string codWordStart, int cicleContinion, string codWordEnd)
    {
        Console.WriteLine("����������� ����!");
        while (codWordStart != codWordEnd)
        {
            System.Threading.Thread.Sleep(2000);
            cicleContinion++;
            Console.WriteLine(cicleContinion);
            string endProgram = Console.ReadLine();

            if (endProgram == codWordEnd)
                Console.WriteLine("���� �������� ");
            break;
        }
    }
}
