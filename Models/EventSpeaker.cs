using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace APBD_Zad_Dodatkowe.Models;

[Table("EventSpeaker")]
[PrimaryKey(nameof(EventSpeakerId),nameof(EventId))]
public class EventSpeaker
{
    public int EventSpeakerId { get; set; }
    public int EventId { get; set; }

    [ForeignKey(nameof(EventId))]
    public virtual Event Event { get; set; }
    
    [ForeignKey(nameof(EventSpeakerId))]
    public virtual Speaker Speaker { get; set; }

}