using Itis.Client.Dtos.Abstractions;

namespace Itis.Client.Dtos
{
  public class SvcKingdomInfoDto : SvcTsnBaseDto
  {
    public string? KingdomId { get; set; }
    public string? KingdomName { get; set; }
  }
}
