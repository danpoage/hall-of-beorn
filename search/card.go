package card

type CardType byte

const (
	Quest         CardType = 1
	Campaign               = 2
	Nightmare              = 3
	Encounter              = 20
	Enemy                  = 21
	Location               = 22
	Treachery              = 23
	Objective              = 24
	ObjectiveAlly          = 25
	Player                 = 30
	Character              = 31
	Hero                   = 32
	Ally                   = 33
	Attachment             = 34
	Event                  = 35
	Treasure               = 36
)

func (ct CardType) String() string {
	switch ct {
	case Quest:
		return "Quest"
	case Campaign:
		return "Campaign"
	case Nightmare:
		return "Nightmare"
	case Encounter:
		return "Encounter"
	case Enemy:
		return "Enemy"
	case Location:
		return "Location"
	case Treachery:
		return "Treachery"
	case Objective:
		return "Objective"
	case ObjectiveAlly:
		return "Objective-Ally"
	case Player:
		return "Player"
	case Character:
		return "Character"
	case Hero:
		return "Hero"
	case Ally:
		return "Ally"
	case Attachment:
		return "Attachment"
	case Event:
		return "Event"
	case Treasure:
		return "Treasure"
	default:
		return "Unknown Card Type"
	}
}

type CardSubType byte

const (
	SubTypeNone CardSubType = 0
	Boon                    = 1
	Burden                  = 2
)

func (c CardSubType) String() string {
	switch c {
	case Boon:
		return "Boon"
	case Burden:
		return "Burden"
	default:
		return ""
	}
}

type CardSet struct {
	Name   string
	Year   uint16
	Number byte
	Type   CardSetType
	Cards  []*Card
}

type CardSetType byte

const (
	Core_Set         CardSetType = 1
	Adventure_Pack               = 2
	Deluxe_Expansion             = 3
	Saga_Expansion               = 4
	GenCon_Deck                  = 5
	Nightmare_Deck               = 6
)

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

func (cs *CardSet) String() string {
	return cs.Name
}

type EncounterSet struct {
	Name string
}

type Artist struct {
	Name  string
	Links []Link
}

type Link struct {
	URL   string
	Title string
	Rel   string
}

type Release struct {
	Set      *CardSet
	Number   byte
	Quantity byte
	Scenario *ScenarioInfo
}

type GameMode byte

const (
	NormalMode    GameMode = 0
	EasyMode               = 1
	NightmareMode          = 2
)

func (g GameMode) String() string {
	switch g {
	case NormalMode:
		return "Normal Mode"
	case EasyMode:
		return "Easy Mode"
	case NightmareMode:
		return "Nightmare Mode"
	default:
		return "Unknown Game Mode"
	}
}

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
)

type Sphere StatValue

const (
	NoSphere         Sphere = 0
	LeadershipSphere        = 1
	TacticsSphere           = 2
	SpiritSphere            = 3
	LoreSphere              = 4
	BagginsSphere           = 5
	FellowshipSphere        = 6
)

func (s Sphere) String() string {
	switch s {
	case LeadershipSphere:
		return "[Leadership]"
	case TacticsSphere:
		return "[Tactics]"
	case SpiritSphere:
		return "[Spirit]"
	case LoreSphere:
		return "[Lore]"
	case BagginsSphere:
		return "[Baggins]"
	case FellowshipSphere:
		return "[Fellowship]"
	default:
		return "[Unknown]"
	}
}

type Stat struct {
	Type  StatType
	Value StatValue
}

type EffectType byte

const (
	FlavorText             EffectType = 0
	PassiveEffect                     = 1
	ForcedEffect                      = 2
	ResponseEffect                    = 3
	KeywordEffect                     = 4
	ActionEffect                      = 5
	ResourceActionEffect              = 5
	PlanningActionEffect              = 6
	QuestActionEffect                 = 7
	TravelActionEffect                = 8
	EncounterActionEffect             = 9
	CombatActionEffect                = 10
	RefreshActionEffect               = 11
	SetupEffect                       = 12
	WhenRevealedEffect                = 13
	VictoryConditionEffect            = 14
	ShadowEffect                      = 15
	BurgleEffect                      = 16
	EscapeEffect                      = 17
	HideEffect                        = 18
)

type Effect struct {
	Type EffectType
	Text string
}

type Card struct {
	Slug    string
	Type    CardType
	SubType CardSubType
	Front   *CardSide
	Back    *CardSide
	Release *Release
}

type CardSide struct {
	Title   CardTitle
	Stats   map[StatType]StatValue
	Traits  []string
	Text    []*Effect
	Artists []*Artist
}

type CardTitle struct {
	Main     string
	Subtitle string
	IsUnique bool
}
