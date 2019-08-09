# -*- coding: utf-8 -*-
"""
Created on Wed Aug  7 19:07:56 2019

@author: Clément
"""

from Scene import Scene

class SceneLoader:
    
    def __init__(self):
        self.scenesList = {
                "accueil"       : Scene("Accueil", "data/test.gif"),
                "nuggets"       : Scene("Nuggets", "data/test2.gif"),
                "sel_poivre"    : Scene("Sel ou poivre", ""),
                "menus"         : Scene("Menus", ""),
                "addition"      : Scene("Addition", ""),
                "burger_mort"   : Scene("Le burger de la mort", "")}
    
    def load_scene(self, name):
        print("Charger la scène {}" . format(name))
        scene = self.scenesList[name]
        return scene