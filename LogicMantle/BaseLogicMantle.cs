using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicMantle
{
    public class BaseLogicMantle
    {
        public IConfiguration Configuration;
        public BaseLogicMantle(IConfiguration configuration)
        {
            Configuration = configuration;
        }
    }
}
