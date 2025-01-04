using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CombinedAccessories.Items.Accesories;

public class CelestialGloves : ModItem
{
	public override void SetDefaults()
	{
		((ModItem)this).Item.accessory = true;
		((Entity)((ModItem)this).Item).width = 22;
		((Entity)((ModItem)this).Item).height = 22;
		((ModItem)this).Item.defense = 8;
		((ModItem)this).Item.rare = ItemRarityID.Yellow;
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
        ref StatModifier knockback = ref player.GetKnockback(DamageClass.Generic);
        knockback += 1f;
        ref StatModifier damage = ref player.GetDamage(DamageClass.Generic);
		damage += 0.12f;
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
		Recipe obj = ((ModItem)this).CreateRecipe(1);
		obj.AddIngredient(ItemID.FireGauntlet, 1);
        obj.AddIngredient(ItemID.EyeoftheGolem, 1);
        obj.AddIngredient(ItemID.FleshKnuckles, 1);
		obj.AddTile(TileID.TinkerersWorkbench);
		obj.Register();
	}
}
