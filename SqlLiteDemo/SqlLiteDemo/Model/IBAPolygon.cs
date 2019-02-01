using NetTopologySuite.Geometries;
using System.ComponentModel.DataAnnotations;

namespace SqlLiteDemo.Model
{
    public class IBAPolygon 
    {
        public Polygon Polygon { get; set; }
        public string Name { get; set; }
        [Key]
        public int Id { get; set; }
    }
}