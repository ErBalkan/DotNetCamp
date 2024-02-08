namespace Ödev2.Business.Concrete;

using Ödev2.Business.Abstract;
using Ödev2.Entities.Concrete;
using ServiceReference;

public class PersonManager : IApplicantService
{
    public void ApplyForMask(Person person){

    }

    public List<Person> GetList(){
        return null;
    }

    public bool CheckPerson(Person person){
        KPSPublicSoapClient client = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap);

        return client.TCKimlikNoDogrulaAsync(
            person.NationalIdentity,
            person.FirstName,
            person.LastName,
            person.DateOfBirthYear).Result.Body.TCKimlikNoDogrulaResult;
    }
}