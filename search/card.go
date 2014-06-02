package card

type CardMainType byte

const (
	Quest CardMainType = iota
	Enemy
	Location
	Treachery
	Objective
	ObjectiveAlly
	Hero
	Ally
	Attachment
	Event
	Treasure
	Campaign
	Nightmare
)

type CardSubType byte

const (
	None CardSubType = iota
	Boon
	Burden
)

type CardType struct {
	MainType CardMainType
	SubType  CardSubType
}

type CardSet struct {
	Name string
	Type CardSetType
}

type CardSetType byte

func (cst CardSetType) String() string {
	switch cst {
	case Core_Set:
		return "Core Set"
	case Adventure_Pack:
		return "Adventure Pack"
	case Deluxe_Expansion:
		return "Deluxe Expansion"
	case Saga_Expansion:
		return "Saga Expansion"
	case GenCon_Deck:
		return "GenCon Deck"
	case Nightmare_Deck:
		return "Nightmare Deck"
	default:
		return ""
	}
}

const (
	Core_Set CardSetType = iota
	Adventure_Pack
	Deluxe_Expansion
	Saga_Expansion
	GenCon_Deck
	Nightmare_Deck
)

func (cs *CardSet) String() string {
	return cs.Name
}

type EncounterSet struct {
	Name string
}

type ArtistInfo struct {
	Name  string
	Links []LinkInfo
}

type LinkInfo struct {
	URL   string
	Title string
}

type ReleaseInfo struct {
	Set      *CardSet
	Number   uint
	Quantity byte
	Scenario *ScenarioInfo
}

type GameMode byte

const (
	NormalMode GameMode = iota
	NightmareMode
	EasyMode
)

type ScenarioInfo struct {
	EncounterSet   *EncounterSet
	IncludedSets   []*EncounterSet
	QuantityByMode map[GameMode]byte
}

type StatType byte
type StatValue byte

const (
	WillpowerStat StatType = iota
	AttackStat
	DefenseStat
	HitPointsStat
	ThreatStat
	StageNumberStat
	QuestPointsStat
	VictoryPointsStat
	ThreatCostStat
	ResourceCostStat
	EngagementCostStat
	IsUniqueStat
)

type Sphere StatValue

const (
	NoSphere Sphere = iota
	LeadershipSphere
	TacticsSphere
	SpiritSphere
	LoreSphere
	BagginsSphere
	FellowshipSphere
)

type Stat struct {
	Type  StatType
	Value StatValue
}

type EffectType byte

const (
	PassiveEffect EffectType = iota
	ForcedEffect
	ResponseEffect
	KeywordEffect
	ActionEffect
	ResourceActionEffect
	PlanningActionEffect
	QuestActionEffect
	TravelActionEffect
	EncounterActionEffect
	CombatActionEffect
	RefreshActionEffect
	SetupEffect
	WhenRevealedEffect
	VictoryConditionEffect
	ShadowEffect
)

type Effect struct {
	Type EffectType
	Text string
}

type Card struct {
	Type    CardType
	Front   *CardSide
	Back    *CardSide
	Release *ReleaseInfo
}

type CardSide struct {
	Title      CardTitle
	Stats      map[StatType]StatValue
	Traits     []string
	Text       []*Effect
	FlavorText []string
	Artist     *ArtistInfo
}

type CardTitle struct {
	MainTitle string
	Subtitle  string
}
