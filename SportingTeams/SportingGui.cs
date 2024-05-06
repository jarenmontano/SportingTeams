using SportingAbstract;
using System.Drawing.Text;
using System.Security.AccessControl;

namespace SportingTeams


{
    public partial class SportingGui : Form
    {

        private PickleBall aPickleBall;
        private Soccer aSoccer;

        public SportingGui()
        {
            InitializeComponent();

        }

        private void SportingGui_Load(object sender, EventArgs e)
        {
            aPickleBall = new PickleBall("Picklers", "Jeff", "Co-ed", "Indoor", "PCKL Elite 40");
            aSoccer = new Soccer("Weber Wildcats", "Jeffery Clausen", "Male", "Nike", "FootBall Field", 11);

        }

        private void RBxSoccer_CheckedChanged(object sender, EventArgs e)
        {
            TBxTeamName.Text = aSoccer.TeamName;
            TBxSubclass.Text = "Kit Sponsor: " + aSoccer.KitSponsor;
            RTBxAllInfo.Text = aSoccer.ToString();
            aSoccer.SetTravelCosts();
            aSoccer.SetFundingAmt();
            aSoccer.SetOffSeasonCosts();

            RTBxFunding.Text = "Funded Amount: " + aSoccer.FundedAmount.ToString("C")
                + "\n Travel Costs: " + aSoccer.TravelCosts.ToString("C")
                + "\n Off Season Costs: " + aSoccer.OffSeasonCosts.ToString("C");
        }

        private void RBxPickleball_CheckedChanged(object sender, EventArgs e)
        {
            TBxTeamName.Text = aPickleBall.TeamName;
            TBxSubclass.Text = "Brand of Ball: " + aPickleBall.BallBrand;
            RTBxAllInfo.Text = aPickleBall.ToString();
            RTBxFunding.Text = "No Funding";
            

        }
    }
}