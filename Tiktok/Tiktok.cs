using System;
using System.Collections.Generic;
using System.Text;


namespace Assignment2Tiktok
{
    enum Audience
    {  World, Group,Special
    }

    class TikTok
    {
        // Private instance variables(Fields)
        private static int m_ID;

        //Public properties
        public string Originator { get; }
        public int Length { get; }
        public string Hashtag { get; }
        public Audience Audience { get; }
        public string Id { get; }

        // Constructor
        public TikTok(string originator, int length, string hashTag, Audience audience)
        {
            Originator = originator;
            Length = length;
            Hashtag = hashTag;
            Audience = audience;
            Id = m_ID.ToString();
            m_ID++;
        }

        private TikTok(string id, string originator, int length, string
            hashTag, Audience audience)
        {
            Id = id;
            Originator = originator;
            Length = length;
            Hashtag = hashTag;
            Audience = audience;
        }

        // Public methods
        public override string ToString()
        {
            return $"ID:{Id}\tORIGINATOR:{Originator}\tLENGTH:{Length}\tHASHTAG:{Hashtag}\tAUDIENCE:{Audience}";
        }

        public static TikTok Parse(string line)
        {
            string[] words = line.Split('\t');
            string n_id = words[0];
            string n_originator = words[1];
            int  n_length =Convert.ToInt32(words[2]) ;
            string n_hashTag = words[3];
            Audience n_audience = (Audience) Enum.Parse(typeof(Audience), words[4]);
            TikTok tikTokObject = new TikTok(n_id, n_originator, n_length, n_hashTag, n_audience);
            return tikTokObject;
        }
    }
}
