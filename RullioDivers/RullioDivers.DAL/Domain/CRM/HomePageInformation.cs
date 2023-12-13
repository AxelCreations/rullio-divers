using System.ComponentModel.DataAnnotations;

namespace RullioDivers.DAL.Domain;

public class HomePageInformation
{
    public int ID { get; set; }

    [Required]
    [StringLength(60)]
    public string HeroTitle { get; set; }

    [Required]
    [StringLength(60)]
    public string HeroDescription { get; set; }

    [StringLength(512)]
    public string HeroBackground { get; set; }
}
