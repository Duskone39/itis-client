using Itis.Client.Dtos.Abstractions;

namespace Itis.Client.Dtos
{
  public class SvcTaxonAuthorshipDto : SvcTsnBaseDto
  {
    public long RankId { get; set; }
    public string? RankName { get; set; }
    public string? Authorship { get; set; }
    public string? UpdateDate { get; set; }
  }
}
