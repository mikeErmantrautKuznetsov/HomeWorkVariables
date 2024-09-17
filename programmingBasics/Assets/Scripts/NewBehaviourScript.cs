using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    //    ����������
    //��������������� � �������� ����������, �������� 10 ���������� ������ �����.

    private int intVariable = int.MaxValue;
    protected float floatVariable = float.MaxValue;
    public double doubleVariable = double.MaxValue;
    private short shortVariable = short.MaxValue;
    protected ulong ulongVariable = ulong.MaxValue;
    protected long longVariable = long.MaxValue;
    public bool boolVariable = true;
    private ushort ushortVariable = ushort.MaxValue;
    private sbyte sbyteVariable = sbyte.MaxValue;
    private uint uintVariable = uint.MaxValue;

    void experience()
    {
        //        �������:

        //�� �������� � ����������� � ������ �������� ������� �� ��������, ��� ����� ���������� ����� �������� � �������.

        //���������:
        //������������ ������ ���-�� ����� � �������.
        //������������� ����� ������ ������ �������� ������ ����� 10 �������.
        //������ �����: ������� ���-�� ��������: 14
        //������ ������: "�� ������ �������� � ������� 2 ���� � 20 �����."

        int timeWait = 10;
        int minutes = 60;
        Console.WriteLine("������� ���������� �������� ");
        string clientHospital = Console.ReadLine();
        if (int.TryParse(clientHospital, out int grandMother))
        {
            hospitalGrandmother(timeWait, minutes, grandMother);
        }
        else
        {
            Console.WriteLine("����� �� ��������? ���� ����������! ��� ��������!");
            Console.ReadKey();
        }

        static void hospitalGrandmother(int timeWait, int minutes, int grandMother)
        {
            int waitTimeQueueWaits = grandMother * timeWait;
            int waitTimeQueuehour = waitTimeQueueWaits / minutes;
            float waitTimeQueueMinutes = waitTimeQueueWaits % minutes;
            Console.WriteLine($"�� ������ �������� � ������� " + (waitTimeQueuehour) + " ���� " + (waitTimeQueueMinutes) + " ����� ");
        }
    }

    void experienceSecond()
    {
        //        �������:
        //            �� ��������� � ������� � ������ ������ �� ��� ������ ���������.
        //            � ����� �������� ���� ����� - �� ���������� ������, �������� ���������� � ���, ������� ���������� �� ������ ������?
        //            ����� ������ � ��� ������� ����� - �� ���������� ������ � ���������� ����� - �� ���������� ����������.

        //���������:

        //            ��� ������ ��������� ������������ ������ ��������� ���������� ������.
        //            ����� ��� ������������ ������ ����� - �� ���������� ���������� �� ���� N(������ � ��������� ������).
        //            ������������ ������ ����� � ��� ������ �������������� � ���������. ������� ������ � ���������� ��������� �� �����.

        int crystalsHave = 100;
        int priceCrystal = 50;

        Console.WriteLine("How much money do you have?");
        string money = Console.ReadLine();
        if (int.TryParse(money, out int moneyBuyCrystal))
        {
            Console.WriteLine("�������, ��� ���� ������! �� ��, ����� � ���� ���������? ������� ������?");
        }
        else
        {
            Console.ReadKey();
        }
        string wantBuy = Console.ReadLine();
        if (int.TryParse(wantBuy, out int wantBuyCrystal))
        {
            int howManyBuy = wantBuyCrystal * priceCrystal;
            int howManyStayShop = crystalsHave - wantBuyCrystal;
            int buyCrystalPrice = moneyBuyCrystal - howManyBuy;
            Console.WriteLine("��� ����� �������� �����! �� �� ��� ���������� ����� ������!");
            Console.WriteLine($"� ���������� �������� ��������� " + (howManyStayShop));
            Console.WriteLine($"������ �������� " + (buyCrystalPrice));
            Console.WriteLine($"������ ������ " + (wantBuy));
        }
        else
        {
            Console.WriteLine("�������, � ����� ��������!");
        }
    }

    void experienceThird()
    {
        //���� ��� ����������.�������� ������� �������� ���� ����������.
        //������� �� ����� �������� ���������� �� ������������ � �����.
        //� �������, ���� ��� ���������� ��� � �������, ��� �����
        //������������������, �� ������ �� ������, ������������.
        //��� ��� ������ � ���� �������� ������� ����� ���.

        string firstName = "Dima ";
        string secondName = "Kit ";
        Console.WriteLine($"�������� ���������� �� ������������ " + firstName + secondName);

        string thirdName = secondName;
        secondName = firstName;
        Console.WriteLine($"�������� ���������� ����� " + thirdName + secondName);
    }

    void experienceFourth()
    {
        //�� ������, � ����������� ����, ��������� ��������, �� 3 � ���(�������, ������ �������� �� ����). 
        //    ����� � ������������ � ������� 52 ��������.��� ������ �������, 
        //    ������� ��������� ����������� ����� ����� ����� �������, � ������� �������� ����� ����� ����.

        int image = 52;
        int cow = 3;
        int result;
        int resultSecond;

        result = image / cow;
        Console.WriteLine($"��������� ����������� ����� " + result);
        resultSecond = image % cow;
        Console.WriteLine($"����� ���� " + resultSecond);
    }

    void experienceFive()
    {
        //int a = 10;
        //int b = 38;
        //int c = (31 � 5 * a) / b;
        //Console.WriteLine(c);

        //��������� ��������: ��������� ��� ������� ����������� ������, ��� �������� ��� ���������.
        //��� ������ ���������� �������� ����������� ����� �������. �����: 2
    }

    void experienceSixth()
    {
        //������ �� ��������


        Console.WriteLine("��� ��� �����?");
        string? namePerson = Console.ReadLine();
        StringIsDigits(namePerson);
        Console.WriteLine("����� ��� ���� �������?");
        string? yourZodiacSign = Console.ReadLine();
        StringIsDigits(yourZodiacSign);
        Console.WriteLine("��� �� ���������?");
        string? placeJob = Console.ReadLine();
        StringIsDigits(placeJob);
        Console.WriteLine("������� ��� ���?");
        string howOldYou = Console.ReadLine();
        if (int.TryParse(howOldYou, out int OldYou))
        {
            Console.WriteLine($"Your name " + (namePerson) + " your Zodiac Sign " + (yourZodiacSign)
                + " place your job " + (placeJob) + " Your Old " + (OldYou));
        }
        else
        {
            Console.WriteLine("����������� ������. ��������� ����");
        }

        static bool StringIsDigits(string s)
        {
            foreach (var item in s)
            {
                if (!char.IsDigit(item))
                    return false;
                Console.WriteLine("������������ ����");
                Environment.Exit(item);
            }
            return true;
        }
    }
}
