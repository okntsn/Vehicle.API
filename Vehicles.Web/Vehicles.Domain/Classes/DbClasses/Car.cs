using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vehicles.Domain.Classes.BaseClasses;

namespace Vehicles.Domain.Classes.DbClasses
{
    public class Car : VehicleWarehouse
    {
        public int Wheel { get; set; }
        
    }
}
