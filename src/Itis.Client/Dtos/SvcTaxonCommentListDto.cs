using Itis.Client.Dtos.Abstractions;

namespace Itis.Client.Dtos
{
  public class SvcTaxonCommentListDto : SvcTsnBaseDto
  {
    public List<SvcTaxonCommentDto>? Comments { get; set; }
  }
}
