/*PickleBall
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

using System.Transactions;

namespace SportingAbstract
{
    public class PickleBall: Sporting
    {
        private string environment;// indoor vs outdoor// or both
        private string ballBrand;

        public PickleBall()
        {
            environment = "UnKnown";
            ballBrand = "UnKnown";

        }

        public PickleBall(string name, string coach, string gen, string enviro, string brandBall)
        : base(name, coach, gen, "Pickleball")
        {
            environment = enviro;
            ballBrand = brandBall;
        }

        public string Environment
        {
            get { return environment; }
            set { environment = value; }
        }
        public string BallBrand
        {
            get { return ballBrand; }
            set { ballBrand = value; }
        }

        //this pulls from the abstracts to string then adds our stuff.
        public override string ToString()
        {
            return base.ToString() + 
                "\nEnvironment:  " + Environment +
                "\nBrand of Ball: " + BallBrand;
        }


    }
}