namespace Assignment03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Exercise01
            List<int> grades = new() { 85, 92, 78, 95, 88, 70, 100, 65 };
            foreach (int grade in grades)
            {
                Console.WriteLine(grade);
            }
            Console.WriteLine($"Count : {grades.Count}");
            Console.WriteLine($"First : {grades[0]} - Last : {grades[grades.Count - 1]}");
            grades.Sort();
            Console.WriteLine("==========After Sorting============");
            foreach (int grade in grades)
            {
                Console.WriteLine(grade);
            }
            Console.WriteLine("=========First Grade above 90===========");
            Console.WriteLine(grades.Find(x => x > 90));
            Console.WriteLine("============all grades below 75 (failing grades)=============");
            List<int> FailingGrades = grades.FindAll(x => x < 75);
            foreach (var item in FailingGrades)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("==========Remove all Failing Grades==========");
            grades.RemoveAll(x => x < 75);
            foreach (var item in grades)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine($"Count : {grades.Count}");
            Console.WriteLine("==========Any Grades = 100 ? ==========");
            Console.WriteLine(grades.Exists(x => x == 100));
            Console.WriteLine("===============String Grades================");
            List<string> Gradess = grades.ConvertAll(x => $"Grade : {x.ToString()}");
            foreach (var item in Gradess)
            {
                Console.WriteLine(item);
            }



            #endregion
        }
    }
} 