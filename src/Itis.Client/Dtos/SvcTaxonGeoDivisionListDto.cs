using Itis.Client.Dtos.Abstractions;

namespace Itis.Client.Dtos
{
  public class SvcTaxonGeoDivisionListDto : SvcTsnBaseDto
  {
    public List<SvcTaxonGeoDivisionDto>? GeoDivisions { get; set; }
  }
}
