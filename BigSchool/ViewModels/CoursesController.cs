using BigSchool.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BigSchool.ViewModels
{
    public class CoursesController 
    {
        public  IEnumerable<Course> UpcommingCourses { set; get; }
        public bool ShowAction { set; get; }
        // GET: Courses
        
       
    }
}