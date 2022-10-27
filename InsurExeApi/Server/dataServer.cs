namespace InsurExeApi.Server;
using Newtonsoft.Json;
using InsurExeApi.Models.DatabaseModels;

public class DatabaseContext
{
    public List<InsuranceDb>? InsuranceDatabase { get; set; }

    public DatabaseContext()
    {
        var file = File.ReadAllText(@"DummyDatabase/database.json");
        InsuranceDatabase = JsonConvert.DeserializeObject<List<InsuranceDb>>(file);
    }
}

