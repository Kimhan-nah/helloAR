using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectFilter : MonoBehaviour
{
    public GameObject[] m_Costumes;
    public GameObject[] m_Hats;

    public void Hat(int a_HatNum)
    {
        foreach (var item in m_Hats)
        {
            item.SetActive(false);
        }

        m_Hats[a_HatNum].SetActive(true);
    }

    public void Costume(int a_CostumeNum)
    {
        foreach (var item in m_Costumes)
        {
            item.SetActive(false);
        }

        m_Costumes[a_CostumeNum].SetActive(true);
    }
}
