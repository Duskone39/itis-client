using Itis.Client.Dtos;

namespace Itis.Client.Entities
{
  public class CurrencyRating
  {
    public long RankId { get; set; }
    public string? TaxonCurrency { get; set; }

    public static implicit operator CurrencyRating?(SvcCurrencyDataDto? dto)
    {
      if (dto == null)
        return null;

      return new CurrencyRating()
      {
        RankId = dto.RankId,
        TaxonCurrency = dto.TaxonCurrency,
      };
    }
  }
}
