using SabaaTask.CORE.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace SabaaTask.CORE.Service
{
    public interface IJWTService
    {
        string Auth(Userlogin userlogin);

    }
}
