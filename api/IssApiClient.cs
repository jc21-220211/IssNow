using System;
using System.Threading.Tasks;
using System.Net.Http;
using System.Text.Json;
using IssNow.api;

namespace IssNow
{
    public class IssApiClient
    {
        private readonly HttpClient _httpClient;

        public IssApiClient()
        {
            _httpClient = new HttpClient();
        }

        public async Task<IssPositionResponse> GetIssPositionAsync()
        {
            const string url = "http://api.open-notify.org/iss-now.json";

            try
            {
                // API呼び出し
                HttpResponseMessage response = await _httpClient.GetAsync(url);
                response.EnsureSuccessStatusCode(); // ステータスコードが成功か確認

                // JSON文字列を取得
                string jsonResponse = await response.Content.ReadAsStringAsync();

                // JSONをクラスにデシリアライズ
                return JsonSerializer.Deserialize<IssPositionResponse>(jsonResponse);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"エラーが発生しました: {ex.Message}");
                return null;
            }
        }
    }

}
