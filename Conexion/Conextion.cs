using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conexion
{
    private void Get(string dato)
    {
        var client = new HttpClient();
        client.BaseAddress = new Uri("http://localhost:53382/api");
        client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

        var response = client.GetAsync(client.BaseAddress + dato).Result;

        if (response.IsSuccessStatusCode)
        {
            var data = response.Content.ReadAsStringAsync().Result;
            var personas = new List<persona>();
            Newtonsoft.Json.JsonConvert.PopulateObject(data.ToString(), personas);

            dataGridView1.DataSource = personas;

        }

    }
}
