using System;
using System.Runtime.Serialization;
using System.ServiceModel;
using RfyRedPill.BusinessLogic.Model;

namespace RedPillServiceRole
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract(Namespace = "http://KnockKnock.readify.net")]
    public interface IRedPill
    {
        [OperationContract]
        Guid WhatIsYourToken();

        [OperationContract]
        TriangleType WhatShapeIsThis(int a, int b, int c);

        [OperationContract]
        [FaultContract(typeof(System.ArgumentOutOfRangeException))]
        long FibonacciNumber(long n);

        [OperationContract]
        string ReverseWords(string s);
    }
}
