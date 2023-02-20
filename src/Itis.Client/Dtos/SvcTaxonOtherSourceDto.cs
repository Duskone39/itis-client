using Itis.Client.Dtos.Abstractions;

namespace Itis.Client.Dtos
{
  public class SvcTaxonOtherSourceDto : SvcBaseDto
  {
    public string? Source { get; set; }
    public string? SourceComment { get; set; }
    public string? SourceType { get; set; }
    public string? UpdateDate { get; set; }
    public string? AcquisitionDate { get; set; }
    public string? Version { get; set; }
    public List<SvcReferenceForElementDto>? ReferenceFor { get; set; }
  }
}
