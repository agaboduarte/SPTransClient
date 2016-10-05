﻿using Newtonsoft.Json;
using SPTransClient.Converters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPTransClient.Models
{
    public class Geolocation
    {
        [JsonProperty("p")]
        public long? StopCode { get; set; }

        [JsonProperty("t")]
        [JsonConverter(typeof(TimeSpanConverter))]
        public TimeSpan? TimeLeft { get; set; }

        [JsonProperty("a")]
        public bool? A { get; set; } // TODO: verificar o que é esse campo

        [JsonProperty("py")]
        public float? Longitude { get; set; }

        [JsonProperty("px")]
        public float? Latitude { get; set; }
    }
}
