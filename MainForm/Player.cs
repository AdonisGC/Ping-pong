using Firebase.Database;
using Newtonsoft.Json;
using System;

namespace MainForm
{
   public class Player
    {
        private string id;
        private string name;
        private string photoFilePath;
        private int matchesPlayed;
        private int punts;

        public Player(string name = null, string photoFilePath = null)
        {
            this.name = name;
            this.photoFilePath = photoFilePath;
        }

        // Ignore this property when serializing
        [JsonIgnore]
        public string Id
        {
            get { return id != null ? id : "NA"; }
            set { id = value; }
        }

        public string Name
        {
            get { return name != null ? name : "NA"; }
            set { name = value; }
        }

        public string PhotoFilePath
        {
            get { return photoFilePath != null ? photoFilePath : "NA"; }
            set { photoFilePath = value; }
        }

        public int MatchesPlayed
        {
            get { return matchesPlayed > 0 ? matchesPlayed : 0; }
            set { matchesPlayed = value; }
        }

        public int Punts
        {
            get { return punts > 0 ? punts : 0; }
            set { punts = value; }
        }

        // Self-storing function
        public bool save()
        {
            // Get FirebaseClient instance
            var firebaseClient = new FirebaseClient("https://leaguepong.firebaseio.com/");
            // Get reference
            var childNodeRoot = firebaseClient.Child("players").AsRealtimeDatabase<Player>();

            String key = null;
            if (this != null)
            {
                key = childNodeRoot.Post(this);
                Console.WriteLine($"Player with key : {key}");
            }
            return key == null ? false : true;
        }

        public override string ToString()
        {
            return this.Name.Equals("NA") ? null : JsonConvert.SerializeObject(this, Formatting.Indented);
        }
    }
}
