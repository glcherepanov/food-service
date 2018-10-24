using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
//using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FoodAdmin.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : Controller
    {
        private static string[,] Data = new string[,]
        {
            { "Bob", "First group", "First team" },
            { "Tim", "Second group", "Second team" },
            { "Jon", "Third group", "Third team" },
            { "Stive", "Fourth group", "Fourth team" },
            { "Kate", "Fifth group", "Fifth team" },
        };
        [HttpGet("[action]")]
        public IEnumerable<UserDto> UserDtos()
        {
            var rng = new Random();
            return Enumerable.Range(0, 4).Select(index => new UserDto
            {
                Name = Data[index, 0],
                Group = Data[index, 1],
                Team = Data[index, 2]
            });
        }

        public class UserDto
        {
            public string Name { get; set; }
            public string Group { get; set; }
            public string Team { get; set; }
        }
    }
}