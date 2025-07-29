using project.Models;
//implementation of the interface ıcommanderrepo
namespace project.Data
{
    public class MockCommanderRepo : ICommanderRepo
    {
        public void CreateCommand(Command cmd)
        {
            throw new NotImplementedException();
        }

        public void DeleteCommand(Command cmd)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Command> GetAllCommands()
        {
            var commands = new List<Command>
            {
                 new Command { Id = 0, HowTo ="boil an egg",Line="boil water", Platform="Kettle & Pan"},
                 new Command { Id = 0, HowTo ="cut bread",Line="get a knife", Platform="Knife and chopping board"},
                 new Command { Id = 0, HowTo ="make a cup of tea",Line="place teabag in cup", Platform="Kettle & cup"}
            };

            return commands;
        }

        public Command GetCommandById(int id)
        {
            return new Command { Id = 0, HowTo ="boil an egg",Line="boil water", Platform="Kettle & Pan"};
        }

        public bool SaveChanges()
        {
            throw new NotImplementedException();
        }

        public void UpdateCommand(Command cmd)
        {
            throw new NotImplementedException();
        }
    }
}