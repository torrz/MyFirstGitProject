﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstGitProject
{
    public class Cat
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public string Color { get; set; }
        public override string ToString()
        {
            return "名字:" + Name + " 颜色" + Color;
        }
    }
}
