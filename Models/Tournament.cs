namespace SabagkitMidtermApp.Models;

public class TournamentEvent
{
    public int Id { get; set; }
    public string Title { get; set; } = string.Empty;
    public string Subtitle { get; set; } = string.Empty;
    public string Location { get; set; } = string.Empty;
    public string Country { get; set; } = string.Empty;
    public string DateRange { get; set; } = string.Empty;
    public string Currency { get; set; } = "USD";
    public decimal Fee { get; set; }
    public int PlayerCount { get; set; }
    public bool IsClosingSoon { get; set; }
    public string ThemeGradient { get; set; } = string.Empty;
    public string GraphicType { get; set; } = "generic";
    public List<EventDivision> Divisions { get; set; } = new();
}

public class EventDivision
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public decimal Fee { get; set; }
    public bool IsDoubles { get; set; }
}

public class PlayerRegistrationModel
{
    public int TournamentId { get; set; }
    public int DivisionId { get; set; }
    public string FullName { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public string SkillRating { get; set; } = "3.5";
    public string TShirtSize { get; set; } = "M";
    public string? PartnerName { get; set; }
    public string? PartnerDupr { get; set; }
    public bool AgreedToWaiver { get; set; }
}

public class CreateTournamentModel
{
    public string Title { get; set; } = string.Empty;
    public string Location { get; set; } = string.Empty;
    public string Country { get; set; } = string.Empty;
    public DateTime StartDate { get; set; } = DateTime.Today;
    public DateTime EndDate { get; set; } = DateTime.Today.AddDays(2);
    public decimal BaseFee { get; set; } = 50.00m;
    public string Currency { get; set; } = "USD";
    public string? Venue { get; set; }
}