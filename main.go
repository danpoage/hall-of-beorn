package main

import (
	"fmt"
	"strings"

	hob "github.com/danpoage/hall-of-beorn/search"
)

var (
	cardSets []*hob.CardSet
)

func main() {
	core := &hob.CardSet{Name: "Core"}
	thfg := &hob.CardSet{Name: "The Hunt for Gollum"}
	catc := &hob.CardSet{Name: "Conflict at the Carrock"}
	ajtr := &hob.CardSet{Name: "A Journey to Rhosgobel"}
	thoem := &hob.CardSet{Name: "The Hills of Emyn Muil"}
	tdm := &hob.CardSet{Name: "The Dead Marshes"}
	rtm := &hob.CardSet{Name: "Return to Mirkwood"}

	cardSets = []*hob.CardSet{
		core, thfg, catc, ajtr, thoem, tdm, rtm,
	}

	var names []string
	for _, s := range cardSets {
		names = append(names, s.Name)
	}

	fmt.Println(strings.Join(names, "\n"))
}
