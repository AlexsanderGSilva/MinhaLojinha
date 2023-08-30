using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace LojinhaServer.Collections;

[Table("products")]
[BsonIgnoreExtraElements] //Ignora os campos ques não existe na coleção
public class Product
{
    [BsonId]
    [BsonRepresentation(BsonType.ObjectId)]
    
    public string Id { get; set; }

    [BsonElement("name")]
    [JsonPropertyName("Nome")]

    public string Name { get; set; }

    [BsonElement("Description")]
    [JsonPropertyName("Descrição")]

    public string Description { get; set; }

    [BsonElement("price")]
    [JsonPropertyName("Preço")]

    public decimal Price { get; set; }

    [BsonElement("offprice")]
    [JsonPropertyName("Promoção")]

    public decimal Offprice { get; set; }

    [BsonElement("categories")]
    [JsonPropertyName("Categorias")]

    public List<string> Categories { get; set; }

}
