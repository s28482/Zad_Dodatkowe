using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace APBD_Zad_Dodatkowe.Models;

[Table("Speaker")]
public class Speaker
{
    
    [Key]
    public int SpeakerId { get; set; }

    [MaxLength(150)] 
    public string FirstName { get; set; } = null!;

    [MaxLength(150)]
    public string LastName { get; set; } = null!;

    [MaxLength(200)]
    public string Email { get; set; } = null!;

    public virtual ICollection<EventSpeaker> EventSpeakers { get; set; } = null!;
}