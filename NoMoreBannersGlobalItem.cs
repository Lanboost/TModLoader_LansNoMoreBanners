using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace LansNoMoreBanners
{
    class NoMoreBannersGlobalItem : GlobalItem
    {
        public override bool OnPickup(Item item, Player player)
        {
            

            return true;
        }
    }
}
