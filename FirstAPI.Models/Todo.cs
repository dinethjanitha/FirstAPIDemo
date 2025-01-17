﻿using Microsoft.VisualBasic;

namespace FirstAPI.Models
{
    public class Todo
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime Created { get; set; }
        public DateTime Due { get; set; }  
        public TodoStatus Status { get; set; }

        public int AuthorId {  get; set; }  
        public Author Author { get; set; }    


    }
}


//Test Add