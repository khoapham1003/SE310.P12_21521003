using Bai1_ADO.NET.Business;
using System.Windows.Forms;

namespace Bai1_ADO.NET
{
    public partial class MainForm : Form
    {
        private FarmService _farmService;
        public MainForm()
        {
            InitializeComponent();
        }
        public MainForm(int cowA,int sheepA, int goatA)
        {
            InitializeComponent();
            _farmService = new FarmService();
            _farmService.UpdateInitialAmount(cowA, sheepA, goatA);  
            _farmService.UpdateInterface(lb_cowCount, lb_sheepCount, lb_goatCount);
        }
        private void bt_hungry_Click(object sender, EventArgs e)
        {
            rtb_sound.Text=_farmService.GetHungrySound();
        }

        private void bt_feed_Click(object sender, EventArgs e)
        {
            _farmService.UpdateAfterFeeding(lb_cowCount, lb_cowMilkVolume, lb_sheepCount, lb_sheepMilkVolume, lb_goatCount, lb_goatMilkVolume);
            rtb_sound.Text = "";
        }
    }
}
