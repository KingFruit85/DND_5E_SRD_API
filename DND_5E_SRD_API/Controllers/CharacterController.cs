using DND_5E_SRD_API.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DND_5E_SRD_API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CharacterController : Controller
    {
        [HttpGet]
        public Character Get()
        {
            return new Character();
        }
    }
}
