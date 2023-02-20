using Itis.Client.Dtos;

namespace Itis.Client.Entities
{
  public class Author
  {
    public long RankId { get; set; }
    public string? RankName { get; set; }
    public string? Authorship { get; set; }
    public DateTime? UpdateDate { get; set; }

    public static implicit operator Author?(SvcTaxonAuthorshipDto? dto)
    {
      if (dto == null)
        return null;

      return new Author()
      {
        RankId = dto.RankId,
        RankName = dto.RankName,
        Authorship = dto.Authorship,
        UpdateDate = string.IsNullOrWhiteSpace(dto.UpdateDate) ? null : DateTime.Parse(dto.UpdateDate),
      };
    }
  }
}
