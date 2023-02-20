using Itis.Client.Dtos.Abstractions;

namespace Itis.Client.Dtos
{
  public class SvcCurrencyDataDto : SvcTsnBaseDto
  {
    public long RankId { get; set; }
    public string? TaxonCurrency { get; set; }
  }
}
