﻿using System;
using System.Collections.Generic;
using System.Text;
using Game.Logic.AI;

namespace Game.Server.GameServerScript.AI.Game
{
    public class TimeVortexNormalGame : APVEGameControl
    {
        public override void OnCreated()
        {
            //Game.SetupMissions("12101,12102,12103,12104");
            Game.SetupMissions("12001,12002,12003,12004");
            Game.TotalMissionCount = 2;           
        }

        public override void OnPrepated()
        {
            //Game.SessionId = 0;
        }

        public override int CalculateScoreGrade(int score)
        {
            if(score > 800)
            {
                return 3;
            }
            else if(score > 725)
            {
                return 2;
            }
            else if(score > 650)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }

        public override void OnGameOverAllSession()
        {
        }
    }
}
