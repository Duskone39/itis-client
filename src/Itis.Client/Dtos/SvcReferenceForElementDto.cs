using Itis.Client.Dtos.Abstractions;

namespace Itis.Client.Dtos
{
  public class SvcReferenceForElementDto : SvcBaseDto
  {
    public string? Name { get; set; }
    public string? RefLanguage { get; set; }
    public string? ReferredTsn { get; set; }
  }
}
