using Task02;

Person levan = new Person();
levan.Name = "Levani";
levan.LastName = "Lapachi";

Person giorgi = new Person();
giorgi.Name = "Giorgi";
giorgi.LastName = "Maisuradze";

Person elene = new Person();
elene.Name = "Elene";
elene.LastName = "Bendeliani";

Person mariam = new Person();
mariam.Name = "Mariam";
mariam.LastName = "Itchirali";

Person[] people = new Person [] {giorgi, mariam};

CustomList students = new CustomList();

Console.WriteLine(students.Count());

students[0] = levan;

Console.WriteLine(students[0].Name);

students.AddPerson(elene);


students.AddPerson(elene);

Console.WriteLine("break");

students.AddList(people);

Person[] people2 = new Person[4];
people2 = students.GetPersonList(0, 4);

foreach(Person i in people2)
{
    Console.WriteLine(i.LastName);
}

students.RemovePerson(levan);

Console.WriteLine("break");

students.RemovePeople(people);
people2 = students.GetPersonList(0, 1);

foreach (Person i in people2)
{
    Console.WriteLine(i.LastName);
}

Person search = new Person();
search = students.findPerson("elene");
Console.WriteLine(search.LastName);

Console.WriteLine(students[0].Name);

students.Clear();

Console.WriteLine(students.Count());