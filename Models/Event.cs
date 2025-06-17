using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace APBD_Zad_Dodatkowe.Models;

[Table("Event")]
public class Event
{
    [Key]
    public int EventId { get; set; }

    [MaxLength(200)] 
    public string Title { get; set; } = null!;
    
    [MaxLength(200)]
    public string Description { get; set; } = null!;
    
    public DateTime Date { get; set; }
    
    public int MaxParticipants { get; set; }
    //

    public virtual ICollection<EventSpeaker> EventSpeakers { get; set; } = null!;

    public  virtual ICollection<EventParticipant> EventParticipants { get; set; } = null!;

}