﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ChckNorrisJokesLibrary
{
    class Joke
    {
        public List<object> categories { get; set; }
        public string created_at { get; set; }
        public string icon_url { get; set; }
        public string id { get; set; }
        public string updated_at { get; set; }
        public string url { get; set; }
        public string value { get; set; }
    }
}
