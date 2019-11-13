/******************** */
/* VARIABLES GLOBALES */
/******************** */

//Emplacement de la vidéo de chaque transition
const pathVideos = "assets/Videos/";
const transitions = 
{
    generique: "generique.mp4",
    nuggets: "nuggets-transition.mp4",
    sel_ou_poivre: "selt-pepper-transition2.mp4",
    menus: "menus-transition.mp4",
    addition: "addition-transition.mp4",
    burger_de_la_mort: "death-burger-transition.mp4"
};

//Score de chaque équipe
var scores = 
{
    ketchup: 0, 
    mayo: 0
};

/***********************/
/* PROGRAMME PRINCIPAL */
/***********************/

main();

function main()
{
    afficherScore();

    //Evenements clavier
    document.addEventListener("keydown", function(event)
    {
        switch(event.key)
        {
            case "g":
                afficherTransition("generique");
                break;
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

/***************/
/*    SCORE    */
/***************/

/**
 * Mise à jour du score et de l'affichage
 * @param {string} equipe Le nom de l'équipe (ketchup ou mayo)
 * @param {int} valeur La valeur à ajouter au score
 */
function majScore(equipe, valeur)
{
    scores[equipe] += valeur;
    document.getElementById("score-" + equipe).innerText = scores[equipe] + " MIAMS";
}

/**
 * Afficher la vue du score et cacher la transition
 */
function afficherScore()
{
    stopVideo();
    document.getElementById("div-transition").style.display = "none";
    document.getElementById("div-score").style.display = "block";
}

/**************/
/* TRANSITION */
/**************/

/**
 * Afficher la transition et cacher le score
 * @param {string} transition Le nom de la transition
 */
function afficherTransition(transition)
{   
    document.getElementById("div-score").style.display = "none";
    document.getElementById("div-transition").style.display = "block";
    playVideo(pathVideos + transitions[transition]);
}

/**
 * Démarrer la lecture de la vidéo
 * @param {string} source La source de la vidéo
 */
function playVideo(source)
{
    var videoPlayer = document.getElementById("video-transition");
    videoPlayer.src = source;
    videoPlayer.addEventListener("loadeddata", function(event)
    {
        videoPlayer.play();
    });
}

/**
 * Arrêter la lecture de la vidéo
 */
function stopVideo()
{
    var videoPlayer = document.getElementById("video-transition");
    videoPlayer.pause();
}