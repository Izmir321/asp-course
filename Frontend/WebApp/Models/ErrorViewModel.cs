namespace DittProjektNamn.Models // <-- Ändra detta till ditt faktiska projektnamn
{
    public class ErrorViewModel
    {
        public string? RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}
