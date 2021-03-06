using Newtonsoft.Json;
using System;

namespace Patterns.TimeSeries
{
    class SensorReading
    {
        [JsonProperty("id")]
        public String Id { get; set; }

        [JsonProperty("sensorId")]
        public String SensorId { get; set; }

        [JsonProperty("siteId")]
        public String SiteId { get; set; }

        [JsonProperty("ts")]
        public double UnixTimestamp { get; set; }

        [JsonProperty("temp")]
        public Double Temperature { get; set; }

        [JsonProperty("pressure")]
        public Double Pressure { get; set; }
    }
}
