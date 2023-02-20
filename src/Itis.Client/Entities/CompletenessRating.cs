using Itis.Client.Dtos;

namespace Itis.Client.Entities
{
  public class CompletenessRating
  {
    public long RankId { get; set; }
    public string? Completeness { get; set; }

    public static implicit operator CompletenessRating?(SvcGlobalSpeciesCompletenessDto? dto)
    {
      if (dto == null)
        return null;

      return new CompletenessRating()
      {
        RankId = dto.RankId,
        Completeness = dto.Completeness,
      };
    }
  }
}
