﻿using System;

using Newtonsoft.Json;

namespace SendGrid.WebApi.Models
{
    public class SpamReportsResult
    {
        [JsonProperty("ip")]
        public string Ip { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("created")]
        public DateTime Created { get; set; }
    }
}
