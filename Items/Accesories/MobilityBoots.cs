using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace CombinedAccessories.Items.Accesories;

public class mobilityBoots : ModItem
{
	public override void SetDefaults()
	{
		((ModItem)this).Item.accessory = true;
		((Entity)((ModItem)this).Item).width = 22;
		((Entity)((ModItem)this).Item).height = 22;
		((ModItem)this).Item.rare = ItemRarityID.Yellow;
	}

	public override void UpdateAccessory(Player player, bool hideVisual)
	{
		player.dashType = 1;
		player.frogLegJumpBoost = true;
		player.autoJump = true;
        player.accFlipper = true;
        player.spikedBoots = 2;
		player.noFallDmg = true;
		player.rocketBoots = 4;
		player.maxRunSpeed = 7f;
		player.runAcceleration = 0.25f;
		player.iceSkate = true;
		player.waterWalk2 = true;
		player.waterWalk = true;
		player.lavaImmune = true;
		player.lavaRose = true;
	}

	public override void AddRecipes()
	{
		Recipe obj = ((ModItem)this).CreateRecipe(1);
		obj.AddIngredient(ItemID.Tabi, 1);
		obj.AddIngredient(ItemID.FrogGear, 1);
		obj.AddIngredient(ItemID.LuckyHorseshoe, 1);
		obj.AddIngredient(ItemID.TerrasparkBoots, 1);
		obj.AddTile(TileID.TinkerersWorkbench);
		obj.Register();
	}
}
