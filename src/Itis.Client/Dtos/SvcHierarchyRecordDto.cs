using Itis.Client.Dtos.Abstractions;

namespace Itis.Client.Dtos
{
  public class SvcHierarchyRecordDto : SvcTsnBaseDto
  {
    public string? Author { get; set; }
    public string? ParentName { get; set; }
    public string? ParentTsn { get; set; }
    public string? RankName { get; set; }
    public string? TaxonName { get; set; }
  }
}
