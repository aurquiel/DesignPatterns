using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppDesignPatterns.Composite
{
    public class SongGroup : SongComponent
    {
        List<SongComponent> songComponents = new List<SongComponent>();

        string groupName;
        string groupDescription;

        public SongGroup(string groupName, string groupDescription)
        {
            this.groupName = groupName;
            this.groupDescription = groupDescription;
        }

        public string GroupName { get => groupName; }
        public string GroupDescription { get => groupDescription; }

        public override void Add(SongComponent songComponent) 
        {
            songComponents.Add(songComponent);
        }

        public override void Remove(SongComponent songComponent)
        {
            songComponents.Remove(songComponent);
        }

        public override SongComponent GetComponent(int componentIndex)
        {
            return songComponents[componentIndex];
        }

        public override void DisplaySongInfo()
        {
            Console.WriteLine(GroupName + " " + GroupDescription);

            var iterator = songComponents.GetEnumerator();

            while (iterator.MoveNext()) 
            {
                SongComponent songInfo = iterator.Current;
                songInfo.DisplaySongInfo();  
            }
        }
    }
}
