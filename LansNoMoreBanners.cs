using Terraria.ID;
using Terraria.ModLoader;

namespace LansNoMoreBanners
{
    public class NoMoreBanners : Mod
    {
        public NoMoreBanners()
        {
        }


        public override void AddRecipeGroups()/* tModPorter Note: Removed. Use ModSystem.AddRecipeGroups */
        {
            for (int i = 0; i < ItemID.Sets.KillsToBanner.Length; i++)
            {
                ItemID.Sets.KillsToBanner[i] = int.MaxValue;
            }
        }
    }
}