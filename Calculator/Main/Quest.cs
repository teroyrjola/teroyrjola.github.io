﻿using System.ComponentModel.DataAnnotations;

namespace HeckFire
{

    public static class QuestInfo
    {
        public static string Name(this Quest quest)
        {
            switch (quest)
            {
                case Quest.Construction: return "Construction";
                case Quest.TroopTraining: return "Troop training";
                case Quest.MonsterSlaying: return "Monster slaying";
                case Quest.ResourceGathering: return "Resource gathering";
                case Quest.Researching: return "Researching";
                case Quest.MightGrowth: return "Might growth";
                default: return "Error";
            }
        }
    }
}

public enum Quest
{
    Construction,
    [Display(Name = "Troop training")]
    TroopTraining,
    [Display(Name = "Monster slaying")]
    MonsterSlaying,
    [Display(Name = "Resource gathering")]
    ResourceGathering,
    Researching,
    [Display(Name = "Might growth")]
    MightGrowth
}