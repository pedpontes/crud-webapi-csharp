
namespace rinha_backend_cs.Models{
    public class LoginData(string name, string pass)
    {
        // public int Id { get; set;}
        // [JsonPropertyName("name")]   //definição da propriedade JSON em POST
        public string Name { get; set; } = name;
        // [JsonPropertyName("password")]   //definição da propriedade JSON em POST
        public string Pass { get; set; } = pass;
    }
}