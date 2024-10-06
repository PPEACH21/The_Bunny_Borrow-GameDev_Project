using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class Order : MonoBehaviour, IInteractable
{
    // อ้างอิงไปยัง TextMeshPro 3D ที่ต้องการควบคุม
    public TextMeshPro textToShowWhenFalse; //text1

    private bool order = false; // ตัวแปร order เริ่มต้นเป็น false
    //private bool foodServed = false; // ตัวแปรเช็คว่าได้รับอาหารหรือยัง
    public ParticleSystem fireworkEffect;

    private bool Statement1 = false;
    private bool Statement2 = false;
    private bool Statement3 = false;
    private bool Statement4 = false;

    void Start()
    {
        // ตรวจสอบว่า TextMeshPro 3D ทั้งสองถูกกำหนดค่าใน Inspector หรือไม่
        if (textToShowWhenFalse == null)
        {
            Debug.LogError("โปรดกำหนดค่า TextMeshPro 3D ทั้งสองใน Inspector!");
        }
        else
        {
            // กำหนดค่าเริ่มต้นให้กับ TextMeshPro 3D ตามค่าของ order
            UpdateTextVisibility();
        }

        if(fireworkEffect.isPlaying)
        {
            fireworkEffect.Stop();
        }
    }

    // ฟังก์ชันสำหรับอัปเดตการแสดงผลของ TextMeshPro 3D
    void UpdateTextVisibility()
    {
        textToShowWhenFalse.gameObject.SetActive(!order);
    }

    IEnumerator DelayedDestroy(GameObject obj, float delay,float state)
    {
        AudioManage.instance.PlaySFX("Checkbin");
        fireworkEffect.Play();
        yield return new WaitForSeconds(delay);
        Destroy(obj);
        switch (state)
        {
            case 1:
                Datainfo.score += 100;
                SPAT1.hasSpawned = false;
                UpdateTextAfter.checkbill = false;
                SpawnOrder1.hasSpawned = false;
                FSP1.hasSpawned = false;
                Statement1 = false;
                break;
            case 2:
                Datainfo.score += 200;
                SPAT2.hasSpawned = false;
                UpdateTextAfter2.checkbill = false;
                SpawnOrder2.hasSpawned = false;
                FSP2.hasSpawned = false;
                Statement2 = false;
                break;
            case 3:
                Datainfo.score += 300;
                SPAT3.hasSpawned = false;
                UpdateTextAfter3.checkbill = false;
                SpawnOrder3.hasSpawned = false;
                FSP3.hasSpawned = false;
                Statement3 = false;
                break;
            case 4:
                Datainfo.score += 400;
                SPAT4.hasSpawned = false;
                UpdateTextAfter4.checkbill = false;
                SpawnOrder4.hasSpawned = false;
                FSP4.hasSpawned = false;
                Statement4 = false;
                break;
        }
    }

    // เพิ่มฟังก์ชัน Interact() เพื่อรับ interact
    public void Interact()
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
                        AnimationRes.defaultAnimation = "waiting action 0";
                        Debug.Log("Success");
                    }
                    if (UpdateTextAfter.checkbill && Statement1==false)
                    {
                        Statement1 = true;
                        AnimationRes.defaultAnimation = "Suscess";
                        //AnimationRes.defaultAnimation = "Success";
                        //Destroy(gameObject, 1);
                        StartCoroutine(DelayedDestroy(gameObject, 1f,1f));
                        
                    }
                break;
                case "Spawn At Table 2(Clone)":
                    if (!SpawnOrder2.hasSpawned)
                    {
                        order = true;
                        FindObjectOfType<SpawnOrder2>().SpawnPrefab();
                        UpdateTextVisibility(); // แสดง text2 หลังจาก interact ครั้งแรก
                        AnimationRes2.defaultAnimation = "waiting action 0";
                        Debug.Log("Success");
                    }
                    if (UpdateTextAfter2.checkbill &&  Statement2 == false)
                    {
                        Statement2 = true;
                        AnimationRes2.defaultAnimation = "Suscess";
                        //AnimationRes2.defaultAnimation = "Success";
                        //Destroy(gameObject, 1);
                        StartCoroutine(DelayedDestroy(gameObject, 1f,2f));
                        
                    }
                break;
                case "Spawn At Table 3(Clone)":
                    if (!SpawnOrder3.hasSpawned)
                    {
                        order = true;
                        FindObjectOfType<SpawnOrder3>().SpawnPrefab();
                        UpdateTextVisibility(); // แสดง text2 หลังจาก interact ครั้งแรก
                        AnimationRes3.defaultAnimation = "waiting action 0";
                        Debug.Log("Success");
                    }
                    if (UpdateTextAfter3.checkbill && Statement3 == false)
                    {
                        Statement3 = true;
                        AnimationRes3.defaultAnimation = "Suscess";
                        //AnimationRes3.defaultAnimation = "Success";
                        //Destroy(gameObject,1);
                        StartCoroutine(DelayedDestroy(gameObject, 1f,3f));
                        
                    }
                break;
                case "Spawn At Table 4(Clone)":
                    if (!SpawnOrder4.hasSpawned)
                    {
                        order = true;
                        FindObjectOfType<SpawnOrder4>().SpawnPrefab();
                        UpdateTextVisibility(); // แสดง text2 หลังจาก interact ครั้งแรก
                        AnimationRes4.defaultAnimation = "waiting action 0";
                        Debug.Log("Success");
                    }
                    if (UpdateTextAfter4.checkbill && Statement4 == false)
                    {
                        Statement4 = true;
                        AnimationRes4.defaultAnimation = "Suscess";
                        //AnimationRes4.defaultAnimation = "Success";
                        //Destroy(gameObject, 1);
                        StartCoroutine(DelayedDestroy(gameObject, 1f,4f));
                        
                    }
                break;
                default:
                    // Optional: Handle cases where the name doesn't match any of the above
                    break;

            }

    }
}