// See https://aka.ms/new-console-template for more information


using Hw2;

Console.Write("Enter Your Name : ");
var name = Console.ReadLine();

Console.Write("Enter Your Occuration : ");
var occuration = Console.ReadLine();

Console.Write("Enter Your Salary : ");
var salary = Console.ReadLine();

Console.Write("Enter Your Tax : ");
var tax = Console.ReadLine();


var changesalary = decimal.Parse(salary);
var changetax = decimal.Parse(tax);


var callJob = new Doctor(name, occuration, changesalary, changetax);
var whoname = callJob.WhoIam();
var pay = callJob.GetTax();
Console.WriteLine($"{whoname}\n");
Console.WriteLine($"{pay}\n");




