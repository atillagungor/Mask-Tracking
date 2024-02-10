using Business.Abstract;
using Entities.Concrete;
using MernisServiceReference;

namespace Business.Concrete;
public class PersonManager : IApplicantService
{
    public void ApplyForMask(Person person)
    {
        
    }

    public bool CheckPerson(Person person)
    {
        KPSPublicSoapClient client = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap);
        return client.TCKimlikNoDogrulaAsync(
            new TCKimlikNoDogrulaRequest(new TCKimlikNoDogrulaRequestBody(person.NationalIdentity,person.Name,person.Surname,person.DateOfBirthYear)))
            .Result.Body.TCKimlikNoDogrulaResult;
    }

    public List<Person> GetList()
    {
        return null;
    }
}