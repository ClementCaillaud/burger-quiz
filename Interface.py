# -*- coding: utf-8 -*-
"""
Created on Wed Aug  7 20:41:48 2019

@author: Clément
"""

from tkinter import *
from PIL import ImageTk, Image
from SceneLoader import SceneLoader

class Interface():
    
    def __init__(self):
        self.sceneLoader = SceneLoader()
        self.currentPath = ""
        self.started = False
        
        #Création de la fenêtre
        self.window = Tk()
        #Création du conteneur racine
        self.root = Canvas(self.window, bg="black", highlightthickness=0)
        self.root.pack(fill=BOTH, expand=1)
        #Création du conteneur principal
        self.canvas = Canvas(self.root, bg="black", highlightthickness=0)
        self.canvas.pack(fill=BOTH, padx=10, pady=50, expand=1)
        self.canvas.bind("<Configure>", self.resize)
        #Ecoute des événements clavier
        self.window.bind("<Key>", self.key_pressed)
    
    def start(self):
        self.started = True
        self.window.mainloop()
    
    def display_image(self, name):
        #Récupération chemin image
        self.currentPath = self.sceneLoader.load_scene(name).get_path()
        #Ajout du background
        self.background = ImageTk.PhotoImage(Image.open(self.currentPath))
        self.canvas_img = self.canvas.create_image(0, 0, anchor="nw", image=self.background)
        #Redimensionnement de l'image
        self.resize()
    
    def key_pressed(self, event):
        #Récupération de la touche pressée et action en conséquence
        keyPressed = event.keysym
        if keyPressed == "space":
            self.display_image("score")
        elif keyPressed == "n":
            self.display_image("nuggets")
        elif keyPressed == "s":
            self.display_image("sel_poivre")
        elif keyPressed == "m":
            self.display_image("menus")
        elif keyPressed == "a":
            self.display_image("addition")
        elif keyPressed == "b":
            self.display_image("burger_mort")
     
    def resize(self, event=""):
        #Définition de la largeur et la hauteur du contenenur
        refWidth = self.canvas.winfo_width() if event == "" else event.width
        refHeight = self.canvas.winfo_height() if event == "" else event.height
        #Si on a une image à redimensionner on le fait
        if self.currentPath != ""  and self.started:
            #Récupération de l'image
            img = Image.open(self.currentPath)
            #Calcul de la hauteur avec le ratio de l'image
            ratio = img.size[1] / img.size[0]
            height = refWidth * ratio if refWidth * ratio <= refHeight else refHeight
            #Redimensionnement
            img = img.resize((refWidth, int(height)), Image.ANTIALIAS)
            #Modification du background du conteneur
            self.background = ImageTk.PhotoImage(img)
            self.canvas.itemconfig(self.canvas_img, image=self.background)