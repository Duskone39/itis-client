using Itis.Client.Dtos.Abstractions;

namespace Itis.Client.Dtos
{
  public class SvcTaxonOtherSourceListDto : SvcTsnBaseDto
  {
    public List<SvcTaxonOtherSourceDto>? OtherSourceList { get; set; }
  }
}
