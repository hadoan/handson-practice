using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace Product.API.Application.Commands
{
    [DataContract]
    public class CreateProductCommand:IRequest<bool>
    {
        [DataMember]
        public string Name { get; private set; }

        [DataMember]
        public string Desc { get; private set; }

        public CreateProductCommand(string name, string desc)
        {
            Name = name;
            Desc = desc;
        }
    }
}
