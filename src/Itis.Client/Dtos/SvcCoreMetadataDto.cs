using Itis.Client.Dtos.Abstractions;

namespace Itis.Client.Dtos
{
  public class SvcCoreMetadataDto : SvcTsnBaseDto
  {
    public long RankId { get; set; }
    public string? CredRating { get; set; }
    public string? TaxonCoverage { get; set; }
    public string? TaxonCurrency { get; set; }
    public string? TaxonUsageRating { get; set; }
    // ReSharper disable once IdentifierTypo
    public string? UnacceptReason { get; set; }
  }
}
