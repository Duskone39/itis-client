using Itis.Client.Dtos;

namespace Itis.Client.Entities
{
  public class JurisdictionalOrigin
  {
    public string? Origin { get; set; }
    public DateTime? UpdateDate { get; set; }
    public string? JurisdictionValue { get; set; }

    public static implicit operator JurisdictionalOrigin?(SvcTaxonJurisdictionalOriginDto? dto)
    {
      if (dto == null)
        return null;

      return new JurisdictionalOrigin
      {
        Origin = dto.Origin,
        JurisdictionValue = dto.JurisdictionValue,
        UpdateDate = dto.UpdateDate == null ? null : DateTime.Parse(dto.UpdateDate),
      };
    }
  }
}
