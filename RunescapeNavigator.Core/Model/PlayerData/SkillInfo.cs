namespace RunescapeNavigator.Core.Model.PlayerData
{
    public class SkillInfo
    {
        public int Rank { get; set; }
        public int Level { get; set; }
        public int Experience { get; set; }

        public SkillInfo(int rank, int lvl, int xp)
        {
            Rank = rank;
            Level = lvl;
            Experience = xp;
        }
    }
}