using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using HtmlAgilityPack;
using RunescapeNavigator.Core.Extensions;
using RunescapeNavigator.Core.Model;
using RunescapeNavigator.Core.Model.Achievements;

namespace RunescapeNavigator.DOMParser
{
    public static class WikiParser
    {
        public static List<Achievement> GetLatestAchievements()
        {
            // Get DOM
            WebClient wc = new WebClient();
            var data = wc.DownloadString("https://runescape.wiki/w/List_of_achievements");
            
            // Load it into htmldocument for parsing
            HtmlDocument doc = new HtmlDocument();
            doc.LoadHtml(data);

            var achievements = new List<Achievement>();
            // Store all tr nodes as rows
            foreach (var row in doc.DocumentNode.SelectNodes("//tr[td]"))
            {
                var tableRow = row.SelectNodes("td").Select(td => td.InnerText).ToArray();
                // Sanity check (Also exists invalid rows in the data)
                if (tableRow.Length < 5)
                {
                    continue;
                }
                
                var ach = new Achievement();
                ach.Name = StringHelpers.CleanString(tableRow[0]);
                ach.Members = StringHelpers.CleanString(tableRow[1]);
                ach.Description = StringHelpers.CleanString(tableRow[2]);
                ach.Category = StringHelpers.CleanString(tableRow[3]);
                ach.SubCategory = StringHelpers.CleanString(tableRow[4]);
                ach.SubSubCategory = StringHelpers.CleanString(tableRow[5]);
                ach.RuneScore = StringHelpers.CleanString(tableRow[6]);
                
                achievements.Add(ach);
            }

            return achievements;
        }
    }
}