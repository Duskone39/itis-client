using Itis.Client.Dtos.Abstractions;

namespace Itis.Client.Dtos
{
  public class SvcScientificNameDto : SvcTsnBaseDto
  {
    public string? Author { get; set; }
    public string? CombinedName { get; set; }
    public string? Kingdom { get; set; }
    public string? UnitInd1 { get; set; }
    public string? UnitInd2 { get; set; }
    public string? UnitInd3 { get; set; }
    public string? UnitInd4 { get; set; }
    public string? UnitName1 { get; set; }
    public string? UnitName2 { get; set; }
    public string? UnitName3 { get; set; }
    public string? UnitName4 { get; set; }
  }
}
