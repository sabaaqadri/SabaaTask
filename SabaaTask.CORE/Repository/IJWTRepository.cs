using SabaaTask.CORE.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace SabaaTask.CORE.Repository
{
    public interface IJWTRepository
    {
        Userlogin Auth (Userlogin user);

    }
}
