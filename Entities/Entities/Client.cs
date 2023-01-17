using Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Entities
{
    public class Client
    {
        public string Name { get; set; }
        public string CpfCnpj { get; set; }
        public int CodigoInterno { get; set; }
        public ClientConfig Configuration { get; set; }
    }
}
