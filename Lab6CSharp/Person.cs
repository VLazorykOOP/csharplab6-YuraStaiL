using System.Collections;

namespace Lab6
{
    abstract class Person : IPerson, IEnumerable<Person>
    {
        protected int birthdate;
        protected string name;
        public int Age { get => DateTime.Now.Year - birthdate; }

        private static List<Person> persons = [];
        public static List<Person> Persons { get => persons; }

        static int index = -1;

        public Person(string name, int birthdate)
        {
            this.name = name;
            this.birthdate = birthdate;
            persons.Add(this);
        }

        public virtual void Print()
        {
            Console.WriteLine("Class: {0}\nName: {1}\nBirthdate: {2}\nAge: {3}", GetType().Name, name, birthdate, Age);
        }

        public int CompareTo(object? obj)
        {
            if (obj is Person person) return (int)(this.Age - person.Age);
            else throw new ArgumentException("Incorrent parameter value");
        }

        public IEnumerator<Person> GetEnumerator()
        {
            return persons.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
