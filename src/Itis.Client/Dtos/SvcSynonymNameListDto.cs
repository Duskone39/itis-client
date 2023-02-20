using Itis.Client.Dtos.Abstractions;

namespace Itis.Client.Dtos
{
  public class SvcSynonymNameListDto : SvcTsnBaseDto
  {
    public List<SvcTaxonNameDto>? Synonyms { get; set; }
  }
}
