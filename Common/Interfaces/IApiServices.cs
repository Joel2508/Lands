using Common.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Common.Interfaces
{
    public interface IApiServices
    {
        Task<Response> GestListAsync<T>(string urlBase, string servicePrexi, string controller);
    }
}
