﻿using Newtonsoft.Json;

namespace HaloOnline.Server.Model.Presence
{
    public class PartyKickRequest
    {
        [JsonProperty("userID")]
        public string UserId { get; set; }
    }
}
