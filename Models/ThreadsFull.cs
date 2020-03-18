using System;

namespace Task_Try_Out_Forum.Models
{
    public class ThreadsFull
    {
        public int Id {get;set;}
        public string Category {get;set;}
        public string Title {get;set;}
        public string Body {get;set;}
        public string Image {get;set;}
        public DateTime CreatedAt {get;set;}
        public int UserId {get;set;}
        public string UserName {get;set;}
        public int ThreadId {get;set;}
    }
}