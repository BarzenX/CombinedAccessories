using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace CombinedAccessories.Items.Accesories;

public class MobilityBoots : ModItem
{
	public override void SetDefaults()
	{
		Item.accessory = true;
		Item.width = 22;
        Item.height = 22;
		Item.rare = ItemRarityID.Yellow;
	}

	public override void UpdateAccessory(Player player, bool hideVisual)
	{
		// Tabi
		player.dashType = 1;

        // Frog Gear
        player.accFlipper = true;
        player.spikedBoots = 2;
        player.frogLegJumpBoost = true;
		player.autoJump = true;

        // Lucky Horseshoe
        player.noFallDmg = true;

        // Terraspark Boots
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
		Recipe obj = CreateRecipe();
		obj.AddIngredient(ItemID.Tabi);
		obj.AddIngredient(ItemID.FrogGear);
		obj.AddIngredient(ItemID.LuckyHorseshoe);
		obj.AddIngredient(ItemID.TerrasparkBoots);
		obj.AddTile(TileID.TinkerersWorkbench);
		obj.Register();
	}
}
