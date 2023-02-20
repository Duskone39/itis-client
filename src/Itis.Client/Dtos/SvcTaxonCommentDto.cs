using Itis.Client.Dtos.Abstractions;

namespace Itis.Client.Dtos
{
  public class SvcTaxonCommentDto : SvcBaseDto
  {
    public string? CommentId { get; set; }
    public string? Commentator { get; set; }
    public string? UpdateDate { get; set; }
    public string? CommentDetail { get; set; }
    public string? CommentTimeStamp { get; set; }
  }
}
