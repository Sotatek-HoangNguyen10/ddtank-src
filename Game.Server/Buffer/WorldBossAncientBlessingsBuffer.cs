﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Game.Server.GameObjects;
using SqlDataProvider.Data;

namespace Game.Server.Buffer
{
    public class WorldBossAncientBlessingsBuffer : AbstractBuffer
    {
        public WorldBossAncientBlessingsBuffer(BufferInfo buffer) : base(buffer) { }

        public override void Start(GamePlayer player)
        {
            WorldBossAncientBlessingsBuffer buffer = player.BufferList.GetOfType(typeof(WorldBossAncientBlessingsBuffer)) as WorldBossAncientBlessingsBuffer;
            if (buffer != null)
            {
                buffer.Info.ValidDate = Info.ValidDate;
                player.BufferList.UpdateBuffer(buffer);
                player.UpdateFightBuff(Info);
            }
            else
            {
                base.Start(player);
                player.FightBuffs.Add(Info);
            }
        }

        public override void Stop()
        {
            m_player.FightBuffs.Remove(Info);
            base.Stop();
        }
    }
}
