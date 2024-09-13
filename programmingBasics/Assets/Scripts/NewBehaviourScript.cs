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
        int grandMother = Convert.ToInt32(Console.ReadLine());
        int waitTimeQueueWaits = grandMother * timeWait;
        int waitTimeQueuehour = waitTimeQueueWaits / minutes;
        float waitTimeQueueMinutes = waitTimeQueueWaits % minutes;
        Console.WriteLine($"�� ������ �������� � ������� " + (waitTimeQueuehour) + " ���� " + (waitTimeQueueMinutes) + " ����� ");
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
        int money = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("�������, ��� ���� ������! �� ��, ����� � ���� ���������? ������� ������?");
        int wantBuy = Convert.ToInt32(Console.ReadLine());
        int howManyBuy = wantBuy * priceCrystal;
        int howManyStayShop = crystalsHave - wantBuy;
        int buyCrystalPrice = money - howManyBuy;
        Console.WriteLine("��� ����� �������� �����! �� �� ��� ���������� ����� ������!");
        Console.WriteLine($"� ���������� �������� ��������� " + (howManyStayShop));
        Console.WriteLine($"������ �������� " + (buyCrystalPrice));
        Console.WriteLine($"������ ������ " + (wantBuy));
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

        string thirdName = firstName;
        string fourthName = secondName;
        secondName = thirdName;
        firstName = fourthName;
        Console.WriteLine($"�������� ���������� ����� " + firstName + secondName);
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
        string namePerson = Console.ReadLine();
        Console.WriteLine("����� ��� ���� �������?");
        string yourZodiacSign = Console.ReadLine();
        Console.WriteLine("��� �� ���������?");
        string placeJob = Console.ReadLine();
        Console.WriteLine("������� ��� ���?");
        int howOldYou = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine($"Your name " + (namePerson) + " your Zodiac Sign " + (yourZodiacSign)
            + " place your job " + (placeJob) + " Your Old " + (howOldYou));
    }
}
