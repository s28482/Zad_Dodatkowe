using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace APBD_Zad_Dodatkowe.Models;

[Table("Participant")]
public class Participant
{
    [Key]
    public int ParticipantId { get; set; }

    [MaxLength(150)] 
    public string FirstName { get; set; } = null!;
    
    [MaxLength(150)]
    public string LastName { get; set; } = null!;
    
    [MaxLength(200)]
    public string Email { get; set; } = null!;

    public ICollection<EventParticipant> EventParticipants { get; set; } = null!;
}