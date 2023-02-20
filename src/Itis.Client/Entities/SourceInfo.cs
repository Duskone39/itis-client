using Itis.Client.Dtos;

namespace Itis.Client.Entities
{
  public class SourceInfo
  {
    public string? Type { get; set; }
    public string? Source { get; set; }
    public string? Comment { get; set; }
    public string? Version { get; set; }
    public DateTime? UpdateDate { get; set; }
    public DateTime? AcquisitionDate { get; set; }
    public List<Reference>? References { get; set; }

    public static implicit operator SourceInfo?(SvcTaxonOtherSourceDto? dto)
    {
      if (dto == null)
        return null;

      return new SourceInfo()
      {
        Source = dto.Source,
        Type = dto.SourceType,
        Version = dto.Version,
        Comment = dto.SourceComment,
        UpdateDate = dto.UpdateDate == null ? null : DateTime.Parse(dto.UpdateDate),
        AcquisitionDate = dto.AcquisitionDate == null ? null : DateTime.Parse(dto.AcquisitionDate),

        References = dto.ReferenceFor?
          .Select(c => (Reference?)c)
          .Where(c => c != null)
          .Select(c => c!)
          .ToList(),
      };
    }
  }
}
