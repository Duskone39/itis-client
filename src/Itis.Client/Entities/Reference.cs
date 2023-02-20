using Itis.Client.Dtos;

namespace Itis.Client.Entities
{
  public class Reference
  {
    public string? Name { get; set; }
    public string? Language { get; set; }
    //Можливо те саме що Taxonomy.Id
    public string? ReferredTsn { get; set; }

    public static implicit operator Reference?(SvcReferenceForElementDto? dto)
    {
      if (dto == null)
        return null;

      return new Reference()
      {
        Name = dto.Name,
        Language = dto.RefLanguage,
        ReferredTsn = dto.ReferredTsn,
      };
    }
  }
}
