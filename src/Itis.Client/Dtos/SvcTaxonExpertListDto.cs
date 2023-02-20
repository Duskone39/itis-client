using Itis.Client.Dtos.Abstractions;

namespace Itis.Client.Dtos
{
  public class SvcTaxonExpertListDto : SvcTsnBaseDto
  {
    public List<SvcTaxonExpertDto>? Experts { get; set; }
  }
}
