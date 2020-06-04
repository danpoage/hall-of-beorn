using System;

namespace HallOfBeorn.Models.LotR.Play
{
    public abstract class Target
    {
        protected Target(string name)
        {
            Id = Guid.NewGuid().ToString("D");
            Name = name;
        }

        public string Id { get; private set; }
        public string Name { get; private set; }
    }
}