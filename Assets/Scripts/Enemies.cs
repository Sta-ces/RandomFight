using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemies{

	private List<Enemi> m_listEnemies = new List<Enemi>();
    public List<Enemi> ListEnemies{
        get { return m_listEnemies; }
        set { m_listEnemies = value; }
    }

	public void CreateEnemiesList(){
		m_listEnemies.Add(new Enemi("Skeleton",	20,		1));
		m_listEnemies.Add(new Enemi("Ogre",		50,		3));
		m_listEnemies.Add(new Enemi("Vampire",	35,		1));
		m_listEnemies.Add(new Enemi("Zombie",	20,		1));
		m_listEnemies.Add(new Enemi("Dragon",	200,	10));
	}
}

public class Enemi{
	
	public string enemi_name;
	public int enemi_life;
	public int enemi_levelRequired;

	public Enemi(string _name, int _life, int _levelRequired){
		enemi_name = _name;
		enemi_life = _life;
		enemi_levelRequired = _levelRequired;
	}
}