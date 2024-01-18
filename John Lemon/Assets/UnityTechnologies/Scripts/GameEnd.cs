using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameEnd : MonoBehaviour
{

    public float fadeDuration = 1f;
    public GameObject player;
    public CanvasGroup exitBackgroundImageCanvasGroup;
    float m_Timer;
    bool m_IsPlayerAtExit;

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
         if(m_IsPlayerAtExit)
        {
            EndLevel();
        }
    }   

   void OnTriggerEnter(Collider other)
   {
    if(other.gameObject == player)
    {
        m_IsPlayerAtExit = true;
    }
   }

   void EndLevel()
   {

   }
}
