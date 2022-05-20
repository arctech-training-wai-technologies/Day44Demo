using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Day44ThreadDemo.DataAccess.Models;

public class Feed
{
    [Key]
    public int MyTestKey { get; set; }

    [Column(TypeName = "varchar(100)")]
    public string Id { get; set; }
    
    [Column(TypeName="varchar(2000)")]
    public string Title { get; set; }

    [Column(TypeName = "varchar(2000)")]
    public string Description { get; set; }

    [Column(TypeName = "varchar(2000)")]
    public string Location { get; set; }

    public override string ToString()
    {
        return $"{Id,-10}{Title,-20}{Description,-20}{Location}";
    }
}