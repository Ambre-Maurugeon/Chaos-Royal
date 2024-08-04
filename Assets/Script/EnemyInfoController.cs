using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyInfoController : MonoBehaviour
{
    [SerializeField] private Text healthText;
    //[SerializeField] private Image _imgIcon;

    private DatabaseManager _databaseMgr;
    private EnemyDatabase enemyDatabase;
    private MiniBossDatabase miniBossDatabase;

    private int id=0;


    // Start is called before the first frame update
    void Start()
    {
        _databaseMgr = FindObjectOfType<DatabaseManager>();
        enemyDatabase = FindObjectOfType<EnemyDatabase>();
        miniBossDatabase = FindObjectOfType<MiniBossDatabase>();
    }

    // Update is called once per frame
    void Update()
    {
        //healthText.text = _databaseMgr.GetEnemyData(id).pv.ToString();
        
        //_imgIcon.sprite = data.icon;
    }

    public EnemyData GetEnemy(int id){
        return _databaseMgr.GetEnemyData(id);
    }
}
