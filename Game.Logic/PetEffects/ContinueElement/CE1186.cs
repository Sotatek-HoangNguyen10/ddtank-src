﻿using System;
using System.Collections.Generic;
using Game.Logic.Phy.Object;

namespace Game.Logic.PetEffects.ContinueElement
{
    public class CE1186 : BasePetEffect
    {
        private int m_type = 0;
        private int m_count = 0;
        private int m_probability = 0;
        private int m_delay = 0;
        private int m_coldDown = 0;
        private int m_currentId;
        private int m_added = 0;

        public CE1186(int count, int probability, int type, int skillId, int delay, string elementID)
            : base(ePetEffectType.CE1186, elementID)
        {
            m_count = count;
            m_coldDown = count;
            m_probability = probability == -1 ? 10000 : probability;
            m_type = type;
            m_delay = delay;
            m_currentId = skillId;
        }

        public override bool Start(Living living)
        {
            CE1186 effect = living.PetEffectList.GetOfType(ePetEffectType.CE1186) as CE1186;
            if (effect != null)
            {
                effect.m_probability = m_probability > effect.m_probability ? m_probability : effect.m_probability;
                return true;
            }
            else
            {
                return base.Start(living);
            }
        }

        protected override void OnAttachedToPlayer(Player player)
        {
            player.BeginNextTurn += Player_BeginNextTurn;
            player.BeginSelfTurn += Player_BeginSelfTurn;
        }

        private void Player_BeginNextTurn(Living living)
        {
           
        }

        private void Player_BeginSelfTurn(Living living)
        {
            m_added = 500;
            living.AddBlood(-m_added, 1);
            if (living.Blood <= 0)
            {
                living.Die();
                if (living.Game.CurrentLiving != null && living.Game.CurrentLiving is Player)
                    (living.Game.CurrentLiving as Player).PlayerDetail.OnKillingLiving(living.Game, 2, living.Id, living.IsLiving, m_added);
            }
        }

        protected override void OnRemovedFromPlayer(Player player)
        {
            player.BeginNextTurn -= Player_BeginNextTurn;
            player.BeginSelfTurn -= Player_BeginSelfTurn;
        }
    }
}
