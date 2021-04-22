using DataGenerationTool.Repositories;
using DataGenerationTool.Services;
using Microsoft.Xrm.Tooling.Connector;

namespace DataGenerationTool
{
    class Program
    {
        static void Main(string[] args)
        {
            var orgService = new CrmServiceClient("");
            var repository = new RentDataGenerationRepository(orgService);
            var randomizeService = new RandomizeService();
            var service = new RentDataGenerationService(repository, randomizeService);

            service.GenerateData();
        }
    }
}
