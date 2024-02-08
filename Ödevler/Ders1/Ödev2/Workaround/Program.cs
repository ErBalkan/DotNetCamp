using Ödev2.Business.Concrete;
using Ödev2.Entities.Concrete;

Variables();

static void Variables()
{
    string message = "Selam";
    double price = 100000;
    int number = 100;
    bool isActive = false;

    Console.WriteLine(message);
    Console.WriteLine(price * 1.18);


    string ad = "Erhan";
    string soyad = "Balkan";
    int dogumYili = 1999;
    long tcNo = 11111111111;
}

Person person1 = new();
person1.FirstName = "Erhan";

Person person2 = new();
person2.FirstName = "Engin";

PttManager pttManager = new(new ForeignerManager());
pttManager.GiveMask(person1);