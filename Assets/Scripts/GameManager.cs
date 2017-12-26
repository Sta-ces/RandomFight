using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    #region Public Members

	    [Header("Experiences:")]
	    public Button m_buttonExperiences;
	    public Text m_locationExperiences;
	    [Range(10,200)]
	    public int m_experienceMax = 100;

	    [Header("Levels:")]
	    public Text m_locationLevel;
	    [Range(1,200)]
	    public int m_levelUpExperience = 100;

	    [Header("Lifes:")]
	    public Text m_locationLifeEnemi;
	    public Text m_locationLifePlayer;
	    [Range(1,100)]
	    public int m_lifePlayerMax = 50;
	    public bool m_displayMaxLife = false;

    #endregion

    #region Public void

	    public void Attack(){
	    	Debug.Log("Attack");
	    }

	    public void Potions(){
	    	Debug.Log("Potions");
	    }

    #endregion

    #region System

        void Awake()
		{
            m_classExperiences = new Experiences();
            m_experiencesPlayer = m_classExperiences.ExperiencePlayer;
            m_displayGame = new DisplayGame();
            m_calcul = new Calcul();
            m_lifePlayer = m_lifePlayerMax;
            m_enemies = new Enemies();
            m_enemies.CreateEnemiesList();
            m_listEnemies = m_enemies.ListEnemies;
    	}
	
	    void Update()
        {
            ExperiencesFunction();
            LevelFunction();
            LifeFunction();
        }

        void OnGUI()
        {
            if (GUI.Button(new Rect(0, Screen.height - 25, 75, 25), "+10xp"))
                m_experiencesPlayer += 12.47f;
        }

    #endregion

    #region Tools Debug And Utility

        private void ExperiencesFunction(){
            float percentage = m_calcul.ValueToPercentage(m_experiencesPlayer, m_experienceMax) / 100;
            m_displayGame.DisplayText(m_locationExperiences, Mathf.Floor(m_experiencesPlayer).ToString()+" / "+m_experienceMax.ToString());
            m_displayGame.UIExperience(m_buttonExperiences, percentage);
        }

        private void LevelFunction(){
        	if(m_experiencesPlayer >= m_experienceMax){
        		m_levelPlayer++;
        		m_experiencesPlayer -= m_experienceMax;
        		m_experienceMax += m_levelUpExperience;
        	}
        	m_displayGame.DisplayText(m_locationLevel, m_levelPlayer.ToString());
        }

        private void LifeFunction(){
        	m_lifeEnemi = 120;
        	string displayLife = m_lifePlayer.ToString();
        	
        	if(m_displayMaxLife){
        		displayLife += " / "+m_lifePlayerMax.ToString();
        	}

        	m_displayGame.DisplayText(m_locationLifePlayer, displayLife);
        	m_displayGame.DisplayText(m_locationLifeEnemi, m_lifeEnemi.ToString());
        }

    #endregion

    #region Private and Protected Members

        private Experiences m_classExperiences;
        private float m_experiencesPlayer;
        private DisplayGame m_displayGame;
        private Calcul m_calcul;
        private int m_levelPlayer = 1;
        private int m_lifePlayer;
        private int m_lifeEnemi;
        private Enemies m_enemies;
        private List<Enemi> m_listEnemies;

    #endregion

    #region TEST Zone
	#endregion
}
