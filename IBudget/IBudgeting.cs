/*IBudgeting.cs
 * Author: Jaren Montano
 * Date: 11/5/2023
 * Purpose: Is to be
 * and interface so the Classes
 * that pull this must instantiate
 * these methods.
 * 
 */



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IBudget
{
    public interface IBudgeting
    {

        void SetFundingAmt();
        void SetTravelCosts();
        void SetOffSeasonCosts();


    }
}
