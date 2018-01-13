using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    [Header("Experiences:")]
    public Button m_buttonExperiences;
    public Text m_locationExperiences;
    [Range(10,200)]
    public int m_experienceMax = 100;

    [Header("Levels:")]
    public Text m_locationLevel;
    [Range(1,200)]
    public int m_levelUpExperience = 100;

    [Header("Player:")]
    public Text m_locationLifePlayer;
    [Range(1,100)]
    public int m_lifePlayerMax = 50;
    public bool m_displayMaxLife = false;
    public Text m_locationDamagePlayer;
    [Range(1,100)]
    public int m_damageMaxPlayer = 5;

    [Header("Enemies")]
    public Text m_locationLifeEnemi;
    public Text m_locationNameEnemi;
    public Text m_locationDamageEnemi;


    public void Attack(){
    	int damagePlayer = Calcul.RandomNumber(0, m_damageMaxPlayer);
    	int damageEnemi = Calcul.RandomNumber(0, m_lifeEnemi/2);
    	DisplayGame.DisplayText(m_locationDamagePlayer, "-"+damagePlayer.ToString());
    	DisplayGame.DisplayText(m_locationDamageEnemi, "-"+damageEnemi.ToString());
    	m_lifeEnemi -= damagePlayer;
    	m_lifePlayer -= damageEnemi;
        
        if(CheckIsDead(m_lifePlayer))
            Debug.Log("Player is Dead");
        if(CheckIsDead(m_lifeEnemi))
            Debug.Log("Enemi is Dead");
    }

    public void Potions(){
    	Debug.Log("Potions");
    }


    void Awake()
	{
        m_experiencesPlayer = Experiences.ExperiencePlayer;
        m_lifePlayer = m_lifePlayerMax;
        Enemies.CreateEnemiesList();
        m_listEnemies = Enemies.ListEnemies;
    	DisplayGame.DisplayText(m_locationDamagePlayer, "");
    	DisplayGame.DisplayText(m_locationDamageEnemi, "");
	}

    void Update()
    {
        ExperiencesFunction();
        LevelFunction();
        LifeFunction();
        RandomEnemiFunction();
    }

    void OnGUI()
    {
        if (GUI.Button(new Rect(0, Screen.height - 25, 75, 25), "+10xp"))
            m_experiencesPlayer += 12.47f;
    }


    private void ExperiencesFunction(){
        float percentage = Calcul.ValueToPercentage(m_experiencesPlayer, m_experienceMax) / 100;
        DisplayGame.DisplayText(m_locationExperiences, Mathf.Floor(m_experiencesPlayer).ToString()+" / "+m_experienceMax.ToString());
        DisplayGame.UIExperience(m_buttonExperiences, percentage);
    }

    private void LevelFunction(){
    	if(m_experiencesPlayer >= m_experienceMax){
    		m_levelPlayer++;
    		m_experiencesPlayer -= m_experienceMax;
    		m_experienceMax += m_levelUpExperience;
    	}
    	DisplayGame.DisplayText(m_locationLevel, m_levelPlayer.ToString());
    }

    private void LifeFunction(){
    	string displayLife = m_lifePlayer.ToString();
    	
    	if(m_displayMaxLife)
    		displayLife += " / "+m_lifePlayerMax.ToString();

    	if(CheckIsDead(m_lifeEnemi))
    		isEnemiAlive = false;

    	DisplayGame.DisplayText(m_locationLifePlayer, displayLife);
    	DisplayGame.DisplayText(m_locationLifeEnemi, m_lifeEnemi.ToString());
    }

    private void RandomEnemiFunction(){
    	if(!isEnemiAlive){
        	Enemi selected;

        	do{
        		selected = m_listEnemies[Calcul.RandomNumber(0, m_listEnemies.Count)];
        	}while(selected.enemi_levelRequired > m_levelPlayer);

        	DisplayGame.DisplayText(m_locationNameEnemi, selected.enemi_name);
        	m_lifeEnemi = selected.enemi_life;
        	isEnemiAlive = true;
        }
    }

    private bool CheckIsDead(int _life){
        bool check = false;
        if(_life <= 0)
            check = true;
        return check;
    }


    private float m_experiencesPlayer;
    private int m_levelPlayer = 1;
    private int m_lifePlayer;
    private int m_lifeEnemi;
    private List<Enemi> m_listEnemies;

    private bool isEnemiAlive = false;
}
