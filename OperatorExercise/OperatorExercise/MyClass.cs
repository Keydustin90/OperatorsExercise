using System;
namespace OperatorExercise
{
    public class MyClass
    {
        static viold Main(string [] args)
        {
            var a = 17;
            var b = 4;

            var div = a / b;
            var mod = a % b;

            Console.WriteLine($"{a}/{b} is {div}remainder {mod}");

            var r = 20;
            var pi = Math.PI;

            var areaOfCircle = pi * (r * r);

            Console.WriteLine($"The area of a circle with radius of {r} is {areaOfCircle}";
        }
    }
}
