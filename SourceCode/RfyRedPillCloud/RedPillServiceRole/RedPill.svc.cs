using System;
using RfyRedPill.BusinessLogic.Model;
using System.Linq;
using RfyRedPill.BusinessLogic;
using System.ServiceModel;

namespace RedPillServiceRole
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class RedPill : IRedPill
    {

        public Guid WhatIsYourToken()
        {
            return new Guid("1a3bd9aa-fbe9-489f-9a33-410318ad39a5");
        }


        public TriangleType WhatShapeIsThis(int a, int b, int c)
        {
            return RedPillController.WhatShapeIsThis(a, b, c);
        }

        public long FibonacciNumber(long n)
        {

            try
            {
                return RedPillController.GetFibonacci(n);
            }
            catch (ArgumentOutOfRangeException ex)
            {
                throw new FaultException<ArgumentOutOfRangeException>(ex, ex.Message);
            }

        }

        public string ReverseWords(string s)
        {
            return RedPillController.ReverseWords(s);
        }

    }
}
