using Itis.Client.Dtos;

namespace Itis.Client.Entities
{
  public class Taxonomy
  {
    public int Id { get; set; }
    public int? ParentId { get; set; }
    public Author? Author { get; set; }
    public Kingdom? Kingdom { get; set; }
    public string? Coverage { get; set; }
    public string? CredRating { get; set; }
    public DateTime UpdateDate { get; set; }
    public Hierarchy? Hierarchy { get; set; }
    public DateTime InitialTime { get; set; }
    public List<Expert>? Experts { get; set; }
    public string? UsageRating { get; set; }
    // ReSharper disable once IdentifierTypo
    public string? UnacceptReason { get; set; }
    public List<Comment>? Comments { get; set; }
    public List<Synonym>? Synonyms { get; set; }
    public string? OriginalJsonView { get; set; }
    public List<SourceInfo>? Sources { get; set; }
    public List<CommonName>? CommonNames { get; set; }
    public ScientificName? ScientificName { get; set; }
    public CurrencyRating? CurrencyRating { get; set; }
    public List<Publication>? Publications { get; set; }
    public List<AcceptedName>? AcceptedNames { get; set; }
    public CompletenessRating? CompletenessRating { get; set; }
    public List<GeographicDivision>? GeographicDivisions { get; set; }
    public List<JurisdictionalOrigin>? JurisdictionalOrigins { get; set; }

    public static implicit operator Taxonomy?(SvcFullRecordDto? dto)
    {
      if (dto == null)
        return null;

      return new Taxonomy
      {
        Kingdom = dto.Kingdom,
        Id = int.Parse(dto.Tsn),
        Author = dto.TaxonAuthor,
        Hierarchy = dto.HierarchyUp,
        CurrencyRating = dto.CurrencyRating,
        ScientificName = dto.ScientificName,
        OriginalJsonView = dto.JsonResponse,
        UsageRating = dto.Usage?.TaxonUsageRating,
        Coverage = dto.CoreMetadata?.TaxonCoverage,
        CompletenessRating = dto.CompletenessRating,
        CredRating = dto.CredibilityRating?.CredRating,
        UnacceptReason = dto.UnacceptReason?.UnacceptReason,
        UpdateDate = DateTime.Parse(dto.DateData.UpdateDate),
        InitialTime = DateTime.Parse(dto.DateData.InitialTimeStamp),
        Experts = MapList<SvcTaxonExpertDto, Expert>(dto.ExpertList?.Experts),
        Synonyms = MapList<SvcTaxonNameDto, Synonym>(dto.SynonymList?.Synonyms),
        Comments = MapList<SvcTaxonCommentDto, Comment>(dto.CommentList?.Comments),
        CommonNames = MapList<SvcCommonNameDto, CommonName>(dto.CommonNameList?.CommonNames),
        ParentId = dto.ParentTSN?.ParentTsn == null ? null : int.Parse(dto.ParentTSN.ParentTsn),
        Sources = MapList<SvcTaxonOtherSourceDto, SourceInfo>(dto.OtherSourceList?.OtherSourceList),
        AcceptedNames = MapList<SvcAcceptedNameDto, AcceptedName>(dto.AcceptedNameList?.AcceptedNames),
        Publications = MapList<SvcTaxonPublicationDto, Publication>(dto.PublicationList?.Publications),
        GeographicDivisions = MapList<SvcTaxonGeoDivisionDto, GeographicDivision>(dto.GeographicDivisionList?.GeoDivisions),
        JurisdictionalOrigins = MapList<SvcTaxonJurisdictionalOriginDto, JurisdictionalOrigin>(dto.JurisdictionalOriginList?.JurisdictionalOrigins),
      };
    }

    private static List<TResult>? MapList<TSource, TResult>(List<TSource>? source) where TResult : class
    {
      if (source == null)
        return null;

      var result = source
        .Select(c => c as TResult)
        .Where(c => c != null)
        .Select(c => c!)
        .ToList();

      return result?.Count == 0 ?
        null :
        result;
    }
  }
}
