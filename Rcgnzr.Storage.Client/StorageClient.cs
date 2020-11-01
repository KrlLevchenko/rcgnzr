using System;
using System.IO;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace Rcgnzr.Storage.Client
{
    public class StorageClient : IStorageClient
    {
        private readonly HttpClient _client;

        public StorageClient(HttpClient client)
        {
            _client = client;
        }

        public async Task<Stream?> GetFile(string containerId, string fileId, CancellationToken ct)
        {
            var url = $"/api/storage/{containerId}/{fileId}";
            var result = await _client.GetAsync(url, ct);
            result.EnsureSuccessStatusCode();
            var stream = await result.Content.ReadAsStreamAsync();
            return stream;
        }

        public async Task SaveFile(string containerId, string fileId, Stream content, CancellationToken ct)
        {
            var url = $"/api/storage/{containerId}/{fileId}";
            var result = await _client.PostAsync(url, new StreamContent(content), ct);
            result.EnsureSuccessStatusCode();
        }
    }
}