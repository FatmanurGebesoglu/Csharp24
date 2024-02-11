
//Console.WriteLine("Hello, World!");
// variables --> camelCase
using Intro.Business;
using Intro.Entities;

string message1 = "krediler";
int term = 12;
double amount = 100000.6;
bool isAuthenticated = false;


//condition

if (isAuthenticated==true)
{
    Console.WriteLine("Buton ---> Hoşgeldiniz");
}
else
{
    Console.WriteLine("Buton ---> Sisteme giriş yap");
}

string[] loans = { "kredi1", "kredi2", "kredi3", "kredi4", "kredi5", "kredi6"};
//string[] loans2 = new string[6];
//loans2[0] = "kredi1";


        //start    condition         increment
for (int i = 0;  i < loans.Length;  i++)
{
    Console.WriteLine(loans[i]);
}
Course course1 = new Course();
course1.Id = 1;
course1.Name = "c#";
course1.Description = ".Net8";
course1.Price = 0;

Course course2 = new Course();
course2.Id = 2;
course2.Name = "java";
course2.Description = "java 17";
course2.Price = 10;

Course course3 = new Course();
course3.Id = 3;
course3.Name = "python";
course3.Description = "python 3.5";
course3.Price = 20;

Course[] courses = { course1, course2, course3 };

for (int i = 0; i < courses.Length; i++)
{
    Console.WriteLine(courses[i].Name + "/" + courses[i].Price);
}

Console.WriteLine("*****************************************");

CourseManager courseManager = new();
courseManager.GetAll();

Course[] courses2 = courseManager.GetAll();

for (int i = 0; i < courses2.Length; i++)
{
    Console.WriteLine(courses2[i].Name + "/" + courses2[i].Price);
}

Console.WriteLine("kod bitti");

IndividualCustomer customer1 = new IndividualCustomer();
customer1.Id = 1;
customer1.NationalIdentity = "12345678921";
customer1.FirstName = "Aslı";
customer1.LastName = "Karayiğit";
customer1.CustomerNumber = "123456";

IndividualCustomer customer2 = new IndividualCustomer();
customer2.Id = 2;
customer2.NationalIdentity = "12345674561";
customer2.FirstName = "Özgür";
customer2.LastName = "Atılgan";
customer2.CustomerNumber = "123457";

CorporateCustomer customer3 = new CorporateCustomer();
customer3.Id = 3;
customer3.Name = "Kodlamaio";
customer3.CustomerNumber = "123433";
customer3.TaxNumber = "2345689011";

CorporateCustomer customer4 = new CorporateCustomer();
customer4.Id = 4;
customer4.Name = "Abc";
customer4.CustomerNumber = "123990";
customer4.TaxNumber = "2345689551";

int number1 = 10;
int number2 = 20;
number1 = number2;
number2 = 50;
Console.WriteLine(number1);

string[] cities1 = { "Ankara", "İstanbul", "İzmir" };
string[] cities2 = { "Bursa", "Bolu", "Diyarbakır" };

cities2=cities1;
cities1[0] = "Adana";

Console.WriteLine(cities2[0]);

//value types int bool double
// reference types array class interface

                                 //101      102       103          104
BaseCustomer[] customers = { customer1, customer2, customer3, customer4 };
//polymorphism
foreach(BaseCustomer customer in customers)
{
   
    Console.WriteLine(customer.CustomerNumber); 
}


