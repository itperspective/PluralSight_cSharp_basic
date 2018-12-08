using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades
{
    class Program
    {
        static void Main(string[] args)
        {                   
           
            GradeBook book = new GradeBook();

            book.NameChanged += OnNameChaned;
            book.NameChanged += OnNameChaned2;
            book.NameChanged += OnNameChaned2;
            book.NameChanged -= OnNameChaned2;


            book.Name = "Scott's grade book";
            book.Name = "Grade book";
            book.Name = null;
            book.AddGrade(91);
            book.AddGrade(89.5f);
            book.AddGrade(75);



            GradeStatistics stats = book.ComputeStatistics();
            Console.WriteLine(book.Name);
            WriteResult("Avarage", stats.AvarageGrade);
            WriteResult("Highest", (int)stats.HighestGrade);
            WriteResult("Lowest", stats.LowestGrade);
            

        }

        static void OnNameChaned(string existingName, string newName)
        {
            Console.WriteLine($"Grade book changing name from {existingName} to {newName}");
        }

        static void OnNameChaned2(string existingName, string newName)
        {
            Console.WriteLine("***");
        }

        static void WriteResult(string description, int result)
        {
            Console.WriteLine(description + ": " + result);
        }

        static void WriteResult(string description, float result)
        {
            Console.WriteLine($"{description:F2}: {result}", description, result);
                
        }
    }
}
