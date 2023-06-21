﻿using System;
using System.Collections.Generic;
using Game.Logic.Phy.Object;

namespace Game.Logic.PetEffects.ContinueElement
{
    public class CE1198 : BasePetEffect
    {
        private int m_type = 0;
        private int m_count = 0;
        private int m_probability = 0;
        private int m_delay = 0;
        private int m_coldDown = 0;
        private int m_currentId;
        private int m_added = 0;

        public CE1198(int count, int probability, int type, int skillId, int delay, string elementID)
            : base(ePetEffectType.CE1198, elementID)
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
            CE1198 effect = living.PetEffectList.GetOfType(ePetEffectType.CE1198) as CE1198;
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
            player.BeginSelfTurn += Player_BeginSelfTurn;
            if (!IsTrigger)
            {
                m_added = 30;
                player.PetEffects.CritRate += m_added;
                IsTrigger = true;
            }
            player.PlayerClearBuffSkillPet += Player_PlayerClearBuffSkillPet;
        }

        private void Player_PlayerClearBuffSkillPet(Player player)
        {
            Stop();
        }

        private void Player_BeginSelfTurn(Living living)
        {
            m_count--;
            if (m_count < 0)
            {               
                Stop();
            }
        }

        protected override void OnRemovedFromPlayer(Player player)
        {
            player.Game.SendPetBuff(player, ElementInfo, false);
            player.PetEffects.CritRate -= m_added;
            m_added = 0;
            player.BeginSelfTurn -= Player_BeginSelfTurn;            
        }
    }
}
