using Itis.Client.Dtos;

namespace Itis.Client.Entities
{
  public class Kingdom
  {
    public int Id { get; set; }
    public string? Name { get; set; }

    public static implicit operator Kingdom?(SvcKingdomInfoDto? dto)
    {
      if (dto == null)
        return null;

      return new Kingdom()
      {
        Name = dto.KingdomName,
        Id = int.Parse(dto.KingdomId),
      };
    }
  }
}
