package main

import (
	"fmt"

	hob "github.com/danpoage/hall-of-beorn/search"
)

var (
	cs = &hob.CardService{}
)

func main() {

	var norm string
	for _, s := range cs.Sets() {
		norm, _ = hob.Normalize(s.Name)
		fmt.Printf("%s [%s] (%s)\n", s.Name, norm, s.Type.String())
	}
}
