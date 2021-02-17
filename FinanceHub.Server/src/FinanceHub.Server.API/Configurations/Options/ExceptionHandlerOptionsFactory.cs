using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Formatters;
using System.Net.Mime;
using System.Text.Json;
using System.Threading.Tasks;

namespace FinanceHub.Server.API.Configurations.Options
{
    internal static class ExceptionHandlerOptionsFactory
    {
        internal static ExceptionHandlerOptions Create() =>
            new ExceptionHandlerOptions
            {
                ExceptionHandler = Handle,
                ExceptionHandlingPath = null
            };

        // TODO: VER UMA MANEIRA DE MELHORAR ESSE TRATAMENTO
        private static async Task Handle(this HttpContext context)
        {
            context.Response.StatusCode = 500;
            context.Response.ContentType = MediaTypeNames.Application.Json;

            // TODO: Estrutura de Error Response
            var error = new
            {
                Status = 500,
                Message = "Deu ruim"
            };

            var result = JsonSerializer.Serialize(error, options: new JsonSerializerOptions
            {
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase
            });

            await context.Response.WriteAsync(result).ConfigureAwait(false);
        }
    }
}