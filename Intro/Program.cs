
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



