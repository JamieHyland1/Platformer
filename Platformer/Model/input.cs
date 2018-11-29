using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Platformer.Model
{
    class Input
    {
        //reference the keys up down left and right
        //{get; set;} is a shorthand for get() and set() methods.

        public Keys  Down {get; set;}
        public Keys  Left {get; set;}
        public Keys  Right {get; set;}
        public Keys  Up {get; set;}
    }
}
