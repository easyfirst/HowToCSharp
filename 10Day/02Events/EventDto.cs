using System;

namespace _01ObserverPattern
{
    /// <summary>
    /// Event DTO
    /// 
    /// The constructor should be implemented. (recommended)
    /// </summary>
    public class EventDto : EventArgs
    {
        public int Data;

        public EventDto(int data)
        {
            this.Data = data;
        }
    }
}