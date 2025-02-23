using UnityEngine;
using UnityEngine.SceneManagement;

public class AnimationTrigger : MonoBehaviour
{
    public Animator animator; // GameObject'in Animator bileşeni
    public string animationName; // Kontrol edilecek animasyon adı
    public string nextSceneName; // Geçilecek sahne adı
    public float triggerDistance = 3f; // Mesafe kontrolü (karakter ne kadar yakın olmalı)

    private Transform hero; // Hero karakterinin transformu
    private bool doorlock = false;

    void Start()
    {
        // Hero tagine sahip karakteri bul
        GameObject heroObject = GameObject.FindGameObjectWithTag("Player");
        if (heroObject != null)
        {
            hero = heroObject.transform;
        }
        else
        {
            Debug.LogError("Hero tagine sahip karakter bulunamadı!");
        }
    }

    void Update()
    {
        if (hero == null) return;

        float distance = Vector3.Distance(hero.position, transform.position); // Mesafeyi hesapla
        //&& distance <= triggerDistance
        if (!doorlock  && Input.GetKeyDown(KeyCode.F))
        {
            SceneManager.LoadScene(nextSceneName); // Sahneyi değiştir
        }
    }

    bool IsAnimationPlaying(string animName)
    {
        return animator.GetCurrentAnimatorStateInfo(0).IsName(animName);
    }
    public void istheredoor(){
        doorlock = true;
        Debug.Log("kapı kilitli");
    }
    public void isntThereDoor(){
        doorlock = false;
        Debug.Log("kapı açık");
    }
}
