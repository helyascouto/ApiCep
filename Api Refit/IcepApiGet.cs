using Refit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api_Refit
{
    public interface IcepApiGet
    {
        [Get("/ws/{cep}/json/")]
        Task<CepResponse> GetEndereco(string cep);
    }
}
