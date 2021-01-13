using System;
using System.ComponentModel.DataAnnotations;

namespace SignalRChat.Models
{
    public class Message{
        [Key]
        public int MessageId{get; set;}
        [MaxLength(50)]
        public string Username{ get; set;}
        [MaxLength(400)]
        public string MessageText{get; set;}
        public DateTime MessageDate{get; set;}


    }
}