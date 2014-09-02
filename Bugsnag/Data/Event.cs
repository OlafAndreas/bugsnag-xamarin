using System.Collections.Generic;
using Newtonsoft.Json;
using Bugsnag.Json;

namespace Bugsnag.Data
{
    [JsonObject (MemberSerialization.OptIn)]
    public class Event
    {
        [JsonProperty ("payloadVersion")]
        public string Version { get { return "2"; } }

        [JsonProperty ("user", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public UserInfo User { get; set; }

        [JsonProperty ("app")]
        public ApplicationInfo App { get; set; }

        [JsonProperty ("appState", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public ApplicationState AppState { get; set; }

        [JsonProperty ("device", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public SystemInfo System { get; set; }

        [JsonProperty ("deviceState", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public SystemState SystemState { get; set; }

        [JsonProperty ("context")]
        public string Context { get; set; }

        [JsonProperty ("severity"), JsonConverter (typeof(ErrorSeverityConverter))]
        public ErrorSeverity Severity { get; set; }

        [JsonProperty ("exceptions")]
        public List<ExceptionInfo> Exceptions { get; set; }

        [JsonProperty ("metaData")]
        public Metadata Metadata { get; set; }
    }
}
