﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayWithStudentApp
{
    class Student
    {
        public int regNo;
        public string firstName;
        public string lastName;

        public string GetFullName()
        {
            return firstName + " " + lastName;
        }
    }
}
