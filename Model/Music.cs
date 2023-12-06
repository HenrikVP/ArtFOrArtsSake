namespace Art.Model
{
    internal sealed class Music : PerformingArts
    {
        public List<string> Instruments { get; set; }

        public Music() { }

        public Music(List<string> instr, string artist)
        {
            Instruments = instr;
            //Artist = artist;
            _artist = artist;
        }

        public override string ToString()
        {
            string s = Artist;
            foreach (string i in Instruments) 
            {
                s += ", " + i.ToString();
            }

            return s;
        }
    }
}
