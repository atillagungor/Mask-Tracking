using Business.Abstract;
using Entities.Concrete;

namespace Business.Concrete;

public class PttManager
{
    IApplicantService _applicantService;
    public PttManager(IApplicantService applicantService)
    {
        _applicantService = applicantService;
    }
    public void GiveMask(Person person)
    {
        if (_applicantService.CheckPerson(person))
        {
            Console.WriteLine(person.Name + " için maske verildi.");
        }
        else
        {
            Console.WriteLine(person.Name + " için maske verilemedi.");
        }
    }
}