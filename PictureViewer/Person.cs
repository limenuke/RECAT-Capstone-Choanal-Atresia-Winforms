﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PictureViewer
{
    public class Person
    {
        // Field 
        public string name;

        // Constructor that takes no arguments. 
        public Person()
        {
            name = "unknown";
        }

        // Constructor that takes one argument. 
        public Person(string nm)
        {
            name = nm;
        }

        // Method 
        public void SetName(string newName)
        {
            name = newName;
        }
    }
    class TestPerson
    {
    }
}
