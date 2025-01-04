using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace CombinedAccessories.Items.Accesories;

public class survivorsGear : ModItem
{
	public override void SetDefaults()
	{
		((ModItem)this).Item.accessory = true;
		((Entity)((ModItem)this).Item).width = 22;
		((Entity)((ModItem)this).Item).height = 22;
		((ModItem)this).Item.defense = 10;
		((ModItem)this).Item.rare = ItemRarityID.Yellow;
	}

	public override void UpdateAccessory(Player player, bool hideVisual)
	{
		//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b9: Unknown result type (might be due to invalid IL or missing references)
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
		ref StatModifier damage = ref player.GetDamage(DamageClass.Generic);
		damage += 0.1f;
		player.GetCritChance(DamageClass.Generic) += 0.1f;
	}

	public override void AddRecipes()
	{
		Recipe obj = ((ModItem)this).CreateRecipe(1);
		obj.AddIngredient(ItemID.AnkhShield, 1);
		obj.AddIngredient(ItemID.PhilosophersStone, 1);
		obj.AddIngredient(ItemID.HeroShield, 1);
		obj.AddIngredient(ItemID.PutridScent, 1);
		obj.AddTile(TileID.TinkerersWorkbench);
		obj.Register();
	}
}
