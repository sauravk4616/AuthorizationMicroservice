using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AuthorizationService.Repository
{
    public interface ICredentials
    {
        public Dictionary<string, string> GetCredentials();
    }
}
