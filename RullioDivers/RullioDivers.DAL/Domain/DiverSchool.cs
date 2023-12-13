using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace RullioDivers.DAL.Domain;

  public class DiverSchool
  {
      public int ID { get; set; }

      [Required]
      [StringLength(50)]
      public string Name { get; set; }

      public virtual IEnumerable<User> Users { get; set; }
  }
