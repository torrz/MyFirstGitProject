﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstGitProject
{
    class Program
    {
        static void Main(string[] args)
        {
            var Tom = new Cat() { Id = 1, Name = "Tom",Extend="英短",Color="蓝色" };
            Console.WriteLine("修复一个bug");
            Console.WriteLine(Tom.ToString());
            Console.ReadLine();
        }
    }
}
