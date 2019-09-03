using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//author @Jacob Schuller
namespace StudentGrade
{
    class StudentGrade
    {
        static void Main(string[] args)
        {

            string first; //assign inputs
            string last;
            double id;
            double hw;
            double part;
            double q;
            double mt;
            double f;
            const double partg = .1; //assign weights
            const double hwg = .25;
            const double qg = .1;
            const double mtg = .25;
            const double fg = .3;

            Console.WriteLine("What is your first name?"); //Ask user for name, id, and grades on components of class
            first = Console.ReadLine();

            Console.WriteLine("What is your last name?"); 
            last = Console.ReadLine();

            Console.WriteLine("What is your student id?");
            id = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("What is your overall percentage grade for homeworks?"); 
            hw = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("What is your overall percentage grade for participation?"); 
            part = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("What is your overall percentage grade for quizzes?");
            q = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("What is your overall percentage grade for midterm?");
            mt = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("What is your overall percentage grade for final?");
            f = Convert.ToDouble(Console.ReadLine());

            double cpgrade = part * partg; //calculate weighted points for each component of the class
            double hwgrade = hw * hwg;
            double qgrade = q * qg;
            double mtgrade = mt * mtg;
            double fgrade = f * fg;

            double overallgrade = cpgrade + hwgrade + qgrade + mtgrade + fgrade;

            string sentence = first + " " + last + " (" + id + "), your final grade is " + overallgrade.ToString("N2") + "%";
            Console.WriteLine(sentence);
            Console.WriteLine("Press any key to continue . . .");

            Console.ReadKey(); //Stopping Point
             













        }
    }
}
