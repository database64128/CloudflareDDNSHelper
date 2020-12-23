using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CloudflareDDNSHelper
{
    public class Config
    {
        /// <summary>
        /// Gets or sets the update interval for DDNS.
        /// </summary>
        public TimeSpan UpdateInterval { get; set; } = TimeSpan.FromMinutes(5);

        /// <summary>
        /// Gets or sets the list of DNS records for processing.
        /// </summary>
        public List<DnsRecord> DnsRecords { get; set; } = new();

        /// <summary>
        /// Loads settings from Settings.json.
        /// </summary>
        /// <returns>A <see cref="Config"/> object.</returns>
        public static Task<Config> LoadConfigAsync()
            => Utilities.LoadJsonAsync<Config>("config.json", Utilities.commonJsonDeserializerOptions);

        /// <summary>
        /// Saves settings to Settings.json.
        /// </summary>
        /// <param name="settings">The <see cref="Config"/> object to save.</param>
        /// <returns>A task that represents the asynchronous write operation.</returns>
        public static Task SaveConfigAsync(Config settings)
            => Utilities.SaveJsonAsync("config.json", settings, Utilities.commonJsonSerializerOptions);
    }
}
