﻿using System;

namespace class_study
{
    class Person
    {
        string _name;

        public Person(string name)
        {
            _name = name;
        }

        public void WriteName()
        {
            Console.WriteLine("Name: " + _name);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person("영희");
            person.WriteName();
        }
    }

}
