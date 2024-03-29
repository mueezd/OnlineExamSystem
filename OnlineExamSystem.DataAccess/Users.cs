﻿using System;
using System.Collections;
using System.Collections.Generic;

namespace OnlineExamSystem.DataAccess
{
    public class Users
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public int Role { get; set; }
        public ICollection<Groups> Groups { get; set; } = new HashSet<Groups>();
    }
}
