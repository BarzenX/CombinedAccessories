using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CombinedAccessories.Items.Accesories;

public class godslayerGear : ModItem
{
	public override void SetDefaults()
	{
		((ModItem)this).Item.accessory = true;
		((Entity)((ModItem)this).Item).width = 22;
		((Entity)((ModItem)this).Item).height = 22;
		((ModItem)this).Item.defense = 20;
		((ModItem)this).Item.rare = ItemRarityID.Expert;
	}

	public override void UpdateAccessory(Player player, bool hideVisual)
	{
		//IL_013a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0144: Unknown result type (might be due to invalid IL or missing references)
		//IL_0149: Unknown result type (might be due to invalid IL or missing references)
		//IL_015a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0164: Unknown result type (might be due to invalid IL or missing references)
		//IL_0169: Unknown result type (might be due to invalid IL or missing references)
		player.noKnockback = true;
		player.buffImmune[BuffID.Bleeding] = true;
		player.buffImmune[BuffID.BrokenArmor] = true;
		player.buffImmune[BuffID.Burning] = true;
		player.buffImmune[BuffID.Confused] = true;
		player.buffImmune[BuffID.Cursed] = true;
		player.buffImmune[BuffID.Darkness] = true;
		player.buffImmune[BuffID.Poisoned] = true;
		player.buffImmune[BuffID.Silenced] = true;
		player.buffImmune[BuffID.Slow] = true;
		player.buffImmune[BuffID.Weak] = true;
		player.buffImmune[BuffID.Chilled] = true;
		player.buffImmune[BuffID.Stoned] = true;
		player.pStone = true;
		player.lifeRegen += 3;
		player.hasPaladinShield = true;
		player.GetCritChance(DamageClass.Generic) += 0.18f;
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
		player.aggro += 400;
		ref StatModifier damage = ref player.GetDamage(DamageClass.Generic);
		damage += 0.6f;
		ref StatModifier knockback = ref player.GetKnockback(DamageClass.Generic);
		knockback += 1f;
		player.magmaStone = true;
		player.GetAttackSpeed(DamageClass.Generic) += 0.12f;
		player.autoReuseAllWeapons = true;
		player.meleeScaleGlove = true;
		player.chiselSpeed = true;
		player.treasureMagnet = true;
		player.autoPaint = true;
		player.tileSpeed += 10f;
		player.wallSpeed += 10f;
		player.blockRange += 3;
		player.wingTimeMax += 1000;
		player.wingTime += 1000f;
		player.rocketTimeMax += 1000;
		player.rocketTime += 1000;
	}

	public override void AddRecipes()
	{
		Recipe obj = ((ModItem)this).CreateRecipe(1);
		obj.AddIngredient<mobilityBoots>(1);
		obj.AddIngredient<celestialGloves>(1);
		obj.AddIngredient<survivorsGear>(1);
		obj.AddIngredient(ItemID.HandOfCreation, 1);
		obj.AddIngredient(ItemID.EmpressFlightBooster, 1);
		obj.AddTile(TileID.TinkerersWorkbench);
		obj.Register();
	}
}
