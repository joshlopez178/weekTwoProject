//Joshua Lopez  
//COSC 1320 001
//9-8-2019
//Week 2 project

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace weekTwoProject
{
    class Program
    {
        static void Main(string[] args)
        {

            object[] listOfGrades = new object[10];

            listOfGrades[0] = 67;
            listOfGrades[1] = 77;
            listOfGrades[2] = 83;
            listOfGrades[3] = 94;
            listOfGrades[4] = 73;
            listOfGrades[5] = 92;
            listOfGrades[6] = 89;
            listOfGrades[7] = 55;
            listOfGrades[8] = 98;
            listOfGrades[9] = 78;

            Array.Sort(listOfGrades);
            Array.Reverse(listOfGrades);

            double gradeAverage = 80.66;
            foreach (int grade in listOfGrades)
            {
                Console.WriteLine(grade.ToString());
      
            }
            Console.WriteLine("Press the SpaceBar to display grade point average..");
            Console.ReadKey();

            Console.WriteLine(gradeAverage.ToString());

        }

    }
}
