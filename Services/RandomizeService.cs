using Microsoft.Xrm.Sdk;
using System;
using System.Collections.Generic;

namespace DataGenerationTool.Services
{
    class RandomizeService
    {
        public Entity GetRandomFromEntityList(List<Entity> entityList)
        {
            return entityList[new Random().Next(entityList.Count)];
        }
    }
}
