using System.Diagnostics.Metrics;

namespace Assignment03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Exercise01
            /*
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
            }*/



            #endregion
            #region Exercise02
            /*
            SortedList<int, string> Players = new()
            {   [500] = "Ahmed",
                [200] = "Sara",
                [800] = "Ali",
                [350] = "Mona"
            };
            Console.WriteLine("==========Print All Entries===========");
            foreach(var i in Players)
            {
                Console.WriteLine($"{i.Key} - {i.Value} ");
            }
            Console.WriteLine("==========Print First Key/Value");
            Console.WriteLine($"First key : {Players.Keys[0]} - First Value : {Players.Values[0]}");
            Console.WriteLine("============ if score 500 exists ? ============");
            Console.WriteLine(Players.ContainsKey(500));
            Console.WriteLine("===============The player with score 999==============");
            if (Players.TryGetValue(999, out string result))
            {
                Console.WriteLine($"Result : {result}");
            }
            else
            {
                Console.WriteLine("Not Found");
            }
            Console.WriteLine("===============Remove Score 200 and print the list updated=================");
            Players.Remove(200);
            foreach(var i in Players)
            {
                Console.WriteLine($"{i.Key} - {i.Value} ");
            }*/
            #endregion
            #region Exercise03
            /*Dictionary<string, string> PhoneBook = new()
            {
                ["Ali"]="01234",
                ["Ahmed"]="01256",
                ["Aya"]="01278",
                ["Mona"]="01291",
            };
            //Add Using [] -> Add if not added /updated if added 
            PhoneBook["Omar"] = "01111";
            //Handle The Exception With Try/Catch
            try
            {
                PhoneBook.Add("Ali", "5555");
            }
            catch 
            {
                Console.WriteLine($"Can't add with the same key !");
            }
            bool isAdded = PhoneBook.TryAdd("Ali", "6666");
            Console.WriteLine($"{((isAdded) ? "Add Successful": "Add Fail" )}");
            bool isExist = PhoneBook.ContainsKey("Mostafa");
            Console.WriteLine($"{((isExist) ? "Exist" : "Not Exist")}");
            Console.WriteLine(PhoneBook.GetValueOrDefault("Mohamed","NotFound"));
            int counter = 0;
            foreach(var x  in PhoneBook)
            {
                counter++;
                if (counter == PhoneBook.Count)
                {
                    Console.WriteLine($"{x.Key}");
                    counter = 0;
                    break;
                }
                Console.Write($"{x.Key} - ");
            }
            foreach(var x  in PhoneBook)
            {  counter++;
                if (counter == PhoneBook.Count)
                {
                    Console.Write($"{x.Value}");
                    break;
                }
                Console.Write($"{x.Value} - ");
            }*/
            #endregion
            #region Exercise04
            /*
            HashSet<string> Emails = new(StringComparer.OrdinalIgnoreCase);
            Emails.Add("ahmed@test.com");
            Emails.Add("AHMED@test.com");
            Emails.Add("sara@test.com");
            Emails.Add("Sara@Test.Com");
            Console.WriteLine($"Count : {Emails.Count}");
            foreach(string email in Emails)
            {
                Console.WriteLine(email);
            }
            //Printed Count = 2 because HashSet uses a case insensitive comparer and not allow duplicate elements
            HashSet<int> SetA = new() { 1,2,3,4,5};
            HashSet<int> SetB = new() {4,5,6,7,8};
            Console.WriteLine("==============Union -> All Elements without duplication===============");
            HashSet<int> Union = new(SetA);
            Union.UnionWith(SetB);   
            foreach(int i in Union)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("===============Intersect With -> Common elements================");
            HashSet<int> intersect= new(SetA);
            intersect.IntersectWith(SetB);
           foreach (int i in intersect)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("===============Except With -> elements in A except B ================");
            HashSet<int> Except= new(SetA);
            Except.ExceptWith(SetB);
            foreach ( var i in Except)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("===============IS Subset===============");
            HashSet<int> sub = new() { 1, 2 };
            Console.WriteLine(sub.IsSubsetOf(SetA));*/
            #endregion
            #region Exercise05
            /*
            Queue<string> Files = new();
            Files.Enqueue("Report.pdf");
            Files.Enqueue("Invoice.pdf");
            Files.Enqueue("Letter.docx");
            Files.Enqueue("Resume.pdf");
            Files.Enqueue("Photo.jpg");
            Console.WriteLine($"Count : {Files.Count}");
            foreach (var file in Files)
            {
                Console.WriteLine(file);
            }
            Console.WriteLine($"Next : {Files.Peek()}");
            while(Files.Count > 0)
            {
                Console.WriteLine($"Printing : {Files.Dequeue()}");
            }
            bool IsDequeued = Files.TryDequeue(out string result);
            Console.WriteLine(((IsDequeued ? $"Printing :{result} " : "Queue Empty")));
            */
            #endregion

        }
    }
} 