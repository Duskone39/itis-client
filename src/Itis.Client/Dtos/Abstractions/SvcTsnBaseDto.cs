namespace Itis.Client.Dtos.Abstractions
{
  public abstract class SvcTsnBaseDto : SvcBaseDto
  {
    public string Tsn { get; set; } = null!;
  }
}
