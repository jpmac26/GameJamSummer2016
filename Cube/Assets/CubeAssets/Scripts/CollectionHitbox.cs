﻿using UnityEngine;
using System.Collections;

public class CollectionHitbox : MonoBehaviour {

    ScoreManager m_scoreManager;

    [SerializeField]
    private GameObject m_objWithScoreManager;
    [SerializeField]
    private AudioSource m_objWithSound;
    // Use this for initialization
    void Start () {
        m_scoreManager = m_objWithScoreManager.GetComponent<ScoreManager>();
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Collectible"))
        {
            Destroy(other.gameObject);
            m_scoreManager.AddScore(10);
            m_objWithSound.Play();
            //Debug.Log("Score: " + m_score + "\n");
        }

    }
}
