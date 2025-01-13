using CommandSystem;
using RemoteAdmin;
using System;
using Exiled.API.Features;

[CommandHandler(typeof(ClientCommandHandler))]
public class SuicideCommand : ICommand
{
    public string Command => "suicide";
    public string[] Aliases => new[] { ".suicide"};
    public string Description => "Kills the player who executes the command.";

    public bool Execute(ArraySegment<string> arguments, ICommandSender sender, out string response)
    {
        if (sender is PlayerCommandSender playerSender)
        {
            var player = Player.Get(playerSender.ReferenceHub);
            if (player != null)
            {
                player.Kill("You have committed suicide.");
                response = "You have killed yourself.";
                return true;
            }
            response = "Unable to find your player object.";
            return false;
        }

        response = "This command can only be used by players.";
        return false;
    }
}
