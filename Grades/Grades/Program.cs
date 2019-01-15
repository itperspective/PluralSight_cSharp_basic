﻿using System;
using System.Collections.Generic;
using System.IO;
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

            GetBookName(book);
            AddingGrades(book);
            SaveGrades(book);
            WriteResults(book);

        }

        private static void WriteResults(GradeBook book)
        {
            GradeStatistics stats = book.ComputeStatistics();

            WriteResult("Avarage", stats.AvarageGrade);
            WriteResult("Highest", stats.HighestGrade);
            WriteResult("Lowest", stats.LowestGrade);
            WriteResult(stats.Description, stats.LetterGrade);
        }

        private static void SaveGrades(GradeBook book)
        {
            using (StreamWriter outputFile = File.CreateText("grades.txt"))
            {
                book.WriteGrades(outputFile);
            }
        }

        private static void AddingGrades(GradeBook book)
        {
            book.AddGrade(91);
            book.AddGrade(89.5f);
            book.AddGrade(75);
        }

        private static void GetBookName(GradeBook book)
        {
            try
            {
                Console.WriteLine("Plz enter a name");
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
