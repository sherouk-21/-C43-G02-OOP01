namespace Assignment_C43_G02_OOP01
{
    enum WeekDays
    {
        Monday, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday
    }
    enum Season
    {
        Spring, Summer, Autumn, Winter
    }
    enum Permissions
    {
        None = 0, Read, Write, Delete, Execute
    }

    enum Colors
    {
        Red, Green, Blue
    }


    struct Point
    {
        public double X { get; set; }
        public double Y { get; set; }

        public Point(double x, double y)
        {
            X = x;
            Y = y;
        }

        public double DistanceTo(Point other)
        {
            return Math.Sqrt(Math.Pow(other.X - X, 2) + Math.Pow(other.Y - Y, 2));
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            #region QUESTION 1
            Console.WriteLine("Days of the Week:");
            foreach (string day in Enum.GetNames(typeof(WeekDays)))
            {
                Console.WriteLine(day);
            }
            #endregion

            #region Question2

            Console.WriteLine("Enter a season (Spring, Summer, Autumn, Winter):");
            string seasonInput = Console.ReadLine();
            if (Enum.TryParse(seasonInput, true, out Season season))
            {
                switch (season)
                {
                    case Season.Spring:
                        Console.WriteLine("Spring: March to May");
                        break;
                    case Season.Summer:
                        Console.WriteLine("Summer: June to August");
                        break;
                    case Season.Autumn:
                        Console.WriteLine("Autumn: September to November");
                        break;
                    case Season.Winter:
                        Console.WriteLine("Winter: December to February");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Invalid season entered.");
            }

            #endregion

            #region Question3
            Permissions userPermissions = Permissions.None;

            Console.WriteLine("Adding and Removing Permissions:");
            userPermissions |= Permissions.Read;
            userPermissions |= Permissions.Write;
            Console.WriteLine($"Current Permissions: {userPermissions}");

            Console.WriteLine($"Has Read Permission: {userPermissions.HasFlag(Permissions.Read)}");
            Console.WriteLine("Removing Write Permission...");
            userPermissions &= ~Permissions.Write;
            Console.WriteLine($"Current Permissions: {userPermissions}");

            #endregion

            #region Question 4
            Console.WriteLine("Enter a color :");
            string colorInput = Console.ReadLine();
            if (Enum.TryParse(colorInput, true, out Colors color))
            {
                Console.WriteLine($"{color} is a primary color.");
            }
            else
            {
                Console.WriteLine($"{colorInput} is not a primary color.");
            }
            #endregion

            #region Question5

            Console.WriteLine("Enter the coordinates of the first point (X1 , Y1):");
            string[] point1Input = Console.ReadLine().Split();
            Point p1 = new Point(double.Parse(point1Input[0]), double.Parse(point1Input[1]));

            Console.WriteLine("Enter the coordinates of the second point (X2 , Y2):");
            string[] point2Input = Console.ReadLine().Split();
            Point p2 = new Point(double.Parse(point2Input[0]), double.Parse(point2Input[1]));

            Console.WriteLine($"Distance between points: {p1.DistanceTo(p2)}");
            #endregion



        }
    }
}
