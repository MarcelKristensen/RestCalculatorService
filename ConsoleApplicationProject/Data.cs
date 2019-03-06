using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace ConsoleApplicationProject
{
    public class Data
    {        
        private int _a;
        private int _b;

        public Data(int a, int b)
        {
            _a = a;
            _b = b;
        }

        public int A
        {
            get { return _a; }
            set { _a = value; }
        }

        public int B
        {
            get { return _b; }
            set { _b = value; }
        }

        public static async Task<string> AsyncAdd(Data data)
        {
            using (HttpClient client = new HttpClient())
            {
                Console.WriteLine("Data " + data);

                var jsonString = JsonConvert.SerializeObject(data);
                Console.WriteLine("json string: " + jsonString);

                StringContent content = new StringContent(jsonString, Encoding.UTF8, "application/json");
                Console.WriteLine("content: : " + content.ToString());
                Console.WriteLine("CalculatorUri: " + CalculatorUri);

                HttpResponseMessage response = await client.PostAsync(CalculatorUri + "Add", content);
                string str = await response.Content.ReadAsStringAsync();
                //Int32 sumStr = JsonConvert.DeserializeObject<Int32>(str);
                return str;
            }
        }


    }
}