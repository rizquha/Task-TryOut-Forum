namespace Task_Try_Out_Forum.Models
{
    public class User
    {
        public int Id {get;set;}
        public string Nama {get;set;}
        public string Email {get;set;}
        public string Password {get;set;}
        public string Role {get;set;}
        public string Images {get;set;}
        public bool Verification {get;set;}
        public bool Ban {get;set;}

    }
}