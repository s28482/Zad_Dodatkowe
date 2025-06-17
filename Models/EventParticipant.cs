using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace APBD_Zad_Dodatkowe.Models;


[Table("EventParticipant")]
[PrimaryKey(nameof(EventId),nameof(ParticipantId))]
public class EventParticipant
{
    public int EventId { get; set; }
    public int ParticipantId { get; set; }
    
    public DateTime RegistrationDate { get; set; }
    public bool IsCallenced { get; set; }
    
    [ForeignKey(nameof(ParticipantId))]
    public virtual Participant Participant { get; set; }
    
    [ForeignKey(nameof(EventId))]
    public virtual Event Event { get; set; }
}