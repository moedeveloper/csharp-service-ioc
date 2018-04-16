using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{

    public class Node: INode
    {
        public string ResturnString()
        {
            return "abcd";
        }
    }
}
