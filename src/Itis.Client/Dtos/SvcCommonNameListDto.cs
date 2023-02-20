using Itis.Client.Dtos.Abstractions;

namespace Itis.Client.Dtos
{
  public class SvcCommonNameListDto : SvcTsnBaseDto
  {
    public List<SvcCommonNameDto>? CommonNames { get; set; }
  }
}
