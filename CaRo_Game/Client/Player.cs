﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client
{
    public class Player
    {
        private string name; // ctrl + r + e để đóng gói 

        public string Name { get => name; set => name=value; }

        private Image mark;
        public Image Mark { get => mark; set => mark=value; }

        public Player(string name, Image mark) {
            this.Name = name;   
            this.Mark = mark; 
        
        }
    }


}
