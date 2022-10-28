using UnityEngine;
using UnityEditor;
#if (UNITY_EDITOR)
using UnityEditor.SceneManagement;

public class DefaultSceneLoader : MonoBehaviour
{
    [MenuItem("Reset/Reset Default Scene")]
    static void OpenMainScene()
    {
        EditorSceneManager.SaveCurrentModifiedScenesIfUserWantsTo();
        EditorSceneManager.OpenScene("Assets/Starter Scene.unity");
        EditorUtility.LoadWindowLayout("Assets/Editor/Default Window Layout.wlt");
    }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

#endif