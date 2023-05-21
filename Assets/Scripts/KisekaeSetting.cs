using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KisekaeSetting : MonoBehaviour
{
    public static KisekaeSetting instance;

    public enum PARTS_TYPE
    {
        HAIR,
        BODY,
        UPPER,
        BOTTOM,
        SHOES,
        PARTS_MAX
    }

    public int[] indexes;
    
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
            indexes = new int[(int)PARTS_TYPE.PARTS_MAX];
        }
        else
        {
            Destroy(gameObject);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void setIndex(PARTS_TYPE type, int index)
    {
        indexes[(int)type] = index;
    }
}
