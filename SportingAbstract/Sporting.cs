/*SportingAbstract
 * author: Jaren Montano
 * Date: 11/5/2023
 * Purpose: This will be the abstract
 * the will hold the base information about
 * sporting teams on campus.
 */




namespace SportingAbstract
{
    public abstract class Sporting
    {
        private string teamName;
        private string primaryCoach;
        private string gender;
        private string sport;


        public Sporting()
        {

        }

        public Sporting(string name, string coach, string gen, string sportType)
        {
            teamName = name;
            primaryCoach = coach;
            gender = gen;
            sport = sportType;
        }

        public string TeamName {
            get { return teamName; }
            set {  teamName = value; }
        }

        public string PrimaryCoach {
            get { return primaryCoach;}

            set {  primaryCoach = value; } 
        }

        public string Gender {
            get { return gender;}
            set {  gender = value; } 
        }
        public string Sport
        {
            get { return sport; }
            set { sport = value; }

        }

        public override string ToString()
        {
            return "Sport: " + Sport
                + "\nTeam Name: " + TeamName +
                "\nPrimary Coach: " + PrimaryCoach +
                "\nGender: " + Gender ;
        }

    }

}