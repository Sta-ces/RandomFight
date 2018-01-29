using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateMap : MonoBehaviour {

    [Header("Info Map")]
    public GameObject m_Floor;
    public Vector3 m_MapSize;
    public string m_ParentMapName = "GeneratedMap";
    [Range(0,1)]
    public float m_OutlinePercent;

    [Header("Change Map automatically on the scene")]
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
                for (int z = 0; z < m_MapSize.z; z++)
                {
                    Vector3 tilePosition = new Vector3(-m_MapSize.x / 2 + 0.5f + x, -m_MapSize.y / 2 + 0.5f + y, -m_MapSize.z / 2 + 0.5f + z);
                    GameObject newTile = Instantiate(m_Floor, tilePosition, Quaternion.identity, mapParent);
                    newTile.transform.localScale = Vector3.one * (1 - m_OutlinePercent);

                    // If the cube is on the surface
                    if (y == m_MapSize.y + 1){}
                }
            }
        }
    }
}