﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SentimentalWeb.Models
{
    public class ResultViewModel
    {
        public string OriginalText { get; set; }
        public Double SentimentScore { get; set; }
        public List<string> KeyPhrases { get; set; }
        public string KeyPhrasesAsString { get; set; }
    }
}
