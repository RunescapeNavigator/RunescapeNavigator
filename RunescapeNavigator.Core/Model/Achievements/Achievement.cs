using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace RunescapeNavigator.Core.Model.Achievements
{
    public class Achievement : INotifyPropertyChanged
    {
        private string name;
        private string members;
        private string description;
        private string category;
        private string subcategory;
        private string subsubcategory;
        private string runescore;
        public string Name {
            get { return name; }
            set { 
                name = value;
                NotifyPropertyChanged();
            }
        }
        public string Members
        {
            get { return members; }
            set { 
                members = value;
                NotifyPropertyChanged();
            }
        }
        public string Description
        {
            get { return description; }
            set { 
                description = value;
                NotifyPropertyChanged();
            }
        }
        public string Category
        {
            get { return category; }
            set { 
                category = value;
                NotifyPropertyChanged();
            }
        }
        public string SubCategory
        {
            get { return subcategory; }
            set { 
                subcategory = value;
                NotifyPropertyChanged();
            }
        }
        public string SubSubCategory
        {
            get { return subsubcategory; }
            set { 
                subsubcategory = value;
                NotifyPropertyChanged();
            }
        }
        public string RuneScore
        {
            get { return runescore; }
            set { 
                runescore = value;
                NotifyPropertyChanged();
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void NotifyPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}