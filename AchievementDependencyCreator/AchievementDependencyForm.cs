using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;
using AchievementDependencyCreator.Model;
using RunescapeNavigator.Core.Enums;
using RunescapeNavigator.Core.Extensions;
using ListViewItem = System.Windows.Forms.ListViewItem;

namespace AchievementDependencyCreator
{
    public partial class AchievementDependencyForm : Form
    {
        private static List<Achievement> mappedAchievements = new List<Achievement>();
        private static List<ListViewItem> DependencyOptions = new List<ListViewItem>();
        
        public AchievementDependencyForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Test button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonLoadDepData_Click(object sender, System.EventArgs e)
        {
            if (mappedAchievements.Count < 1)
            {
                LogInfo("[-] Please load the achievements first!");
                return;
            }
            var fileDialog = new OpenFileDialog();
            fileDialog.CheckFileExists = true;
            fileDialog.Multiselect = false;
            fileDialog.CheckPathExists = true;
            var res = fileDialog.ShowDialog();
            if (res == DialogResult.OK)
            {
                mappedAchievements = JsonObjectFileSaveLoad.ReadFromJsonFile<List<Achievement>>(fileDialog.FileName);
                foreach (var achievement in mappedAchievements)
                {
                    var listItem = new ListViewItem(achievement.Name);
                    listItem.SubItems.Add(new ListViewItem.ListViewSubItem(listItem, achievement.Description));
                    listViewAchievement.Items.Add(listItem);
                }
            }
            LogInfo("[+] Loaded old dependency data");
        }
        private void buttonLoadData_Click(object sender, System.EventArgs e)
        {
            var fileDialog = new OpenFileDialog();
            fileDialog.CheckFileExists = true;
            fileDialog.Multiselect = false;
            fileDialog.CheckPathExists = true;
            var res = fileDialog.ShowDialog();
            if (res == DialogResult.OK)
            {
                mappedAchievements = JsonObjectFileSaveLoad.ReadFromJsonFile<List<Achievement>>(fileDialog.FileName);
                foreach (var achievement in mappedAchievements)
                {
                    var listItem = new ListViewItem(achievement.Name);
                    listItem.SubItems.Add(new ListViewItem.ListViewSubItem(listItem, achievement.Description));
                    listViewAchievement.Items.Add(listItem);
                    DependencyOptions.Add((ListViewItem) listItem.Clone());
                }
                foreach (var skill in Enum.GetValues(typeof(Skill)))
                {
                    var listItem = new ListViewItem(skill.ToString());
                    listItem.SubItems.Add(new ListViewItem.ListViewSubItem(listItem, "Level required to complete achievement"));
                    DependencyOptions.Add(listItem);
                }
                LogInfo("[+] Loaded achievement data");
            }
        }

        private ListViewItemSelectionChangedEventArgs currentAchievement = null;
        private void listViewAchievement_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            try
            {
                labelTarget.Text = "Target Dependency List: " + e.Item.Text;
                listViewTargetDep.Items.Clear();
                listViewCurrentDep.Items.Clear();
                listViewTargetDep.Items.AddRange(DependencyOptions.ToArray());
                var oldData = mappedAchievements.FirstOrDefault(x => x.Name == e.Item.Text);
                foreach (var oldDataDependency in oldData.AchievementBaseDependencies)
                {
                    var listItem = new ListViewItem(oldDataDependency.Name);
                    listItem.SubItems.Add(new ListViewItem.ListViewSubItem(listItem, oldDataDependency.Description));
                    DeleteFromTargetDependency(oldDataDependency.Name);
                    listViewCurrentDep.Items.Add(listItem);
                }

                foreach (var dependency in oldData.SkillDependencies)
                {
                    var listItem = new ListViewItem(nameof(dependency.Skill));
                    listItem.SubItems.Add(new ListViewItem.ListViewSubItem(listItem, dependency.Level.ToString()));
                    DeleteFromTargetDependency(nameof(dependency.Skill));
                    listViewCurrentDep.Items.Add(listItem);
                }
                currentAchievement = e;
            }
            catch (Exception ex)
            {
                LogInfo("[-] Don't try to select multiple rows please!");
            }

        }

        private void listView2_DoubleClick(object sender, EventArgs e)
        {
            if (_currentItemNewDep != null)
            {
                var item = _currentItemNewDep.Item;
                if (Enum.TryParse<Skill>(item.Text, out var res))
                {
                    var levelSelector = new LevelSelectForm(res.ToString());
                    var diagRes = levelSelector.ShowDialog();
                    if (diagRes == DialogResult.OK)
                    {
                        var listItem = new ListViewItem(res.ToString());
                        listItem.SubItems.Add(new ListViewItem.ListViewSubItem(listItem, levelSelector.level.Value.ToString()));
                        listViewCurrentDep.Items.Add(listItem);
                    }
                    else
                    {
                        LogInfo("[-] Could not add level dependency");
                    }
                }
                else
                {
                    listViewCurrentDep.Items.Add((ListViewItem)item.Clone());
                }
                listViewTargetDep.Items.RemoveAt(_currentItemNewDep.ItemIndex);
                _currentItemNewDep = null;
            }
        }

        private ListViewItemSelectionChangedEventArgs _currentItemNewDep = null;
        private void listViewTargetDep_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            _currentItemNewDep = e;
        }

        private void listViewTargetDep_Leave(object sender, EventArgs e)
        {
            _currentItemNewDep = null;
        }
        private ListViewItemSelectionChangedEventArgs _currentDep = null;
        private void listViewCurrentDep_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            _currentDep = e;
        }

        private void listViewCurrentDep_DoubleClick(object sender, EventArgs e)
        {
            if (_currentDep != null)
            {
                 listViewTargetDep.Items.Add((ListViewItem)_currentItemNewDep.Item.Clone());
                 listViewCurrentDep.Items.RemoveAt(_currentItemNewDep.ItemIndex);
                 _currentDep = null;
            }
        }

        private void listViewCurrentDep_Leave(object sender, EventArgs e)
        {
            _currentDep = null;
        }

        private void LogInfo(string log)
        {
            Log.Text += log+"\n";
        }

        private void buttonSaveData_Click(object sender, EventArgs e)
        {
            try
            {
                JsonObjectFileSaveLoad.WriteToJsonFile(Path.Combine(AppContext.BaseDirectory, "AllDependencies.json"), mappedAchievements);
                LogInfo("[+] Saved all dependency data to file");
            }
            catch (Exception ex)
            {
                LogInfo("[-] Error while saving data " + ex.GetType().ToString());
            }
        }

        private void buttonCurrentData_Click(object sender, EventArgs e)
        {
            if (currentAchievement == null)
            {
                LogInfo("[-] Current picked achievement is null, try again!");
                return;
            }
            var curr = mappedAchievements.FirstOrDefault(x => x.Name == currentAchievement.Item.Text);
            if (curr == null)
            {
                LogInfo("[-] Cannot find achievement to save, try again!");
            }
            var achievementDependencies = new List<AchievementBaseDependency>();
            var skillDependencies = new List<SkillBaseDependency>();

            foreach (ListViewItem item in listViewCurrentDep.Items)
            {
                if (Enum.TryParse<Skill>(item.Text, out var res))
                {
                    var sp = new SkillBaseDependency{Skill = res, Level = int.Parse(item.SubItems[1].Text) };
                    skillDependencies.Add(sp);
                }
                else
                {
                    var dep = new AchievementBaseDependency { Name = item.Text, Description = item.SubItems[1].Text };
                    achievementDependencies.Add(dep);
                }
            }
            // There is no list in loaded json list, so list is null
            if (curr.AchievementBaseDependencies == null)
            {
                curr.AchievementBaseDependencies = new List<AchievementBaseDependency>();
            }

            if (curr.SkillDependencies == null)
            {
                curr.SkillDependencies = new List<SkillBaseDependency>();
            }
            curr.AchievementBaseDependencies.Clear();
            curr.SkillDependencies.Clear();
            curr.AchievementBaseDependencies.AddRange(achievementDependencies);
            curr.SkillDependencies.AddRange(skillDependencies);

            LogInfo($"[+] Added {achievementDependencies.Capacity + skillDependencies.Count} dependencies to {curr.Name}");
        }

        public ListViewItem GetItemtoDelete(string ClientName)
        {
            for (int i = 0; i < listViewTargetDep.Items.Count; i++)
            {
                var listviewitem = listViewTargetDep.Items[i];
                if (ClientName == listviewitem.Text)
                {
                    return listviewitem;
                }
            }
            return null;
        }


        public void DeleteFromTargetDependency(string ClientName)
        {
            ListViewItem listviewitem = new ListViewItem();
            listviewitem = GetItemtoDelete(ClientName);
            if (listviewitem != null)
            {
                if (InvokeRequired)
                {
                    Invoke((MethodInvoker)delegate () { listViewTargetDep.Items.Remove(listviewitem); });
                }
                else
                {
                    listViewTargetDep.Items.Remove(listviewitem);
                }
            }
        }

        private void textBoxAchSearch_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxAchSearch.Text) || listViewAchievement.Items.Count < 1)
            {
                return;
            }
            ListViewItem foundItem = listViewAchievement.FindItemWithText(textBoxAchSearch.Text, true, 0, true);
            if (foundItem != null)
            {
                listViewAchievement.TopItem = foundItem;
            }
        }

        private void textBoxCurrentDepSearch_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxCurrentDepSearch.Text) || listViewCurrentDep.Items.Count < 1)
            {
                return;
            }
            ListViewItem foundItem = listViewCurrentDep.FindItemWithText(textBoxCurrentDepSearch.Text, true, 0, true);
            if (foundItem != null)
            {
                listViewCurrentDep.TopItem = foundItem;
            }
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxSearch.Text) || listViewTargetDep.Items.Count < 1)
            {
                return;
            }
            ListViewItem foundItem = listViewTargetDep.FindItemWithText(textBoxSearch.Text, true, 0, true);
            if (foundItem != null)
            {
                listViewTargetDep.TopItem = foundItem;
            }
        }
    }
}
