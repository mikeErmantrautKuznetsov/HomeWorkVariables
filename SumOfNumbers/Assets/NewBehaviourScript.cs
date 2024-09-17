using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    static void Main(string[] args)
    {
        // Написать программу, которая будет выполняться до тех пор, пока не будет введено слово exit.
        //Помните, в цикле должно быть условие, которое отвечает за то, когда цикл должен завершиться.
        //Это нужно, чтобы любой разработчик взглянув на ваш код, понял четкие границы вашего цикла.
        int cicleContinion = 0;
        string codWordStart = "Start";
        Console.WriteLine("Для начала работы программы, наберите Start");
        string endProgram = Console.ReadLine();
        string codWordEnd = "Exit";
        Console.WriteLine("Начала цикла! Для выхода наберите Exit.");

        switch (endProgram)
        {
            case "Start":
                cicleForever(codWordStart, cicleContinion, codWordEnd);
                break;
        }

    }

    static void cicleForever(string codWordStart, int cicleContinion, string codWordEnd)
    {
        Console.WriteLine("Безконечный цикл!");
        while (codWordStart != codWordEnd)
        {
            System.Threading.Thread.Sleep(2000);
            cicleContinion++;
            Console.WriteLine(cicleContinion);
            string endProgram = Console.ReadLine();

            if (endProgram == codWordEnd)
                Console.WriteLine("Цикл завершен ");
            break;
        }
    }
}
