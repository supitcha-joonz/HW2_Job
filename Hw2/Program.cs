// See https://aka.ms/new-console-template for more information


using Hw2;


Console.WriteLine("\t--------------------------------------------------\n");

//Doctor
Console.WriteLine("\t##################### Doctor #####################\n");


Console.Write("\tEnter Your Name : ");
var name = Console.ReadLine();

Console.Write("\n\tEnter Your Occuration : ");
var occuration = Console.ReadLine();

Console.Write("\n\tEnter Your Salary : ");
var salary = Console.ReadLine();

Console.Write("\n\tEnter Your Tax : ");
var tax = Console.ReadLine();


var changesalary = decimal.Parse(salary);
var changetax = decimal.Parse(tax);


var callJob = new Doctor(name, occuration, changesalary, changetax);
var whoname = callJob.WhoIam();
var pay = callJob.GetTax();

Console.WriteLine($"\n\t======================");
Console.WriteLine($"\t  {whoname}.");
Console.WriteLine($"\t");
Console.WriteLine($"\t  {pay} Bath.");
Console.WriteLine($"\t======================\n");



//Police
Console.WriteLine("\t##################### Police #####################\n");

Console.Write("\tEnter Your Name : ");
var poname = Console.ReadLine();

Console.Write("\n\tEnter Your Occuration : ");
var pooccuration = Console.ReadLine();

Console.Write("\n\tEnter Your Salary : ");
var posalary = Console.ReadLine();

Console.Write("\n\tEnter Your Tax : ");
var potax = Console.ReadLine();


var chposalary = decimal.Parse(posalary);
var chpotax = decimal.Parse(potax);


var callPo = new Police(poname, pooccuration, chposalary, chpotax);
var powhoname = callPo.WhoIam();
var popay = callPo.GetTax();
Console.WriteLine($"\n\t======================");
Console.WriteLine($"\t  {powhoname}.");
Console.WriteLine($"\t");
Console.WriteLine($"\t  {popay} Bath.");
Console.WriteLine($"\t======================\n");



//Teacher
Console.WriteLine("\t##################### Teacher #####################\n");

Console.Write("\tEnter Your Name : ");
var tename = Console.ReadLine();

Console.Write("\n\tEnter Your Occuration : ");
var teoccuration = Console.ReadLine();

Console.Write("\n\tEnter Your Salary : ");
var tesalary = Console.ReadLine();

Console.Write("\n\tEnter Your Tax : ");
var tetax = Console.ReadLine();

var chtesalary = decimal.Parse(tesalary);
var chtetax = decimal.Parse(tetax);


var callTe = new Teacher(tename, teoccuration, chtesalary, chtetax);
var tewhoname = callTe.WhoIam();
var tepay = callTe.GetTax();
Console.WriteLine($"\n\t======================");
Console.WriteLine($"\t  {tewhoname}.");
Console.WriteLine($"\t");
Console.WriteLine($"\t  {tepay} Bath.");
Console.WriteLine($"\t======================\n");



Console.WriteLine("\t--------------------------------------------------\n");





