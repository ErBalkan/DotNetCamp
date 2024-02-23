using Intro.Business;
using Intro.DataAccess.Concrete;
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


CourseManager courseManager = new(new CourseDal());
List<Course> courses = courseManager.GetAll();

for (int i = 0; i < courses.Count; i++)
{
    System.Console.WriteLine(courses[i].Name + "/" + courses[i].Price);
}

IndividualCustomer customer1 = new();
customer1.Id = 1;
customer1.NationalIdentity= "12345678910";
customer1.FirstName = "Erhan";
customer1.LastName = "Balkan";
customer1.CustomerNumber = "123456";

IndividualCustomer customer2 = new();
customer2.Id = 2;
customer2.NationalIdentity= "12342476529";
customer2.FirstName = "Özgür";
customer2.LastName = "Atılgan";
customer2.CustomerNumber = "123457";

CorporateCustomer customer3 = new();
customer3.Id = 3;
customer3.Name = "Kodlamaio";
customer3.CustomerNumber = "112233";
customer3.TaxNumber = "11111111111";

CorporateCustomer customer4 = new();
customer4.Id = 4;
customer4.Name = "Abc";
customer4.CustomerNumber = "445566";
customer4.TaxNumber = "22222222222";
