using System.Collections.Generic;

namespace ClinicalTrialDemoSite.Models
{
    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse); 
    public class NCTIdAliasList
    {
        public List<string> NCTIdAlias { get; set; }
    }

    public class OrgStudyIdInfo
    {
        public string OrgStudyId { get; set; }
    }

    public class SecondaryIdInfo
    {
        public string SecondaryId { get; set; }
        public string SecondaryIdType { get; set; }
        public string SecondaryIdLink { get; set; }
    }

    public class SecondaryIdInfoList
    {
        public List<SecondaryIdInfo> SecondaryIdInfo { get; set; }
    }

    public class Organization
    {
        public string OrgFullName { get; set; }
        public string OrgClass { get; set; }
    }

    public class IdentificationModule
    {
        public string NCTId { get; set; }
        public NCTIdAliasList NCTIdAliasList { get; set; }
        public OrgStudyIdInfo OrgStudyIdInfo { get; set; }
        public SecondaryIdInfoList SecondaryIdInfoList { get; set; }
        public Organization Organization { get; set; }
        public string BriefTitle { get; set; }
        public string OfficialTitle { get; set; }
        public string Acronym { get; set; }
    }

    public class ExpandedAccessInfo
    {
        public string HasExpandedAccess { get; set; }
    }

    public class StartDateStruct
    {
        public string StartDate { get; set; }
        public string StartDateType { get; set; }
    }

    public class PrimaryCompletionDateStruct
    {
        public string PrimaryCompletionDate { get; set; }
        public string PrimaryCompletionDateType { get; set; }
    }

    public class CompletionDateStruct
    {
        public string CompletionDate { get; set; }
        public string CompletionDateType { get; set; }
    }

    public class StudyFirstPostDateStruct
    {
        public string StudyFirstPostDate { get; set; }
        public string StudyFirstPostDateType { get; set; }
    }

    public class ResultsFirstPostDateStruct
    {
        public string ResultsFirstPostDate { get; set; }
        public string ResultsFirstPostDateType { get; set; }
    }

    public class LastUpdatePostDateStruct
    {
        public string LastUpdatePostDate { get; set; }
        public string LastUpdatePostDateType { get; set; }
    }

    public class StatusModule
    {
        public string StatusVerifiedDate { get; set; }
        public string OverallStatus { get; set; }
        public ExpandedAccessInfo ExpandedAccessInfo { get; set; }
        public StartDateStruct StartDateStruct { get; set; }
        public PrimaryCompletionDateStruct PrimaryCompletionDateStruct { get; set; }
        public CompletionDateStruct CompletionDateStruct { get; set; }
        public string StudyFirstSubmitDate { get; set; }
        public string StudyFirstSubmitQCDate { get; set; }
        public StudyFirstPostDateStruct StudyFirstPostDateStruct { get; set; }
        public string ResultsFirstSubmitDate { get; set; }
        public string ResultsFirstSubmitQCDate { get; set; }
        public ResultsFirstPostDateStruct ResultsFirstPostDateStruct { get; set; }
        public string LastUpdateSubmitDate { get; set; }
        public LastUpdatePostDateStruct LastUpdatePostDateStruct { get; set; }
    }

    public class ResponsibleParty
    {
        public string ResponsiblePartyType { get; set; }
        public string ResponsiblePartyInvestigatorFullName { get; set; }
        public string ResponsiblePartyInvestigatorTitle { get; set; }
        public string ResponsiblePartyInvestigatorAffiliation { get; set; }
    }

    public class LeadSponsor
    {
        public string LeadSponsorName { get; set; }
        public string LeadSponsorClass { get; set; }
    }

    public class Collaborator
    {
        public string CollaboratorName { get; set; }
        public string CollaboratorClass { get; set; }
    }

    public class CollaboratorList
    {
        public List<Collaborator> Collaborator { get; set; }
    }

    public class SponsorCollaboratorsModule
    {
        public ResponsibleParty ResponsibleParty { get; set; }
        public LeadSponsor LeadSponsor { get; set; }
        public CollaboratorList CollaboratorList { get; set; }
    }

    public class OversightModule
    {
        public string OversightHasDMC { get; set; }
    }

    public class DescriptionModule
    {
        public string BriefSummary { get; set; }
        public string DetailedDescription { get; set; }
    }

    public class ConditionList
    {
        public List<string> Condition { get; set; }
    }

    public class KeywordList
    {
        public List<string> Keyword { get; set; }
    }

    public class ConditionsModule
    {
        public ConditionList ConditionList { get; set; }
        public KeywordList KeywordList { get; set; }
    }

    public class PhaseList
    {
        public List<string> Phase { get; set; }
    }

    public class DesignWhoMaskedList
    {
        public List<string> DesignWhoMasked { get; set; }
    }

    public class DesignMaskingInfo
    {
        public string DesignMasking { get; set; }
        public DesignWhoMaskedList DesignWhoMaskedList { get; set; }
    }

    public class DesignInfo
    {
        public string DesignAllocation { get; set; }
        public string DesignInterventionModel { get; set; }
        public string DesignPrimaryPurpose { get; set; }
        public DesignMaskingInfo DesignMaskingInfo { get; set; }
    }

    public class EnrollmentInfo
    {
        public string EnrollmentCount { get; set; }
        public string EnrollmentType { get; set; }
    }

    public class DesignModule
    {
        public string StudyType { get; set; }
        public PhaseList PhaseList { get; set; }
        public DesignInfo DesignInfo { get; set; }
        public EnrollmentInfo EnrollmentInfo { get; set; }
    }

    public class ArmGroupInterventionList
    {
        public List<string> ArmGroupInterventionName { get; set; }
    }

    public class ArmGroup
    {
        public string ArmGroupLabel { get; set; }
        public string ArmGroupType { get; set; }
        public string ArmGroupDescription { get; set; }
        public ArmGroupInterventionList ArmGroupInterventionList { get; set; }
    }

    public class ArmGroupList
    {
        public List<ArmGroup> ArmGroup { get; set; }
    }

    public class InterventionArmGroupLabelList
    {
        public List<string> InterventionArmGroupLabel { get; set; }
    }

    public class InterventionOtherNameList
    {
        public List<string> InterventionOtherName { get; set; }
    }

    public class Intervention
    {
        public string InterventionType { get; set; }
        public string InterventionName { get; set; }
        public string InterventionDescription { get; set; }
        public InterventionArmGroupLabelList InterventionArmGroupLabelList { get; set; }
        public InterventionOtherNameList InterventionOtherNameList { get; set; }
    }

    public class InterventionList
    {
        public List<Intervention> Intervention { get; set; }
    }

    public class ArmsInterventionsModule
    {
        public ArmGroupList ArmGroupList { get; set; }
        public InterventionList InterventionList { get; set; }
    }

    public class PrimaryOutcome
    {
        public string PrimaryOutcomeMeasure { get; set; }
        public string PrimaryOutcomeDescription { get; set; }
        public string PrimaryOutcomeTimeFrame { get; set; }
    }

    public class PrimaryOutcomeList
    {
        public List<PrimaryOutcome> PrimaryOutcome { get; set; }
    }

    public class SecondaryOutcome
    {
        public string SecondaryOutcomeMeasure { get; set; }
        public string SecondaryOutcomeDescription { get; set; }
        public string SecondaryOutcomeTimeFrame { get; set; }
    }

    public class SecondaryOutcomeList
    {
        public List<SecondaryOutcome> SecondaryOutcome { get; set; }
    }

    public class OutcomesModule
    {
        public PrimaryOutcomeList PrimaryOutcomeList { get; set; }
        public SecondaryOutcomeList SecondaryOutcomeList { get; set; }
    }

    public class StdAgeList
    {
        public List<string> StdAge { get; set; }
    }

    public class EligibilityModule
    {
        public string EligibilityCriteria { get; set; }
        public string HealthyVolunteers { get; set; }
        public string Gender { get; set; }
        public string MinimumAge { get; set; }
        public string MaximumAge { get; set; }
        public StdAgeList StdAgeList { get; set; }
    }

    public class OverallOfficial
    {
        public string OverallOfficialName { get; set; }
        public string OverallOfficialAffiliation { get; set; }
        public string OverallOfficialRole { get; set; }
    }

    public class OverallOfficialList
    {
        public List<OverallOfficial> OverallOfficial { get; set; }
    }

    public class Location
    {
        public string LocationFacility { get; set; }
        public string LocationCity { get; set; }
        public string LocationState { get; set; }
        public string LocationZip { get; set; }
        public string LocationCountry { get; set; }
    }

    public class LocationList
    {
        public List<Location> Location { get; set; }
    }

    public class ContactsLocationsModule
    {
        public OverallOfficialList OverallOfficialList { get; set; }
        public LocationList LocationList { get; set; }
    }

    public class Reference
    {
        public string ReferencePMID { get; set; }
        public string ReferenceType { get; set; }
        public string ReferenceCitation { get; set; }
    }

    public class ReferenceList
    {
        public List<Reference> Reference { get; set; }
    }

    public class SeeAlsoLink
    {
        public string SeeAlsoLinkLabel { get; set; }
        public string SeeAlsoLinkURL { get; set; }
    }

    public class SeeAlsoLinkList
    {
        public List<SeeAlsoLink> SeeAlsoLink { get; set; }
    }

    public class ReferencesModule
    {
        public ReferenceList ReferenceList { get; set; }
        public SeeAlsoLinkList SeeAlsoLinkList { get; set; }
    }

    public class ProtocolSection
    {
        public IdentificationModule IdentificationModule { get; set; }
        public StatusModule StatusModule { get; set; }
        public SponsorCollaboratorsModule SponsorCollaboratorsModule { get; set; }
        public OversightModule OversightModule { get; set; }
        public DescriptionModule DescriptionModule { get; set; }
        public ConditionsModule ConditionsModule { get; set; }
        public DesignModule DesignModule { get; set; }
        public ArmsInterventionsModule ArmsInterventionsModule { get; set; }
        public OutcomesModule OutcomesModule { get; set; }
        public EligibilityModule EligibilityModule { get; set; }
        public ContactsLocationsModule ContactsLocationsModule { get; set; }
        public ReferencesModule ReferencesModule { get; set; }
    }

    public class FlowGroup
    {
        public string FlowGroupId { get; set; }
        public string FlowGroupTitle { get; set; }
        public string FlowGroupDescription { get; set; }
    }

    public class FlowGroupList
    {
        public List<FlowGroup> FlowGroup { get; set; }
    }

    public class FlowAchievement
    {
        public string FlowAchievementGroupId { get; set; }
        public string FlowAchievementNumSubjects { get; set; }
    }

    public class FlowAchievementList
    {
        public List<FlowAchievement> FlowAchievement { get; set; }
    }

    public class FlowMilestone
    {
        public string FlowMilestoneType { get; set; }
        public FlowAchievementList FlowAchievementList { get; set; }
    }

    public class FlowMilestoneList
    {
        public List<FlowMilestone> FlowMilestone { get; set; }
    }

    public class FlowPeriod
    {
        public string FlowPeriodTitle { get; set; }
        public FlowMilestoneList FlowMilestoneList { get; set; }
    }

    public class FlowPeriodList
    {
        public List<FlowPeriod> FlowPeriod { get; set; }
    }

    public class ParticipantFlowModule
    {
        public FlowGroupList FlowGroupList { get; set; }
        public FlowPeriodList FlowPeriodList { get; set; }
    }

    public class BaselineGroup
    {
        public string BaselineGroupId { get; set; }
        public string BaselineGroupTitle { get; set; }
        public string BaselineGroupDescription { get; set; }
    }

    public class BaselineGroupList
    {
        public List<BaselineGroup> BaselineGroup { get; set; }
    }

    public class BaselineDenomCount
    {
        public string BaselineDenomCountGroupId { get; set; }
        public string BaselineDenomCountValue { get; set; }
    }

    public class BaselineDenomCountList
    {
        public List<BaselineDenomCount> BaselineDenomCount { get; set; }
    }

    public class BaselineDenom
    {
        public string BaselineDenomUnits { get; set; }
        public BaselineDenomCountList BaselineDenomCountList { get; set; }
    }

    public class BaselineDenomList
    {
        public List<BaselineDenom> BaselineDenom { get; set; }
    }

    public class BaselineClassDenomCount
    {
        public string BaselineClassDenomCountGroupId { get; set; }
        public string BaselineClassDenomCountValue { get; set; }
    }

    public class BaselineClassDenomCountList
    {
        public List<BaselineClassDenomCount> BaselineClassDenomCount { get; set; }
    }

    public class BaselineClassDenom
    {
        public string BaselineClassDenomUnits { get; set; }
        public BaselineClassDenomCountList BaselineClassDenomCountList { get; set; }
    }

    public class BaselineClassDenomList
    {
        public List<BaselineClassDenom> BaselineClassDenom { get; set; }
    }

    public class BaselineMeasurement
    {
        public string BaselineMeasurementGroupId { get; set; }
        public string BaselineMeasurementValue { get; set; }
        public string BaselineMeasurementSpread { get; set; }
    }

    public class BaselineMeasurementList
    {
        public List<BaselineMeasurement> BaselineMeasurement { get; set; }
    }

    public class BaselineCategory
    {
        public string BaselineCategoryTitle { get; set; }
        public BaselineMeasurementList BaselineMeasurementList { get; set; }
    }

    public class BaselineCategoryList
    {
        public List<BaselineCategory> BaselineCategory { get; set; }
    }

    public class BaselineClass
    {
        public BaselineClassDenomList BaselineClassDenomList { get; set; }
        public BaselineCategoryList BaselineCategoryList { get; set; }
        public string BaselineClassTitle { get; set; }
    }

    public class BaselineClassList
    {
        public List<BaselineClass> BaselineClass { get; set; }
    }

    public class BaselineMeasure
    {
        public string BaselineMeasureTitle { get; set; }
        public string BaselineMeasureParamType { get; set; }
        public string BaselineMeasureUnitOfMeasure { get; set; }
        public BaselineClassList BaselineClassList { get; set; }
        public string BaselineMeasureDispersionType { get; set; }
        public string BaselineMeasurePopulationDescription { get; set; }
    }

    public class BaselineMeasureList
    {
        public List<BaselineMeasure> BaselineMeasure { get; set; }
    }

    public class BaselineCharacteristicsModule
    {
        public BaselineGroupList BaselineGroupList { get; set; }
        public BaselineDenomList BaselineDenomList { get; set; }
        public BaselineMeasureList BaselineMeasureList { get; set; }
    }

    public class OutcomeGroup
    {
        public string OutcomeGroupId { get; set; }
        public string OutcomeGroupTitle { get; set; }
        public string OutcomeGroupDescription { get; set; }
    }

    public class OutcomeGroupList
    {
        public List<OutcomeGroup> OutcomeGroup { get; set; }
    }

    public class OutcomeDenomCount
    {
        public string OutcomeDenomCountGroupId { get; set; }
        public string OutcomeDenomCountValue { get; set; }
    }

    public class OutcomeDenomCountList
    {
        public List<OutcomeDenomCount> OutcomeDenomCount { get; set; }
    }

    public class OutcomeDenom
    {
        public string OutcomeDenomUnits { get; set; }
        public OutcomeDenomCountList OutcomeDenomCountList { get; set; }
    }

    public class OutcomeDenomList
    {
        public List<OutcomeDenom> OutcomeDenom { get; set; }
    }

    public class OutcomeMeasurement
    {
        public string OutcomeMeasurementGroupId { get; set; }
        public string OutcomeMeasurementValue { get; set; }
        public string OutcomeMeasurementSpread { get; set; }
    }

    public class OutcomeMeasurementList
    {
        public List<OutcomeMeasurement> OutcomeMeasurement { get; set; }
    }

    public class OutcomeCategory
    {
        public OutcomeMeasurementList OutcomeMeasurementList { get; set; }
    }

    public class OutcomeCategoryList
    {
        public List<OutcomeCategory> OutcomeCategory { get; set; }
    }

    public class OutcomeClass
    {
        public OutcomeCategoryList OutcomeCategoryList { get; set; }
    }

    public class OutcomeClassList
    {
        public List<OutcomeClass> OutcomeClass { get; set; }
    }

    public class OutcomeAnalysisGroupIdList
    {
        public List<string> OutcomeAnalysisGroupId { get; set; }
    }

    public class OutcomeAnalysi
    {
        public OutcomeAnalysisGroupIdList OutcomeAnalysisGroupIdList { get; set; }
        public string OutcomeAnalysisGroupDescription { get; set; }
        public string OutcomeAnalysisNonInferiorityType { get; set; }
        public string OutcomeAnalysisPValue { get; set; }
        public string OutcomeAnalysisStatisticalMethod { get; set; }
    }

    public class OutcomeAnalysisList
    {
        public List<OutcomeAnalysi> OutcomeAnalysis { get; set; }
    }

    public class OutcomeMeasure
    {
        public string OutcomeMeasureType { get; set; }
        public string OutcomeMeasureTitle { get; set; }
        public string OutcomeMeasureDescription { get; set; }
        public string OutcomeMeasureReportingStatus { get; set; }
        public string OutcomeMeasureParamType { get; set; }
        public string OutcomeMeasureDispersionType { get; set; }
        public string OutcomeMeasureUnitOfMeasure { get; set; }
        public string OutcomeMeasureTimeFrame { get; set; }
        public OutcomeGroupList OutcomeGroupList { get; set; }
        public OutcomeDenomList OutcomeDenomList { get; set; }
        public OutcomeClassList OutcomeClassList { get; set; }
        public OutcomeAnalysisList OutcomeAnalysisList { get; set; }
        public string OutcomeMeasurePopulationDescription { get; set; }
    }

    public class OutcomeMeasureList
    {
        public List<OutcomeMeasure> OutcomeMeasure { get; set; }
    }

    public class OutcomeMeasuresModule
    {
        public OutcomeMeasureList OutcomeMeasureList { get; set; }
    }

    public class EventGroup
    {
        public string EventGroupId { get; set; }
        public string EventGroupTitle { get; set; }
        public string EventGroupDescription { get; set; }
        public string EventGroupDeathsNumAffected { get; set; }
        public string EventGroupDeathsNumAtRisk { get; set; }
        public string EventGroupSeriousNumAffected { get; set; }
        public string EventGroupSeriousNumAtRisk { get; set; }
        public string EventGroupOtherNumAffected { get; set; }
        public string EventGroupOtherNumAtRisk { get; set; }
    }

    public class EventGroupList
    {
        public List<EventGroup> EventGroup { get; set; }
    }

    public class AdverseEventsModule
    {
        public string EventsFrequencyThreshold { get; set; }
        public string EventsTimeFrame { get; set; }
        public EventGroupList EventGroupList { get; set; }
    }

    public class CertainAgreement
    {
        public string AgreementPISponsorEmployee { get; set; }
    }

    public class PointOfContact
    {
        public string PointOfContactTitle { get; set; }
        public string PointOfContactOrganization { get; set; }
        public string PointOfContactEMail { get; set; }
        public string PointOfContactPhone { get; set; }
    }

    public class MoreInfoModule
    {
        public CertainAgreement CertainAgreement { get; set; }
        public PointOfContact PointOfContact { get; set; }
    }

    public class ResultsSection
    {
        public ParticipantFlowModule ParticipantFlowModule { get; set; }
        public BaselineCharacteristicsModule BaselineCharacteristicsModule { get; set; }
        public OutcomeMeasuresModule OutcomeMeasuresModule { get; set; }
        public AdverseEventsModule AdverseEventsModule { get; set; }
        public MoreInfoModule MoreInfoModule { get; set; }
    }

    public class LargeDoc
    {
        public string LargeDocTypeAbbrev { get; set; }
        public string LargeDocHasProtocol { get; set; }
        public string LargeDocHasSAP { get; set; }
        public string LargeDocHasICF { get; set; }
        public string LargeDocLabel { get; set; }
        public string LargeDocDate { get; set; }
        public string LargeDocUploadDate { get; set; }
        public string LargeDocFilename { get; set; }
    }

    public class LargeDocList
    {
        public List<LargeDoc> LargeDoc { get; set; }
    }

    public class LargeDocumentModule
    {
        public LargeDocList LargeDocList { get; set; }
    }

    public class DocumentSection
    {
        public LargeDocumentModule LargeDocumentModule { get; set; }
    }

    public class MiscInfoModule
    {
        public string VersionHolder { get; set; }
    }

    public class ConditionMesh
    {
        public string ConditionMeshId { get; set; }
        public string ConditionMeshTerm { get; set; }
    }

    public class ConditionMeshList
    {
        public List<ConditionMesh> ConditionMesh { get; set; }
    }

    public class ConditionAncestor
    {
        public string ConditionAncestorId { get; set; }
        public string ConditionAncestorTerm { get; set; }
    }

    public class ConditionAncestorList
    {
        public List<ConditionAncestor> ConditionAncestor { get; set; }
    }

    public class ConditionBrowseLeaf
    {
        public string ConditionBrowseLeafId { get; set; }
        public string ConditionBrowseLeafName { get; set; }
        public string ConditionBrowseLeafAsFound { get; set; }
        public string ConditionBrowseLeafRelevance { get; set; }
    }

    public class ConditionBrowseLeafList
    {
        public List<ConditionBrowseLeaf> ConditionBrowseLeaf { get; set; }
    }

    public class ConditionBrowseBranch
    {
        public string ConditionBrowseBranchAbbrev { get; set; }
        public string ConditionBrowseBranchName { get; set; }
    }

    public class ConditionBrowseBranchList
    {
        public List<ConditionBrowseBranch> ConditionBrowseBranch { get; set; }
    }

    public class ConditionBrowseModule
    {
        public ConditionMeshList ConditionMeshList { get; set; }
        public ConditionAncestorList ConditionAncestorList { get; set; }
        public ConditionBrowseLeafList ConditionBrowseLeafList { get; set; }
        public ConditionBrowseBranchList ConditionBrowseBranchList { get; set; }
    }

    public class DerivedSection
    {
        public MiscInfoModule MiscInfoModule { get; set; }
        public ConditionBrowseModule ConditionBrowseModule { get; set; }
    }

    public class Study
    {
        public ProtocolSection ProtocolSection { get; set; }
        public ResultsSection ResultsSection { get; set; }
        public DocumentSection DocumentSection { get; set; }
        public DerivedSection DerivedSection { get; set; }
    }

    public class FullStudy
    {
        public int Rank { get; set; }
        public Study Study { get; set; }
    }

    public class FullStudiesResponse
    {
        public string APIVrs { get; set; }
        public string DataVrs { get; set; }
        public string Expression { get; set; }
        public int NStudiesAvail { get; set; }
        public int NStudiesFound { get; set; }
        public int MinRank { get; set; }
        public int MaxRank { get; set; }
        public int NStudiesReturned { get; set; }
        public List<FullStudy> FullStudies { get; set; }
    }

    public class ClinicalTrialAPICallModel
    {
        public FullStudiesResponse FullStudiesResponse { get; set; }
    }


}
