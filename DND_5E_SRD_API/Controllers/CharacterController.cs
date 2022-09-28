using DND_5E_SRD_API.Models;
using DND_5E_SRD_API.Models.BackStory;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Text.Json;

namespace DND_5E_SRD_API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CharacterController : Controller
    {
        private readonly ILogger _logger;

        public CharacterController(ILogger<CharacterController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public string Get()
        {
            return JsonSerializer.Serialize(new Character());
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

    [Route("[controller]")]
    public class BBackstoryController : Controller
    {
        [HttpGet]
        public static Dictionary<string, string> Get()
        {
            return BackStory.GetRandomBackstory();
        }
        
    }
}