using Itis.Client.Dtos.Abstractions;

namespace Itis.Client.Dtos
{
  public class SvcTaxonRankInfoDto : SvcTsnBaseDto
  {
    public string? KingdomId { get; set; }
    public string? KingdomName { get; set; }
    public string? RankId { get; set; }
    public string? RankName { get; set; }
  }
}
