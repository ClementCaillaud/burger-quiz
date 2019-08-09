# -*- coding: utf-8 -*-
"""
Created on Wed Aug  7 19:07:56 2019

@author: Clément
"""

from Scene import Scene

class SceneLoader:
    
    def __init__(self):
        self.scenesList = {
                "score"         : Scene("Score", "data/ketchup.png"),
                "nuggets"       : Scene("Nuggets", "data/nuggets.png"),
                "sel_poivre"    : Scene("Sel ou poivre", "data/seloupoivre.png"),
                "menus"         : Scene("Menus", "data/menus.png"),
                "addition"      : Scene("Addition", "data/addition.png"),
                "burger_mort"   : Scene("Le burger de la mort", "data/burger.png")}
    
    def load_scene(self, name):
        print("Charger la scène {}" . format(name))
        scene = self.scenesList[name]
        return scene