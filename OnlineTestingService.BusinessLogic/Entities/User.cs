﻿using System;
using System.Collections.Generic;

namespace OnlineTestingService.BusinessLogic.Entities
{
    public class User : EntityWithGuid<User>
    {
        public virtual string Name { get; set; }
        public virtual Candidate Candidate { get; set; }
    }
}
