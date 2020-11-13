using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fall2020_CSC403_Project.code
{
    public interface Item
    {
        Image image { get; set; }
        int power { get; set; }
        int cost { get; set; }
        char type { get; set; }
        Player player { get; set; }

        void Use();
    }
}
