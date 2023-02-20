using Itis.Client.Dtos.Abstractions;

namespace Itis.Client.Dtos
{
  public class SvcTaxonDateDataDto : SvcTsnBaseDto
  {
    public string? UpdateDate { get; set; }
    public string? InitialTimeStamp { get; set; }
  }
}
