using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AchievementDependencyCreator
{
    public partial class LevelSelectForm : Form
    {
        public int? level = null;
        public LevelSelectForm(string skill)
        {
            this.Text = "Level input: " + skill;
            DialogResult = DialogResult.Cancel;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBox1.Text, out var val))
            {
                level = val;
                DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("That's not a number");
            }
        }
    }
}
