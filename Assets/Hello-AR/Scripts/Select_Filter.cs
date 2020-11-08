using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;



public class Select_Filter : MonoBehaviour
{

    public SelectFilter m_Select;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void FaceScene1()
    {
        SceneManager.LoadScene("Costume");
    }
   
    public void Hat(int a_HatNum)
    {
        m_Select = GameObject.FindObjectOfType<SelectFilter>();

        if (m_Select == null) return;

        m_Select.Hat(a_HatNum);
    }

    public void Costume(int a_CostumeNum)
    {
        m_Select = GameObject.FindObjectOfType<SelectFilter>();

        if (m_Select == null) return;

        m_Select.Costume(a_CostumeNum);
    }
}
