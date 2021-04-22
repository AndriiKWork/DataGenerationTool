using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Query;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DataGenerationTool.Repositories
{
    class RentDataGenerationRepository : IRentDataGenerationRepository
    {
        private readonly IOrganizationService _organizationService;
        public RentDataGenerationRepository(IOrganizationService organizationService)
        {
            _organizationService = organizationService;
        }
        public Guid Create(Entity entity)
        {
            return _organizationService.Create(entity);
        }

        public List<Entity> GetAllCarClasses()
        {
            var query = new QueryExpression("akl_carclass"); //todo add filters 
            return _organizationService.RetrieveMultiple(query).Entities.ToList();
        }
    }
}
