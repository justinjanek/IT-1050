using System;
namespace Section3Practice
{
    public class SecurityPolicy
    {
        public string fromZone;
        public string toZone;
        public string protocol;
        public double dstPort;
        public bool action;
        public double srcIP;
        public double dstIP;

        public void GetPolicyAttributes()
        {
            Console.WriteLine("What is the from-zone?");
            this.fromZone = Console.ReadLine();

            Console.WriteLine("What is the to-zone?");
            this.toZone = Console.ReadLine();
        }

        public string GetPolicyLine1()
        {
            string line = "set security policies from-zone ";
            line += this.fromZone;
            line += " to-zone ";
            line += this.toZone;

            return line;
        }

    }
}
