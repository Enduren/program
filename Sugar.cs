using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoloLearn
{
    class Sugar
    {
        static void Main(string[] args)
        {
            int answer = 4;
            string response;

            if (answer < 9)
            {
                response = answer + " is less than nine";
            }
            else
            {
                response = answer + "greater than or equal to nine";
            }
            Console.WriteLine(response);
        }
    }