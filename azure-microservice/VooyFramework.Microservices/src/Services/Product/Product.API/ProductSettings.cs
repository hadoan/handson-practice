using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VooyFramework.Microservices.Product.API
{
    public class ProductSettings
    {
        public bool UseCustomizationData { get; set; }
        public string ConnectionString { get; set; }

        public string EventBusConnection { get; set; }

        public int CheckUpdateTime { get; set; }
    }
}
