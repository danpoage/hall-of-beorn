package search

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
	Year     uint
	Artist   *ArtistInfo
	Scenario *ScenarioInfo
}

type GameMode byte

const (
	NormalMode GameMode = iota
	NightmareMode
	EasyMode
)

type ScenarioInfo struct {
	EncounterSet *EncounterSet
	IncludedSets []*EncounterSet
	Modes        map[GameMode]byte
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
	Type       CardType
	Title      string
	Release    *ReleaseInfo
	Stats      map[StatType]StatValue
	Traits     []string
	Text       []Effect
	FlavorText []string
}

func (c *Card) NormalizedTitle() string {
	return c.Title
}
