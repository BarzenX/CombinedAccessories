using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace CombinedAccessories.Items.Accesories;

[AutoloadEquip(EquipType.Shield)]
//TODO: "*_Shoes.png" needs spriting
public class VitalityShield : ModItem
{
	public override void SetDefaults()
	{
		Item.accessory = true;
		Item.width = 22;
        Item.height = 22;
		Item.defense = 10;
        Item.rare = ItemRarityID.Yellow;
	}

	public override void UpdateAccessory(Player player, bool hideVisual)
	{
		//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b9: Unknown result type (might be due to invalid IL or missing references)

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

        // Hero Shield + Flesh Knuckles
        player.GetDamage(DamageClass.Generic) += 0.1f; ;
        player.GetCritChance(DamageClass.Generic) += 0.1f;
        // Flesh Knuckles aggro -400 and Hero Shield aggro + 400 = 0 aggro change
    }

    public override void AddRecipes()
	{
		Recipe obj = CreateRecipe();
		obj.AddIngredient(ItemID.AnkhShield);
		obj.AddIngredient(ItemID.CharmofMyths);
		obj.AddIngredient(ItemID.HeroShield);
		obj.AddIngredient(ItemID.PutridScent);
		obj.AddTile(TileID.TinkerersWorkbench);
		obj.Register();
	}
}
