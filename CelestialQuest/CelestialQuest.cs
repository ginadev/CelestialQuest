using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Engine;

namespace CelestialQuest
{
    public partial class CelestialQuest : Form
    {
        private Player _player;

        public CelestialQuest()
        {
            InitializeComponent();

            Location location = new Location(1, "Home", "This is your house.");
            //location.ID = 1;
            //location.Name = "Home";
            //location.Description = "This is your house.";

            _player = new Player(10, 10, 20, 0, 1);
            lblHitPoints.Text = _player.CurrentHitPoints.ToString();
            lblGold.Text = _player.Gold.ToString();
            lblExperience.Text = _player.ExperiencePoints.ToString();
            lblLevel.Text = _player.Level.ToString();
        }

    }
}