using Itis.Client.Dtos;

namespace Itis.Client.Entities
{
  public class Comment
  {
    public long Id { get; set; }
    public string? Commentator { get; set; }
    public DateTime UpdateDate { get; set; }
    public string? CommentDetail { get; set; }
    public DateTime? CommentTimeStamp { get; set; }

    public static implicit operator Comment?(SvcTaxonCommentDto? dto)
    {
      if (dto == null)
        return null;

      return new Comment
      {
        Id = long.Parse(dto.CommentId),
        Commentator = dto.Commentator,
        CommentDetail = dto.CommentDetail,
        UpdateDate = DateTime.Parse(dto.UpdateDate),
        CommentTimeStamp = DateTime.Parse(dto.CommentTimeStamp),
      };
    }
  }
}
