using Org.BouncyCastle.Bcpg;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ToeicExamOnline
{
    public class ActionServiceResult
    {
        public ActionServiceResult()
        {

        }
        public ActionServiceResult(int _APPCode, string _Message, object _Data)
        {
            APPCode = _APPCode;
            Message = _Message;
            Data = _Data;
        }
        public int APPCode { get; set; }
        public string Message { get; set; }
        public object Data { get; set; }
    }
}
