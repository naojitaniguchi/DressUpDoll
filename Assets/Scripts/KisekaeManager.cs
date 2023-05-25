using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KisekaeManager : MonoBehaviour
{
    [SerializeField] GameObject Hair;
    [SerializeField] GameObject Body;
    [SerializeField] GameObject Face;
    [SerializeField] GameObject Clothes;
    [SerializeField] GameObject Shoes;

    // Start is called before the first frame update
    void Start()
    {
        if (KisekaeSetting.instance != null)
        {
            select(Hair, KisekaeSetting.instance.indexes[(int)KisekaeSetting.PARTS_TYPE.HAIR]);
            select(Body, KisekaeSetting.instance.indexes[(int)KisekaeSetting.PARTS_TYPE.BODY]);
            select(Face, KisekaeSetting.instance.indexes[(int)KisekaeSetting.PARTS_TYPE.FACE]);
            select(Clothes, KisekaeSetting.instance.indexes[(int)KisekaeSetting.PARTS_TYPE.CLOTHES]);
            select(Shoes, KisekaeSetting.instance.indexes[(int)KisekaeSetting.PARTS_TYPE.SHOES]);
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void selectHair( int selected)
    {
        select(Hair, selected);
        KisekaeSetting.instance.setIndex(KisekaeSetting.PARTS_TYPE.HAIR, selected);
    }

    public void selectBody(int selected)
    {
        select(Body, selected);
        KisekaeSetting.instance.setIndex(KisekaeSetting.PARTS_TYPE.BODY, selected);
    }

    public void selectFace(int selected)
    {
        select(Face, selected);
        KisekaeSetting.instance.setIndex(KisekaeSetting.PARTS_TYPE.FACE, selected);
    }

    public void selectClothes(int selected)
    {
        select(Clothes, selected);
        KisekaeSetting.instance.setIndex(KisekaeSetting.PARTS_TYPE.CLOTHES, selected);
    }

    public void selectShoes(int selected)
    {
        select(Shoes, selected);
        KisekaeSetting.instance.setIndex(KisekaeSetting.PARTS_TYPE.SHOES, selected);
    }

    void select( GameObject target, int selected)
    {
        for ( int i = 0; i < target.transform.childCount; i ++)
        {
            if ( i == selected)
            {
                target.transform.GetChild(i).gameObject.SetActive(true);
            }
            else
            {
                target.transform.GetChild(i).gameObject.SetActive(false);
            }
        }
    }
}
