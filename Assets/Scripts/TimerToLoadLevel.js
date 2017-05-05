var timer : float = 10.0;
var level : String = "";
function Update () 
{
    timer -= Time.deltaTime;
     
    if(timer <= 0)
    {
        Application.LoadLevel(level);
    }
}