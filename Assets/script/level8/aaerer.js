#pragma strict

#pragma strict

function OnCollisionEnter(nesne:Collision)
    {

        if(nesne.gameObject.tag=="yanma"){
           
            Time.timeScale=0;
			
            Time.timeScale=1;
            Application.LoadLevel(9);
	
	
        }
	
    }	