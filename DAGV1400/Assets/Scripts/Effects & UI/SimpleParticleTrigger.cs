using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(ParticleSystem), typeof(Collider))]
public class SimpleParticleTrigger : MonoBehaviour
{
    
    private ParticleSystem particleSystem;
    
    public int firstParticleAmount = 10;
    public int secondParticleAmount = 20;
    public int thirdParticleAmount = 30;
    public float delayBetweenEmissions = 0.5f;
    
    // Start is called before the first frame update
    void Start()
    {
        particleSystem = GetComponent<ParticleSystem>();
    }
    
    
/*   this is the lab's part
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            particleSystem.Emit(firstParticleAmount);
        }
        
    }
*/

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            StartCoroutine(EmitParticlesCoroutine());
        }
    }
    
    private IEnumerator EmitParticlesCoroutine()
    {
        particleSystem.Emit(firstParticleAmount);
        yield return new WaitForSeconds(delayBetweenEmissions);
       
        particleSystem.Emit(secondParticleAmount);
        yield return new WaitForSeconds(delayBetweenEmissions);
        
        particleSystem.Emit(thirdParticleAmount);
        
    }
    
    
    
}
