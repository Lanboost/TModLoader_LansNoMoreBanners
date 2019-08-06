using Terraria.ID;
using Terraria.ModLoader;

namespace NoMoreBanners
{
    public class NoMoreBanners : Mod
    {
        public NoMoreBanners()
        {
        }


        public override void AddRecipeGroups()
        {
            for (int i = 0; i < ItemID.Sets.KillsToBanner.Length; i++)
            {
                ItemID.Sets.KillsToBanner[i] = int.MaxValue;
            }
        }
    }
}