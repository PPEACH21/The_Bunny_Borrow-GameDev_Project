using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class Order : MonoBehaviour, IInteractable
{
    // อ้างอิงไปยัง TextMeshPro 3D ที่ต้องการควบคุม
    public TextMeshPro textToShowWhenFalse; //text1
    public TextMeshPro textToShowWhenTrue; //text2
    public TextMeshPro textToShowAfterFoodServed; //text3

    private bool order = false; // ตัวแปร order เริ่มต้นเป็น false
    private bool foodServed = false; // ตัวแปรเช็คว่าได้รับอาหารหรือยัง

    void Start()
    {
        // ตรวจสอบว่า TextMeshPro 3D ทั้งสองถูกกำหนดค่าใน Inspector หรือไม่
        if (textToShowWhenFalse == null || textToShowWhenTrue == null)
        {
            Debug.LogError("โปรดกำหนดค่า TextMeshPro 3D ทั้งสองใน Inspector!");
        }
        else
        {
            // กำหนดค่าเริ่มต้นให้กับ TextMeshPro 3D ตามค่าของ order
            UpdateTextVisibility();
        }

        // ซ่อน text2 และ text3 ตอนเริ่มต้น
        textToShowWhenTrue.gameObject.SetActive(false);
        if (textToShowAfterFoodServed != null)
        {
            textToShowAfterFoodServed.gameObject.SetActive(false);
        }
    }

    // ฟังก์ชันสำหรับอัปเดตการแสดงผลของ TextMeshPro 3D
    void UpdateTextVisibility()
    {
        textToShowWhenFalse.gameObject.SetActive(!order);
        textToShowWhenTrue.gameObject.SetActive(order);
    }

    public void UpdateTextAfterFoodServed()
    {
        // ซ่อน TextMeshPro ทั้งสองตัวเดิม
        textToShowWhenFalse.gameObject.SetActive(false);
        textToShowWhenTrue.gameObject.SetActive(false);

        // แสดง TextMeshPro ใหม่หลังจากได้รับอาหาร
        if (textToShowAfterFoodServed != null)
        {
            textToShowAfterFoodServed.gameObject.SetActive(true);
        }
        else
        {
            Debug.LogError("โปรดกำหนดค่า TextMeshPro สำหรับแสดงหลังจากได้รับอาหารใน Inspector!");
        }
    }

    // เพิ่มฟังก์ชัน Interact() เพื่อรับ interact
    public void Interact()
    {
        if (!foodServed)
        {
            Debug.Log(gameObject.name);
            switch (gameObject.name)
            {
                case "Spawn At Table 1(Clone)":
                    if (!SpawnOrder1.hasSpawned)
                    {
                        order = true;
                        FindObjectOfType<SpawnOrder1>().SpawnPrefab();
                        UpdateTextVisibility(); // แสดง text2 หลังจาก interact ครั้งแรก
                        Debug.Log("Success");
                    }
                    break;
                case "Spawn At Table 2(Clone)":
                    if (!SpawnOrder2.hasSpawned)
                    {
                        order = true;
                        FindObjectOfType<SpawnOrder2>().SpawnPrefab();
                        UpdateTextVisibility(); // แสดง text2 หลังจาก interact ครั้งแรก
                        Debug.Log("Success");
                    }
                    break;
                case "Spawn At Table 3(Clone)":
                    if (!SpawnOrder3.hasSpawned)
                    {
                        order = true;
                        FindObjectOfType<SpawnOrder3>().SpawnPrefab();
                        UpdateTextVisibility(); // แสดง text2 หลังจาก interact ครั้งแรก
                        Debug.Log("Success");
                    }
                    break;
                case "Spawn At Table 4(Clone)":
                    if (!SpawnOrder4.hasSpawned)
                    {
                        order = true;
                        FindObjectOfType<SpawnOrder4>().SpawnPrefab();
                        UpdateTextVisibility(); // แสดง text2 หลังจาก interact ครั้งแรก
                        Debug.Log("Success");
                    }
                    break;
                default:
                    // Optional: Handle cases where the name doesn't match any of the above
                    break;
            }

        }
        else
        {
            // ถ้าได้รับอาหารแล้ว และมีการ Interact อีกครั้ง ให้ลบ Object ที่มีสคริปต์ Order นี้
            Destroy(gameObject);
        }
    }

    // ฟังก์ชันที่จะถูกเรียกจากสคริปต์ของ Prefab อาหาร เมื่อมีการ Interact
    public void FoodInteracted()
    {
        foodServed = true;
        UpdateTextAfterFoodServed(); // แสดง text3 หลังจาก interact กับอาหาร
    }
}