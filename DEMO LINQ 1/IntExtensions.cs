﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEMO_LINQ_1
{
    internal static class IntExtensions
    {

        public static int Reverse(this int Number)
        {
            int ReverseNumber = 0, Reminder;
            while (Number > 0)
            {
                Reminder = Number % 10;
                ReverseNumber = ReverseNumber * 10 + Reminder;
                Number = Number / 10;
            }
            return ReverseNumber;

        }
    }
}
