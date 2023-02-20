using Itis.Client.Dtos.Abstractions;

namespace Itis.Client.Dtos
{
  public class SvcTaxonNameDto : SvcTsnBaseDto
  {
    public string? Author { get; set; }
    public string? SciName { get; set; }
  }
}
