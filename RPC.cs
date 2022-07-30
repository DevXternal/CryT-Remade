using System;
using DiscordRPC;
namespace CryT_Remade
{
	public class RPC
	{
		public static DiscordRpcClient client;
		public static Timestamps rpctimestamp { get; set; }
		private static RichPresence presence;
		public static void InitializeRPC()
		{
			client = new DiscordRpcClient("994682897619501136");
			client.Initialize();
			Button[] buttons = { new Button() { Label = "Download", Url = "https://github.com/DevXternal/CryT-Remade/releases" }, new Button() { Label = "Repository", Url = "https://github.com/DevXternal/CryT-Remade" } };

			presence = new RichPresence()
			{
				Details = "Using CryT executor lol.",
				State = "Scripts go brrrr.",
				Timestamps = rpctimestamp,
				Buttons = buttons,

				Assets = new Assets()
				{
					LargeImageKey = "cryt",
					LargeImageText = "I need graphic designer lol",
					SmallImageKey = "devx",
					SmallImageText = "Developer DevXternal#2256"
				}
			};
			SetState("Scripts go brrrr.");
		}
		public static void SetState(string state, bool watching = false)
		{
			if (watching)
				state = "Looking at " + state;

			presence.State = state;
			client.SetPresence(presence);
		}
	}
}