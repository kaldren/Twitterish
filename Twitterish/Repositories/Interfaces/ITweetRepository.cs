using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Twitterish.Models;

namespace Twitterish.Repositories.Interfaces
{
    public interface ITweetRepository
    {
        IEnumerable<Tweet> GeAllTweets();
    }
}
