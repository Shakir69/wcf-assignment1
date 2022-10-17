using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace Asssignment_1
{
   
    [ServiceContract]
    public interface IService1
    {

        [OperationContract]
        string GetPrime_Number(int pn);
      
        [OperationContract]
        string getSum_of_digits(int num);

        [OperationContract]
        string reverse_String(string val);
       
        [OperationContract]
        string html_tags(string value , string val);

        [OperationContract]
        string sort_Numbers(string asc_desc, int number, int val, int value, int num, int n);

    }



}
