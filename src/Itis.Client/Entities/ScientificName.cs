using Itis.Client.Dtos;

namespace Itis.Client.Entities
{
  public class ScientificName
  {
    public string? Author { get; set; }
    public string? UnitInd1 { get; set; }
    public string? UnitInd2 { get; set; }
    public string? UnitInd3 { get; set; }
    public string? UnitInd4 { get; set; }
    public string? UnitName1 { get; set; }
    public string? UnitName2 { get; set; }
    public string? UnitName3 { get; set; }
    public string? UnitName4 { get; set; }
    public string? CombinedName { get; set; }

    public static implicit operator ScientificName?(SvcScientificNameDto? dto)
    {
      if (dto == null)
        return null;

      return new ScientificName()
      {
        Author = dto.Author,
        UnitInd1 = dto.UnitInd1,
        UnitInd2 = dto.UnitInd2,
        UnitInd3 = dto.UnitInd3,
        UnitInd4 = dto.UnitInd4,
        UnitName1 = dto.UnitName1,
        UnitName2 = dto.UnitName2,
        UnitName3 = dto.UnitName3,
        UnitName4 = dto.UnitName4,
        CombinedName = dto.CombinedName,
      };
    }
  }
}
