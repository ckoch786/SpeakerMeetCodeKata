using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace SpeakerMeet.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SpeakerController : ControllerBase
    {
        private readonly List<Speaker> Speakers = new List<Speaker>
            {
                new Speaker("Joshua"),
                new Speaker("Josh"),
                new Speaker("Joseph"),
                new Speaker("Bob"),
                new Speaker("Joe")
    };

        [Route("search")]
        public OkObjectResult Search(string searchString)
        {
            var result = new List<Speaker>();

            result = SearchForExactMatch(searchString);
            if (result.Any())
            {
                return new OkObjectResult(result);
            }
            // books solution!
            //result = Speakers.Where(x => x.Name.StartsWith(searchString, StringComparison.OrdinalIgnoreCase)).ToList();

            result = SearchForAnyMatch(searchString);

            return new OkObjectResult(result);
        }

        private List<Speaker> SearchForExactMatch(string searchString)
        {
            var result = new List<Speaker>();
            foreach (var speaker in Speakers)
            {
                if (speaker.Name.ToLower() == searchString.ToLower())
                {
                    result.Add(speaker);
                    return result;
                }
            }

            return result;
        }

        private List<Speaker> SearchForAnyMatch(string searchString)
        {
            var result = new List<Speaker>();
            result = Speakers.Where<Speaker>(x => searchString.ToLower().Contains(x.Name.ToLower())).ToList();
            foreach (var speaker in Speakers)
            {
                var speakerInSearchString = speaker.Name.ToLower().Contains(searchString.ToLower());
                if (speakerInSearchString)
                {
                    result.Add(speaker);
                }
            }

            return result;
        }
    }
}