﻿using System;
using System.Collections.Generic;


namespace HashSetExample
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> candidates = new HashSet<string>();

            candidates.Add("John");
            candidates.Add("Amelie");
            candidates.Add("Tom");
            candidates.Add("Richard");
            candidates.Add("Barbara");
            candidates.Add("Susan");
            candidates.Add("Charles");
            candidates.Add("Daniel");
            candidates.Add("Tamara");
            candidates.Add("Donald");

            HashSet<string> hiring = new HashSet<string>();

            while (hiring.Count < 3)
            {
                string hire = Console.ReadLine(); hiring.Add(hire);
            }
            
            if (hiring.IsSubsetOf(candidates) == true) Console.Write("Starting hiring process");
            else Console.Write("Something is wrong");
        }
    }
}
