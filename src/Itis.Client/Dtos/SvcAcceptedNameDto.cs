using Itis.Client.Dtos.Abstractions;

namespace Itis.Client.Dtos
{
  public class SvcAcceptedNameDto : SvcBaseDto
  {
    public string? AcceptedName { get; set; }
    public string? AcceptedTsn { get; set; }
    public string? Author { get; set; }
  }
}
