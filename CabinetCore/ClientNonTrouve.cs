using System;
using System.Runtime.Serialization;

namespace CabinetCore
{
    
    public class ClientNonTrouve : Exception
    {
        public ClientNonTrouve()
        {
        }

        public ClientNonTrouve(string message) : base(message)
        {
        }
        
    }
}