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
	    public int m_experienceMax = 100;

    #endregion

    #region Public void

    #endregion

    #region System

        void Awake()
		{
            m_classExperiences = new Experiences();
            m_experiencesPlayer = m_classExperiences.ExperiencePlayer;
            m_displayGame = new DisplayGame();
            m_percentCalcul = new Calcul();
    	}
	
	    void Update()
        {
            float percentage = m_percentCalcul.Percentage(m_experiencesPlayer, m_experienceMax) / 100;
            m_displayGame.DisplayText(m_locationExperiences, m_experiencesPlayer.ToString()+"/"+m_experienceMax.ToString());
            m_displayGame.UIExperience(m_buttonExperiences, percentage);
        }

        private void OnGUI()
        {
            if (GUI.Button(new Rect(0, Screen.height - 25, 75, 25), "+10xp"))
                m_experiencesPlayer += 12.47f;
        }

    #endregion

    #region Tools Debug And Utility

    #endregion

    #region Private and Protected Members

        private Experiences m_classExperiences;
        private float m_experiencesPlayer;
        private DisplayGame m_displayGame;
        private Calcul m_percentCalcul;

    #endregion
}
