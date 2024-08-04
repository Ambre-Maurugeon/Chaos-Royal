using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WavesManager : MonoBehaviour
{
    //[SerializeField] private GameObject enemyPrefab;
    
    //Script
    [SerializeField]private EnemyDatabase enemyDatabase;
    [SerializeField]private DatabaseManager _databaseManager;
    private BossWaves _bossWaves;
    private EnemyLife enemyLife;

    //Enemy créé
    //[HideInInspector]
    public List<GameObject> enemyOnStage;


    void Start()
    {
        //enemyDatabase = FindObjectOfType<EnemyDatabase>();
        //_databaseManager = FindObjectOfType<DatabaseManager>();
        _bossWaves = FindObjectOfType<BossWaves>();
        enemyLife = GetComponentInChildren<EnemyLife>();

        StartCoroutine(Test());
        //FindObjectOfType<EnemyInfoController>().GetEnemy(0);
    }

    // Update is called once per frame
    void Update()
    {
        if(_bossWaves.callBoss == true){
            _bossWaves.callBoss = false;
            RemoveEnemyOnStage();
            _databaseManager.Invoke(Types.Boss);
        }
    }

    IEnumerator Test(){

       _databaseManager.CreateData(enemyDatabase.EnemyDatas[2]);
        yield return new WaitForSeconds(2);

        _databaseManager.CreateData(enemyDatabase.EnemyDatas[0]);
        yield return new WaitForSeconds(1);
        _databaseManager.Invoke(Types.Enemy);

    }

    public void AddEnemyOnStage(GameObject newEnemy){
        enemyOnStage.Add(newEnemy);
    }

    public void RemoveEnemyOnStage(){
        foreach(GameObject enemy in enemyOnStage){
            _bossWaves.additionalHealth += enemy.GetComponentInChildren<EnemyLife>().ActualHealth;
            Debug.Log("vie du boss " + _bossWaves.additionalHealth);
            Destroy(enemy);
        }
    }
}
