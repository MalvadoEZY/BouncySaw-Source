using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scriptBlock : MonoBehaviour
{
    [SerializeField] AudioClip hitSound;

    //cached reference
    Level level;

    private void Start()
    {
        level = FindObjectOfType<Level>();
        level.CountBreakableBlocks();
    }

    //events
    private void OnCollisionEnter2D(Collision2D collision)
    {
        destroyBlock();
    }

    private void destroyBlock()
    {
        AudioSource.PlayClipAtPoint(hitSound, Camera.main.transform.position);
        Destroy(gameObject);
        level.BlockDestroyed();
    }
}
