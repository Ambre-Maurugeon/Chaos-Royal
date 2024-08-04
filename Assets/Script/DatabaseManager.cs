using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DatabaseManager : MonoBehaviour
{
    //Script
    public EnemyDatabase database;
    public GameObject enemyPrefab;
    public WavesManager _wavesManager;
    private BossWaves _bossWaves;

    //
    private GameObject newEnemy;

    void Start(){
        //_wavesManager = FindObjectOfType<WavesManager>();
        _bossWaves = FindObjectOfType<BossWaves>();
    }
    
    public EnemyData GetEnemyData(int id) => database.EnemyDatas[id];

    public void CreateData(EnemyData data, Types? type = null){ //public GameObject CreateData(EnemyData data, Types types)
        newEnemy = Instantiate(enemyPrefab);

        if (type != Types.Boss){
            _wavesManager.AddEnemyOnStage(newEnemy);
            newEnemy.GetComponentInChildren<EnemyLife>().InitValues(data.stats.pv, data.stats.atk);
        } else{
            int life = data.stats.pv + _bossWaves.additionalHealth;
            newEnemy.GetComponentInChildren<EnemyLife>().InitValues(life, data.stats.atk);
            Debug.Log("Vie du Boss est " + newEnemy.GetComponentInChildren<EnemyLife>().ActualHealth); 
                                    // Init Health fonctionne mais pas actualHealth qui égale 1
        }
    }

    public void Invoke(Types type){
        foreach (EnemyData data in database.EnemyDatas){
            if(data.types == type){
                CreateData(data, type);
                return;
            }
        }
    }
}
