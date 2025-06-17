using APBD_Zad_Dodatkowe.Models;
using Microsoft.EntityFrameworkCore;

namespace APBD_Zad_Dodatkowe.Data;

public class MyDbContext : DbContext
{
    
    // zarejestrowac modele
    public DbSet<Event> Events { get; set; }
    public DbSet<Speaker> Speakers { get; set; }
    public DbSet<Participant> Participants { get; set; }
    public DbSet<EventSpeaker> EventSpeakers { get; set; }
    public DbSet<EventParticipant> EventParticipants { get; set; }
    
    
    
    public MyDbContext(DbContextOptions<MyDbContext> options) : base(options) { }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        var events = new List<Event>
        {
            new Event
            {
                EventId = 1,
                Title = "Tytul",
                Description = "EDESC",
                Date = new DateTime(2020, 09, 09),
                MaxParticipants = 5

            },
            new Event
            {
                EventId = 2,
                Title = "Tytul1",
                Description = "ED1ESC",
                Date = new DateTime(2020, 09, 09),
                MaxParticipants = 2

            }
        };
        modelBuilder.Entity<Event>().HasData(events);

        var speakers = new List<Speaker>
        {
            new Speaker
            {
                SpeakerId = 1,
                FirstName = "James",
                LastName = "Bond",
                Email = "jbond@gmail.com",
            },
            new Speaker
            {
                SpeakerId = 2,
                FirstName = "ames",
                LastName = "Fond",
                Email = "jbond@gmail.com",
            }
        };
        modelBuilder.Entity<Speaker>().HasData(speakers);

        var participants = new List<Participant>
        {
            new Participant
            {
                ParticipantId = 1,
                FirstName = "Jaefmes",
                LastName = "Dnd",
                Email = "jdnd@gmail.com",
            },
            new Participant
            {
                ParticipantId = 2,
                FirstName = "Jmes2",
                LastName = "Dnd",
                Email = "jdnd@gmail.com",
            }
        };
        modelBuilder.Entity<Participant>().HasData(participants);

        var s = new List<EventSpeaker>
        {
            new EventSpeaker
            {
              SpeakerId = 1,
              EventId = 1
              }
        };
        modelBuilder.Entity<EventSpeaker>().HasData(s);

        var eventParticipant = new List<EventParticipant>
        {
            new EventParticipant
            {
                EventId = 1,
                ParticipantId = 1,
                RegistrationDate = new DateTime(2020, 09, 09),

            }
        };
        modelBuilder.Entity<EventParticipant>().HasData(eventParticipant);

    }

}