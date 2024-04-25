using kalendarForms.Model;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;



namespace kalendarForms.Service
{
    public class Mservice
    {

        HttpClient httpClient;
        public Mservice()
        {
            httpClient = new HttpClient();
        }


        List<DataModel> monkeyList = new List<DataModel>();
        public async Task<List<DataModel>> GetMonkeys()
        {
            if (monkeyList.Count > 0)
                return monkeyList;

            var response = await httpClient.GetAsync("https://www.montemagno.com/monkeys.json");

            if (response.IsSuccessStatusCode)
            {

                var json = await response.Content.ReadAsStringAsync();
                monkeyList = JsonConvert.DeserializeObject<List<DataModel>>(json);
            }

            return monkeyList;
        }
    }
}
