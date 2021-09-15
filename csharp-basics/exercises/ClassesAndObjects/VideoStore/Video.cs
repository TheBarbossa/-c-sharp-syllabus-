using System.Collections.Generic;

namespace VideoStore
{
    class Video
    {
        private string Name;
        private bool Flag;
        private double UserRating;
        private int Count;
        public Video(string title)
        {
            
            this.Flag = true;
            this.UserRating = 0;
            this.Count = 0;
        }

        public void BeingCheckedOut()
        {
            this.Flag = false;
        }

        public void BeingReturned()
        {
            this.Flag = true;
        }

        public void ReceivingRating(double rating)
        {
            this.Count++;
            this.UserRating += rating;
        }

        public double AverageRating()
        {
            return this.UserRating/this.Count;
        }

        public bool Available()
        {
            return this.Flag;
        }

        public string Title => "";
        public override string ToString()
        {
            return $"{Title} {AverageRating()} {Available()}";
        }
    }
}
