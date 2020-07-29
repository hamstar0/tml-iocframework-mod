using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Graphics;
using Terraria;
using Terraria.ModLoader;
using HamstarHelpers.Classes.Loadable;


namespace IoCFramework {
	public class ExampleIoCHooks : ILoadable {
		void ILoadable.OnModsLoad() {
			// Apply bindings here:
			IoCHooks.Bind( typeof(Mod), "PostDrawInterface", this.MyPostDrawInterface );
		}

		void ILoadable.OnModsUnload() { }

		void ILoadable.OnPostModsLoad() { }



		////////////////

		private bool MyPostDrawInterface( out object output, params object[] args ) {
			var sb = (SpriteBatch)args[0];

			sb.DrawString( Main.fontMouseText, "Look, I'm NOT located in Mod.PostDrawInterface!", Vector2.Zero, Color.White );

			// does not return
			output = null;
			return false;
		}
	}
}
