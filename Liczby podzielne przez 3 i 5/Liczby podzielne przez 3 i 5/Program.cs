﻿using System;

public class Program
{
    public static void Main(string[] args)
    {
        for (int i = 1; i <= 100; i++)
        {
            if ( (i % 3 == 0) || (i % 5 == 0) )
            {
                Console.WriteLine(i);
                Console.ReadLine();
            }
        }
    }
}
