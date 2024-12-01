using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;

namespace IssNow.api
{
    // ISS位置情報を格納するクラス
    public class IssPositionResponse
    {
        [JsonPropertyName("timestamp")]
        public long Timestamp { get; set; }

        [JsonPropertyName("message")]
        public string Message { get; set; }

        [JsonPropertyName("iss_position")]
        public IssPosition Position { get; set; }
    }
}
