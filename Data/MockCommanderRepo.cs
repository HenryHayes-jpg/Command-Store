using System.Collections.Generic;
using CommandStore.Models;

namespace CommandStore.Data
{
    public class MockCommanderRepo : ICommandstoreRepo
    {
        public IEnumerable<Command> GetAllCommands()
        {
            throw new System.NotImplementedException();
        }

        public Command GetCommandById(int id)
        {
            throw new System.NotImplementedException();
        }
    }
}