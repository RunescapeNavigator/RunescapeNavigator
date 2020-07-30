using System;
using System.Collections.Generic;
using System.Text;
using RunescapeNavigator.Core.Enums;

namespace AchievementDependencyCreator
{
    public class SkillBaseDependency : BaseDependency
    {
        public Skill Skill { get; set; }
        public int Level { get; set; }
    }
}
