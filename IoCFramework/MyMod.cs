using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria.Graphics;
using Terraria.Localization;
using Terraria.ModLoader;
using Terraria.UI;


namespace IoCFramework {
	public class IoCMod : Mod {
		private MethodInfo AddRecipeGroups_Method;
		private MethodInfo AddRecipes_Method;
		private MethodInfo Call_Method;
		private MethodInfo Close_Method;
		private MethodInfo HandlePacket_Method;
		private MethodInfo HijackGetData_Method;
		private MethodInfo HijackSendData_Method;
		private MethodInfo HotKeyPressed_Method;
		private MethodInfo LoadResources_Method;
		private MethodInfo MidUpdateDustTime_Method;
		private MethodInfo MidUpdateGoreProjectile_Method;
		private MethodInfo MidUpdateInvasionNet_Method;
		private MethodInfo MidUpdateItemDust_Method;
		private MethodInfo MidUpdateNPCGore_Method;
		private MethodInfo MidUpdatePlayerNPC_Method;
		private MethodInfo MidUpdateTimeWorld_Method;
		private MethodInfo ModifyInterfaceLayers_Method;
		private MethodInfo ModifyLightingBrightness_Method;
		private MethodInfo ModifySunLightColor_Method;
		private MethodInfo ModifyTransformMatrix_Method;
		private MethodInfo PostAddRecipes_Method;
		private MethodInfo PostDrawFullscreenMap_Method;
		private MethodInfo PostDrawInterface_Method;
		private MethodInfo PostSetupContent_Method;
		private MethodInfo PostUpdateEverything_Method;
		private MethodInfo PostUpdateInput_Method;
		private MethodInfo PreSaveAndQuit_Method;
		private MethodInfo PreUpdateEntities_Method;
		private MethodInfo Unload_Method;
		private MethodInfo UpdateMusic_Method;
		private MethodInfo UpdateUI_Method;
		private MethodInfo MidUpdateProjectileItem_Method;



		////////////////

		public override void Load() {
			Type modType = this.GetType();
			this.AddRecipeGroups_Method = modType.GetMethod( nameof(AddRecipeGroups) );
			this.AddRecipes_Method = modType.GetMethod( nameof(AddRecipes) );
			this.Call_Method = modType.GetMethod( nameof(Call) );
			this.Close_Method = modType.GetMethod( nameof(Close) );
			this.HandlePacket_Method = modType.GetMethod( nameof(HandlePacket) );
			this.HijackGetData_Method = modType.GetMethod( nameof(HijackGetData) );
			this.HijackSendData_Method = modType.GetMethod( nameof(HijackSendData) );
			this.HotKeyPressed_Method = modType.GetMethod( nameof(HotKeyPressed) );
			this.LoadResources_Method = modType.GetMethod( nameof(LoadResources) );
			this.MidUpdateDustTime_Method = modType.GetMethod( nameof(MidUpdateDustTime) );
			this.MidUpdateGoreProjectile_Method = modType.GetMethod( nameof(MidUpdateGoreProjectile) );
			this.MidUpdateInvasionNet_Method = modType.GetMethod( nameof(MidUpdateInvasionNet) );
			this.MidUpdateItemDust_Method = modType.GetMethod( nameof(MidUpdateItemDust) );
			this.MidUpdateNPCGore_Method = modType.GetMethod( nameof(MidUpdateNPCGore) );
			this.MidUpdatePlayerNPC_Method = modType.GetMethod( nameof(MidUpdatePlayerNPC) );
			this.MidUpdateTimeWorld_Method = modType.GetMethod( nameof(MidUpdateTimeWorld) );
			this.ModifyInterfaceLayers_Method = modType.GetMethod( nameof(ModifyInterfaceLayers) );
			this.ModifyLightingBrightness_Method = modType.GetMethod( nameof(ModifyLightingBrightness) );
			this.ModifySunLightColor_Method = modType.GetMethod( nameof(ModifySunLightColor) );
			this.ModifyTransformMatrix_Method = modType.GetMethod( nameof(ModifyTransformMatrix) );
			this.PostAddRecipes_Method = modType.GetMethod( nameof(PostAddRecipes) );
			this.PostDrawFullscreenMap_Method = modType.GetMethod( nameof(PostDrawFullscreenMap) );
			this.PostDrawInterface_Method = modType.GetMethod( nameof(PostDrawInterface) );
			this.PostSetupContent_Method = modType.GetMethod( nameof(PostSetupContent) );
			this.PostUpdateEverything_Method = modType.GetMethod( nameof(PostUpdateEverything) );
			this.PostUpdateInput_Method = modType.GetMethod( nameof(PostUpdateInput) );
			this.PreSaveAndQuit_Method = modType.GetMethod( nameof(PreSaveAndQuit) );
			this.PreUpdateEntities_Method = modType.GetMethod( nameof(PreUpdateEntities) );
			this.Unload_Method = modType.GetMethod( nameof(Unload) );
			this.UpdateMusic_Method = modType.GetMethod( nameof(UpdateMusic) );
			this.UpdateUI_Method = modType.GetMethod( nameof(UpdateUI) );
			this.MidUpdateProjectileItem_Method = modType.GetMethod( nameof(MidUpdateProjectileItem) );
		}


		////

		public override void AddRecipeGroups() {
			IoCHooks.Call( out object _, this.AddRecipeGroups_Method );
		}
		public override void AddRecipes() {
			IoCHooks.Call( out object _, this.AddRecipes_Method );
		}
		public override object Call( params object[] args ) {
			if( IoCHooks.Call(out object output, this.Call_Method, args) ) {
				return output;
			}
			return base.Call( args );
		}
		public override void Close() {
			IoCHooks.Call( out object _, this.Close_Method );
		}
		public override void HandlePacket( BinaryReader reader, int whoAmI ) {
			IoCHooks.Call( out object _, this.HandlePacket_Method, reader, whoAmI );
		}
		public override bool HijackGetData( ref byte messageType, ref BinaryReader reader, int playerNumber ) {
			if( IoCHooks.Call(out object output, this.HijackGetData_Method, messageType, reader, playerNumber) ) {
				return (bool)output;
			}
			return false;
		}
		public override bool HijackSendData( int whoAmI, int msgType, int remoteClient, int ignoreClient, NetworkText text, int number, float number2, float number3, float number4, int number5, int number6, int number7 ) {
			if( IoCHooks.Call(out object output, this.HijackSendData_Method, msgType, remoteClient, ignoreClient, text, number, number2, number3, number4, number5, number6, number7 ) ) {
				return (bool)output;
			}
			return false;
		}
		public override void HotKeyPressed( string name ) {
			IoCHooks.Call( out object _, this.HotKeyPressed_Method );
		}
		public override void LoadResources() {
			IoCHooks.Call( out object _, this.LoadResources_Method );
		}
		public override void MidUpdateDustTime() {
			IoCHooks.Call( out object _, this.MidUpdateDustTime_Method );
		}
		public override void MidUpdateGoreProjectile() {
			IoCHooks.Call( out object _, this.MidUpdateGoreProjectile_Method );
		}
		public override void MidUpdateInvasionNet() {
			IoCHooks.Call( out object _, this.MidUpdateInvasionNet_Method );
		}
		public override void MidUpdateItemDust() {
			IoCHooks.Call( out object _, this.MidUpdateItemDust_Method );
		}
		public override void MidUpdateNPCGore() {
			IoCHooks.Call( out object _, this.MidUpdateNPCGore_Method );
		}
		public override void MidUpdatePlayerNPC() {
			IoCHooks.Call( out object _, this.MidUpdatePlayerNPC_Method );
		}
		public override void MidUpdateProjectileItem() {
			IoCHooks.Call( out object _, this.MidUpdateProjectileItem_Method );
		}
		public override void MidUpdateTimeWorld() {
			IoCHooks.Call( out object _, this.MidUpdateTimeWorld_Method );
		}
		public override void ModifyInterfaceLayers( List<GameInterfaceLayer> layers ) {
			IoCHooks.Call( out object _, this.ModifyInterfaceLayers_Method );
		}
		public override void ModifyLightingBrightness( ref float scale ) {
			IoCHooks.Call( out object _, this.ModifyLightingBrightness_Method );
		}
		public override void ModifySunLightColor( ref Color tileColor, ref Color backgroundColor ) {
			IoCHooks.Call( out object _, this.ModifySunLightColor_Method );
		}
		public override void ModifyTransformMatrix( ref SpriteViewMatrix Transform ) {
			IoCHooks.Call( out object _, this.ModifyTransformMatrix_Method );
		}
		public override void PostAddRecipes() {
			IoCHooks.Call( out object _, this.PostAddRecipes_Method );
		}
		public override void PostDrawFullscreenMap( ref string mouseText ) {
			IoCHooks.Call( out object _, this.PostDrawFullscreenMap_Method );
		}
		public override void PostDrawInterface( SpriteBatch spriteBatch ) {
			IoCHooks.Call( out object _, this.PostDrawInterface_Method );
		}
		public override void PostSetupContent() {
			IoCHooks.Call( out object _, this.PostSetupContent_Method );
		}
		public override void PostUpdateEverything() {
			IoCHooks.Call( out object _, this.PostUpdateEverything_Method );
		}
		public override void PostUpdateInput() {
			IoCHooks.Call( out object _, this.PostUpdateInput_Method );
		}
		public override void PreSaveAndQuit() {
			IoCHooks.Call( out object _, this.PreSaveAndQuit_Method );
		}
		public override void PreUpdateEntities() {
			IoCHooks.Call( out object _, this.PreUpdateEntities_Method );
		}
		public override void Unload() {
			IoCHooks.Call( out object _, this.Unload_Method );
		}
		public override void UpdateMusic( ref int music, ref MusicPriority priority ) {
			IoCHooks.Call( out object _, this.UpdateMusic_Method );
		}
		public override void UpdateUI( GameTime gameTime ) {
			IoCHooks.Call( out object _, this.UpdateUI_Method );
		}
	}
}
