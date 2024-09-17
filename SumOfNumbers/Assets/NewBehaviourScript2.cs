using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript2 : MonoBehaviour
{
    static void Main(string[] args)
    {
        //При помощи циклов вы можете повторять один и тот же код множество раз.
        //Напишите простейшую программу, которая выводит указанное(установленное)
        //пользователем сообщение заданное количество раз.
        //Количество повторов также должен ввести пользователь.

        Console.WriteLine("Ведите сообщение: ");
        string messageRepeat = Console.ReadLine();
        Console.WriteLine("Сколько нужно повторить? ");
        int repeatMany = Convert.ToInt32(Console.ReadLine());
        int startPosition = 0;

        //один вариант

        //for (int i = 0; i < repeatMany; i++)
        //{
        //    Console.WriteLine(messageRepeat);
        //}

        //второй вариант 

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
                Console.WriteLine($"Сообщение вывелось " + repeatMany);
            break;
        }
    }
}
