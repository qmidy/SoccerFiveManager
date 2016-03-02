using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;

namespace CommonLibrary
{
    public interface IPlayer
    {
        Point Position { get; set; }

        EnumArea Area { get; set; }

        int Number { get; set; }

        string Name { get; set; }

        int Attack { get; set; }

        int Defense { get; set; }
    }
}
