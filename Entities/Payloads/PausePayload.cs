using Newtonsoft.Json;

namespace Victoria.Entities.Payloads
{
    internal sealed class PausePayload : PlayerPayload
    {
        [JsonProperty("pause")] 
        public bool Pause { get; }
        
        public PausePayload(bool pause, ulong guildId) : base("pause", guildId)
        {
            Pause = pause;
        }
    }
}