using System;
using ServiceReference1;
using static ServiceReference1.CountryInfoServiceSoapTypeClient;

namespace ConsoleAppWebService
{
    class Program
    {
        static void Main(string[] args)
        {
            consumeWebServiceCountry("DO");
        }

        private static void consumeWebServiceCountry(string code)
        {
            CountryInfoServiceSoapTypeClient client = new CountryInfoServiceSoapTypeClient(EndpointConfiguration.CountryInfoServiceSoap);
            CapitalCityRequestBody cityRequestBody = new CapitalCityRequestBody(code);
            CapitalCityRequest cityRequest = new CapitalCityRequest(cityRequestBody);
            CapitalCityResponse cityResponse = client.CapitalCity(cityRequest);

            Console.WriteLine(cityResponse.Body.CapitalCityResult);
        }
    }
}
