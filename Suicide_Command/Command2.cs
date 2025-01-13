using CommandSystem;
using RemoteAdmin;
using System;
using Exiled.API.Features;

[CommandHandler(typeof(ClientCommandHandler))]
public class KillCommand : ICommand
{
    public string Command => "kill";
    public string[] Aliases => new[] { ".kill" };
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
