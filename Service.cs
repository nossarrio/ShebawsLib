using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using System;

namespace ShebawsCoreLibrary
{
    public class ShebawsService : IShebawsService
    { 
        public ObservationModel getObservation(IConfiguration configuration)
        {
            //todo: There should be an AppSettings model
            string ObservationUrl = configuration.GetSection("AppSettings").GetSection("ServiceUrl").Value;

            return JsonConvert.DeserializeObject<ObservationModel>(Utility.HTTPGet(ObservationUrl));
        }
    }
}
