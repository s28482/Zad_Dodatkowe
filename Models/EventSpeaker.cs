using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace APBD_Zad_Dodatkowe.Models;

[Table("EventSpeaker")]
[PrimaryKey(nameof(SpeakerId),nameof(EventId))]
public class EventSpeaker
{
    public int SpeakerId { get; set; }
    public int EventId { get; set; }

    [ForeignKey(nameof(EventId))]
    public virtual Event Event { get; set; }
    
    [ForeignKey(nameof(SpeakerId))]
    public virtual Speaker Speaker { get; set; }

}