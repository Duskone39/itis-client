using Itis.Client.Dtos.Abstractions;

namespace Itis.Client.Dtos
{
  public class SvcCommonNameDto : SvcTsnBaseDto
  {
    public string? Language { get; set; }
    public string? CommonName { get; set; }
  }
}
