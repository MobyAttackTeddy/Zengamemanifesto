using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using zengamemanifesto.Models;

namespace zengamemanifesto.Models
{
    public class AdminModel
    {
        public List<BookSet> Books = new List<BookSet>();
        public List<StartPagePostsSet> Home = new List<StartPagePostsSet>();
        public List<VideoSet> Video = new List<VideoSet>();
    }
}