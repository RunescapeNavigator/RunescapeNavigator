using System;
using RunescapeNavigator.Core.Enums;
using RunescapeNavigator.Data;

namespace RunescapeNavigator.ConsoleTester
{
    class Program
    {
        static void Main(string[] args)
        {
            var client = new RS3RestClient();
            var p2 = client.GetRegularPlayer("Dreamhack");
            Console.WriteLine(p2.GetSkill(Skill.Ranged).Experience);
        }
    }
}