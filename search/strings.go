package card

import (
	"io/ioutil"
	"strings"
	"unicode"

	"code.google.com/p/go.text/transform"
	"code.google.com/p/go.text/unicode/norm"
)

//Normalize returns a string with all diacritics removed
//e.g. Númenor becomes Numenor
//strings without diacritics will be returned unchanged
func Normalize(s string) (n string, err error) {
	if s == "" {
		return s, nil
	}

	isMn := func(r rune) bool {
		return unicode.Is(unicode.Mn, r)
	}

	tr := transform.Chain(norm.NFD, transform.RemoveFunc(isMn), norm.NFC)

	r := transform.NewReader(strings.NewReader(s), tr)

	data, err := ioutil.ReadAll(r)
	if err == nil {
		n = string(data)
	} else {
		n = s
	}

	return
}
