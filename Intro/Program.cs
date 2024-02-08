using Intro.Business;
using Intro.Entities;

Console.WriteLine("Hello, World!");

// Variables --> camelCase
string message1 = "Krediler";
int term = 12;
double amount = 100000;
bool isAuthenticated = true;

// Condition
if (isAuthenticated)
{
    System.Console.WriteLine("Buton-->Hoşgeldin Erhan");    
}else{
    System.Console.WriteLine("Buton-->Sisteme giriş yap");
}

System.Console.WriteLine("Kod bitti.");

string[] loans = ["Kredi 1","Kredi 2","Kredi 3","Kredi 4","Kredi 5","Kredi 6",];

for (int i = 0; i < loans.Length; i++)
{
    System.Console.WriteLine(loans[i]);
}


CourseManager courseManager = new();
Course[] courses = courseManager.GetAll();

for (int i = 0; i < courses.Length; i++)
{
    System.Console.WriteLine(courses[i].Name + "/" + courses[i].Price);
}