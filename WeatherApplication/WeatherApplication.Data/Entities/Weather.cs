//namespace WeatherApp;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WeatherApplication.Data.Entities;

public class Weather
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.None)]
    public int Id { get; set; }
    public string main { get; set; }
    public string description { get; set; }
    public string icon { get; set; }
}