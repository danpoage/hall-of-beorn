using System;

namespace HallOfBeorn.Play
{
    public class GamePart
    {
        public GamePart(
            GameSegment segment, FrameworkStep step, Func<Game, ExecutionResult> getResult)
        {
            Segment = segment;
            SetupStep = Play.SetupStep.None;
            FrameworkStep = step;
            this.getResult = getResult;
        }

        public GamePart(
            GameSegment segment, SetupStep step, Func<Game, ExecutionResult> getResult)
        {
            Segment = segment;
            SetupStep = step;
            FrameworkStep = Play.FrameworkStep.None;
            this.getResult = getResult;
        }

        private readonly Func<Game, ExecutionResult> getResult;

        public GameSegment Segment { get; private set; }
        public SetupStep SetupStep { get; private set; }
        public FrameworkStep FrameworkStep { get; private set; }

        public virtual ExecutionResult Execute(Game game)
        {
            return getResult(game);
        }
    }
}
