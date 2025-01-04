using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CombinedAccessories.Items.Accesories;

public class celestialGloves : ModItem
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
		ref StatModifier damage = ref player.GetDamage(DamageClass.Generic);
		damage += 0.49f;
		ref StatModifier knockback = ref player.GetKnockback(DamageClass.Generic);
		knockback += 1f;
		player.magmaStone = true;
		player.GetAttackSpeed(DamageClass.Generic) += 0.12f;
		player.autoReuseAllWeapons = true;
		player.meleeScaleGlove = true;
		player.GetCritChance(DamageClass.Generic) += 0.08f;
		player.aggro += 400;
	}

	public override void AddRecipes()
	{
		Recipe obj = ((ModItem)this).CreateRecipe(1);
		obj.AddIngredient(ItemID.WarriorEmblem, 1);
		obj.AddIngredient(ItemID.AvengerEmblem, 1);
		obj.AddIngredient(ItemID.DestroyerEmblem, 1);
		obj.AddIngredient(ItemID.WarriorEmblem, 1);
		obj.AddIngredient(ItemID.FireGauntlet, 1);
		obj.AddIngredient(ItemID.FleshKnuckles, 1);
		obj.AddTile(TileID.TinkerersWorkbench);
		obj.Register();

		Recipe obj2 = ((ModItem)this).CreateRecipe(1);
		obj2.AddIngredient(ItemID.RangerEmblem, 1);
		obj2.AddIngredient(ItemID.AvengerEmblem, 1);
		obj2.AddIngredient(ItemID.DestroyerEmblem, 1);
		obj2.AddIngredient(ItemID.WarriorEmblem, 1);
		obj2.AddIngredient(ItemID.FireGauntlet, 1);
		obj2.AddIngredient(ItemID.FleshKnuckles, 1);
		obj2.AddTile(TileID.TinkerersWorkbench);
		obj2.Register();

		Recipe obj3 = ((ModItem)this).CreateRecipe(1);
		obj3.AddIngredient(ItemID.SummonerEmblem, 1);
		obj3.AddIngredient(ItemID.AvengerEmblem, 1);
		obj3.AddIngredient(ItemID.DestroyerEmblem, 1);
		obj3.AddIngredient(ItemID.WarriorEmblem, 1);
		obj3.AddIngredient(ItemID.FireGauntlet, 1);
		obj3.AddIngredient(ItemID.FleshKnuckles, 1);
		obj3.AddTile(TileID.TinkerersWorkbench);
		obj3.Register();

		Recipe obj4 = ((ModItem)this).CreateRecipe(1);
		obj4.AddIngredient(ItemID.SorcererEmblem, 1);
		obj4.AddIngredient(ItemID.AvengerEmblem, 1);
		obj4.AddIngredient(ItemID.DestroyerEmblem, 1);
		obj4.AddIngredient(ItemID.WarriorEmblem, 1);
		obj4.AddIngredient(ItemID.FireGauntlet, 1);
		obj4.AddIngredient(ItemID.FleshKnuckles, 1);
		obj4.AddTile(TileID.TinkerersWorkbench);
		obj4.Register();
	}
}
