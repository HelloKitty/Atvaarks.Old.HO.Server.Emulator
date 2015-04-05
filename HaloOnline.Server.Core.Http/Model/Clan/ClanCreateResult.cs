using HaloOnline.Server.Model.User;
using Newtonsoft.Json;

namespace HaloOnline.Server.Core.Http.Model.Clan
{
    public class ClanCreateResult
    {
        [JsonProperty("ClanCreateResult")]
        public ServiceResult<UserBaseData> Result { get; set; }
    }
}
