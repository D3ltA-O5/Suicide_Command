# 💀 Suicide/Kill Command Plugin for SCP: Secret Laboratory

The **Suicide/Kill Command Plugin** allows players to execute the `.suicide`, `.kill`, or `.die` commands to instantly eliminate themselves during the game. This can be useful for quick respawns, role resets, or other gameplay preferences.

## ✨ Features

- **Player Self-Elimination**: Players can type `.suicide`, `.kill`, or `.die` to immediately end their in-game life.
- **Custom Death Reasons**: Players can specify a custom reason for their death by typing it after the command.
- **Configurable Aliases**: Administrators can add or modify command aliases via the configuration file.

## 📋 Requirements

- **SCP: Secret Laboratory** game server
- **Exiled API** version 9.0.0 or higher

## 📥 Installation

1. **Download the `Suicide_Command.dll` file** from the [Releases](https://github.com/D3ltA-O5/Suicide_Command/releases) page.
2. **Place the `Suicide_Command.dll` file** in your server's `EXILED/Plugins` directory.
3. **Restart your server** to load the plugin.

## ⚙️ Configuration

Once installed, the plugin generates a configuration file in your server's `EXILED/Configs` directory. You can customize the following settings:

- **`IsEnabled`**: Enables or disables the plugin (default: `true`).
- **`Debug`**: Enables or disables debug mode (default: `false`).
- **`Description`**: Provides a short description of the plugin's functionality.
- **`CommandAliases`**: A list of aliases for the `.suicide` command (default: `kill`, `die`).

### Example Configuration
```yaml
# Is the plugin enabled?
IsEnabled: true

# Enables debug logs?
Debug: false

# Description of plugin functionality for user reference
Description: This plugin adds a suicide command with optional death reasons and configurable aliases.

# List of aliases for the .suicide command (without leading dots)
CommandAliases:
  - kill
  - die
```

## 🕹️ Usage

After installing and configuring the plugin, players can use the following commands during the game:

- **`.suicide`** - Instantly kill yourself. Optional: Add a custom reason after the command.
- **`.kill`** - Alias for `.suicide`, also kills the player instantly.
- **`.die`** - Another alias for `.suicide`.

### Custom Death Reason Example
To specify a custom reason for your death:
```
.suicide I regret nothing
.kill Sacrificing myself for the team
```

If no reason is specified, a default RP-friendly message will be used: "You decided to end your suffering...".

## 🛠️ Logs

All commands and reasons are logged on the server for administrative review and tracking.

## 🤝 Contributing

We welcome contributions from the community! If you have suggestions or improvements, feel free to fork the repository and submit a pull request.

## 🛠️ Support

For support, questions, or to report bugs, please visit the [GitHub Issues page](https://github.com/D3ltA-O5/Suicide_Command/issues) or DM me in Discord: **cyberco**.
