using Itis.Client.Dtos.Abstractions;

namespace Itis.Client.Dtos
{
  public class SvcTaxonJurisdictionalOriginDto : SvcBaseDto
  {
    public string? Origin { get; set; }
    public string? UpdateDate { get; set; }
    public string? JurisdictionValue { get; set; }
  }
}
