﻿using System;

namespace Ds_LInkedListOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            //uc-1
            Operations obj = new Operations();
            //Insertion Operation
            obj.InsertLast(56);
            obj.InsertLast(30);
            obj.InsertLast(70);
            //Display Operation
            Console.WriteLine("--------insertion at Last-------");
            obj.Display();
            // Console.WriteLine("Hello World!");
        }
    }
}
