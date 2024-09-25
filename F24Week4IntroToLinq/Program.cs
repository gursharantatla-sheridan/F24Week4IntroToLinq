namespace F24Week4IntroToLinq
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 5, 3, 7, 6, 8, 3, 2, 1, 6, 5, 4, 9, 8, 7 };


            // query syntax
            //var greaterThan3 = from num in array
            //                   where num > 3
            //                   orderby num
            //                   select num;

            // method syntax
            var greaterThan3 = array.Where(num => num > 3);

            foreach (var i in greaterThan3)
                Console.Write(i + " ");
            Console.WriteLine("\n\n");



            List<string> colors = new List<string>();
            colors.Add("bLuE");
            colors.Add("ruSt");
            colors.Add("GreEEn");
            colors.Add("ReD");

            var startsWithR = from c in colors
                              let uppercaseColors = c.ToUpper()
                              where uppercaseColors.StartsWith("R")
                              orderby uppercaseColors
                              select uppercaseColors;

            foreach (var i in startsWithR)
                Console.WriteLine(i);
            Console.WriteLine("\n\n");


            colors.Add("rUBy");
            colors.Add("PiNK");

            // deferred execution
            foreach (var i in startsWithR)
                Console.WriteLine(i);
            Console.WriteLine("\n\n\n\n");



            List<Employee> employees = new List<Employee>()
            {
                new Employee("John", "Green", 4000),
                new Employee("James", "Indigo", 5000),
                new Employee("Anne", "Indigo", 7000),
                new Employee("Walter", "White", 6000),
                new Employee("John", "Brown", 5500),
                new Employee("Katy", "Green", 3000)
            };


        }
    }
}
