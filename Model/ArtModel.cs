namespace Art.Model
{
    public abstract class ArtModel
    {
        private int _id;
        protected string _artist;

        public int Id { get { return _id; } set { _id = value; } }
        public string Artist { get { return _artist; } set { _artist = value; } }
        public string Title { get; set; }

        internal int GetId()
        {
            
            return 42;
        }

    }

}
