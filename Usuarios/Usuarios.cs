
using System.Text.Json.Serialization;

namespace usuarios;

class Usuarios
{

    [JsonPropertyName ("name")]
    public string? Nombre { get; set; }
    [JsonPropertyName ("email")]
    public string? Correo { get ; set; }
    [JsonPropertyName ("adress")]
    public Domicilio? Direccion { get; set; }

}

public class Domicilio
{
    [JsonPropertyName("street")]
    public string? Calle { get; set; }

    [JsonPropertyName("suite")]
    public string? Departamento { get; set; }

    [JsonPropertyName("city")]
    public string? Ciudad { get; set; }

    [JsonPropertyName("zipcode")]
    public string? CodigoPostal { get; set; }
}