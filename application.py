# -*- coding: utf-8 -*-
"""
Created on Wed Aug  7 20:41:48 2019

@author: Clément
"""

from tkinter import Tk, Canvas, Label
from PIL import ImageTk, Image
from scene_loader import SceneLoader
from team import Team

class Application():
    
    def __init__(self):
        self.sceneLoader = SceneLoader()
        self.currentImage = ""
        self.started = False
        #Création des équipes
        self.teamKetchup = Team("Ketchup")
        self.teamMayo = Team("Mayo")
        #Création de la fenêtre
        self.window = Tk()
        #Création du conteneur racine
        self.root = Canvas(self.window, bg="black", highlightthickness=0)
        self.root.pack(fill="both", expand=1)
        #Création du conteneur principal
        self.canvas = Canvas(self.root, bg="black", highlightthickness=0)
        self.canvas.pack(fill="both", padx=10, pady=10, expand=1)
        self.canvas.bind("<Configure>", self.resize)
        #Création des labels score
        self.fontSize = 50
        self.labelScoreKetchup = Label(self.root, text="{} MIAMS".format(self.teamKetchup.get_score()), bg="black", fg="red", font=("Horseshoes and Lemonade", self.fontSize))
        self.labelScoreMayo = Label(self.root, text="{} MIAMS".format(self.teamMayo.get_score()), bg="black", fg="yellow", font=("Horseshoes and Lemonade", self.fontSize))
        self.labelScoreKetchup.pack(side="left", expand=1, pady=40)
        self.labelScoreMayo.pack(side="right", expand=1, pady=40)
        #Ecoute des événements clavier
        self.window.bind("<Key>", self.key_pressed)
    
    def start(self):
        self.started = True
        self.window.mainloop()
    
    def display_image(self, name):
        #Récupération chemin image
        self.currentImage = self.sceneLoader.load_scene(name).get_image()
        #Ajout du background
        self.background = ImageTk.PhotoImage(Image.open(self.currentImage))
        self.canvas_img = self.canvas.create_image(0, 0, anchor="nw", image=self.background)
        #Redimensionnement de l'image
        self.resize()
    
    def key_pressed(self, event):
        #Récupération de la touche pressée et action en conséquence
        keyPressed = event.keysym
        if keyPressed == "space":
            self.display_image("score")
            self.display_score(True)
        elif keyPressed == "n":
            self.display_image("nuggets")
            self.display_score(False)
        elif keyPressed == "s":
            self.display_image("sel_poivre")
            self.display_score(False)
        elif keyPressed == "m":
            self.display_image("menus")
            self.display_score(False)
        elif keyPressed == "a":
            self.display_image("addition")
            self.display_score(False)
        elif keyPressed == "b":
            self.display_image("burger_mort")
            self.display_score(False)
        elif keyPressed == "Right":
            self.teamKetchup.add_score(1)
            self.display_score()
        elif keyPressed == "Left":
            self.teamKetchup.add_score(-1)
            self.display_score()
        elif keyPressed == "Up":
            self.teamMayo.add_score(1)
            self.display_score()
        elif keyPressed == "Down":
            self.teamMayo.add_score(-1)
            self.display_score()
     
    def resize(self, event=""):
        #Définition de la largeur et la hauteur du contenenur
        refWidth = self.canvas.winfo_width() if event == "" else event.width
        refHeight = self.canvas.winfo_height() if event == "" else event.height
        #Si on a une image à redimensionner on le fait
        if self.currentImage != ""  and self.started:
            #Récupération de l'image
            img = Image.open(self.currentImage)
            #Calcul de la hauteur avec le ratio de l'image
            ratio = img.size[1] / img.size[0]
            height = refWidth * ratio if refWidth * ratio <= refHeight else refHeight
            #Redimensionnement
            img = img.resize((refWidth, int(height)), Image.ANTIALIAS)
            #Modification du background du conteneur
            self.background = ImageTk.PhotoImage(img)
            self.canvas.itemconfig(self.canvas_img, image=self.background)
    
    def display_score(self, toggle=None):
        self.labelScoreKetchup.configure(text="{} MIAMS".format(self.teamKetchup.get_score()))
        self.labelScoreMayo.configure(text="{} MIAMS".format(self.teamMayo.get_score()))
        if toggle == True:
            self.labelScoreKetchup.pack(side="left", expand=1, pady=40)
            self.labelScoreMayo.pack(side="right", expand=1, pady=40)
        elif toggle == False:
            self.labelScoreKetchup.forget()
            self.labelScoreMayo.forget()
        