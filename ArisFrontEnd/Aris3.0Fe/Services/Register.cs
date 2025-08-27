namespace Aris3._0Fe.Services
{
    public class Register
    {
        private readonly HttpClient _httpClient;
        private readonly ILogger<SendEmail> _logger;

        public Register(HttpClient httpClient, ILogger<SendEmail> logger)
        {
            _httpClient = httpClient;
            _logger = logger;
        }
        public async Task<string> CreatNewAccount(string email,string password,int subscription)
        {
            try
            {
                var response = await _httpClient.PostAsync($"https://localhost:7248/api/Account/{email}/{password}/{subscription}", null);
                return await response.Content.ReadAsStringAsync();
            }
            catch (HttpRequestException ex)
            {
                _logger.LogError(ex, "HTTP request failed while registering new account.");
                return $"Request failed: {ex.Message}";
            }
        }
    }
}
