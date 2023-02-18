using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using Refit;
using System.Threading.Tasks;

namespace UI
{
    internal interface ICepApiService
    {
        [Get("/ws/{cep}/json")]

        Task<System.Net.webResponse> GetAdressAsync(string cep);

    }
}
 