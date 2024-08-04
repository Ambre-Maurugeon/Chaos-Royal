using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class EnemyData 
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
        public int pv;
        public int atk;
        public int lvl;
        public int shield;
        public float speed;

        Stats(int pv, int atk, int lvl, int shield, float speed){
            this.pv = pv;
            this.atk = atk;
            this.lvl = lvl;
            this.shield = shield;
            this.speed = speed;
        }
    }

    public string name;
    public Infos infos;
    public Stats stats;
    public Types types ;
    public Capacity capacity;

    // public string label;
    // public int pv; // ajout pv ennemis restants on stage
    // public int atk;
    // public int lvl;
    // public BossCapacity bossCapacity; 

}
