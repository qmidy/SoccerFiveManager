using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace CommonLibrary
{
    public class Player : IPlayer
    {
        public Point Position { get; set; }

        public EnumArea Area { get; set; }

        public int Number { get; set; }

        public string Name { get; set; }

        public int Attack { get; set; }

        public int Defense { get; set; }
    }
}
