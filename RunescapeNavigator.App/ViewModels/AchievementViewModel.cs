using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.IO;
using System.Text;
using Newtonsoft.Json;
using RunescapeNavigator.Core.Model.Achievements;

namespace RunescapeNavigator.App.ViewModels
{
    class AchievementViewModel
    {
        public ObservableCollection<Achievement> Achievements { get; set; }
        public AchievementViewModel()
        {
            Achievements = GetAchievements();
        }

        ObservableCollection<Achievement> GetAchievements()
        {
            using StreamReader sr = new StreamReader("test.json");
            string json = sr.ReadToEnd();

            return JsonConvert.DeserializeObject<ObservableCollection<Achievement>>(json);
        }
    }
}
