using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Full_Nitro_Client
{
    class ProgramSettings
    {
        // ---- GENERAL ----
        public string Version = "1.0.0.1";
        public bool Beta = false;
        // -----------------


        // ---- UPDATES ----
        public string UpdateURL = "https://updates.cldm.ml/full-nitro-client/";
        public string UpdateURLXML = "master.xml";
        public string UpdateURLStruct = "downloads";
        // ------------------
    }
}
