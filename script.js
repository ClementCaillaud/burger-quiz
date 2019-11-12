var scores = 
{
    ketchup: 0, 
    mayo: 0
};

const transitions = 
{
    nuggets: "nuggets-transition.mp4",
    sel_ou_poivre: "selt-pepper-transition.mp4",
    menus: "menus-transition.mp4",
    addition: "addition-transition.mp4",
    burger_de_la_mort: "death-burger-transition.mp4"
};

main();

function main()
{
    afficherScore();
    document.addEventListener("keydown", function(event)
    {
        console.log(event);
        
        switch(event.key)
        {
            case "n":
                afficherTransition("nuggets");
                break;
            case "s":
                afficherTransition("sel_ou_poivre");
                break;
            case "m":
                afficherTransition("menus");
                break;
            case "a":
                afficherTransition("addition");
                break;
            case "b":
                afficherTransition("burger_de_la_mort");
                break;
            case " ":
                afficherScore();
                break;
            case "ArrowUp":
                majScore("ketchup", 1);
                break;
            case "ArrowDown":
                majScore("ketchup", -1);
                break;
            case "ArrowRight":
                majScore("mayo", 1);
                break;
            case "ArrowLeft":
                majScore("mayo", -1);
                break;
        }
    });
}

function majScore(equipe, valeur)
{
    scores[equipe] += valeur;
    document.getElementById("score-" + equipe).innerText = scores[equipe] + " MIAMS";
}

function afficherScore()
{
    stopVideo();
    document.getElementById("div-transition").style.display = "none";
    document.getElementById("div-score").style.display = "block";
}

function afficherTransition(transition)
{   
    document.getElementById("div-score").style.display = "none";
    document.getElementById("div-transition").style.display = "block";
    playVideo("assets/Videos/" + transitions[transition]);
}

function playVideo(source)
{
    var videoPlayer = document.getElementById("video-transition");
    videoPlayer.src = source;
    videoPlayer.addEventListener("loadeddata", function(event)
    {
        videoPlayer.play();
    });
}

function stopVideo()
{
    var videoPlayer = document.getElementById("video-transition");
    videoPlayer.pause();
}