using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Twitterish.Data;
using Twitterish.Models;
using Twitterish.Repositories.Interfaces;

namespace Twitterish.Repositories
{
    public class TweetRepository : ITweetRepository
    {
        private readonly ApplicationDbContext _context;

        public TweetRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Tweet> GeAllTweets()
        {
            return _context.Tweets
                .Include(a => a.Author)
                .ToList();
        }
    }
}
