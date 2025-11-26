using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
namespace IngenieriaSoftware.BLL.Ayuda
{
    public class AyudaService
    {
        public async Task<string> EnviarAyuda(string email, string telefono, string mensaje)
        {
            try
            {
                using (var client = new HttpClient())
                {
                    // URL correcta para enviar (IMPORTANTE: usar formResponse)
                    var formUrl = "https://docs.google.com/forms/d/e/1FAIpQLSf9PILO1ZpaQMToAFbLvvU7u6z3LPc0XGcZOQgU0-VKBODiuA/formResponse";

                    var values = new Dictionary<string, string>
                                {
                                    { "entry.482963870", email },
                                    { "entry.404334100", telefono },
                                    { "entry.182713056", mensaje }
                                };

                    var content = new FormUrlEncodedContent(values);

                    var response = await client.PostAsync(formUrl, content);

                    if (response.IsSuccessStatusCode)
                        return "OK";

                    return $"ERROR: Código HTTP {response.StatusCode}";
                }
            }
            catch (Exception ex)
            {
                return "ERROR: " + ex.Message;
            }
        }
    }
}
