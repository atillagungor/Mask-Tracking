using Entities.Concrete;

namespace Business.Abstract;
public interface IApplicantService
{
    public void ApplyForMask(Person person);

    public List<Person> GetList();

    bool CheckPerson(Person person);
}