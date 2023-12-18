using System;

namespace SingleResponsibility
{
    public class Student
    {
        private string firstName;

        private string lastName;

        private int motivation;

        private int skill;

        public Student(string firstName, string lastName, int motivation, int skill)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.motivation = motivation;
            this.skill = skill;
        }

        public void DoAssignment(Assignment assignment)
        {
            Console.WriteLine($"Doing assignment {assignment.Name} worth {assignment.Points} points.");
            assignment.TurnIn(this.motivation, this.skill);
        }

        public void GoToClass()
        {
            Console.WriteLine("Going to class.");
        }

        public void TakeBreak()
        {
            Console.WriteLine("Taking a break.");
        }
    }
}