using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using test;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            // creating a valid Test object
            // minOccurs = 0, maxOccurs = 2
            var test = new Test();
            test.El.Add("0123456789");
            test.El.Add("0123456789");

            var context = new ValidationContext(test);
            var errors = new List<ValidationResult>();
            Validator.TryValidateObject(test, context, errors, true);

            Console.WriteLine("Errors count: " + errors.Count);
            foreach (var error in errors)
            {
                Console.WriteLine(error.ErrorMessage);
            }

            Console.ReadKey();
        }
    }
}