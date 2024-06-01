using System.ComponentModel.DataAnnotations;
using System.Data;

namespace MVC.Models;

public  class HeThongPhanPhoi
{
    [Key]
    public string? MaHTPP {get; set;}
    public string? TenHTPP {get; set;}
    


    }