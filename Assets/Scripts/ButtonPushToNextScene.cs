using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonPushToNextScene : MonoBehaviour
{
    [SerializeField] string nextScene;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void loadNextScene()
    {
        SceneManager.LoadScene(nextScene);
    }
}
