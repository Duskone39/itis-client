using Itis.Client.Dtos;

namespace Itis.Client.Entities
{
  public class AcceptedName
  {
    public string? Name { get; set; }
    public string? Author { get; set; }
    public string? AcceptedTsn { get; set; }

    public static implicit operator AcceptedName?(SvcAcceptedNameDto? dto)
    {
      if (dto == null)
        return null;

      return new AcceptedName
      {
        Author = dto.Author,
        Name = dto.AcceptedName,
        AcceptedTsn = dto.AcceptedTsn,
      };
    }
  }
}
