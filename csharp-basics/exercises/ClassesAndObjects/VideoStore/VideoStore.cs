using System;
using System.Collections.Generic;

namespace VideoStore
{
    class VideoStore
    {
        private readonly Video _video;
        public VideoStore()
        {
            
        }

        public void AddVideo(string title)
        {
            
        }
        
        public void Checkout(string title)
        {
            
        }

        public void ReturnVideo(string title)
        {
            
        }

        public void TakeUsersRating(double rating, string title)
        {
            _video.ReceivingRating(rating);
        }

        public void ListInventory()
        {
            _video.ToString();
        }
    }
}
