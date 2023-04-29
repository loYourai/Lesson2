using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



   

        /* -6*x^3+5*x^2-10*x+15
  
 
string a = Console.ReadLine();

int x = Convert.ToInt32(a);

Console.WriteLine( -6 * x ^ 3 + 5 * x ^ 2 - 10 * x + 15);


string a = Console.ReadLine();

long x = Convert.ToInt32(a);
Console.WriteLine(-6 * x ^ 3 + 5 * x ^ 2 - 10 * x + 15);
*/




        /*
              2*pi*x 

        string a = Console.ReadLine();

        long x = Convert.ToInt32(a);
        double d = Math.PI;

        Console.WriteLine(2 * d * x);
        */



        //    max(x, y)

        /*
        string a = Console.ReadLine();

        long x = Convert.ToInt32(a);

        x = long.MaxValue;
        Console.WriteLine(x);

        string b = Console.ReadLine();

        int y = Convert.ToInt32(b);

        y = int.MaxValue;
        Console.WriteLine(y);
        */





        // до/после нового гота
        /*

        Console.WriteLine("До Нового года осталось:");
        var today = DateTime.Today;
        var newYear = new DateTime(today.Year + 0, 12, 31);
        var days = (newYear - today).TotalDays;
        Console.WriteLine("{0} дней.", days);
        */
        Console.WriteLine("после нового года пошло:");
        var today = DateTime.Today;
        var oldYear = new DateTime(today.Year - 0, 1, 1);
        var days = (today - oldYear).TotalDays;
        Console.WriteLine("{0} дней.", days);
    

