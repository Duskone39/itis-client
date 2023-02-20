using Itis.Client.Dtos.Abstractions;

namespace Itis.Client.Dtos
{
  public class SvcTaxonExpertDto : SvcBaseDto
  {
    public string? Comment { get; set; }
    public string? Expert { get; set; }
    public List<SvcReferenceForElementDto>? ReferenceFor { get; set; }
    public string? UpdateDate { get; set; }
  }
}
