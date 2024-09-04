using System.Runtime.InteropServices;
using System.Threading;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Course_Management.models
{
    public class Blog
    {
        private string Title;
        private string Author;
        private string BlogInfo;
        private int CommentNo;
        private string[] comments = new string[0];
        private DateTime CreationDate {get; set;} = DateTime.Now;
        public void CreateA_Blog()
        {
            Console.WriteLine($"===========Make A Blog===========");
            Console.Write($"Blog Title: ");
            Title = Console.ReadLine();
            Console.Write($"Author Name: ");
            Author = Console.ReadLine();
            Console.Write($"Blog Description: ");
            BlogInfo = Console.ReadLine();
            Console.WriteLine($"---------------------------");
            Console.Write($"How many Comments do want to give: ");
            CommentNo = int.Parse(Console.ReadLine());
            comments = new string[CommentNo];

            for(int i = 0; i < comments.Length; i++)
            {
                Console.Write($"Comment {i + 1}: ");
                comments[i] = Console.ReadLine();
            }
        }
        public void ShowBlogs()
        {
            Console.WriteLine($"===============Blogs=============");
            Console.WriteLine($"Topic: {Title}");
            Console.WriteLine($"Author Name: {Author}");
            Console.WriteLine($"Created: {DateTime.Now.ToString("dddd, dd-MMMM-yyyy")}");
            Console.WriteLine($"----------------------------");
            Console.WriteLine(BlogInfo);
        }
        public void ShowComments()
        {
            Console.WriteLine($"===========!Comments!===========");
            for(int i = 0; i < CommentNo; i++)
            {
                Console.WriteLine($"{i + 1}. {comments[i]}");
            }
        }
    }
}