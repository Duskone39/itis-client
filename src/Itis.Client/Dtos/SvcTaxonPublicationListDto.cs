using Itis.Client.Dtos.Abstractions;

namespace Itis.Client.Dtos
{
  public class SvcTaxonPublicationListDto : SvcTsnBaseDto
  {
    public List<SvcTaxonPublicationDto>? Publications { get; set; }
  }
}
