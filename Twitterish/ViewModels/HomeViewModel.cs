using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Twitterish.Models;

namespace Twitterish.ViewModels
{
    public class HomeViewModel
    {
        public IEnumerable<Tweet> ShowAllTweets { get; set; }
    }
}
