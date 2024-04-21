namespace Lab6
{
    class Program
    {
        static Company[] initCompanies()
        {
            Company[] companies = new Company[3];
            companies[0] = new Factory("Ferrari", 3000, 999999, "Cars");
            companies[1] = new InsuranceCompany("TAC", 200, 100002, true);
            companies[2] = new OilGasCompany("Навтогаз України", 2100, 3222123, 99999);

            return companies;
        }

        static void Task1()
        {
            Company[] companies = initCompanies();
            Array.Sort(companies);

            Console.WriteLine("Sorted by: capital");
            for (int i = 0; i < companies.Length; i++)
            {
                companies[i].Show();
                Console.WriteLine();
            }
        }

        static Person[] initPersonDatabase()
        {
            Person[] persons = new Person[4];
            persons[0] = new Graduate("Pupkin", 2006, "MPUIK");
            persons[1] = new Student("Deresh", 2003, "MPUIK", 3);
            persons[2] = new Teacher("Lazoryk", 1965, "MPUIK", "Docent", 99);
            persons[3] = new Teacher("Fratavchan", 1965, "MPUIK", "Docent", 99);

            return persons;
        }

        static void Task2()
        {
            Person[] persons = initPersonDatabase();
            Array.Sort(persons);
            for (int i = 0; i < persons.Length; i++)
            {
                persons[i].Print();
                Console.WriteLine();
            }

            Console.WriteLine("Find by age range: \n >= ");
            int ageMin = int.Parse(Console.ReadLine());
            Console.WriteLine("Find by age range: \n <= ");
            int ageMax = int.Parse(Console.ReadLine());

            int cnt = 0;
            for (int i = 0; i < persons.Length; i++)
            {
                if (persons[i].Age >= ageMin && persons[i].Age <= ageMax)
                {
                    ++cnt;
                }
            }
            if (cnt != 0)
            {
                Person[] byAge = new Person[cnt];
                for (int i = 0, j = 0; i < persons.Length; i++)
                {
                    if (persons[i].Age >= ageMin && persons[i].Age <= ageMax)
                    {
                        byAge[j++] = persons[i];
                    }
                }
                Console.WriteLine("Found: ");
                for (int i = 0; i < byAge.Length; i++)
                {
                    Console.WriteLine("---------------------");
                    Console.WriteLine("{0}.", i);

                    byAge[i].Print();
                }
            }
            else
            {
                Console.WriteLine("Nothing found");
            }

        }

        static void Task3()
        {
            Person person1 = new Graduate("Baran", 2006, "MPUIK");
            Person person2 = new Student("Olump", 2003, "MPUIK", 3);
            foreach (Person person in Person.Persons)
            {
                Console.WriteLine();
                person.Print();
            }
        }



        static void Main(string[] args)
        {
            Console.WriteLine("Csharp #6 | Student: Faryna Yurii, 341b");

            Console.WriteLine("\n\n\tTask 1");
            Task1();

            Console.WriteLine("\n\n\tTask 2");
            Task2();

            Console.WriteLine("\n\n\tTask 3");
            Task3();
        }
    }

}