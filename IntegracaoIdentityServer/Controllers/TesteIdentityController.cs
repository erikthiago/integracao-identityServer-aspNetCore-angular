using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace IntegracaoIdentityServer.Controllers
{
    [Route("api/identity")]
    [ApiController]
    [Authorize]
    public class TesteIdentityController : ControllerBase
    {
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "Controller", "Protegido", "Com obstrução" };
        }
    }
}