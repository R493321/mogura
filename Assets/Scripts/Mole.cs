using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mole : MonoBehaviour
{
    private bool isUp = false;
    private bool isHit = false;

    public float minTime = 1f;
    public float maxTime = 3f;

    void Start()
    {
        StartCoroutine(MoveRoutine());
    }

    IEnumerator MoveRoutine()
    {
        while (true)
        {
            float wait = Random.Range(minTime, maxTime);
            yield return new WaitForSeconds(wait);

            // 出る
            Up();

            yield return new WaitForSeconds(1f);

            // 引っ込む
            Down();
        }
    }

    void Up()
    {
        isUp = true;
        isHit = false;
        transform.position += new Vector3(0, 1, 0);
    }

    void Down()
    {
        isUp = false;
        transform.position -= new Vector3(0, 1, 0);
    }
    void OnMouseDown()
    {
        if (isUp && !isHit)
        {
            isHit = true;
            GameManager.Instance.AddScore(1);

            Debug.Log("Hit!");

            // すぐ引っ込める（任意）
            Down();
        }
    }

}
