﻿using System;
using System.Collections.Generic;
using System.Linq;
//using System.Threading.Tasks;
using System.Windows.Forms;

namespace CardDispenserTest
{
    static class Program
    {
       //try detached head
	   //try 2 分离头
        [STAThread]
        static void Main()
        {
			//我是来制造冲突的
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
		//我要增加一个函数
		int function(x,y)
		{
			return y+x;
		}
    }
}
