using Itis.Client.Dtos;

namespace Itis.Client.Entities
{
  public class Expert
  {
    public string? Name { get; set; }
    public string? Comment { get; set; }
    public DateTime? UpdateDate { get; set; }
    public List<Reference>? References { get; set; }

    public static implicit operator Expert?(SvcTaxonExpertDto? dto)
    {
      if (dto == null)
        return null;

      return new Expert()
      {
        Name = dto.Expert,
        Comment = dto.Comment,

        References = dto.ReferenceFor?
          .Select(c => (Reference?)c)
          .Where(c => c != null)
          .Select(c => c!)
          .ToList(),

        UpdateDate = dto.UpdateDate == null ? null : DateTime.Parse(dto.UpdateDate),
      };
    }
  }
}
