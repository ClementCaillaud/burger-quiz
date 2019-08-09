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
        self.window = Tk()
        self.canvas = Canvas(self.window, width=500, height=400)
        self.canvas.pack()
        self.window.bind("<Key>", self.key_pressed)
    
    def start(self):
        self.window.mainloop()
    
    def display_image(self, name):
        self.background = PhotoImage(file=self.sceneLoader.load_scene(name).get_path())
        self.canvas.create_image(0, 0, image=self.background)
    
    def key_pressed(self, event):
        keyPressed = event.keysym
        if keyPressed == "a":
            self.display_image("accueil")
        if keyPressed == "n":
            self.display_image("nuggets")
        