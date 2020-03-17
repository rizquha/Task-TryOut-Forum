namespace Task_Try_Out_Forum.Models
{
    public class Comment
    {
        public int Id {get;set;}
        public string Comments {get;set;}
        public int User_Id {get;set;}
        public int Thread_Id {get;set;}
        public int ForUserId {get;set;}
    }
}