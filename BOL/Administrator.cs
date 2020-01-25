using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PersonLib;

namespace BOL
{
    public class Administrator : Person
    {
        PersonLib.Person p = new PersonLib.Person();

        //-----------------------------------
        public bool ReviewAuctionRequest()
        {
            throw new NotImplementedException();
        }
        //Vetem njera nga keto do te perdoret per konfirmimin/refuzimin e kerkeses
        public void AproveAuctionRequest() { }
        public void DenyAuctionRequest() { }
        //-------------------------------

        public bool ReviewCreditRequest()
        {
            throw new NotImplementedException();
        }
        //Vetem njera nga keto do te perdoret per konfirmimin/refuzimin e kerkeses
        public void ApproveCreditRequest() { }
        public void DenyCreditRequest() { }

    }
}
