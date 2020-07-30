using System.Collections.Generic;

namespace AchievementDependencyCreator.Model
{
    public class Achievement
    {
        public string Name { get; set; }
        public string Members { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        public string SubCategory { get; set; }
        public string SubSubCategory { get; set; }
        public string RuneScore { get; set; }

        public List<SkillBaseDependency> SkillDependencies { get; set; }
        public List<AchievementBaseDependency> AchievementBaseDependencies { get; set; }

        public Achievement()
        {
            SkillDependencies = new List<SkillBaseDependency>();
            AchievementBaseDependencies = new List<AchievementBaseDependency>();
        }
    }
}
