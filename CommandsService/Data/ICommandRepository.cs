using CommandsService.Models;

namespace CommandsService.Data
{
    public interface ICommandRepository
    {
        bool SaveChanges();

        // Platforms
        IEnumerable<Platform> GetAllPlatforms();
        void CreatePlatform(Platform plat);
        bool PlaformExits(Guid platformId);
        bool ExternalPlatformExists(Guid externalPlatformId);

        //Commands
        void CreateCommand(Guid platformId, Command command);
        Command GetCommand(Guid platformId, Guid commandId);
        IEnumerable<Command> GetCommandsForPlatform(Guid platformId);
    }
}
