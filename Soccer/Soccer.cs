/*Soccer
 * Author: Jaren Montano
 * Date: 11/5/2023
 * Purpose:
 * this is the soccer class
 * it will pull from the abstract 
 * sporting, and it will have some special
 * methods for itself.
 * 
 */
//the abstract public Sporting(string name, string coach, string gen, string sportType)

using IBudget;

namespace SportingAbstract
{
    public class Soccer : Sporting, IBudgeting
    {
        private string kitSponsor;
        private string fieldLocation;
        private int numberOnField;
       

        public Soccer()
        {
            kitSponsor = "UnKnown";
            fieldLocation = "UnKnown";
            numberOnField = 666;
        }
        public Soccer(string name, string coach, string gen, string kit, string location, int numOnField)
        : base(name, coach, gen, "Soccer")
        {
            kitSponsor = kit;
            fieldLocation = location;
            numberOnField = numOnField;

        }

        public string KitSponsor {
            get { return kitSponsor; }
            set { kitSponsor = value; }
        }
        public string FieldLocation
        {
            get { return fieldLocation; }
            set { fieldLocation = value; }
        }
        public int NumberOnField
        {
            get { return numberOnField; }
            set { numberOnField = value; }
        }

        public decimal FundedAmount { get; set; }
        public decimal OffSeasonCosts { get; set; }
        public decimal TravelCosts { get; set; }

        public void SetFundingAmt()
        {
            FundedAmount = 600000M;
        }

        public void SetOffSeasonCosts()
        {
            OffSeasonCosts = 180100M;
        }

        public void SetTravelCosts()
        {
            TravelCosts = 423230M;
        }

        //this pulls from the abstracts to string then adds our stuff.

        public override string ToString()
        {
            return base.ToString() +
                "\n Kit: " + KitSponsor +
                "\n Field Location: " + FieldLocation +
                "\n Number of Players On the Field: " + NumberOnField;
                
        }        
    }
}