using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HallOfBeorn.Play
{
    public class ExecutionResult
    {
        public ExecutionResult()
        {
        }

        public ExecutionResult(Effect effect)
        {
            Add(effect);
        }

        public ExecutionResult(IEnumerable<Effect> effects)
        {
            AddRange(effects);
        }

        public static ExecutionResult Create(Effect effect)
        {
            return new ExecutionResult(effect);
        }

        public static ExecutionResult Create(IEnumerable<Effect> effects)
        {
            return new ExecutionResult(effects);
        }

        public static ExecutionResult CreateTerminal(
            Effect effect, string message)
        {
            return new ExecutionResult(effect).Terminate(message);
        }

        public static ExecutionResult CreateTerminal(
            IEnumerable<Effect> effects, string message)
        {
            return new ExecutionResult(effects)
                .Terminate(message);
        }

        private bool isTerminal = false;
        private string message;
        private List<Effect> effects = new List<Effect>();

        public bool IsTerminal { get { return isTerminal; } }

        public string Message { get { return message; } }

        public IEnumerable<Effect> Effects
        {
            get { return effects; }
        }

        public void Add(Effect effect)
        {
            effects.Add(effect);
        }

        public void AddRange(IEnumerable<Effect> effects)
        {
            this.effects.AddRange(effects);
        }

        public ExecutionResult Append(ExecutionResult result)
        {
            this.isTerminal = result.IsTerminal;
            this.message = result.Message;
            AddRange(result.Effects);
            return this;
        }

        public ExecutionResult Terminate(string message)
        {
            this.isTerminal = true;
            this.message = message;
            return this;
        }
    }
}
