using Microsoft.Xna.Framework;
using Terraria;
using Terraria.GameContent.Achievements;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;
using Terraria.Localization;

namespace AlchemistNPC.Items.Boosters
{
	class FishronBooster : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Duke Fishron booster");
			Tooltip.SetDefault("+4% all stats up while on surface, mount is always accelerated");
			DisplayName.AddTranslation(GameCulture.Russian, "Усилитель Рыброна");
			Tooltip.AddTranslation(GameCulture.Russian, "Все параметры усилены на 4% когда на поверхности, ездовой питомец всегда ускорен");
			DisplayName.AddTranslation(GameCulture.Chinese, "猪鲨增益容器");
			Tooltip.AddTranslation(GameCulture.Chinese, "处于地表时所有属性增加4%，坐骑总处于加速状态");
        }

		public override void SetDefaults()
		{
			item.CloneDefaults(ItemID.LifeFruit);
			item.consumable = false;
			item.value = 100000;
		}

		public override bool UseItem(Player player)
        {
			if (player.GetModPlayer<AlchemistNPCPlayer>().FishronBooster == 0)
			{
				player.GetModPlayer<AlchemistNPCPlayer>().FishronBooster = 1;
				return true;
			}
			if (player.GetModPlayer<AlchemistNPCPlayer>().FishronBooster == 1)
			{
				player.GetModPlayer<AlchemistNPCPlayer>().FishronBooster = 0;
				return true;
			}
			return base.UseItem(player);
		}
	}
}
