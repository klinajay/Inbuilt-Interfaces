﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inbuilt_Interfaces
{
    internal class Student :  IComparable
    {
        public string studentName;
        public int percentage;
        public int age;

        public Student(string studentName, int percentage, int age)
        {
            this.studentName = studentName;
            this.percentage = percentage;
            this.age = age;
        }
        public int CompareTo(Object other)
        {
            var otherRecord = (Student) other;
            if (otherRecord.percentage > this.percentage) {
                return 1;
            }
            else if (otherRecord.percentage < this.percentage)
            {
                return -1;
            }
            else
            {
                return 0;
            }

        }
    }
}
