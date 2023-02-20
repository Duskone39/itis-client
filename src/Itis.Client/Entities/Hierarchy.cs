using Itis.Client.Dtos;

namespace Itis.Client.Entities
{
  public class Hierarchy
  {
    public int? ParentId { get; set; }
    public string? Author { get; set; }
    public string? RankName { get; set; }
    public string? TaxonName { get; set; }
    public string? ParentName { get; set; }

    public static implicit operator Hierarchy?(SvcHierarchyRecordDto? dto)
    {
      if (dto == null)
        return null;

      return new Hierarchy()
      {
        Author = dto.Author,
        RankName = dto.RankName,
        TaxonName = dto.TaxonName,
        ParentName = dto.ParentName,
        ParentId = dto.ParentTsn == null ? null : int.Parse(dto.ParentTsn),
      };
    }
  }

}
