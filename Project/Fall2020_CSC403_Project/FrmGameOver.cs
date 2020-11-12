﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fall2020_CSC403_Project
{
    public partial class FrmGameOver : Form {
        public static FrmGameOver instance = null;

        public FrmGameOver() {
            InitializeComponent();
        }

        public static FrmGameOver GetInstance() {
            if(instance == null) {
                instance = new FrmGameOver();
            }
            return instance;
        }
    }
}
