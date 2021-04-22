using Microsoft.Xrm.Sdk;
using System;
using System.Collections.Generic;

namespace DataGenerationTool.Repositories
{
    interface IRentDataGenerationRepository
    {
        List<Entity> GetAllCarClasses();
        Guid Create(Entity entity);
    }
}
