﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FurRealEngine
{
    class Character
    {
        int identifier;
        int profession;
        bool isPlayable;

        public bool isCharacterPlayable()
        {
            return this.isPlayable;
        }

        public void setIsPlayable(bool isPlayable)
        {
            this.isPlayable = isPlayable;
        }

        public int getIdentifier()
        {
            return this.identifier;
        }

        public void setIdentifier(int identifier)
        {
            this.identifier = identifier;
        }

        public int getProfession()
        {
            return this.profession;
        }

        public void setProfession(int profession)
        {
            this.profession = profession;
        }
    }
}
