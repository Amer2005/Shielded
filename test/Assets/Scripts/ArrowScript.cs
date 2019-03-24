using System;
using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace Game
{
    public class ArrowScript : MonoBehaviour
    {
        //SpriteRenderer rend;

        private int untilDespawn = 0;
        public int despawnCounter = 50;
        bool deSpawing = false;

        public float speed = 10f;

        private Text score;

        // Use this for initialization
        private GameObject spawn;

        int randomSpawn;

        GameObject arrowMaxY;
        GameObject arrowMinY;

        SpriteRenderer rend;

        float maxY, minY = 0;

        void Start()
        {
            arrowMaxY = GameObject.FindGameObjectWithTag("arrowMaxY");
            arrowMinY = GameObject.FindGameObjectWithTag("arrowMinY");

            maxY = arrowMaxY.transform.position.y;
            minY = arrowMinY.transform.position.y;
            maxY *= 1000;
            minY *= 1000;
            int intMaxY = (int)Math.Round(maxY);
            int intMinY = (int)Math.Round(minY);
            rend = GetComponentInChildren<SpriteRenderer>();

            randomSpawn = UnityEngine.Random.Range(1, 3);
            int randomSpawn2 = UnityEngine.Random.Range(intMinY, intMaxY);
            if (randomSpawn == 1)
            {
                spawn = GameObject.FindGameObjectWithTag("spawn1");
                transform.localRotation *= Quaternion.Euler(0, 180, 0);
            }
            else
            {
                spawn = GameObject.FindGameObjectWithTag("spawn2");
                speed = -speed;
            }
            float floatY = randomSpawn2;
            float spawnY = floatY / 1000;
            transform.position = new Vector2(spawn.transform.position.x, spawnY);
        }

        // Update is called once per frame
        void FixedUpdate()
        {
            if (deSpawing == false)
            {
                if (randomSpawn == 1)
                {
                    if (transform.position.x >= -spawn.transform.position.x)
                    {
                        Destroy(gameObject);
                    }
                }
                else
                {
                    if (transform.position.x <= -spawn.transform.position.x)
                    {
                        Destroy(gameObject);
                    }
                }

            }
            else
            {
                untilDespawn++;
                if (untilDespawn >= despawnCounter)
                {
                    Destroy(gameObject);
                }
            }
            transform.position = new Vector2(transform.position.x + speed, transform.position.y);
        }

        void OnTriggerEnter2D(Collider2D col)
        {
            if (col.tag == "Body")
            {
                Destroy(gameObject);
                SceneManager.LoadScene("Menu");
            }

            if (col.tag == "Shield")
            {
                deSpawing = true;
                gameObject.transform.SetParent(col.transform);
                speed = 0;

            }
        }

    }
}