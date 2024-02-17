// See https://aka.ms/new-console-template for more information

using Intro.Business;
using Intro.Entities;

IndividualCustomer customer1 = new IndividualCustomer();
customer1.Id = 1;
customer1.NationalIdentity = "12345678910";
customer1.FirstName = "TestFirstName";
customer1.LastName = "TestSurname";
customer1.CustomerNumber = "123456";

IndividualCustomer customer2 = new IndividualCustomer();
customer2.Id = 2;
customer2.NationalIdentity = "98765432110";
customer2.FirstName = "TestFirstName2";
customer2.LastName = "TestSurname2";
customer2.CustomerNumber = "123457";

CorporateCustomer customer3 = new CorporateCustomer();
customer3.Id = 3;
customer3.CompanyName = "Kodlamaio";
customer3.CustomerNumber = "654778";
customer3.TaxNumber = "12345678987";

CorporateCustomer customer4 = new CorporateCustomer();
customer4.Id = 4;
customer4.CompanyName = "Abc";
customer4.CustomerNumber = "654779";
customer4.TaxNumber = "12345678985";

int number1 = 10;//20
int number2 = 20;
number1 = number2;
number2 = 50;
Console.WriteLine(number1);

string[] cities1 = { "Ankara", "İstanbul", "İzmir" };
string[] cities2 = { "Bursa", "Bolu", "Diyarbakır" };

cities2 = cities1;
cities1[0] = "Adana";

Console.WriteLine(cities2[0] + "\n");

//value types -->int, bool,double...
//reference types --> array, class, interface...
//101        //102     //103      //104
BaseCustomer[] customers = { customer1, customer2, customer3, customer4 };

//polymorphism
foreach (BaseCustomer customer in customers)
{
	if (customer is IndividualCustomer)
	{
		Console.WriteLine(((IndividualCustomer)customer).FirstName + "...");
	}
	else if (customer is CorporateCustomer)
	{
        Console.WriteLine(((CorporateCustomer)customer).CompanyName + "...");
    }

    Console.WriteLine(customer.CustomerNumber + "\n");
}