using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CombinedAccessories.Items.Weapons;

public class AncientTerraBlade : ModItem
{
	public override void SetDefaults()
	{
		//IL_0094: Unknown result type (might be due to invalid IL or missing references)
		Item.damage = 20;
		Item.DamageType = DamageClass.Melee;
		Item.width = 40;
        Item.height = 40;
		Item.useTime = 16;
		Item.useAnimation = 16;
		Item.useStyle = ItemUseStyleID.Swing;
		Item.knockBack = 6.5f;
		Item.crit = 4;
		Item.rare = ItemRarityID.Yellow;
		Item.UseSound = SoundID.Item1;
		Item.shoot = ProjectileID.TerraBeam;
		Item.shootSpeed = 12f;
	}

	public override void AddRecipes()
	{
		Recipe obj = CreateRecipe();
		obj.AddIngredient(ItemID.PlatinumBroadsword);
		obj.AddIngredient(ItemID.NightsEdge);
		obj.AddIngredient(ItemID.Bone, 10);
		obj.AddTile(TileID.DemonAltar);
		obj.Register();

		Recipe obj2 = CreateRecipe();
		obj2.AddIngredient(ItemID.GoldBroadsword);
		obj2.AddIngredient(ItemID.NightsEdge);
		obj2.AddIngredient(ItemID.Bone, 10);
		obj2.AddTile(TileID.DemonAltar);
		obj2.Register();
	}
}
