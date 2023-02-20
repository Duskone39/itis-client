using Itis.Client.Dtos.Abstractions;

namespace Itis.Client.Dtos
{
  public class SvcTaxonJurisdictionalOriginListDto : SvcTsnBaseDto
  {
    public List<SvcTaxonJurisdictionalOriginDto>? JurisdictionalOrigins { get; set; }
  }
}
