using Itis.Client.Dtos;

namespace Itis.Client.Entities
{
  public class Synonym
  {
    public string? Name { get; set; }
    public string? Author { get; set; }

    public static implicit operator Synonym?(SvcTaxonNameDto? dto)
    {
      if (dto == null)
        return null;

      return new Synonym()
      {
        Name = dto.SciName,
        Author = dto.Author,
      };
    }
  }
}
