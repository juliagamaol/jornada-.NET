using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DevTrackR.Api.Entities;

namespace DevTrackR.Api.Persistence
{
    public class DevTrackRContext
    {
        public DevTrackRContext()
        {
            Packages = new List<Package>();
        }

        public List<Package> Packages { get; set; }


    }
}