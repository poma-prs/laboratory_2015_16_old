using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project6
{
    interface IcommentHandler
    {
        string add_comment(Comment comment);
        Comment handle_comment(int id_user, string comment);
    }
}
