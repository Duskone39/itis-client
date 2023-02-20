using Itis.Client.Dtos.Abstractions;

namespace Itis.Client.Dtos
{
  public class SvcTaxonGeoDivisionDto : SvcTsnBaseDto
  {
    public string? GeographicValue { get; set; }
    public string? UpdateDate { get; set; }
  }
}
