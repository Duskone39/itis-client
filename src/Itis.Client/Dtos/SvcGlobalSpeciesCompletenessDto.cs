using Itis.Client.Dtos.Abstractions;

namespace Itis.Client.Dtos
{
  public class SvcGlobalSpeciesCompletenessDto : SvcTsnBaseDto
  {
    public long RankId { get; set; }
    public string? Completeness { get; set; }
  }
}
