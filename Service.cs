using System;

namespace ShebawsCoreLibrary
{
    public class ShebawsService
    {
        string Url = "";       

        public ShebawsService(string url)
        {
            Url = url;
        }

        public string getObservation()
        {
            return Utility.HTTPGet(Url);
        } 
    }
}
