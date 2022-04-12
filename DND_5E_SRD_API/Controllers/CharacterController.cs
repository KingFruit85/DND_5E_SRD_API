using DND_5E_SRD_API.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

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

        [HttpGet("{id}")]
        public Character GetSpecificCharacter(string id)
        {
            return new Character(id);
        }
    }

    [Route("[controller]")]
    public class AbilityScoreController : Controller
    {
        [HttpGet]
        public int[] Get()
        {
            return new AbilityScores().GetRawScores();
        }

        [HttpGet("{id}")]
        public Dictionary<string, int> GetRollsForSpecificClass(string id)
        {
            int[] rawScores = new AbilityScores().GetRawScores();
            return new AbilityScores().Arrange(id,rawScores);
        }
    }
}