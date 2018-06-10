using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Twitterish.Data;
using Twitterish.Dtos;
using Twitterish.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Twitterish.Controllers
{
    [Route("api/[controller]")]
    public class TweetController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<ApplicationUser> _userManager;

        public TweetController(ApplicationDbContext context,
            UserManager<ApplicationUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        // GET: api/<controller>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<controller>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<controller>
        [HttpPost]
        public IActionResult CreateTweet([FromBody] string msg)
        {
            //var userId = User.Identity.Name;

            //if (!User.Identity.IsAuthenticated)
            //{
            //    return BadRequest("Unauthenticated user");
            //}

            var tweet = new Tweet
            {
                Content = msg,
                DateTime = DateTime.Now,
                AuthorId = "8b44e556-e169-4d82-8e09-36bb93205c4a"
            };

            _context.Add(tweet);
            _context.SaveChanges();

            return Ok(msg);
        }

        // PUT api/<controller>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
