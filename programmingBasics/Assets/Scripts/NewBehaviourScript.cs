using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    //    Переменные
    //Попрактикуйтесь в создании переменных, объявить 10 переменных разных типов.

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
        //        Легенда:

        //Вы заходите в поликлинику и видите огромную очередь из старушек, вам нужно рассчитать время ожидания в очереди.

        //Формально:
        //Пользователь вводит кол-во людей в очереди.
        //Фиксированное время приема одного человека всегда равно 10 минутам.
        //Пример ввода: Введите кол-во старушек: 14
        //Пример вывода: "Вы должны отстоять в очереди 2 часа и 20 минут."

        int timeWait = 10;
        int minutes = 60;
        Console.WriteLine("Введите количество старушек ");
        int grandMother = Convert.ToInt32(Console.ReadLine());
        int waitTimeQueueWaits = grandMother * timeWait;
        int waitTimeQueuehour = waitTimeQueueWaits / minutes;
        float waitTimeQueueMinutes = waitTimeQueueWaits % minutes;
        Console.WriteLine($"Вы должны отстоять в очереди " + (waitTimeQueuehour) + " часа " + (waitTimeQueueMinutes) + " минут ");
    }

    void experienceSecond()
    {
        //        Легенда:
        //            Вы приходите в магазин и хотите купить за своё золото кристаллы.
        //            В вашем кошельке есть какое - то количество золота, продавец спрашивает у вас, сколько кристаллов вы хотите купить?
        //            После сделки у вас остаётся какое - то количество золота и появляется какое - то количество кристаллов.

        //Формально:

        //            При старте программы пользователь вводит начальное количество золота.
        //            Потом ему предлагается купить какое - то количество кристаллов по цене N(задать в программе самому).
        //            Пользователь вводит число и его золото конвертируется в кристаллы. Остаток золота и кристаллов выводится на экран.

        int crystalsHave = 100;
        int priceCrystal = 50;

        Console.WriteLine("How much money do you have?");
        int money = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Здорово, рад тебя видеть! Ну чё, давай о деле поговорим? Сколько хабара?");
        int wantBuy = Convert.ToInt32(Console.ReadLine());
        int howManyBuy = wantBuy * priceCrystal;
        int howManyStayShop = crystalsHave - wantBuy;
        int buyCrystalPrice = money - howManyBuy;
        Console.WriteLine("Мне нужен реальный товар! Ты бы ещё консервных банок принес!");
        Console.WriteLine($"У Сидоровича осталось кристалов " + (howManyStayShop));
        Console.WriteLine($"Баланс кошелька " + (buyCrystalPrice));
        Console.WriteLine($"Баланс хабара " + (wantBuy));
    }

    void experienceThird()
    {
        //Даны две переменные.Поменять местами значения двух переменных.
        //Вывести на экран значения переменных до перестановки и после.
        //К примеру, есть две переменные имя и фамилия, они сразу
        //инициализированные, но данные не верные, перепутанные.
        //Вот эти данные и надо поменять местами через код.

        string firstName = "Dima ";
        string secondName = "Kit ";
        Console.WriteLine($"значения переменных до перестановки " + firstName + secondName);

        string thirdName = firstName;
        string fourthName = secondName;
        secondName = thirdName;
        firstName = fourthName;
        Console.WriteLine($"значения переменных после " + firstName + secondName);
    }

    void experienceFourth()
    {
        //На экране, в специальной зоне, выводятся картинки, по 3 в ряд(условно, ничего рисовать не надо). 
        //    Всего у пользователя в альбоме 52 картинки.Код должен вывести, 
        //    сколько полностью заполненных рядов можно будет вывести, и сколько картинок будет сверх меры.

        int image = 52;
        int cow = 3;
        int result;
        int resultSecond;

        result = image / cow;
        Console.WriteLine($"полностью заполненных рядов " + result);
        resultSecond = image % cow;
        Console.WriteLine($"сверх меры " + resultSecond);
    }

    void experienceFive()
    {
        //int a = 10;
        //int b = 38;
        //int c = (31 – 5 * a) / b;
        //Console.WriteLine(c);

        //Приоритет действий: умножение или деление выполняются раньше, чем сложение или вычитание.
        //При равном приоритете действия выполняются слева направо. Вывод: 2
    }

    void experienceSixth()
    {
        //Работа со строками


        Console.WriteLine("как вас зовут?");
        string namePerson = Console.ReadLine();
        Console.WriteLine("какой ваш знак зодиака?");
        string yourZodiacSign = Console.ReadLine();
        Console.WriteLine("Где вы работаете?");
        string placeJob = Console.ReadLine();
        Console.WriteLine("Сколько вам лет?");
        int howOldYou = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine($"Your name " + (namePerson) + " your Zodiac Sign " + (yourZodiacSign)
            + " place your job " + (placeJob) + " Your Old " + (howOldYou));
    }
}
