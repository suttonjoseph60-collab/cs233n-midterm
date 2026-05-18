
using System;

namespace ProfessorClasses
{
    public class Professor
    {
        // Attributes
        private string lNumber;
        private string firstName;
        private string lastName;
        private string department;
        
        // Constructor
        public Professor(string lNumber, string firstName, string lastName, string department)
        {
            this.lNumber = lNumber;
            this.firstName = firstName;
            this.lastName = lastName;
            this.department = department;
        }

        // default constructor
        public Professor()
            {
            lNumber = "Unknown";
            firstName = "Unknown";
            lastName = "Unknown";
            department = "Unknown";
        }

        // Getters and Setters
        public string LNumber
        {
            get { return lNumber; }
            set { lNumber = value; }
        }
        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }
        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }
        public string Department
        {
            get { return department; }
            set { department = value; }
        }
        
        // ToString method
        public override string ToString()
        {
            return $"Professor: {firstName} {lastName}, LNumber: {lNumber}, Department: {department}";
        }
    }
}
