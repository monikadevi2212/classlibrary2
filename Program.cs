using System;

namespace ConsoleApp
{
    // Employee class definition
    class Employee
    {
        // Properties for Employee class
        public int Id { get; set; }  // Employee Id property
        public string FirstName { get; set; }  // Employee First Name property
        public string LastName { get; set; }  // Employee Last Name property

        // Overloading the "==" operator to compare two Employee objects by their Id
        public static bool operator ==(Employee emp1, Employee emp2)
        {
            // Check if the Id properties are the same
            if (emp1 == null || emp2 == null)
            {
                return false; // If either object is null, return false
            }
            return emp1.Id == emp2.Id; // Return true if Ids are equal
        }


        // See https://aka.ms/new-console-template for more information
        Console.WriteLine("Hello, World!");
