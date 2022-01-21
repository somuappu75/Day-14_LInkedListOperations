﻿using System;

namespace Ds_LInkedListOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---------linked list operations---------");
            Console.WriteLine("\n1.insert last \n2.insert first \n3.insert middle \n4.Delete first \n5.Delete Last \n6.Search ");
            Console.WriteLine("Enter Your choice");
            int num = Convert.ToInt32(Console.ReadLine());
            Operations obj = new Operations();
            switch (num)
            {
                case 1:
                    obj.InsertLast(56);
                    obj.InsertLast(30);
                    obj.InsertLast(70);
                    obj.Display();
                    break;
                case 2:
                    obj.InsertFront(56);
                    obj.InsertFront(30);
                    obj.InsertFront(70);
                    obj.Display();
                    break;
                case 3:
                    obj.InsertLast(56);
                    obj.InsertLast(70);
                    obj.Insert_Between(2, 30);
                    obj.Display();
                    break;
                case 4:
                    obj.InsertFront(56);
                    obj.InsertFront(30);
                    obj.InsertFront(70);
                    obj.DeleteFirst();
                    obj.Display();
                    break;

                case 5:
                    obj.InsertLast(56);
                    obj.InsertLast(30);
                    obj.InsertLast(70);
                    obj.DeleteLast();
                    obj.Display();
                    break;
                case 6:
                    obj.InsertLast(56);
                    obj.InsertLast(30);
                    obj.InsertLast(70);
                    Console.WriteLine("-----------");
                    obj.Search(56);
                    break;


            }
            Console.ReadLine();


        }
    }
    }

