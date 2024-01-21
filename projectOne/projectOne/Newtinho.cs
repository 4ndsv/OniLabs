using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projectOne
{
    public class Newtinho
    {
        public string ExtractedData { get; set; }

        public Newtinho(string json)
        {
            string json1 = @"{
              'Name': 'Bad Boys',
              'ReleaseDate': '1995-4-7T00:00:00',
              'Genres': [
                'Action',
                'Comedy'
              ]
            }";

            Movie m = JsonConvert.DeserializeObject<Movie>(json1);

            ExtractedData = m.Name;
        }
    }
}
