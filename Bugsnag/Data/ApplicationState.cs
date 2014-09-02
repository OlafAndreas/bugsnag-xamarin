using System;
using Newtonsoft.Json;
using Bugsnag.Json;

namespace Bugsnag.Data
{
    [JsonObject (MemberSerialization.OptIn)]
    public class ApplicationState
    {
        [JsonProperty ("duration", DefaultValueHandling = DefaultValueHandling.Ignore)]
        [JsonConverter (typeof(TimeSpanConverter))]
        public TimeSpan RunningTime { get; set; }

        [JsonProperty ("memoryUsage", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public long MemoryUsage { get; set; }
    }
}
