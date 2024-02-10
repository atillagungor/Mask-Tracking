using Business.Concrete;
using Entities.Concrete;

internal class Program
{
    private static void Main(string[] args)
    {
        Person person1 = new Person();
        person1.NationalIdentity = 123;
        person1.Name = "Atilla";
        person1.Surname = "Güngör";
        person1.DateOfBirthYear = 1998;

        PttManager pttManager = new PttManager(new PersonManager());
        pttManager.GiveMask(person1);
        Console.ReadLine();
    }
}