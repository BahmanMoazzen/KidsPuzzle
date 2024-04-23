using UnityEngine;

public class LoadingSceneManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        BAHMANLoadingManager._INSTANCE._LoadScene(1);   
    }

    
}
