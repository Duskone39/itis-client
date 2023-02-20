using Itis.Client.Dtos;

namespace Itis.Client.Entities
{
  public class CommonName
  {
    public string? Name { get; set; }
    public string? Language { get; set; }

    public static implicit operator CommonName?(SvcCommonNameDto? dto)
    {
      if (dto == null)
        return null;

      return new CommonName
      {
        Name = dto.CommonName,
        Language = dto.Language,
      };
    }
  }
}
