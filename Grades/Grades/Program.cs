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
            Console.WriteLine("Plz enter a name");
            try
            {
                book.Name = Console.ReadLine();
            }

            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }

            catch (Exception ex)
            {
                Console.WriteLine("Something went wrong");
            }
                
            

            book.AddGrade(91);
            book.AddGrade(89.5f);
            book.AddGrade(75);
            book.WriteGrades(Console.Out);


            GradeStatistics stats = book.ComputeStatistics();
            
            WriteResult("Avarage", stats.AvarageGrade);
            WriteResult("Highest", stats.HighestGrade);
            WriteResult("Lowest", stats.LowestGrade);
            WriteResult(stats.Description, stats.LetterGrade);
            

        }

        static void WriteResult(string description, string result)
        {
            Console.WriteLine($"{description}: {result}", description, result);

        }

        static void WriteResult(string description, float result)
        {
            Console.WriteLine($"{description:F2}: {result}", description, result);
                
        }
    }
}
