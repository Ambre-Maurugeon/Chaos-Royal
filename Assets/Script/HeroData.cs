using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class HeroData
{
    [Serializable]
    public struct Infos{
        public string bio;

        Infos(string bio) 
        {
            this.bio = bio;
        }
    }

    [Serializable]
    public struct Stats{
        public int def;
        public int atk;

        Stats(int def, int atk){
            this.def = def;
            this.atk = atk;
        }
    }

    public string name;
    public HeroCapacity heroCapacity;
    public Infos infos;
    public Stats stats;

    [HideInInspector]
    public Types types = Types.Hero;

}
