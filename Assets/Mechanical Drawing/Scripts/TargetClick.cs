using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetClickHandler : MonoBehaviour
{
    public GameObject BulletPrefab; // Assign in Inspector
    public float bulletLifetime = 2f; // Time before bullet disappears

    void Update()
    {
        if (Input.GetMouseButtonDown(0)) // Left-click
        {
            Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);

            // Check if the click is near the target
            if (Vector2.Distance(mousePosition, transform.position) < 0.5f)
            {
                InstantiateBullet(mousePosition); // Create bullet
                Destroy(gameObject);  // Destroys Target
            }
        }
    }

    void InstantiateBullet(Vector2 position)
    {
        if (BulletPrefab != null) // Check if bulletPrefab is assigned
        {
            GameObject bullet = Instantiate(BulletPrefab, position, Quaternion.identity);
            Destroy(bullet, bulletLifetime); // Bullet disappears after a few seconds
        }
    }
}
  