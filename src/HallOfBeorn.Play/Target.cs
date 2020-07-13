using System;

namespace HallOfBeorn.Play
{
    public abstract class Target
    {
        protected Target(string name)
        {
            Id = Guid.NewGuid().ToString("D");
            Name = name;
        }

        protected Target(string name, string id)
        {
            Id = id;
            Name = name;
        }

        public string Id { get; private set; }
        public string Name { get; private set; }
    }
}