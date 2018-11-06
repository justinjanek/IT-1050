using System;

namespace Section3Practice
{
    class Program
    {
        static void Main(string[] args)
        {
        
            SecurityPolicy policy1 = new SecurityPolicy();

            policy1.GetPolicyAttributes();

            Console.WriteLine(policy1.GetPolicyLine1());

            Console.ReadKey();

        }
    }
}
