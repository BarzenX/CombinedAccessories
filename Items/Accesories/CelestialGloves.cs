using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CombinedAccessories.Items.Accesories;

public class CelestialGloves : ModItem
{
	public override void SetDefaults()
	{
		Item.accessory = true;
		Item.width = 22;
		Item.height = 22;
		Item.defense = 8;
        Item.rare = ItemRarityID.Yellow;
	}

	public override void UpdateAccessory(Player player, bool hideVisual)
	{
        //IL_000c: Unknown result type (might be due to invalid IL or missing references)
        //IL_0016: Unknown result type (might be due to invalid IL or missing references)
        //IL_001b: Unknown result type (might be due to invalid IL or missing references)
        //IL_002c: Unknown result type (might be due to invalid IL or missing references)
        //IL_0036: Unknown result type (might be due to invalid IL or missing references)
        //IL_003b: Unknown result type (might be due to invalid IL or missing references)

		// Mechanical Glove
		player.GetKnockback(DamageClass.Generic) += 1f;
        player.GetDamage(DamageClass.Generic) += 0.12f;
        player.GetAttackSpeed(DamageClass.Generic) += 0.12f;
        player.GetCritChance(DamageClass.Generic) += 0.08f;

        player.autoReuseAllWeapons = true;
        player.meleeScaleGlove = true;

        // magma stone
        player.magmaStone = true;

        // Flesh Knuckles
        player.aggro += 400;
	}

	public override void AddRecipes()
	{
		Recipe obj = CreateRecipe();
		obj.AddIngredient(ItemID.FireGauntlet);
        obj.AddIngredient(ItemID.EyeoftheGolem);
        obj.AddIngredient(ItemID.FleshKnuckles);
		obj.AddTile(TileID.TinkerersWorkbench);
		obj.Register();
	}
}
