//namespace WeatherApp;
namespace WeatherApplication.Data.Entities;

public class Root
{
    
    public int Id { get; set; }
    public Coord coord { get; set; }
    public List<Weather> weather { get; set; }
    public string @base { get; set; }
    public Main main { get; set; }
    public int visibility { get; set; }
    public Wind wind { get; set; }
    public Clouds clouds { get; set; }
    public int dt { get; set; }
    public int timezone { get; set; }
    public string name { get; set; }
    public int cod { get; set; }
}