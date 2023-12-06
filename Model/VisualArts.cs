namespace Art.Model
{
    internal class VisualArts : ArtModel
    {
        public int WeightInGrams { get; set; }

        public VisualArts()
        {
            //Protected can be accessed from own class and derived classes
            //_artist = "Salvador Dali";
        }
    }
}
