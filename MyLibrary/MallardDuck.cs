﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLibrary
{
    public class MallardDuck : Duck
    {
        public MallardDuck()
        {
            flyBehavior = new FlyWithWings();
            quackBehavior = new DQuack();
        }
    }
}