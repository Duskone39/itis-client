using Itis.Client.Dtos.Abstractions;

namespace Itis.Client.Dtos
{
  public class SvcTaxonPublicationDto : SvcBaseDto
  {
    public string? ActualPubDate { get; set; }
    public string? Isbn { get; set; }
    // ReSharper disable once IdentifierTypo
    public string? Issn { get; set; }
    public string? ListedPubDate { get; set; }
    public string? Pages { get; set; }
    public string? PubComment { get; set; }
    public string? PubName { get; set; }
    public string? PubPlace { get; set; }
    public string? Publisher { get; set; }
    public string? ReferenceAuthor { get; set; }
    public string? Title { get; set; }
    public string? UpdateDate { get; set; }
    public List<SvcReferenceForElementDto>? ReferenceFor { get; set; }
  }
}
