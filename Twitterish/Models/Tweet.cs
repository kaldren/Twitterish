using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Twitterish.Models
{
    public class Tweet
    {
        public int Id { get; set; }
        public string Content { get; set; }
        public DateTime DateTime { get; set; }

        public string AuthorId { get; set; }
        public ApplicationUser Author { get; set; }
    }
}
