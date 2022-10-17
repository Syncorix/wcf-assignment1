using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfServiceAssignment1
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IMethodService" in both code and config file together.
    [ServiceContract]
    public interface IMethodService
    {
        [OperationContract]
        bool PrimeNumber(int number);

        [OperationContract]
        int SumOfDigits(string input);

        [OperationContract]
        string ReverseString(string input);

        [OperationContract]
        string HTMLTag(string tag, string data);

        [OperationContract]
        string SortNumbers(string sort, string input);

    }
}
