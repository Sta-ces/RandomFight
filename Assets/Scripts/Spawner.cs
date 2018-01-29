using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour {

    public Transform m_SpawnerLocation;
    public GameObject m_Player;

    private void Awake()
    {
        m_tallOfPlayer = m_Player.transform.lossyScale.y;
    }

    private void Start()
    {
        Vector3 playerPosition = m_SpawnerLocation.transform.position;
        playerPosition.y += m_tallOfPlayer;

        m_Player.transform.position = playerPosition;
    }

    private float m_tallOfPlayer;
}
