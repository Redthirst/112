using System.Text.Json;
namespace Test
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            
            string jsonstring = File.ReadAllText("E:/teststring.json");
            List<JsonString> l = new();
            
            foreach(string s in jsonstring.Split('{', StringSplitOptions.RemoveEmptyEntries))
            {
                l.Add(JsonSerializer.Deserialize<JsonString>('{' + s)!);
            }
            foreach(JsonString js in l)
            {
                Console.WriteLine(js.key);
            }
            string filename = "E:/stringtest.json";
            string json = File.ReadAllText(filename);
            
            //string js = JsonSerializer.Serialize(st);
            //File.WriteAllText(filename, js);

        }
    }
    [System.Serializable]
    public class JsonString
    {
        public string key { get; set; }
        public string value { get; set; }
        //public JsonString(KeyValuePair<string, string> kvp)
        //{
        //    key = kvp.Key;
        //    value = kvp.Value;
        //}
        public JsonString(string key, string value)
        {
            this.key = key;
            this.value = value;
        }
    }
}