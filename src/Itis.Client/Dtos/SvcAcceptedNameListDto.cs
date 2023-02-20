using Itis.Client.Dtos.Abstractions;

namespace Itis.Client.Dtos
{
  public class SvcAcceptedNameListDto : SvcTsnBaseDto
  {
    public List<SvcAcceptedNameDto>? AcceptedNames { get; set; }
  }
}
