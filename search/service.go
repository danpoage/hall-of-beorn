package card

import ()

var (
	cardSets []*CardSet
)

type CardService struct {
}

func init() {
	core := &CardSet{Name: "Core Set", Type: Core_Set}
	thfg := &CardSet{Name: "The Hunt for Gollum", Type: Adventure_Pack}
	catc := &CardSet{Name: "Conflict at the Carrock", Type: Adventure_Pack}
	ajtr := &CardSet{Name: "A Journey to Rhosgobel", Type: Adventure_Pack}
	thoem := &CardSet{Name: "The Hills of Emyn Muil", Type: Adventure_Pack}
	tdm := &CardSet{Name: "The Dead Marshes", Type: Adventure_Pack}
	rtm := &CardSet{Name: "Return to Mirkwood", Type: Adventure_Pack}
	kd := &CardSet{Name: "Khazad-dûm", Type: Deluxe_Expansion}
	trg := &CardSet{Name: "The Redhorn Gate", Type: Adventure_Pack}
	rtr := &CardSet{Name: "Road to Rivendell", Type: Adventure_Pack}
	twitw := &CardSet{Name: "The Watcher in the Water", Type: Adventure_Pack}
	tld := &CardSet{Name: "The Long Dark", Type: Adventure_Pack}
	fos := &CardSet{Name: "Foundations of Stone", Type: Adventure_Pack}
	saf := &CardSet{Name: "Shadow and Flame", Type: Adventure_Pack}
	hon := &CardSet{Name: "Heirs of Númenor", Type: Deluxe_Expansion}
	tsf := &CardSet{Name: "The Steward's Fear", Type: Adventure_Pack}
	tdf := &CardSet{Name: "The Drúadan Forest", Type: Adventure_Pack}
	eaad := &CardSet{Name: "Encounter at Amon Dîn", Type: Adventure_Pack}
	aoo := &CardSet{Name: "Assault on Osgiliath", Type: Adventure_Pack}
	tbog := &CardSet{Name: "The Blood of Gondor", Type: Adventure_Pack}
	tmv := &CardSet{Name: "The Morgul Vale", Type: Adventure_Pack}
	tvoi := &CardSet{Name: "The Voice of Isengard", Type: Deluxe_Expansion}
	thohauh := &CardSet{Name: "The Hobbit: Over Hill and Under Hill", Type: Saga_Expansion}
	thotd := &CardSet{Name: "The Hobbit: On the Doorstep", Type: Saga_Expansion}
	tbr := &CardSet{Name: "The Black Riders", Type: Saga_Expansion}
	mao := &CardSet{Name: "The Massing at Osgiliath", Type: GenCon_Deck}
	tbol := &CardSet{Name: "The Battle of Lake-town", Type: GenCon_Deck}
	tsoe := &CardSet{Name: "The Stone of Erech", Type: GenCon_Deck}

	cardSets = []*CardSet{
		core, thfg, catc, ajtr, thoem, tdm, rtm,
		kd, trg, rtr, twitw, tld, fos, saf,
		hon, tsf, tdf, eaad, aoo, tbog, tmv,
		tvoi,
		thohauh, thotd, tbr,
		mao, tbol, tsoe,
	}
}

func (s *CardService) Sets() []*CardSet {
	return cardSets
}
