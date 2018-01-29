using UnityEditor;

[CustomEditor(typeof(GenerateMap))]
public class MapGenerator : Editor {

    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();

        GenerateMap map = target as GenerateMap;
        if(map.m_ChangeOnScene)
            map.MapGenerator();

    }
}
