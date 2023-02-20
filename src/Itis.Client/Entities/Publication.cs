using Itis.Client.Dtos;

namespace Itis.Client.Entities
{
  public class Publication
  {
    public string? Isbn { get; set; }
    // ReSharper disable once IdentifierTypo
    public string? Issn { get; set; }
    public string? Name { get; set; }
    public string? Title { get; set; }
    public string? Pages { get; set; }
    public string? Place { get; set; }
    public string? Author { get; set; }
    public string? Comment { get; set; }
    public string? Publisher { get; set; }
    public DateTime? UpdateDate { get; set; }
    public DateTime? ListedPubDate { get; set; }
    public List<Reference>? References { get; set; }
    public DateTime? ActualPublicationDate { get; set; }

    public static implicit operator Publication?(SvcTaxonPublicationDto? dto)
    {
      if (dto == null)
        return null;

      return new Publication()
      {
        Isbn = dto.Isbn,
        Issn = dto.Issn,
        Pages = dto.Pages,
        Title = dto.Title,
        Place = dto.PubPlace,
        Comment = dto.PubComment,
        Publisher = dto.Publisher,
        Author = dto.ReferenceAuthor,
        UpdateDate = dto.UpdateDate == null ? null : DateTime.Parse(dto.UpdateDate),
        ListedPubDate = dto.ListedPubDate == null ? null : DateTime.Parse(dto.ListedPubDate),
        ActualPublicationDate = dto.ActualPubDate == null ? null : DateTime.Parse(dto.ActualPubDate),

        References = dto.ReferenceFor?
          .Select(c => (Reference?)c)
          .Where(c => c != null)
          .Select(c => c!)
          .ToList(),
      };
    }
  }
}
