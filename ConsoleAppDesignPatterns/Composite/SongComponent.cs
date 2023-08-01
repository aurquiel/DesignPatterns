using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppDesignPatterns.Composite
{
    public abstract class SongComponent
    {
        public virtual void Add(SongComponent songComponent)
        {
            throw new NotImplementedException();
        }

        public virtual void Remove(SongComponent songComponent)
        {
            throw new NotImplementedException();
        }

        public virtual SongComponent GetComponent(int componentIndex)
        {
            throw new NotImplementedException();
        }

        public virtual string GetSongName()
        {
            throw new NotImplementedException();
        }

        public virtual string GetBandName()
        {
            throw new NotImplementedException();
        }

        public virtual int GetReleaseYear()
        {
            throw new NotImplementedException();
        }

        public virtual void DisplaySongInfo()
        {
            throw new NotImplementedException();
        }
    }
}
