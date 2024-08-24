namespace CommandsService.DTOs
{
    public class CommandReadDto
    {
        public Guid Id { get; set; }
        public string HowTo { get; set; }
        public string CommandLine { get; set; }
        public Guid PlatformId { get; set; }
    }
}
