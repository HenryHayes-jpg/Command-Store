using System.Collections.Generic;
using CommandStore.Models;

namespace CommandStore.Data{

    public interface ICommandstoreRepo
    {
        IEnumerable<Command> GetAllCommands(); 
        Command GetCommandById(int id);
    }

}