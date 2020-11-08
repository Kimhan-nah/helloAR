using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Click_Pin : MonoBehaviour
{
    public GameObject[] m_Click;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Text(int a_TextNum)
    {
        foreach(var item in m_Click)
        {
            item.SetActive(false);
        }
        m_Click[a_TextNum].SetActive(true);
    }

}
