using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gaokao
{
    public partial class SubjectForm : Form
    {

        public static bool physics = false;
        public static bool chemistry = false;
        public static bool biology = false;
        public static bool politics = false;
        public static bool history = false;
        public static bool geography = false;

        public SubjectForm()
        {
            InitializeComponent();
        }
    }
}
