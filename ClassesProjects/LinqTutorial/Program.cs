List<int> numbers1 = new List<int> { 2, 5, 10, 12, 5, 1, 12, 2, 10, 11, 4 };

var bigNumbers = numbers1.Where(x => x > 10);

numbers1.Add(50);

foreach (var item in bigNumbers)
{
    Console.WriteLine(item);
}



var persons = new Person[] {
    new Person(1, "James", "Bond", 40, new [] { "Spying", "Women", "Cars" }),
    new Person(2, "Kirk", "Hammett", 50, new [] { "Guitar", "Comic books", "Horrors" }),
    new Person(3, "Ozzy", "Ozbourne", 70, new [] { "Guitar", "Singing", "Women", "Alcohol", "Drugs" }),
    new Person(4, "John", "Lennon", 66, new [] { "Guitar", "Singing", "Poetry" }),
    new Person(5, "Donald", "Trump", 80, new [] { "Money", "Women", "Power" }),
    new Person(6, "Donald", "Duck", 71, new [] { "Seed", "Quacking" }),
    new Person(7, "John", "Travolta", 33, new [] { "Singing", "Acting" }),
};
var addresses = new Address[] {
    new Address(1, 1, "London", "Baker street", TypeOfAddress.Home),
    new Address(2, 1, "Birmingham", "Aldrige St.", TypeOfAddress.Mail),
    new Address(3, 2, "San Francisco", "10 Avenue", TypeOfAddress.Home),
    new Address(4, 2, "San Francisco", "Roman Blvd", TypeOfAddress.Mail),
    new Address(5, 2, "Los Angeles", "Mulholland Drive", TypeOfAddress.Temporary),
    new Address(6, 2, "Los Angeles", "Beverly Hills 90210", TypeOfAddress.Temporary),
    new Address(100, -1, "Moon", "Dark side", TypeOfAddress.Home),
    new Address(100, -1, "Sun", "Gas", TypeOfAddress.Temporary),
};

//var byHobbies = persons.GroupBy(x => x.Hobbies.Length).OrderBy(x=>x.Key);

//foreach (var oneGroup in byHobbies)
//{
//    Console.WriteLine(oneGroup.Key);
//    foreach (var item in oneGroup)
//    {
//        Console.WriteLine(item.FirstName + " " + item.LastName);
//    }
//}

//var byAgeRanges = persons.GroupBy(x => x.Age / 10);

//foreach (var oneGroup in byAgeRanges)
//{
//    Console.WriteLine(oneGroup.Key * 10);
//    foreach (var item in oneGroup)
//    {
//        Console.WriteLine(item.FirstName + " " + item.LastName);
//    }
//}


enum TypeOfAddress { Home, Mail, Temporary }
record Person(int Id, string FirstName, string LastName, int Age, string[] Hobbies);
record Address(int Id, int PersonId, string City, string Street, TypeOfAddress AddressType);
record Book(int Id, string Title);
record Author(int Id, string Name);