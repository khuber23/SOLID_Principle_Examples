using System;
using System.Collections.Generic;
using System.Text;

namespace SingleResponsibility
{
    public class Assignment
    {
        private string name;
        private int points;

        public Assignment(string name, int points)
        {
            this.name = name;
            this.points = points;
        }

        public string Name
        {
            get { return name; }
        }
        public int Points
        {
            get { return points; }
        }

        public void TurnIn(int motivation, int skill) 
        {
            double motivationPoints = this.Points * motivation / 100;
            double skillPoints = this.Points * skill / 100;
            double totalPoints = (motivationPoints + skillPoints) / 2;

            Console.WriteLine($"Received {totalPoints} out of {this.Points}.");
        }

    }
}
