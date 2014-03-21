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
