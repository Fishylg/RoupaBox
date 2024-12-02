using Newtonsoft.Json; 
using System; 
using System.Collections.Generic; 
using System.Linq;
using System.Linq.Expressions;
using System.Net.Http; 
using System.Text; 
using System.Threading.Tasks; 

namespace API
{
	internal class Program
	{
		static async Task Main(string[] args)
		{
			
			HttpClient client = new HttpClient();

			
			string apiUrl = "https://api.invertexto.com/v1/currency/:symbols";

			try
			{
				
				HttpResponseMessage response = await client.GetAsync(apiUrl);

				
				if (response.IsSuccessStatusCode)
				{
					
					string jsonResult = await response.Content.ReadAsStringAsync();

					
					var jsonObject = JsonConvert.DeserializeObject<dynamic>(jsonResult);

					
					Console.WriteLine("Resposta da API: ");
					Console.WriteLine(jsonResult);
				}
				else
				{
					Console.WriteLine($"Erro na requisição: {response.StatusCode}");
				}
			}
			catch (Exception ex)
			{
				Console.WriteLine($"Erro: {ex.Message}");
			}
			finally
			{
				client.Dispose();
			}
		}
	}
}