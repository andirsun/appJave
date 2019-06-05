using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft;
using Newtonsoft.Json;

namespace Prueba2.model
{
    public class usuario
    {
        private string user;
        private string pass;
        public bool valido { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public string email { get; set; }
        public string periodo { get; set; }
        public string emplid { get; set; }

        [JsonProperty("x-t6519fdd1s5q")]
        public string token { get; set; }
        public long token_expire_in { get; set; }
        public List<string> roles { get; set; }

        /*
        public string User
        {
            get { return user; }
            set
            {
                user = value;
            }
        }
        public string Pass
        {
            get
            {
                return pass;
            }
            set
            {
                pass = value;
            }
        }
        */
}
}
