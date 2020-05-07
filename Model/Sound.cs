using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UWPSoundBoard.Model
{
    public enum SoundCategory
    {
        Animals,
        Cartoons,
        Taunts,
        Warnings

    }
    public class Sound
    {
        public string Name { get; set; }
        public SoundCategory Category { get; set; }
        public string AudioFileLocation { get; set; }

        public string ImageFileLocation { get; set; }

        public Sound(string name, SoundCategory category)
        {
            Name = name;
            Category = category;
            AudioFileLocation = $"/Assets/Audio/{category}/{name}.wav";
            ImageFileLocation = $"/Assets/Images/{category}/{name}.png";
        }
    }
}
