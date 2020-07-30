using System;
using System.Collections.Generic;
using RunescapeNavigator.Core.Enums;

namespace RunescapeNavigator.Core.Model.PlayerData
{
    public class Player
    {
        private readonly Dictionary<Skill, SkillInfo> _playerSkills = new Dictionary<Skill, SkillInfo>();
        
        public SkillInfo GetSkill(Skill skill)
        {
            return _playerSkills[skill];
        }
        
        public static Player BuildPlayerFromRest(string content)
        {
            var player = new Player();
            var skillsList = Enum.GetValues(typeof(Skill));
            var skillRow = content.Split('\n');
            // Rest response of skills are ordered based on their order in the enum
            for (var i = 0; i < skillsList.Length; i++)
            {
                var entries = skillRow[i].Split(',');
                var rank = Convert.ToInt32(entries[0]);
                var level = Convert.ToInt32(entries[1]);
                var experience = Convert.ToInt32(entries[2]);
                var skillInfo = new SkillInfo(rank, level, experience);
                player._playerSkills.Add(Enum.Parse<Skill>(i.ToString()), skillInfo);
            }

            return player;
        }
    }
}