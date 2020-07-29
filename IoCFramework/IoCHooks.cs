using System;
using System.Collections.Generic;
using System.Reflection;
using Terraria.ModLoader;
using HamstarHelpers.Classes.Loadable;
using HamstarHelpers.Helpers.DotNET.Extensions;


namespace IoCFramework {
	/*[AttributeUsage( AttributeTargets.Method, Inherited = true, AllowMultiple = false )]
	public class IoCAttribute : Attribute {
		public IoCAttribute() {
		}
	}*/




	public class IoCHooks : ILoadable {
		public delegate bool IoCCallback( out object output, params object[] args );



		////////////////

		public static MethodInfo Bind( Type srcClass, string srcMethodName, IoCCallback callback ) {
			MethodInfo methInfo = srcClass.GetMethod( srcMethodName );
			var hooks = ModContent.GetInstance<IoCHooks>();

			hooks.Callbacks.Set2D( methInfo, callback );

			return methInfo;
		}

		public static bool Call( out object output, MethodInfo method, params object[] args ) {
			var hooks = ModContent.GetInstance<IoCHooks>();

			foreach( IoCCallback callback in hooks.Callbacks[method] ) {
				return callback( out output, args );
			}

			output = null;
			return false;
		}



		////////////////
		
		private IDictionary<MethodInfo, ISet<IoCCallback>> Callbacks = new Dictionary<MethodInfo, ISet<IoCCallback>>();



		////////////////

		void ILoadable.OnModsLoad() { }
		void ILoadable.OnModsUnload() { }
		void ILoadable.OnPostModsLoad() { }
	}
}
