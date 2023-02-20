using Itis.Client.Dtos;

namespace Itis.Client.Entities
{
  public class GeographicDivision
  {
    public DateTime? UpdateDate { get; set; }
    public string? GeographicValue { get; set; }

    public static implicit operator GeographicDivision?(SvcTaxonGeoDivisionDto? dto)
    {
      if (dto == null)
        return null;

      return new GeographicDivision()
      {
        GeographicValue = dto.GeographicValue,
        UpdateDate = dto.UpdateDate == null ? null : DateTime.Parse(dto.UpdateDate),
      };
    }
  }
}
