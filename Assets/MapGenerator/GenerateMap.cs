using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateMap : MonoBehaviour {

    public GameObject m_Floor;
    public Vector2 m_MapSize;
    public string m_ParentMapName = "GeneratedMap";

    [Range(0,1)]
    public float m_OutlinePercent;

    public bool m_ChangeOnScene = true;

    public void MapGenerator()
    {
        if (GameObject.Find(m_ParentMapName))
        {
            DestroyImmediate(GameObject.Find(m_ParentMapName).gameObject);
        }

        Transform mapParent = new GameObject(m_ParentMapName).transform;

        for(int x = 0; x < m_MapSize.x; x++)
        {
            for(int y = 0; y < m_MapSize.y; y++)
            {
                Vector3 tilePosition = new Vector3(-m_MapSize.x / 2 + 0.5f + x, 0, -m_MapSize.y / 2 + 0.5f + y);
                GameObject newTile = Instantiate(m_Floor, tilePosition, Quaternion.identity, mapParent);
                newTile.transform.localScale = Vector3.one * (1 - m_OutlinePercent);
            }
        }
    }
}