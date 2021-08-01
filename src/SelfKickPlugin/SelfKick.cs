using System;
using System.Reflection;
using Terraria;
using TerrariaApi.Server;
using TShockAPI;

namespace SelfKickPlugin
{
    [ApiVersion(2, 1)]
    public class SelfKick : TerrariaPlugin
    {
        public override string Name => Assembly.GetExecutingAssembly().GetCustomAttribute<AssemblyTitleAttribute>().Title;

        public override string Description => Assembly.GetExecutingAssembly().GetCustomAttribute<AssemblyDescriptionAttribute>().Description;

        public override Version Version => Assembly.GetExecutingAssembly().GetName().Version;

        public override string Author => Assembly.GetExecutingAssembly().GetCustomAttribute<AssemblyCompanyAttribute>().Company;

        public SelfKick(Main game) : base(game)
        {

        }

        public override void Initialize()
        {
            Console.WriteLine($"    {Name}  Copyright (C) 2021  {Author}");
            Console.WriteLine($"    This program comes with ABSOLUTELY NO WARRANTY; see {Name}.COPYING for details");
            Console.WriteLine($"    This is free software, and you are welcome to redistribute it");
            Console.WriteLine($"    under certain conditions; see {Name}.COPYING for details.");

            Commands.ChatCommands.Add(new Command("selfkickplugin.selfkick", KickSelf, "selfkick", "kickself", "skick"));
        }

        private void KickSelf(CommandArgs args)
        {
            var wasKicked = args.Player.Kick("You kicked yourself", true, true, saveSSI: true);
            if (!wasKicked)
            {
                args.Player.SendErrorMessage("You can't kick yourself");
            }
        }
    }
}
