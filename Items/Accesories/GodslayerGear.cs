using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CombinedAccessories.Items.Accesories;

public class GodslayerGear : ModItem
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

        #region Vitality Shield

        // Ankh Shield
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

        // Charm of Myths
        player.pStone = true;
        player.lifeRegen += 1;

        // Hero Shield
        player.hasPaladinShield = true;

        // Hero Shield + Flesh Knuckels
        //damage += 0.1f; --> see combination below
        //player.GetCritChance(DamageClass.Generic) += 0.1f; --> see combination below

        #endregion


        #region Celestial Gloves

        // Mechanical Glove
        ref StatModifier knockback = ref player.GetKnockback(DamageClass.Generic);
        knockback += 1f;
        //damage += 0.12f; --> see combination below
        player.GetAttackSpeed(DamageClass.Generic) += 0.12f;
        //player.GetCritChance(DamageClass.Generic) += 0.08f; --> see combination below

        player.autoReuseAllWeapons = true;
        player.meleeScaleGlove = true;

        // magma stone
        player.magmaStone = true;

        // Flesh Knuckles
        //player.aggro += 400;

        #endregion


        #region MobilityBoots

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

        #endregion


        #region Hand of Creation

        player.chiselSpeed = true;
        player.tileSpeed += 10f;
        player.wallSpeed += 10f;
        player.blockRange += 3;
        player.treasureMagnet = true;
        player.autoPaint = true;
        

        #endregion


        #region Soaring Insignia

        player.wingTimeMax += 1000;
        player.wingTime += 1000f;
        player.rocketTimeMax += 1000;
        player.rocketTime += 1000;

        #endregion

        // Resulting Damage, CritChance and aggro from Celestial Gloves and Vitality Shield

        ref StatModifier damage = ref player.GetDamage(DamageClass.Generic);
        damage += 0.2f; // 0.1 from Vitality Shield and 0.12 from Celestial Gloves * 0.91
        player.GetCritChance(DamageClass.Generic) += 0.16f; // 0.1 from Vitality Shield and 0.08 from Celestial Gloves * 0.9

        // Flesh Knuckels aggro -400 and Hero Shield aggro + 400 = 0 aggro change
    }

	public override void AddRecipes()
	{
		Recipe obj = ((ModItem)this).CreateRecipe(1);
		obj.AddIngredient<MobilityBoots>(1);
		obj.AddIngredient<CelestialGloves>(1);
		obj.AddIngredient<VitalityShield>(1);
		obj.AddIngredient(ItemID.HandOfCreation, 1);
		obj.AddIngredient(ItemID.EmpressFlightBooster, 1);
		obj.AddTile(TileID.TinkerersWorkbench);
		obj.Register();
	}
}
