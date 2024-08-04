using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyLife : MonoBehaviour
{
    public int InitialHealth=1; // pr le préfab
    [SerializeField] private Text healthText;

    //Values Health & Dmg
    [HideInInspector] public int ActualHealth;
    private int dmg=1; // pr le préfab

    //Animation Degats  
    [SerializeField] private float degatsSpeed;
    private Vector3 destination;
    private bool go=false;
    private Text textDegats;

    [HideInInspector] public List<Text> listTxt;

    
    void Start()
    {
        ActualHealth = InitialHealth;
        UpdateActualHealth(); 

        destination = healthText.transform.localPosition + new Vector3(0, 100f, 0);
    }

    void Update()
    {
        if(ActualHealth<=0){
            KillEnemy();
        }

        if(go && textDegats !=null){
            if(textDegats.transform.localPosition != destination){
                launchAnim();
            }
            else{
                go = false;
            }
           
        }

        UpdateDmgList();
    }

//Vie 

    public void  IncreaseHealth(int aug){
        ActualHealth += aug;
        UpdateActualHealth();
    }

    public void DecreaseHealth(){
        ActualHealth -= dmg;
        AnimDegats();
        UpdateActualHealth();
    }
  
    public void KillEnemy(){
        Destroy(gameObject.transform.parent.gameObject);
    }
    
    private void UpdateActualHealth(){
        healthText.text = ActualHealth.ToString();
    }

// Etablir les valeurs init
    public void InitValues(int vie, int dmg){
        InitialHealth = vie ;
        this.dmg = dmg ;
    }

//Anim degats

    private void AnimDegats(){
        textDegats = Instantiate(healthText, healthText.transform.parent);
        textDegats.text = dmg.ToString();
        Debug.Log("Instanciate");
        
        listTxt.Add(textDegats);
    
        go = true;
    }

    private void launchAnim(){
        //textDegats.transform.localPosition = Vector3.MoveTowards(textDegats.transform.localPosition, destination, degatsSpeed*Time.deltaTime);
        foreach(Text text in listTxt){
            text.transform.localPosition = Vector3.MoveTowards(text.transform.localPosition, destination, degatsSpeed*Time.deltaTime);
        }
    }

    private void UpdateDmgList(){
        for(int i =0; i<listTxt.Count; i++){
            if (listTxt[i].transform.localPosition == destination){
                Destroy(listTxt[i].gameObject);
            }
            if (listTxt[i] ==null || listTxt[i].transform.localPosition == destination){
                listTxt.Remove(listTxt[i]);
            }
        }
    }


}
