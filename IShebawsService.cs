using Microsoft.Extensions.Configuration;

namespace ShebawsCoreLibrary
{
    public interface IShebawsService
    {
          ObservationModel getObservation(IConfiguration configuration);
    }
}