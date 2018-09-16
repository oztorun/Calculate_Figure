using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CalculataShapeForm;

namespace Calculator.Model.Factory
{
    public class SoftwareKnowledge : ISoftwareKnowledge
    {
        #region IAppDomain Members

        public string Property
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }

        public void method()
        {
            throw new NotImplementedException();
        }

        public void method2()
        {
            throw new NotImplementedException();
        }

        #endregion
    }

    interface ISoftwareKnowledge
    {
        string Property {get;}
        void method();
    }

    public enum CommandType
    {
        Default,
        Insert ,
        Update,
        Delete
    }

   
}
