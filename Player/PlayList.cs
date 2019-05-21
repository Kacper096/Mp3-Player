using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Player
{
    class PlayList
    {
        private IList<string> _songsName = new List<string>();
        private string _path = string.Empty;

        /// <summary>
        /// Gets the path folder or set the path.
        /// </summary>
        public string PathFolder
        {
            get => _path;
            set
            {
                if (_path != value)
                    _path = value;
                Make();
            }
        }

        /// <summary>
        /// Gets the names of all files from playlist.
        /// </summary>
        public IList<string> Read
        {
            get => _songsName;
        }

        /// <summary>
        /// Clears the list.
        /// </summary>
        public void ClearPlayList()
        {
            _songsName.Clear();
        }

        /// <summary>
        /// Gets Files to again read of the same path.
        /// </summary>
        public void GetsFilesToRead()
        {
            Make();
        }

        /// <summary>
        /// Makes the song playlist.
        /// </summary>
        private void Make()
        {
            //TODO .mp3 makes more fluent
            _songsName = Directory.GetFiles(_path, "*.mp3")
                .Select(Path.GetFileName)
                .ToList<string>();
        }
    }
}
