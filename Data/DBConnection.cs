using Azure.Identity;
using Azure.Security.KeyVault.Secrets;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;



namespace Data
{
    public class DBConnection
    {
        public string GetConnectionString()
        {

            const string secretName = "TyrellCorpDBConnectionString";
            var keyVaultName = "tyrellcorp-kv";
            var kvUri = $"https://{keyVaultName}.vault.azure.net";

            var client = new SecretClient(new Uri(kvUri), new DefaultAzureCredential());
            var secret = client.GetSecret(secretName);

            return secret.Value.Value.ToString(); ;
        }




    }
}
