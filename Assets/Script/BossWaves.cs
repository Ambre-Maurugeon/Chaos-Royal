using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BossWaves : MonoBehaviour
{
    [Serializable]
    public struct Wave{
        public string name;
        public float timer;
        public GameObject boss;
    }
    
    [SerializeField] private List<Wave> waves;
    [SerializeField] private Text timerText;
    private float time;
    private List<float> times = new List<float>();

    private int index;

    [HideInInspector]
    public bool callBoss=false;
    public int additionalHealth;

    void Awake(){
        foreach (Wave wave in waves) {
            times.Add(wave.timer*60);
        }
        time = times[index];
    }

    void Update(){
        timerText.text = String.Format ("{1:00}:{0:00}", Mathf.Floor(time % 60), Mathf.Floor(time / 60));
        if(index != waves.Count-1)
            {
                //Debug.Log("Encore des vagues");  
                time -= Time.deltaTime;
                if(time <=0){
                    Debug.Log("Lancement d'une vague");
                    callBoss = true;
                    waves[index].boss.SetActive(false);
                    index ++;
                    Reset();
                }
            }else{
            Debug.Log("timer s'arrete");
        }
                
            
    }

    private void Reset(){
        time = times[index];
    }

    private void ResetAdditionalHealth(){
        additionalHealth = 0;
    }

}
