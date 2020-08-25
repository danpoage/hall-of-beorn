using System;

namespace HallOfBeorn.Models
{
    public class Content
    {
        public Content(string text)
        {
            Text = text;
            NormalizedText = text?.NormalizeCaseSensitiveString();
        }

        public string Text { get; }
        public string NormalizedText { get; }

        public override string ToString()
        {
            return Text?.ToString();
        }

        public string ToNormalizedString()
        {
            return NormalizedText ?? Text;
        }

        public bool EquivalentTo(string value)
        {
            return Text.ToLowerSafe() == value.ToLowerSafe() || 
                NormalizedText.ToLowerSafe() == value.ToLowerSafe();
        }

        public bool MatchesPattern(string pattern)
        {
            return Text.ToLowerSafe().MatchesPattern(pattern)
                || NormalizedText.ToLowerSafe().MatchesPattern(pattern);
        }

        public bool StartsWith(string value)
        {
            return Text.ToLowerSafe().StartsWith(value)
                || NormalizedText.ToLowerSafe().StartsWith(value);
        }

        public bool Contains(string value)
        {
            var lower = value.ToLowerSafe();
            return Text.ToLowerSafe().Contains(lower)
                || NormalizedText.ToLowerSafe().Contains(lower);
        }

        public Content AppendLine(string value)
        {
            if (Text == null || value == null)
            {
                return this;
            }

            return new Content(Text + Environment.NewLine + value);
        }
    }
}
