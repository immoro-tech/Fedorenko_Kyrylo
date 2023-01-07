using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAPI
{
    public class DropboxClient
    {
        private string ACCESS_TOKEN = "sl.BWcDtVL6sG-JHjqwRiZ2GLQzCLO2sIcteLSyDkciGO37h4VhEjDFEckfLH2bhDy6_6g2Jm69Z0qmQwmKSXbz6t5_3hmpK_WgtLX08Odb1aXbCuTURCqX1ssDp35QBJEX6Zl7_fZO7TK9";
        private HttpClient _client;

        public DropboxClient()
        {
            _client = new HttpClient();
        }

        public void UploadFile(string filePath, string dropboxPath)
        {
            
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Post,
                RequestUri = new Uri("https://content.dropboxapi.com/2/files/upload"),
                Headers = {
                    { "Authorization", $"Bearer {ACCESS_TOKEN}" },
                    { "Dropbox-API-Arg", $"{{\"autorename\":false,\"mode\":\"overwrite\",\"mute\":false,\"path\":\"{dropboxPath}\",\"strict_conflict\":false}}" }
                },
                Content = new StreamContent(new FileStream(filePath, FileMode.Open)),
            };
            request.Content.Headers.ContentType = new MediaTypeHeaderValue("application/octet-stream");

            
            var response = _client.SendAsync(request).Result;

            
            if (!response.IsSuccessStatusCode)
            {
                throw new Exception("Failed to upload file");
            }
        }

        public JObject GetFileMetadata(string dropboxPath)
        {
            
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Post,
                RequestUri = new Uri("https://api.dropboxapi.com/2/files/get_metadata"),
                Headers = {
                    { "Authorization", $"Bearer {ACCESS_TOKEN}" }
                },
                Content = new StringContent($"{{\"path\": \"{dropboxPath}\"}}", Encoding.UTF8, "application/json")
            };
            request.Content.Headers.ContentType = new MediaTypeHeaderValue("application/json");

            
            var response = _client.SendAsync(request).Result;
            return JObject.Parse(response.Content.ReadAsStringAsync().Result);
        }

        public void DeleteFile(string dropboxPath)
        {
            
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Post,
                RequestUri = new Uri("https://api.dropboxapi.com/2/files/delete"),
                Headers = {
                    { "Authorization", $"Bearer {ACCESS_TOKEN}" }
                },
                Content = new StringContent($"{{\"path\": \"{dropboxPath}\"}}", Encoding.UTF8, "application/json")
            };
            request.Content.Headers.ContentType = new MediaTypeHeaderValue("application/json");
            
            var response = _client.SendAsync(request).Result;

            
            if (!response.IsSuccessStatusCode)
            {
                throw new Exception("Failed to delete file");
            }
        }
    }
}
