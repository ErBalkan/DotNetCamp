using Ödev2.Business.Abstract;
using Ödev2.Entities.Concrete;

namespace Ödev2.Business.Concrete;
public class PttManager : ISupplierService
{
    private IApplicantService _applicantService;

    public PttManager(IApplicantService applicantService)
    {
        _applicantService = applicantService;
    }
    public void GiveMask(Person person){
        if(_applicantService.CheckPerson(person)){
            Console.WriteLine(person.FirstName + " için maske verildi.");
        }else{
            Console.WriteLine(person.FirstName + " için maske verilemedi.");
        }
    }
}