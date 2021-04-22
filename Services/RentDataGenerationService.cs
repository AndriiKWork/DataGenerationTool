using DataGenerationTool.Repositories;
using Microsoft.Xrm.Sdk;

namespace DataGenerationTool.Services
{
    class RentDataGenerationService
    {
        private readonly IRentDataGenerationRepository _repository;
        private readonly RandomizeService _randomizeService;

        public RentDataGenerationService(IRentDataGenerationRepository repository, RandomizeService randomizeService )
        {
            _repository = repository;
            _randomizeService = randomizeService;
        }

        public void GenerateData(int recordCount=1)
        {
            var allCarClasses = _repository.GetAllCarClasses();

            for (int i = 0; i < recordCount; i++)
            {
                _repository.Create(new Entity("akl_rent")
                {
                    ["akl_carclassid"]=_randomizeService.GetRandomFromEntityList(allCarClasses).ToEntityReference(),
                });
            }
        }

    }
}
