# MERNİS SERVİSİNİ KULLANMAK

`dotnet tool install --global dotnet-svcutil` komutu ile svcutil aracını kuruyoruz.

`dotnet-svcutil https://tckimlik.nvi.gov.tr/Service/KPSPublic.asmx?WSDL` Komutu ile mernis servisini projemize referans ediyoruz.

Bu komuttan sonra projemizde ServiceReference adında bir klasör oluşur içinde de kullanacağımız class'lar vardır.

```c#
    public bool CheckPerson(Person person){
        KPSPublicSoapClient client = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap);

        return client.TCKimlikNoDogrulaAsync(
            person.NationalIdentity,
            person.FirstName,
            person.LastName,
            person.DateOfBirthYear).Result.Body.TCKimlikNoDogrulaResult;
    }
```

Bu metot true ya da false döner...