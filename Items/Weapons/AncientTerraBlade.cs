using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CombinedAccessories.Items.Weapons;

public class AncientTerraBlade : ModItem
{
	public override void SetDefaults()
	{
		//IL_0094: Unknown result type (might be due to invalid IL or missing references)
		((ModItem)this).Item.damage = 20;
		((ModItem)this).Item.DamageType = DamageClass.Melee;
		((Entity)((ModItem)this).Item).width = 40;
		((Entity)((ModItem)this).Item).height = 40;
		((ModItem)this).Item.useTime = 16;
		((ModItem)this).Item.useAnimation = ((ModItem)this).Item.useTime;
		((ModItem)this).Item.useStyle = ItemUseStyleID.Swing;
		((ModItem)this).Item.knockBack = 6.5f;
		((ModItem)this).Item.crit = 4;
		((ModItem)this).Item.rare = ItemRarityID.Yellow;
		((ModItem)this).Item.UseSound = SoundID.Item1;
		((ModItem)this).Item.shoot = ProjectileID.TerraBeam;
		((ModItem)this).Item.shootSpeed = 12f;
	}

	public override void AddRecipes()
	{
		Recipe obj = ((ModItem)this).CreateRecipe(1);
		obj.AddIngredient(ItemID.PlatinumBroadsword, 1);
		obj.AddIngredient(ItemID.NightsEdge, 1);
		obj.AddIngredient(ItemID.Bone, 10);
		obj.AddTile(TileID.DemonAltar);
		obj.Register();

		Recipe obj2 = ((ModItem)this).CreateRecipe(1);
		obj2.AddIngredient(ItemID.GoldBroadsword, 1);
		obj2.AddIngredient(ItemID.NightsEdge, 1);
		obj2.AddIngredient(ItemID.Bone, 10);
		obj2.AddTile(TileID.DemonAltar);
		obj2.Register();
	}
}
