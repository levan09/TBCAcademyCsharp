using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task02
{
    public class Person
    {
        private string _name;
        private string _lastName;

        public string Name { get { return _name; } set { _name = value;} }
        public string LastName { get { return _lastName;} set { _lastName = value;} }
    }

    public class CustomList
    {
        private Person[]? _peopleList;

        public CustomList() 
        {
            _peopleList = new Person[0];       
        }

        public int Count()
        {
            return _peopleList.Length;
        }

        public Person this[int i]
        {
            get
            {
                return _peopleList[i];
            }
            set
            {
                if (i > _peopleList.Length)
                {
                    Console.WriteLine("Given index is out of bounds, choose between; 0 - " + _peopleList.Length);
                }
                else
                {
                    Array.Resize(ref _peopleList, _peopleList.Length + 1);
                    _peopleList[i] = value;
                }
            }
        }

        public void AddPerson(Person person)
        {
            Person search = _peopleList.FirstOrDefault(var => var == person);

            if (search == null)
            {
                Array.Resize(ref _peopleList, _peopleList.Length + 1);
                _peopleList[_peopleList.Length - 1] = person;
            }
            else
            {
                Console.WriteLine("Given person is already this list");
            }
        }

        public void AddList(Person[] people)
        {
            int j = _peopleList.Length;
            Array.Resize(ref _peopleList, _peopleList.Length + people.Length);

            for (int i = _peopleList.Length - people.Length; i < _peopleList.Length; i++) 
            {
                _peopleList[i] = people[i-j];
            }
        }

        public Person? GetPerson(int i)
        {
            if (i > _peopleList.Length)
            {
                Console.WriteLine("Given index is out of bounds, choose between; 0 - " + _peopleList.Length);
                return null;
            }
            else
            {
                return _peopleList[i];
            }
        }

        public Person[]? GetPersonList(int from, int count) 
        {
            if (from + count > _peopleList.Length)
            {
                Console.WriteLine("Given index is out of bounds, choose between; 0 - " + _peopleList.Length);
                return null;
            }
            else
            {
                Person[] people = new Person[count];
                for(int i = from; i < from + count; i++)
                {
                    people[i - from] = _peopleList[i];
                }
                return people;
            }
        }
        public void RemovePerson(Person person) 
        {
            Person search = _peopleList.FirstOrDefault(var => var == person);

            if (search == null)
            {
                Console.WriteLine("Given personi isn't in this list");
            }
            else
            {
                _peopleList = _peopleList.Where(var => var != person).ToArray();
            }
        }

        public void RemovePeople(Person[] people)
        {
            foreach (Person person in people)
            {
                _peopleList = _peopleList.Where(var => var != person).ToArray();
            }
        }

        public void Clear() 
        {
            Array.Clear(_peopleList);
        }

        public Person findPerson(string name)
        {
            Person search = _peopleList.FirstOrDefault(var => var.Name == name);
            if (search == null)
            {
                Console.WriteLine("Given book isn't in this library");
                return search;
            }
            else
            {
                return search;
            }
        }
    }
}
