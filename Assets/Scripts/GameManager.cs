using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    #region Public Members

    [Header("Experiences:")]
    public Text m_locationExperiences;

    #endregion

    #region Public void

    #endregion

    #region System

    void Awake()
		{
            m_experiences = new Experiences();
            m_experiencesPlayer = m_experiences.ExperiencePlayer;
        }
	
		void Update()
		{
            new DisplayGame(m_locationExperiences, m_experiencesPlayer.ToString()+"/100");
        }

    #endregion

    #region Tools Debug And Utility

    #endregion

    #region Private and Protected Members

        private Experiences m_experiences;
        private int m_experiencesPlayer;

	#endregion
}
