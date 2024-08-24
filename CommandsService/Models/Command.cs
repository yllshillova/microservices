namespace CommandsService.Models
{
    public class Command
    {
        public Guid Id { get; set; }
        public string HowTo { get; set; }
        public string CommandLine { get; set; }
        public Guid PlatformId { get; set; }
        public Platform Platform { get; set; }
    }
}
