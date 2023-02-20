using Itis.Client.Dtos.Abstractions;

namespace Itis.Client.Dtos
{
  public class SvcFullRecordDto : SvcTsnBaseDto
  {
    public SvcAcceptedNameListDto? AcceptedNameList { get; set; }
    public SvcTaxonCommentListDto? CommentList { get; set; }
    public SvcCommonNameListDto? CommonNameList { get; set; }
    public SvcGlobalSpeciesCompletenessDto? CompletenessRating { get; set; }
    public SvcCoreMetadataDto? CoreMetadata { get; set; }
    public SvcKingdomInfoDto? Kingdom { get; set; }
    public SvcScientificNameDto? ScientificName { get; set; }
    public SvcTaxonJurisdictionalOriginListDto? JurisdictionalOriginList { get; set; }
    public SvcHierarchyRecordDto? HierarchyUp { get; set; }
    public SvcTaxonOtherSourceListDto? OtherSourceList { get; set; }
    public SvcParentTsnDto? ParentTSN { get; set; }
    public SvcTaxonPublicationListDto? PublicationList { get; set; }
    public SvcSynonymNameListDto? SynonymList { get; set; }
    public SvcTaxonRankInfoDto? TaxRank { get; set; }
    public SvcTaxonAuthorshipDto? TaxonAuthor { get; set; }
    public SvcUnacceptDataDto? UnacceptReason { get; set; }
    public SvcTaxonUsageData? Usage { get; set; }
    public SvcTaxonGeoDivisionListDto? GeographicDivisionList { get; set; }
    public SvcTaxonExpertListDto? ExpertList { get; set; }
    public SvcTaxonDateDataDto? DateData { get; set; }
    public SvcCurrencyDataDto? CurrencyRating { get; set; }
    public SvcCredibilityDataDto? CredibilityRating { get; set; }
    public string? JsonResponse { get; set; }
  }
}
