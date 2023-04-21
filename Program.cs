namespace Prog_226_S23_L6_Events
{
    internal class Program
    {
        // This is a how you delcare a delegate for methods that have
        // a return type of double, and take two double parameters
        public delegate double MyMathDelegate(double num1, double num2);
        static void Main(string[] args)
        {

            


        } // Main

        public static double Add(double num1, double num2)
        {
            return num1 + num2;
        } // Add

        public static void LambdaExample()
        {

        } // LambdaExample


        public static void FuncExample()
        {
            // Functions - Generate Delegate that let you define input and output
            // Func<TResult> that's not void
            Func<double, double, double> mathFun = Add;

            Console.WriteLine(mathFun(5, 1));

        } // FuncExample

        public static void PredicateExample()
        {
            // Predicate - Always returns a bool, and takes type of object to compare
            Predicate<int> compare = item => item > 5 && item < 10;

            List<int> _numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            // All lists have built in methods that help sort / search using predicates
            // Lambda
            List<int> result = _numbers.FindAll(item => item > 5 && item < 10);

            foreach (var item in result)
            {
                Console.WriteLine(item);
            }

            // Class routes
            // name
            // style
            // routes
            // List<Route> _routes = new List<Route>() // have all the routes
            // Display all areas that have over 1500 routes
            // List<Route routesAbove1500 = _routes.FindAll( s => s.Routes > 4500);


            //foreach (int item in _numbers)
            //{
            //    if (item > 5 && item < 10)
            //    {
            //        Console.WriteLine(item);
            //    }
            //}

        }

        public static void ActionExample()
        {
            // We can use premade delegates
            // Action<T> - Takes upto many parameters and returns void
            Action<string> displayInfo = DisplayStudentInfo;

            displayInfo("Soren");
            string instructor = "Will";

            displayInfo = DisplayTeacherName;
            displayInfo(instructor);

        }

        // Math Methods that has a return type of double, and takes two doubles

        public static void DisplayStudentInfo(string stringToDisplay)
        {
            Console.WriteLine("Student Name: " + stringToDisplay);
        }

        public static void DisplayTeacherName(string teachName)
        {
            Console.WriteLine("Teacher Name: " + teachName);

        }

    
        public static double Subtract(double num1, double num2)
        {
            return num1 - num2;
        }

        public static void DeclareDelegateExample()
        {
            // Delegates
            // Are variables that hold methods
            // If you have something with a method signature similar to a Delegate, you can assign a different method to it to be called
            // User my Delegate to how my method
            // Delegate Name  Variable Name = Method Name
            MyMathDelegate myMath = Add;
            Console.WriteLine(myMath(1, 2));

            myMath = Subtract;
            Console.WriteLine(myMath(1, 2));
            // Lambdas

        }


    }
}