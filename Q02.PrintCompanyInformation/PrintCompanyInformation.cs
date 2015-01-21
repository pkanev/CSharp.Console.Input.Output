using System;

class PrintCompanyInformation
{
    static void Main()
    {
        Console.Write("Company name: ");
        string companyName = Console.ReadLine();
        Console.Write("Company address: ");
        string address = Console.ReadLine();
        Console.Write("Phone number:");
        string phoneNo = Console.ReadLine();
        Console.Write("Fax number: ");
        string faxNo = Console.ReadLine();
        Console.Write("Web site: ");
        string web = Console.ReadLine();
        Console.Write("Manager first name: ");
        string managerFirstName = Console.ReadLine();
        Console.Write("Manager last name:");
        string managerLastName = Console.ReadLine();
        Console.Write("Manager age: ");
        int managerAge = int.Parse(Console.ReadLine());
        Console.Write("Manager phone: ");
        string managerPhone = Console.ReadLine();
        Console.WriteLine("");
        Console.WriteLine(companyName);
        Console.WriteLine("Company address: {0}", address);
        Console.WriteLine("Tel. {0}", phoneNo);
        Console.WriteLine("Fax: {0}", faxNo == "" ? "(no fax)" : faxNo);
        Console.WriteLine("Web site: {0}", web);
        Console.WriteLine("Manager: {0} {1} (age: {2}, tel. {3})", managerFirstName, managerLastName, managerAge, managerPhone);
    }
}