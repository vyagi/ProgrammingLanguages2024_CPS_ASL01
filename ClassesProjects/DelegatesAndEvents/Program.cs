//Homework - make the intergral class even more flexible,
//So that StartPoint, Endpoint, Number of midpoints is not hardcoded
//but you can set it "on the go"

namespace DelegatesAndEvents
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //IntegrableFunction del1 = MyFirstMethod;
            Func<double, double> del1 = MyFirstMethod;

            var integrator = new Integrator();
            Console.WriteLine(integrator.Integrate(del1));

            double cubic(double x) { return x * x * x; }

            del1 = cubic;
            Console.WriteLine(integrator.Integrate(del1));

            Console.WriteLine(integrator.Integrate(x => Math.Sin(x)));
        }

        public static double MyFirstMethod(double x) { return x * x; }
    }

    //Extending this class will be your homework, so couple of things 
    //I will do just temporarily

    //this old school way is not much used nowadays 
    //public delegate double IntegrableFunction(double x);
    //because we have Func and Action

    public class Integrator
    {
        public double StartingPoint { get; } = 0;
        public double EndingPoint { get; } = 1;
        public int Midpoints { get; } = 10;

        //public double Integrate(IntegrableFunction function)
        public double Integrate(Func<double, double> function)
        {
            //double square(double x)
            //{
            //    return x * x;
            //}

            var arguments = new double[Midpoints + 1];
            var values = new double[Midpoints + 1];

            var argumentStep = (EndingPoint - StartingPoint) / Midpoints;

            for (int i = 0; i <= Midpoints; i++)
            {
                arguments[i] = StartingPoint + i * argumentStep;
                values[i] = function(arguments[i]);
            }

            var sum = 0.0;

            for (int i = 0; i < Midpoints; i++)
            {
                sum += argumentStep * (values[i] + values[i+1]) / 2;
            }

            return sum;
        }
    }
}