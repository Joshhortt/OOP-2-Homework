using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AMLibrary
{
	public class AccessAM
	{
        private void AccessModifier()
        {
            AccessAM accessModifier = new AccessAM();
            //accessModifier.
        }

        private void PrivateAM()
        {
            // private access modifier
        }

        private protected void PrivateProtectedAM()
        {
            // private protected access modifier
        }

        protected void ProtectedAM()
        {
            // protected access modifier
        }

        protected internal void ProtectedInternalAM()
        {
            // protected internal access modifier
        }

        internal void InternalAM()
        {
            // internal access modifier
        }

        public void PublicAM()
        {
            // public access modifier
        }
    }
}

/*
 //Available only to the container Class 
      private string privateVariable;

      // Available in entire assembly across the classes 
      internal string internalVariable;  

      //Available in the container class and the derived class   
      protected string protectedVariable; 

      //Available to the container class, entire assembly and to outside    
      public string publicVariable;   

      //Available to the derived class and entire assembly as well
      protected internal string protectedInternalVariable;  

      private string PrivateFunction()  
      { 
          return privateVariable;  
      }  

      internal string InternalFunction()
      {    
          return internalVariable; 
      }    

      protected string ProtectedFunction() 
      {       
          return protectedVariable; 
      }  

      public string PublicFunction() 
      {       
          return publicVariable; 
      }  

      protected internal string ProtectedInternalFunction()  
      {      
           return protectedInternalVariable;  
      }
 */
