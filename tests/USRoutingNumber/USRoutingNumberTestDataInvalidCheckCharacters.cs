using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IBANValidation.Tests.USRoutingNumber
{
    public class USRoutingNumberTestDataInvalidCheckCharacters : TheoryData<string>
    {
        public USRoutingNumberTestDataInvalidCheckCharacters()
        {
            Add("122105154");
            Add("122235824");
            Add("123103724");
            Add("074900784");
            Add("101000184");
            Add("091215924");
            Add("081000214");
            Add("104000024");
            Add("091300024");
            Add("123000224");
            Add("124302154");
            Add("307070114");
            Add("082000544");
            Add("102101644");
            Add("071904774");
            Add("104000024");
            Add("042100174");
            Add("091300024");
            Add("101200454");
            Add("121201692");
            Add("041202584");
            Add("091408504");
            Add("125000104");
            Add("091000024");
            Add("121122674");
            Add("102000024");
            Add("081202754");
            Add("073000544");
            Add("083900364");
            Add("091000024");
            Add("092900384");
            Add("107002311");
            Add("042000012");
            Add("064000051");
            Add("075000021");
        }
    }
}
