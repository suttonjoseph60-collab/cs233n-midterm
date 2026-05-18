using System;
using ProfessorClasses;

namespace ProfessorTests
{
    class Program
    {
        static void Main(string[] args)
        {
            TestProfessorConstructor();
            TestProfessorToString();
            TestProfessorGetters();
            TestProfessorSetters();
        }

        static void TestProfessorConstructor()
        {
            Professor professor = new Professor("L12345", "Matt", "Flemmingson", "Building Stuff");
            Console.WriteLine("Testing Professor Constructor:");
            Console.WriteLine($"LNumber: {professor.LNumber}, FirstName: {professor.FirstName}, LastName: {professor.LastName}, Department: {professor.Department}");
        }

        static void TestProfessorToString()
        {
            Professor professor = new Professor("L00327638", "Dingle", "Doe", "Computer Science");
            Console.WriteLine("Testing Professor ToString:");
            Console.WriteLine(professor.ToString());
        }

        static void TestProfessorGetters()
        {
            Professor professor = new Professor("L00892376", "Mary", "Poppins", "Academy of Umbrella Flying");
            Console.WriteLine("Testing Professor Getters:");
            Console.WriteLine($"LNumber: {professor.LNumber}, FirstName: {professor.FirstName}, LastName: {professor.LastName}, Department: {professor.Department}");
        }

        static void TestProfessorSetters()
        {
            Professor professor = new Professor();
            professor.LNumber = "L00543219";
            professor.FirstName = "Jacob";
            professor.LastName = "Martin";
            professor.Department = "Mathematics";
            Console.WriteLine("Testing Professor Setters:");
            Console.WriteLine($"LNumber: {professor.LNumber}, FirstName: {professor.FirstName}, LastName: {professor.LastName}, Department: {professor.Department}");
        }
    }
}
