﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameProject.Abstract;
using GameProject.Entity;

namespace GameProject.Concrete
{
    class GameManager:IGameService
    {

        public void Add(Game game)
        {
            Console.WriteLine(game.GameName + " adlı oyun eklendi.");
        }

        public void Update(Game game)
        {
            Console.WriteLine(game.GameName + " adlı oyun silindi.");
        }

        public void Delete(Game game)
        {
            Console.WriteLine(game.GameName + " adlı oyun güncellendi.");
        }
    }
}
