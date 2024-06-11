//namespace WeatherApp;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WeatherApplication.Data.Entities;

public class Wind
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.None)]
    public int Id { get; set; }
    public double speed { get; set; }
    public int deg { get; set; }
    public double gust { get; set; }
}